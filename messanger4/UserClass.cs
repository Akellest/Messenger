using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ConsoleClient
{
    [Serializable]
    public class UserClass
    {
        public string UserName { get; set; }

        public UserClass(string userName)
        {
            UserName = userName;
        }

        public UserClass()
        {
        }

        public override string ToString()
        {
            string output = String.Format(UserName);
            return output;
        }
    }
}
