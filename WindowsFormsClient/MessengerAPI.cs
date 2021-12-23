using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace WindowsFormsClient
{
    class MessangerClientAPI
    {
        private static readonly HttpClient client = new HttpClient();
        string baseUrl = "http://localhost:5000";

        public async Task<UserClass> GetUser(int userId)
        {
            var responseString = await client.GetStringAsync(baseUrl + "/api/UserList/" + userId.ToString());
            if (responseString != null)
            {
                UserClass deserializedUser = JsonConvert.DeserializeObject<UserClass>(responseString);
                return deserializedUser;
            }
            return null;
        }

        public bool AddUser(UserClass user)
        {
            string ServiceUrl = baseUrl;
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/UserList", Method.POST);
            // Json to post.
            string jsonToSend = JsonConvert.SerializeObject(user);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            bool ExitIsTrue = false;
            try
            {
                client.ExecuteAsync(request, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        ExitIsTrue = true;
                    }
                    else
                    {
                        ExitIsTrue = false;
                    }
                });
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            return ExitIsTrue;
        }

        public async Task<MessageClass> GetMessage(int messageID)
        {

            var responseString = await client.GetStringAsync(baseUrl + "/api/Messanger/" + messageID.ToString());
            if (responseString != null)
            {
                MessageClass deserializedMessage = JsonConvert.DeserializeObject<MessageClass>(responseString);
                return deserializedMessage;
            }
            return null;
        }

        public bool SendMessage(MessageClass msg)
        {
            string ServiceUrl = baseUrl;
            var client = new RestClient(ServiceUrl);
            var request = new RestRequest("/api/Messanger", Method.POST);
            // Json to post.
            string jsonToSend = JsonConvert.SerializeObject(msg);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            bool ExitIsTrue = false;
            try
            {
                client.ExecuteAsync(request, response =>
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        ExitIsTrue = true;
                    }
                    else
                    {
                        ExitIsTrue = false;
                    }
                });
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            return ExitIsTrue;
        }
    }
}