using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class RegForm : Form
    {
        private static MessangerClientAPI API = new MessangerClientAPI();
        string patternEmail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        string patternPhone = @"^(\+|\(\d+\))?\d+(-\d+)*$";

        public RegForm()
        {
            InitializeComponent();
        }

        public bool Checker()
        {
            if (RegMailF2.Text.Length > 0)
            {
                if (!Regex.IsMatch(RegMailF2.Text, patternEmail, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Некорректный mail");
                    return false;
                }
            }
            if (RegPhoneF2.Text.Length > 0)
            {
                if (!Regex.IsMatch(RegPhoneF2.Text, patternPhone, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Некорректный телефон");
                    return false;
                }
            }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNameF2.Text.Length > 1)
            {
                if (Checker())
                {
                    UserClass user = new UserClass(RegNameF2.Text, RegMailF2.Text, RegPhoneF2.Text);
                    API.AddUser(user);
                    MessageBox.Show("Пользователь зарегистрирован");
                    ChatForm.Self.LogName.Text = RegNameF2.Text;
                    ChatForm.Self.textBox2.ReadOnly = false;
                    ChatForm.Self.RegButton.Enabled = false;
                    ChatForm.Self.RegButton.BackColor = Color.White;
                    Hide();
                }
            }
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }
    }
}