namespace YappPrototype1.Chat_Forms
{
    partial class AccDetails
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
            this.EmailDisplay_TxtBox1 = new System.Windows.Forms.TextBox();
            this.UnameDisplay_TxtBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangePword_Btn1 = new System.Windows.Forms.Button();
            this.DeleteAcc_chkBox1 = new System.Windows.Forms.CheckBox();
            this.DeleteAcc_Btn2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Close_Btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailDisplay_TxtBox1
            // 
            this.EmailDisplay_TxtBox1.Location = new System.Drawing.Point(94, 35);
            this.EmailDisplay_TxtBox1.Name = "EmailDisplay_TxtBox1";
            this.EmailDisplay_TxtBox1.ReadOnly = true;
            this.EmailDisplay_TxtBox1.Size = new System.Drawing.Size(321, 23);
            this.EmailDisplay_TxtBox1.TabIndex = 0;
            // 
            // UnameDisplay_TxtBox2
            // 
            this.UnameDisplay_TxtBox2.Location = new System.Drawing.Point(94, 73);
            this.UnameDisplay_TxtBox2.Name = "UnameDisplay_TxtBox2";
            this.UnameDisplay_TxtBox2.ReadOnly = true;
            this.UnameDisplay_TxtBox2.Size = new System.Drawing.Size(321, 23);
            this.UnameDisplay_TxtBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // ChangePword_Btn1
            // 
            this.ChangePword_Btn1.Location = new System.Drawing.Point(94, 115);
            this.ChangePword_Btn1.Name = "ChangePword_Btn1";
            this.ChangePword_Btn1.Size = new System.Drawing.Size(160, 29);
            this.ChangePword_Btn1.TabIndex = 4;
            this.ChangePword_Btn1.Text = "Change Your Password";
            this.ChangePword_Btn1.UseVisualStyleBackColor = true;
            this.ChangePword_Btn1.Click += new System.EventHandler(this.ChangePword_Btn1_Click);
            // 
            // DeleteAcc_chkBox1
            // 
            this.DeleteAcc_chkBox1.AutoSize = true;
            this.DeleteAcc_chkBox1.Location = new System.Drawing.Point(94, 225);
            this.DeleteAcc_chkBox1.Name = "DeleteAcc_chkBox1";
            this.DeleteAcc_chkBox1.Size = new System.Drawing.Size(218, 19);
            this.DeleteAcc_chkBox1.TabIndex = 5;
            this.DeleteAcc_chkBox1.Text = "Do you wish to delete your account?";
            this.DeleteAcc_chkBox1.UseVisualStyleBackColor = true;
            this.DeleteAcc_chkBox1.CheckedChanged += new System.EventHandler(this.DeleteAcc_chkBox1_CheckedChanged);
            // 
            // DeleteAcc_Btn2
            // 
            this.DeleteAcc_Btn2.Location = new System.Drawing.Point(94, 190);
            this.DeleteAcc_Btn2.Name = "DeleteAcc_Btn2";
            this.DeleteAcc_Btn2.Size = new System.Drawing.Size(160, 29);
            this.DeleteAcc_Btn2.TabIndex = 6;
            this.DeleteAcc_Btn2.Text = "Delete My Account";
            this.DeleteAcc_Btn2.UseVisualStyleBackColor = true;
            this.DeleteAcc_Btn2.Click += new System.EventHandler(this.DeleteAcc_Btn2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Close_Btn3
            // 
            this.Close_Btn3.Location = new System.Drawing.Point(198, 297);
            this.Close_Btn3.Name = "Close_Btn3";
            this.Close_Btn3.Size = new System.Drawing.Size(113, 28);
            this.Close_Btn3.TabIndex = 8;
            this.Close_Btn3.Text = "Close";
            this.Close_Btn3.UseVisualStyleBackColor = true;
            this.Close_Btn3.Click += new System.EventHandler(this.Close_Btn3_Click);
            // 
            // AccDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 337);
            this.Controls.Add(this.Close_Btn3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteAcc_Btn2);
            this.Controls.Add(this.DeleteAcc_chkBox1);
            this.Controls.Add(this.ChangePword_Btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnameDisplay_TxtBox2);
            this.Controls.Add(this.EmailDisplay_TxtBox1);
            this.Name = "AccDetails";
            this.Text = "Yapp! Account Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailDisplay_TxtBox1;
        private System.Windows.Forms.TextBox UnameDisplay_TxtBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangePword_Btn1;
        private System.Windows.Forms.CheckBox DeleteAcc_chkBox1;
        private System.Windows.Forms.Button DeleteAcc_Btn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close_Btn3;
    }
}