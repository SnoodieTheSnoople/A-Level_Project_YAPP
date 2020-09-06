namespace YappPrototype1
{
    partial class ConfirmAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelBtn1 = new System.Windows.Forms.Button();
            this.SubmitBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Email_TxtBox1
            // 
            this.Email_TxtBox1.Location = new System.Drawing.Point(60, 48);
            this.Email_TxtBox1.Name = "Email_TxtBox1";
            this.Email_TxtBox1.Size = new System.Drawing.Size(360, 23);
            this.Email_TxtBox1.TabIndex = 0;
            // 
            // Uname_TxtBox2
            // 
            this.Uname_TxtBox2.Location = new System.Drawing.Point(60, 96);
            this.Uname_TxtBox2.Name = "Uname_TxtBox2";
            this.Uname_TxtBox2.Size = new System.Drawing.Size(360, 23);
            this.Uname_TxtBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // CancelBtn1
            // 
            this.CancelBtn1.Location = new System.Drawing.Point(117, 170);
            this.CancelBtn1.Name = "CancelBtn1";
            this.CancelBtn1.Size = new System.Drawing.Size(112, 28);
            this.CancelBtn1.TabIndex = 4;
            this.CancelBtn1.Text = "Cancel";
            this.CancelBtn1.UseVisualStyleBackColor = true;
            this.CancelBtn1.Click += new System.EventHandler(this.CancelBtn1_Click);
            // 
            // SubmitBtn2
            // 
            this.SubmitBtn2.Location = new System.Drawing.Point(252, 170);
            this.SubmitBtn2.Name = "SubmitBtn2";
            this.SubmitBtn2.Size = new System.Drawing.Size(112, 28);
            this.SubmitBtn2.TabIndex = 5;
            this.SubmitBtn2.Text = "Submit";
            this.SubmitBtn2.UseVisualStyleBackColor = true;
            this.SubmitBtn2.Click += new System.EventHandler(this.SubmitBtn2_Click);
            // 
            // ConfirmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 211);
            this.Controls.Add(this.SubmitBtn2);
            this.Controls.Add(this.CancelBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Uname_TxtBox2);
            this.Controls.Add(this.Email_TxtBox1);
            this.Name = "ConfirmAccount";
            this.Text = "Yapp! Confirm Credentials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email_TxtBox1;
        private System.Windows.Forms.TextBox Uname_TxtBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelBtn1;
        private System.Windows.Forms.Button SubmitBtn2;
    }
}