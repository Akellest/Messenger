using System;

namespace WindowsFormsClient
{
    [Serializable]
    public class UserClass
    {
        public string User { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public UserClass(string userName)
        {
            User = userName;
        }

        public UserClass(string userName, string email, string phone)
        {
            User = userName;
            Email = email;
            Phone = phone;
        }

        public UserClass()
        {
            User = "User is ...";
        }

        public override string ToString()
        {
            string output = User + " | email: " + Email + " | phone: " + Phone;
            return output;
        }
    }
}
