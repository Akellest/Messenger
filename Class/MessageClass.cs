using System;

namespace Class
{
    [Serializable]
    public class MessageClass
    {
        public string UserName { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }

        public MessageClass()
        {
            UserName = "System";
            Message = "Server is running";
            Time = DateTime.UtcNow;
        }

        public MessageClass(string user, string message, DateTime time)
        {
            UserName = user;
            Message = message;
            Time = time;
        }

        public override string ToString()
        {
            string output = $"{UserName} < {Time} > : {Message}";
            return output;
        }
    }
}