
namespace WindowsFormsClient
{
    partial class ChatForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Send = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userList = new System.Windows.Forms.Label();
            this.LogName = new System.Windows.Forms.TextBox();
            this.usersList = new System.Windows.Forms.ListBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.Silver;
            this.Send.Location = new System.Drawing.Point(756, 443);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(134, 42);
            this.Send.TabIndex = 0;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // MessageBox
            // 
            this.MessageBox.FormattingEnabled = true;
            this.MessageBox.ItemHeight = 15;
            this.MessageBox.Location = new System.Drawing.Point(194, 14);
            this.MessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(696, 379);
            this.MessageBox.TabIndex = 1;
            this.MessageBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 462);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(442, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 417);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(35, 466);
            this.Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(57, 15);
            this.Message.TabIndex = 3;
            this.Message.Text = "Message:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userList
            // 
            this.userList.AutoSize = true;
            this.userList.Location = new System.Drawing.Point(66, 14);
            this.userList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(56, 15);
            this.userList.TabIndex = 6;
            this.userList.Text = "User list:";
            // 
            // LogName
            // 
            this.LogName.Location = new System.Drawing.Point(116, 415);
            this.LogName.Margin = new System.Windows.Forms.Padding(4);
            this.LogName.Name = "LogName";
            this.LogName.ReadOnly = true;
            this.LogName.Size = new System.Drawing.Size(176, 23);
            this.LogName.TabIndex = 9;
            this.LogName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogName.TextChanged += new System.EventHandler(this.RegName_TextChanged);
            // 
            // usersList
            // 
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 15;
            this.usersList.Location = new System.Drawing.Point(14, 37);
            this.usersList.Margin = new System.Windows.Forms.Padding(4);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(162, 304);
            this.usersList.TabIndex = 10;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Silver;
            this.RegButton.Location = new System.Drawing.Point(333, 411);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(109, 29);
            this.RegButton.TabIndex = 11;
            this.RegButton.Text = "Registration";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.Silver;
            this.InfoButton.Location = new System.Drawing.Point(14, 352);
            this.InfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(162, 41);
            this.InfoButton.TabIndex = 12;
            this.InfoButton.Text = "User data";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 520);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.LogName);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.Send);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChatForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatForm_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ListBox MessageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label userList;
        public System.Windows.Forms.TextBox LogName;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Button InfoButton;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Button RegButton;
    }
}

