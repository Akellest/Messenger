using ConsoleClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMessenger
{
    class MessangerClientAPI
    {
        public Message GetMessage(int MessageId)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger/" + MessageId.ToString());
            request.Method = "Get";
            WebResponse response = request.GetResponse();
            string status = ((HttpWebResponse)response).StatusDescription;
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            if ((status.ToLower() == "ok") && (responseFromServer != "Not found"))
            {
                Message deserializedMsg = JsonConvert.DeserializeObject<Message>(responseFromServer);
                return deserializedMsg;
            }
            return null;
        }

        public bool SendMessage(Message msg)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger");
            request.Method = "POST";
            string postData = JsonConvert.SerializeObject(msg);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return true;
        }

        public async Task<string> AddUser(UserClass user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://localhost:5000/api/users/adduser";
            using var client = new HttpClient();
            //Console.WriteLine("Response");
            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            UserClass user_in = JsonConvert.DeserializeObject<UserClass>(result);
            Console.WriteLine(result.ToString());
            return "ok"; //TODO: обработчик ошибок;
        }

        public async Task<string> GetUser(UserClass user)
        {
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "http://localhost:5000/api/users/getuser";
            using var client = new HttpClient();
            //Console.WriteLine("Response");
            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            UserClass user_in = JsonConvert.DeserializeObject<UserClass>(result);
            Console.WriteLine(result.ToString());
            return "ok"; //TODO: обработчик ошибок;
        }
    }
}