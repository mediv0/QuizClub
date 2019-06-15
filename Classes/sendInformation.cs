using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace quizclub
{
    class sendInformation
    {
        // private bool Send_Connected, Recive_Connected;
        public static string  JsonRecive , JsonSend;
        private static string Webserver = "http://azkia98.ir/test/dorodbareslam";
        static private bool Connected = false;
        public static bool DataSender(object item)
        {
            // sned and validate datas;
            try
            {
                JsonSend = JsonConvert.SerializeObject(item);
                var httpwebRequest = WebRequest.Create(Webserver); // webserver + json for get;
                httpwebRequest.ContentType = "application/json; charset=utf-8";
                httpwebRequest.Method = "POST";
                using (var streamwriter = new StreamWriter(httpwebRequest.GetRequestStream()))
                {
                    streamwriter.Write(JsonSend);
                    streamwriter.Flush();
                    streamwriter.Close(); 
                }
                var httpwebResponse = httpwebRequest.GetResponse();
                using (var streamreader = new StreamReader(httpwebResponse.GetResponseStream()))
                {
                    var serverResult = streamreader.ReadToEnd();
                    bool conncted;
                    if(bool.TryParse(serverResult,out conncted))
                    {
                        switch(conncted)
                        {
                            case true:
                                Connected = true;break;
                            case false:
                                Connected = false; break;
                        }
                    }
                    else
                    {
                        if(serverResult.GetType() == typeof(object))
                        {
                            ConvertJson convertjson = JsonConvert.DeserializeObject<ConvertJson>(serverResult);
                            Connected = true;
                        }
                        else if(serverResult.GetType() == typeof(string))
                        {
                            // class for save serverdata
                            ConvertJson convertJson = JsonConvert.DeserializeObject<ConvertJson>(serverResult);
                            Connected = true;
                        }
                        else
                        {
                            throw new FormatException("Invalid Format");
                            Connected = false;
                        }
                    }
                }
                return Connected;
            }
            catch(WebException ex)
            {
                throw ex;
                return false;
            }
        }
            // send data to server;
            /*
            try
            {
                string webAdress = "http://azkia98.ir/test/dorodbareslam" + json;
                var httpwebrequest = WebRequest.Create(webAdress);
                httpwebrequest.ContentType = "application/json; charset=utf-8";
                httpwebrequest.Method = "POST";
                // send data;
                using (var streamwriter = new StreamWriter(httpwebrequest.GetRequestStream()))
                {
                    streamwriter.Write(json);
                    streamwriter.Flush();
                    streamwriter.Close();
                }
                // back;
                var httpResponse = httpwebrequest.GetResponse();
                using (var streamreader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var con = streamreader.ReadToEnd();
                    bool conncted;
                    if (bool.TryParse(con, out conncted))
                    {
                        switch (conncted)
                        {
                            case true:
                                Connected = true;
                                break;
                            case false:
                                Connected = false;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Try again,Something is Wrong!", "ServerError", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            return Connected;
            */
    }
}
