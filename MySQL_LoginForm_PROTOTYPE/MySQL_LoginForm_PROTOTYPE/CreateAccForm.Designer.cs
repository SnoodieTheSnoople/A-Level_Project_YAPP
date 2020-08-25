namespace MySQL_LoginForm_PROTOTYPE
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
            this.EmailTxtBox1 = new System.Windows.Forms.TextBox();
            this.UnameTxtBox2 = new System.Windows.Forms.TextBox();
            this.PwordTxtBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmpwordTxtBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelBtn1 = new System.Windows.Forms.Button();
            this.CreateAccBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTxtBox1
            // 
            this.EmailTxtBox1.Location = new System.Drawing.Point(63, 34);
            this.EmailTxtBox1.Name = "EmailTxtBox1";
            this.EmailTxtBox1.Size = new System.Drawing.Size(295, 23);
            this.EmailTxtBox1.TabIndex = 0;
            // 
            // UnameTxtBox2
            // 
            this.UnameTxtBox2.Location = new System.Drawing.Point(63, 82);
            this.UnameTxtBox2.Name = "UnameTxtBox2";
            this.UnameTxtBox2.Size = new System.Drawing.Size(295, 23);
            this.UnameTxtBox2.TabIndex = 1;
            // 
            // PwordTxtBox3
            // 
            this.PwordTxtBox3.Location = new System.Drawing.Point(63, 151);
            this.PwordTxtBox3.Name = "PwordTxtBox3";
            this.PwordTxtBox3.PasswordChar = '*';
            this.PwordTxtBox3.Size = new System.Drawing.Size(295, 23);
            this.PwordTxtBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Email:";
            // 
            // ConfirmpwordTxtBox4
            // 
            this.ConfirmpwordTxtBox4.Location = new System.Drawing.Point(63, 197);
            this.ConfirmpwordTxtBox4.Name = "ConfirmpwordTxtBox4";
            this.ConfirmpwordTxtBox4.PasswordChar = '*';
            this.ConfirmpwordTxtBox4.Size = new System.Drawing.Size(295, 23);
            this.ConfirmpwordTxtBox4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password:";
            // 
            // CancelBtn1
            // 
            this.CancelBtn1.Location = new System.Drawing.Point(92, 259);
            this.CancelBtn1.Name = "CancelBtn1";
            this.CancelBtn1.Size = new System.Drawing.Size(107, 27);
            this.CancelBtn1.TabIndex = 7;
            this.CancelBtn1.Text = "Cancel";
            this.CancelBtn1.UseVisualStyleBackColor = true;
            this.CancelBtn1.Click += new System.EventHandler(this.CancelBtn1_Click);
            // 
            // CreateAccBtn2
            // 
            this.CreateAccBtn2.Location = new System.Drawing.Point(205, 259);
            this.CreateAccBtn2.Name = "CreateAccBtn2";
            this.CreateAccBtn2.Size = new System.Drawing.Size(107, 27);
            this.CreateAccBtn2.TabIndex = 8;
            this.CreateAccBtn2.Text = "Create Account";
            this.CreateAccBtn2.UseVisualStyleBackColor = true;
            this.CreateAccBtn2.Click += new System.EventHandler(this.CreateAccBtn2_Click);
            // 
            // CreateAccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 298);
            this.Controls.Add(this.CreateAccBtn2);
            this.Controls.Add(this.CancelBtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmpwordTxtBox4);
            this.Controls.Add(this.PwordTxtBox3);
            this.Controls.Add(this.UnameTxtBox2);
            this.Controls.Add(this.EmailTxtBox1);
            this.Name = "CreateAccForm";
            this.Text = "Yapp! Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTxtBox1;
        private System.Windows.Forms.TextBox UnameTxtBox2;
        private System.Windows.Forms.TextBox PwordTxtBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfirmpwordTxtBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelBtn1;
        private System.Windows.Forms.Button CreateAccBtn2;
    }
}