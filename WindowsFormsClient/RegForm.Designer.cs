
namespace WindowsFormsClient
{
    partial class RegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegInfoButton = new System.Windows.Forms.Button();
            this.RegNameF2 = new System.Windows.Forms.TextBox();
            this.RegMailF2 = new System.Windows.Forms.TextBox();
            this.RegPhoneF2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegInfoButton
            // 
            this.RegInfoButton.Location = new System.Drawing.Point(379, 248);
            this.RegInfoButton.Name = "RegInfoButton";
            this.RegInfoButton.Size = new System.Drawing.Size(128, 49);
            this.RegInfoButton.TabIndex = 0;
            this.RegInfoButton.Text = "Зарегистрировать данные";
            this.RegInfoButton.UseVisualStyleBackColor = true;
            this.RegInfoButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegNameF2
            // 
            this.RegNameF2.Location = new System.Drawing.Point(105, 52);
            this.RegNameF2.Name = "RegNameF2";
            this.RegNameF2.Size = new System.Drawing.Size(220, 20);
            this.RegNameF2.TabIndex = 1;
            // 
            // RegMailF2
            // 
            this.RegMailF2.Location = new System.Drawing.Point(105, 92);
            this.RegMailF2.Name = "RegMailF2";
            this.RegMailF2.Size = new System.Drawing.Size(220, 20);
            this.RegMailF2.TabIndex = 1;
            // 
            // RegPhoneF2
            // 
            this.RegPhoneF2.Location = new System.Drawing.Point(105, 138);
            this.RegPhoneF2.Name = "RegPhoneF2";
            this.RegPhoneF2.Size = new System.Drawing.Size(220, 20);
            this.RegPhoneF2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegPhoneF2);
            this.Controls.Add(this.RegMailF2);
            this.Controls.Add(this.RegNameF2);
            this.Controls.Add(this.RegInfoButton);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegInfoButton;
        public System.Windows.Forms.TextBox RegNameF2;
        private System.Windows.Forms.TextBox RegMailF2;
        private System.Windows.Forms.TextBox RegPhoneF2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}