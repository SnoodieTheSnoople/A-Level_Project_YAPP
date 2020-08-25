namespace MySQL_LoginForm_PROTOTYPE
{
    partial class Form1
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
            this.uNameTxtBx1 = new System.Windows.Forms.TextBox();
            this.PwordTxtBx2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Quit_Btn1 = new System.Windows.Forms.Button();
            this.Login_Btn2 = new System.Windows.Forms.Button();
            this.CreateAcc_Btn3 = new System.Windows.Forms.Button();
            this.emailTxtBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uNameTxtBx1
            // 
            this.uNameTxtBx1.Location = new System.Drawing.Point(42, 80);
            this.uNameTxtBx1.Name = "uNameTxtBx1";
            this.uNameTxtBx1.Size = new System.Drawing.Size(302, 23);
            this.uNameTxtBx1.TabIndex = 0;
            // 
            // PwordTxtBx2
            // 
            this.PwordTxtBx2.Location = new System.Drawing.Point(42, 130);
            this.PwordTxtBx2.Name = "PwordTxtBx2";
            this.PwordTxtBx2.PasswordChar = '*';
            this.PwordTxtBx2.Size = new System.Drawing.Size(302, 23);
            this.PwordTxtBx2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // Quit_Btn1
            // 
            this.Quit_Btn1.Location = new System.Drawing.Point(96, 193);
            this.Quit_Btn1.Name = "Quit_Btn1";
            this.Quit_Btn1.Size = new System.Drawing.Size(90, 23);
            this.Quit_Btn1.TabIndex = 4;
            this.Quit_Btn1.Text = "Quit";
            this.Quit_Btn1.UseVisualStyleBackColor = true;
            this.Quit_Btn1.Click += new System.EventHandler(this.Quit_Btn1_Click);
            // 
            // Login_Btn2
            // 
            this.Login_Btn2.Location = new System.Drawing.Point(192, 193);
            this.Login_Btn2.Name = "Login_Btn2";
            this.Login_Btn2.Size = new System.Drawing.Size(90, 23);
            this.Login_Btn2.TabIndex = 5;
            this.Login_Btn2.Text = "Login";
            this.Login_Btn2.UseVisualStyleBackColor = true;
            this.Login_Btn2.Click += new System.EventHandler(this.Login_Btn2_Click);
            // 
            // CreateAcc_Btn3
            // 
            this.CreateAcc_Btn3.Location = new System.Drawing.Point(128, 164);
            this.CreateAcc_Btn3.Name = "CreateAcc_Btn3";
            this.CreateAcc_Btn3.Size = new System.Drawing.Size(127, 23);
            this.CreateAcc_Btn3.TabIndex = 6;
            this.CreateAcc_Btn3.Text = "Create Account";
            this.CreateAcc_Btn3.UseVisualStyleBackColor = true;
            this.CreateAcc_Btn3.Click += new System.EventHandler(this.CreateAcc_Btn3_Click);
            // 
            // emailTxtBox3
            // 
            this.emailTxtBox3.Location = new System.Drawing.Point(42, 30);
            this.emailTxtBox3.Name = "emailTxtBox3";
            this.emailTxtBox3.Size = new System.Drawing.Size(302, 23);
            this.emailTxtBox3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailTxtBox3);
            this.Controls.Add(this.CreateAcc_Btn3);
            this.Controls.Add(this.Login_Btn2);
            this.Controls.Add(this.Quit_Btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PwordTxtBx2);
            this.Controls.Add(this.uNameTxtBx1);
            this.Name = "Form1";
            this.Text = "Yapp!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uNameTxtBx1;
        private System.Windows.Forms.TextBox PwordTxtBx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Quit_Btn1;
        private System.Windows.Forms.Button Login_Btn2;
        private System.Windows.Forms.Button CreateAcc_Btn3;
        private System.Windows.Forms.TextBox emailTxtBox3;
        private System.Windows.Forms.Label label3;
    }
}

