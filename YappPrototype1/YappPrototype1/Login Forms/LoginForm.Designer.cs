namespace YappPrototype1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Email_TxtBox1 = new System.Windows.Forms.TextBox();
            this.Username_TxtBox2 = new System.Windows.Forms.TextBox();
            this.Pword_TxtBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Quit_Btn1 = new System.Windows.Forms.Button();
            this.Login_Btn2 = new System.Windows.Forms.Button();
            this.Forgotpword_link1 = new System.Windows.Forms.LinkLabel();
            this.CreateAcc_link2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Email_TxtBox1
            // 
            this.Email_TxtBox1.Location = new System.Drawing.Point(70, 35);
            this.Email_TxtBox1.Name = "Email_TxtBox1";
            this.Email_TxtBox1.Size = new System.Drawing.Size(308, 23);
            this.Email_TxtBox1.TabIndex = 0;
            // 
            // Username_TxtBox2
            // 
            this.Username_TxtBox2.Location = new System.Drawing.Point(70, 81);
            this.Username_TxtBox2.Name = "Username_TxtBox2";
            this.Username_TxtBox2.Size = new System.Drawing.Size(308, 23);
            this.Username_TxtBox2.TabIndex = 1;
            // 
            // Pword_TxtBox3
            // 
            this.Pword_TxtBox3.Location = new System.Drawing.Point(70, 127);
            this.Pword_TxtBox3.Name = "Pword_TxtBox3";
            this.Pword_TxtBox3.PasswordChar = '*';
            this.Pword_TxtBox3.Size = new System.Drawing.Size(308, 23);
            this.Pword_TxtBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // Quit_Btn1
            // 
            this.Quit_Btn1.Location = new System.Drawing.Point(118, 217);
            this.Quit_Btn1.Name = "Quit_Btn1";
            this.Quit_Btn1.Size = new System.Drawing.Size(96, 28);
            this.Quit_Btn1.TabIndex = 6;
            this.Quit_Btn1.Text = "Quit";
            this.Quit_Btn1.UseVisualStyleBackColor = true;
            this.Quit_Btn1.Click += new System.EventHandler(this.Quit_Btn1_Click);
            // 
            // Login_Btn2
            // 
            this.Login_Btn2.Location = new System.Drawing.Point(234, 217);
            this.Login_Btn2.Name = "Login_Btn2";
            this.Login_Btn2.Size = new System.Drawing.Size(96, 28);
            this.Login_Btn2.TabIndex = 7;
            this.Login_Btn2.Text = "Login";
            this.Login_Btn2.UseVisualStyleBackColor = true;
            this.Login_Btn2.Click += new System.EventHandler(this.Login_Btn2_Click);
            // 
            // Forgotpword_link1
            // 
            this.Forgotpword_link1.AutoSize = true;
            this.Forgotpword_link1.Location = new System.Drawing.Point(70, 153);
            this.Forgotpword_link1.Name = "Forgotpword_link1";
            this.Forgotpword_link1.Size = new System.Drawing.Size(127, 15);
            this.Forgotpword_link1.TabIndex = 8;
            this.Forgotpword_link1.TabStop = true;
            this.Forgotpword_link1.Text = "Forgot your password?";
            this.Forgotpword_link1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forgotpword_link1_LinkClicked);
            // 
            // CreateAcc_link2
            // 
            this.CreateAcc_link2.AutoSize = true;
            this.CreateAcc_link2.Location = new System.Drawing.Point(159, 190);
            this.CreateAcc_link2.Name = "CreateAcc_link2";
            this.CreateAcc_link2.Size = new System.Drawing.Size(131, 15);
            this.CreateAcc_link2.TabIndex = 9;
            this.CreateAcc_link2.TabStop = true;
            this.CreateAcc_link2.Text = "Don\'t have an account?";
            this.CreateAcc_link2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAcc_link2_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 257);
            this.Controls.Add(this.CreateAcc_link2);
            this.Controls.Add(this.Forgotpword_link1);
            this.Controls.Add(this.Login_Btn2);
            this.Controls.Add(this.Quit_Btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pword_TxtBox3);
            this.Controls.Add(this.Username_TxtBox2);
            this.Controls.Add(this.Email_TxtBox1);
            this.Name = "LoginForm";
            this.Text = "Yapp! Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email_TxtBox1;
        private System.Windows.Forms.TextBox Username_TxtBox2;
        private System.Windows.Forms.TextBox Pword_TxtBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Quit_Btn1;
        private System.Windows.Forms.Button Login_Btn2;
        private System.Windows.Forms.LinkLabel Forgotpword_link1;
        private System.Windows.Forms.LinkLabel CreateAcc_link2;
    }
}

