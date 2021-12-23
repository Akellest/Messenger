using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class ChatForm : Form
    {
        private static int messageID = 0;
        private static int userId = 0;
        private static MessangerClientAPI API = new MessangerClientAPI();
        public static ChatForm Self;
        InfoForm InfForm = new InfoForm();
        Form Reg = new RegForm();

        public ChatForm()
        {
            InitializeComponent();
            Self = this;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (LogName.ReadOnly)
                textBox2.ReadOnly = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            string user = LogName.Text;
            string message = textBox2.Text;
            
            if ((message.Length > 1) && (user.Length > 1))
            {
                MessageClass msg = new MessageClass(user, message, DateTime.Now);
                API.SendMessage(msg);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            var getUser = new Func<Task>(async () =>
            {
                UserClass user = await API.GetUser(userId);
                while (user != null)
                {
                    usersList.Items.Add(user.User);
                    InfForm.dataGridView1.Rows.Add(user.User, user.Email, user.Phone);
                    MessageBox.Items.Add("User '" + user.User + "' registered");
                    userId++;
                    user = await API.GetUser(userId);
                }
            });
            getUser.Invoke();


            var getMessage = new Func<Task>(async () =>
            {
                MessageClass message = await API.GetMessage(messageID);
                while (message != null)
                {
                    MessageBox.Items.Add(message);
                    messageID++;
                    message = await API.GetMessage(messageID);
                }
            });
            getMessage.Invoke();
        }

        private void RegName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reg.Show();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            InfForm.Show();
        }

        private void ChatForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }
    }
}