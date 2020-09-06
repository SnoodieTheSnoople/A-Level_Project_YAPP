namespace YappPrototype1
{
    partial class CreateAccForm
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
            this.Email_TxtBox1 = new System.Windows.Forms.TextBox();
            this.Uname_TxtBox2 = new System.Windows.Forms.TextBox();
            this.Pword_TxtBox3 = new System.Windows.Forms.TextBox();
            this.ConfirmPword_TxtBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelBtn1 = new System.Windows.Forms.Button();
            this.CreateAccBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Email_TxtBox1
            // 
            this.Email_TxtBox1.Location = new System.Drawing.Point(75, 25);
            this.Email_TxtBox1.Name = "Email_TxtBox1";
            this.Email_TxtBox1.Size = new System.Drawing.Size(337, 23);
            this.Email_TxtBox1.TabIndex = 0;
            // 
            // Uname_TxtBox2
            // 
            this.Uname_TxtBox2.Location = new System.Drawing.Point(75, 71);
            this.Uname_TxtBox2.Name = "Uname_TxtBox2";
            this.Uname_TxtBox2.Size = new System.Drawing.Size(337, 23);
            this.Uname_TxtBox2.TabIndex = 1;
            // 
            // Pword_TxtBox3
            // 
            this.Pword_TxtBox3.Location = new System.Drawing.Point(75, 140);
            this.Pword_TxtBox3.Name = "Pword_TxtBox3";
            this.Pword_TxtBox3.PasswordChar = '*';
            this.Pword_TxtBox3.Size = new System.Drawing.Size(337, 23);
            this.Pword_TxtBox3.TabIndex = 2;
            this.Pword_TxtBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ConfirmPword_TxtBox4
            // 
            this.ConfirmPword_TxtBox4.Location = new System.Drawing.Point(75, 188);
            this.ConfirmPword_TxtBox4.Name = "ConfirmPword_TxtBox4";
            this.ConfirmPword_TxtBox4.PasswordChar = '*';
            this.ConfirmPword_TxtBox4.Size = new System.Drawing.Size(337, 23);
            this.ConfirmPword_TxtBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password:";
            // 
            // CancelBtn1
            // 
            this.CancelBtn1.Location = new System.Drawing.Point(121, 247);
            this.CancelBtn1.Name = "CancelBtn1";
            this.CancelBtn1.Size = new System.Drawing.Size(113, 34);
            this.CancelBtn1.TabIndex = 8;
            this.CancelBtn1.Text = "Cancel";
            this.CancelBtn1.UseVisualStyleBackColor = true;
            this.CancelBtn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAccBtn2
            // 
            this.CreateAccBtn2.Location = new System.Drawing.Point(254, 247);
            this.CreateAccBtn2.Name = "CreateAccBtn2";
            this.CreateAccBtn2.Size = new System.Drawing.Size(111, 33);
            this.CreateAccBtn2.TabIndex = 9;
            this.CreateAccBtn2.Text = "Create Account";
            this.CreateAccBtn2.UseVisualStyleBackColor = true;
            this.CreateAccBtn2.Click += new System.EventHandler(this.CreateAccBtn2_Click);
            // 
            // CreateAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 289);
            this.Controls.Add(this.CreateAccBtn2);
            this.Controls.Add(this.CancelBtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPword_TxtBox4);
            this.Controls.Add(this.Pword_TxtBox3);
            this.Controls.Add(this.Uname_TxtBox2);
            this.Controls.Add(this.Email_TxtBox1);
            this.Name = "CreateAccForm";
            this.Text = "Yapp! Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email_TxtBox1;
        private System.Windows.Forms.TextBox Uname_TxtBox2;
        private System.Windows.Forms.TextBox Pword_TxtBox3;
        private System.Windows.Forms.TextBox ConfirmPword_TxtBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelBtn1;
        private System.Windows.Forms.Button CreateAccBtn2;
    }
}