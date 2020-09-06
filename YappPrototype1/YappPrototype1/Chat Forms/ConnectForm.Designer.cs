namespace YappPrototype1.Chat_Forms
{
    partial class ConnectForm
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
            this.IP_TxtBox1 = new System.Windows.Forms.TextBox();
            this.PortNo_TxtBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel_Btn1 = new System.Windows.Forms.Button();
            this.Connect_Btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP_TxtBox1
            // 
            this.IP_TxtBox1.Location = new System.Drawing.Point(31, 41);
            this.IP_TxtBox1.Name = "IP_TxtBox1";
            this.IP_TxtBox1.Size = new System.Drawing.Size(198, 23);
            this.IP_TxtBox1.TabIndex = 0;
            // 
            // PortNo_TxtBox2
            // 
            this.PortNo_TxtBox2.Location = new System.Drawing.Point(237, 41);
            this.PortNo_TxtBox2.Name = "PortNo_TxtBox2";
            this.PortNo_TxtBox2.Size = new System.Drawing.Size(86, 23);
            this.PortNo_TxtBox2.TabIndex = 1;
            this.PortNo_TxtBox2.Text = "2693";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // Cancel_Btn1
            // 
            this.Cancel_Btn1.Location = new System.Drawing.Point(75, 94);
            this.Cancel_Btn1.Name = "Cancel_Btn1";
            this.Cancel_Btn1.Size = new System.Drawing.Size(96, 29);
            this.Cancel_Btn1.TabIndex = 4;
            this.Cancel_Btn1.Text = "Cancel";
            this.Cancel_Btn1.UseVisualStyleBackColor = true;
            this.Cancel_Btn1.Click += new System.EventHandler(this.Cancel_Btn1_Click);
            // 
            // Connect_Btn2
            // 
            this.Connect_Btn2.Location = new System.Drawing.Point(186, 94);
            this.Connect_Btn2.Name = "Connect_Btn2";
            this.Connect_Btn2.Size = new System.Drawing.Size(93, 29);
            this.Connect_Btn2.TabIndex = 5;
            this.Connect_Btn2.Text = "Connect";
            this.Connect_Btn2.UseVisualStyleBackColor = true;
            this.Connect_Btn2.Click += new System.EventHandler(this.Connect_Btn2_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 135);
            this.Controls.Add(this.Connect_Btn2);
            this.Controls.Add(this.Cancel_Btn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortNo_TxtBox2);
            this.Controls.Add(this.IP_TxtBox1);
            this.Name = "ConnectForm";
            this.Text = "ConnectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IP_TxtBox1;
        private System.Windows.Forms.TextBox PortNo_TxtBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel_Btn1;
        private System.Windows.Forms.Button Connect_Btn2;
    }
}