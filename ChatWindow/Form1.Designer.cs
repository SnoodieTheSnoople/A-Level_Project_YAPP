namespace ChatWindow
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
            this.EnterIPBox = new System.Windows.Forms.TextBox();
            this.EnterPortBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ChatDisplayBox = new System.Windows.Forms.RichTextBox();
            this.SendMsgBox = new System.Windows.Forms.TextBox();
            this.SendMsgButton = new System.Windows.Forms.Button();
            this.DisconnectServerBtn = new System.Windows.Forms.Button();
            this.EnterUNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterIPBox
            // 
            this.EnterIPBox.Location = new System.Drawing.Point(9, 9);
            this.EnterIPBox.Name = "EnterIPBox";
            this.EnterIPBox.Size = new System.Drawing.Size(100, 23);
            this.EnterIPBox.TabIndex = 0;
            this.EnterIPBox.Text = "127.0.0.1";
            // 
            // EnterPortBox
            // 
            this.EnterPortBox.Location = new System.Drawing.Point(9, 45);
            this.EnterPortBox.Name = "EnterPortBox";
            this.EnterPortBox.Size = new System.Drawing.Size(100, 23);
            this.EnterPortBox.TabIndex = 1;
            this.EnterPortBox.Text = "8888";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(9, 74);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(100, 21);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ChatDisplayBox
            // 
            this.ChatDisplayBox.Location = new System.Drawing.Point(120, 12);
            this.ChatDisplayBox.Name = "ChatDisplayBox";
            this.ChatDisplayBox.ReadOnly = true;
            this.ChatDisplayBox.Size = new System.Drawing.Size(635, 383);
            this.ChatDisplayBox.TabIndex = 3;
            this.ChatDisplayBox.Text = "";
            // 
            // SendMsgBox
            // 
            this.SendMsgBox.Location = new System.Drawing.Point(120, 401);
            this.SendMsgBox.Name = "SendMsgBox";
            this.SendMsgBox.Size = new System.Drawing.Size(575, 23);
            this.SendMsgBox.TabIndex = 4;
            this.SendMsgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendMsgBox_KeyDown);
            // 
            // SendMsgButton
            // 
            this.SendMsgButton.Location = new System.Drawing.Point(701, 401);
            this.SendMsgButton.Name = "SendMsgButton";
            this.SendMsgButton.Size = new System.Drawing.Size(53, 22);
            this.SendMsgButton.TabIndex = 5;
            this.SendMsgButton.Text = "Send";
            this.SendMsgButton.UseVisualStyleBackColor = true;
            this.SendMsgButton.Click += new System.EventHandler(this.SendMsgButton_Click);
            this.SendMsgButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendMsgButton_KeyDown);
            // 
            // DisconnectServerBtn
            // 
            this.DisconnectServerBtn.Location = new System.Drawing.Point(9, 101);
            this.DisconnectServerBtn.Name = "DisconnectServerBtn";
            this.DisconnectServerBtn.Size = new System.Drawing.Size(100, 21);
            this.DisconnectServerBtn.TabIndex = 6;
            this.DisconnectServerBtn.Text = "Disconnect";
            this.DisconnectServerBtn.UseVisualStyleBackColor = true;
            this.DisconnectServerBtn.Click += new System.EventHandler(this.DisconnectServerBtn_Click);
            // 
            // EnterUNameBox
            // 
            this.EnterUNameBox.Location = new System.Drawing.Point(9, 141);
            this.EnterUNameBox.Name = "EnterUNameBox";
            this.EnterUNameBox.Size = new System.Drawing.Size(100, 23);
            this.EnterUNameBox.TabIndex = 7;
            this.EnterUNameBox.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterUNameBox);
            this.Controls.Add(this.DisconnectServerBtn);
            this.Controls.Add(this.SendMsgButton);
            this.Controls.Add(this.SendMsgBox);
            this.Controls.Add(this.ChatDisplayBox);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.EnterPortBox);
            this.Controls.Add(this.EnterIPBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterIPBox;
        private System.Windows.Forms.TextBox EnterPortBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.RichTextBox ChatDisplayBox;
        private System.Windows.Forms.TextBox SendMsgBox;
        private System.Windows.Forms.Button SendMsgButton;
        private System.Windows.Forms.Button DisconnectServerBtn;
        private System.Windows.Forms.TextBox EnterUNameBox;
    }
}

