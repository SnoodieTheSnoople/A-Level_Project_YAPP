namespace YappPrototype1.Login_Forms.Forgot_Password
{
    partial class ForgotPassword
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
            this.Npword_TxtBox1 = new System.Windows.Forms.TextBox();
            this.Cnpword_TxtBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelBtn1 = new System.Windows.Forms.Button();
            this.SubmitBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Npword_TxtBox1
            // 
            this.Npword_TxtBox1.Location = new System.Drawing.Point(64, 40);
            this.Npword_TxtBox1.Name = "Npword_TxtBox1";
            this.Npword_TxtBox1.PasswordChar = '*';
            this.Npword_TxtBox1.Size = new System.Drawing.Size(310, 23);
            this.Npword_TxtBox1.TabIndex = 0;
            // 
            // Cnpword_TxtBox2
            // 
            this.Cnpword_TxtBox2.Location = new System.Drawing.Point(64, 88);
            this.Cnpword_TxtBox2.Name = "Cnpword_TxtBox2";
            this.Cnpword_TxtBox2.PasswordChar = '*';
            this.Cnpword_TxtBox2.Size = new System.Drawing.Size(310, 23);
            this.Cnpword_TxtBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm New Password:";
            // 
            // CancelBtn1
            // 
            this.CancelBtn1.Location = new System.Drawing.Point(101, 169);
            this.CancelBtn1.Name = "CancelBtn1";
            this.CancelBtn1.Size = new System.Drawing.Size(113, 26);
            this.CancelBtn1.TabIndex = 4;
            this.CancelBtn1.Text = "Cancel";
            this.CancelBtn1.UseVisualStyleBackColor = true;
            this.CancelBtn1.Click += new System.EventHandler(this.CancelBtn1_Click);
            // 
            // SubmitBtn2
            // 
            this.SubmitBtn2.Location = new System.Drawing.Point(233, 169);
            this.SubmitBtn2.Name = "SubmitBtn2";
            this.SubmitBtn2.Size = new System.Drawing.Size(105, 26);
            this.SubmitBtn2.TabIndex = 5;
            this.SubmitBtn2.Text = "Submit";
            this.SubmitBtn2.UseVisualStyleBackColor = true;
            this.SubmitBtn2.Click += new System.EventHandler(this.SubmitBtn2_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 210);
            this.Controls.Add(this.SubmitBtn2);
            this.Controls.Add(this.CancelBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cnpword_TxtBox2);
            this.Controls.Add(this.Npword_TxtBox1);
            this.Name = "ForgotPassword";
            this.Text = "Yapp! Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Npword_TxtBox1;
        private System.Windows.Forms.TextBox Cnpword_TxtBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelBtn1;
        private System.Windows.Forms.Button SubmitBtn2;
    }
}