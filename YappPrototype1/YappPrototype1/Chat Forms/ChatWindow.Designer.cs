namespace YappPrototype1.Chat_Forms
{
    partial class ChatWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ConnectionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.C_ConnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.C_DisconnectToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.C_QuitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BmarkToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.T_AccDetailsMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.T_OutCLogMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Chat_TextBox1 = new System.Windows.Forms.TextBox();
            this.Msg_TextBox2 = new System.Windows.Forms.TextBox();
            this.SendMsg_Btn1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionsToolStripMenuItem1,
            this.BmarkToolStripMenuItem2,
            this.ToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ConnectionsToolStripMenuItem1
            // 
            this.ConnectionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.C_ConnectToolStripMenuItem1,
            this.C_DisconnectToolStripMenuItem2,
            this.toolStripSeparator1,
            this.C_QuitToolStripMenuItem1});
            this.ConnectionsToolStripMenuItem1.Name = "ConnectionsToolStripMenuItem1";
            this.ConnectionsToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.ConnectionsToolStripMenuItem1.Text = "&Connections";
            // 
            // C_ConnectToolStripMenuItem1
            // 
            this.C_ConnectToolStripMenuItem1.Name = "C_ConnectToolStripMenuItem1";
            this.C_ConnectToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.C_ConnectToolStripMenuItem1.Text = "Connect";
            this.C_ConnectToolStripMenuItem1.Click += new System.EventHandler(this.C_ConnectToolStripMenuItem1_Click);
            // 
            // C_DisconnectToolStripMenuItem2
            // 
            this.C_DisconnectToolStripMenuItem2.Name = "C_DisconnectToolStripMenuItem2";
            this.C_DisconnectToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.C_DisconnectToolStripMenuItem2.Text = "Disconnect";
            this.C_DisconnectToolStripMenuItem2.Click += new System.EventHandler(this.C_DisconnectToolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // C_QuitToolStripMenuItem1
            // 
            this.C_QuitToolStripMenuItem1.Name = "C_QuitToolStripMenuItem1";
            this.C_QuitToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.C_QuitToolStripMenuItem1.Text = "Quit";
            this.C_QuitToolStripMenuItem1.Click += new System.EventHandler(this.C_QuitToolStripMenuItem1_Click);
            // 
            // BmarkToolStripMenuItem2
            // 
            this.BmarkToolStripMenuItem2.Name = "BmarkToolStripMenuItem2";
            this.BmarkToolStripMenuItem2.Size = new System.Drawing.Size(78, 20);
            this.BmarkToolStripMenuItem2.Text = "&Bookmarks";
            this.BmarkToolStripMenuItem2.Click += new System.EventHandler(this.BmarkToolStripMenuItem2_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.T_AccDetailsMenuItem1,
            this.T_OutCLogMenuItem1});
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(46, 20);
            this.ToolStripMenuItem3.Text = "&Tools";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // T_AccDetailsMenuItem1
            // 
            this.T_AccDetailsMenuItem1.Name = "T_AccDetailsMenuItem1";
            this.T_AccDetailsMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.T_AccDetailsMenuItem1.Text = "Account Details";
            this.T_AccDetailsMenuItem1.Click += new System.EventHandler(this.T_AccDetailsMenuItem1_Click);
            // 
            // T_OutCLogMenuItem1
            // 
            this.T_OutCLogMenuItem1.Name = "T_OutCLogMenuItem1";
            this.T_OutCLogMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.T_OutCLogMenuItem1.Text = "Output Chat Log";
            this.T_OutCLogMenuItem1.Click += new System.EventHandler(this.T_OutCLogMenuItem1_Click);
            // 
            // Chat_TextBox1
            // 
            this.Chat_TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chat_TextBox1.Location = new System.Drawing.Point(11, 27);
            this.Chat_TextBox1.Multiline = true;
            this.Chat_TextBox1.Name = "Chat_TextBox1";
            this.Chat_TextBox1.ReadOnly = true;
            this.Chat_TextBox1.Size = new System.Drawing.Size(645, 370);
            this.Chat_TextBox1.TabIndex = 5;
            this.Chat_TextBox1.TextChanged += new System.EventHandler(this.Chat_TextBox1_TextChanged);
            // 
            // Msg_TextBox2
            // 
            this.Msg_TextBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Msg_TextBox2.Location = new System.Drawing.Point(12, 407);
            this.Msg_TextBox2.Name = "Msg_TextBox2";
            this.Msg_TextBox2.Size = new System.Drawing.Size(563, 27);
            this.Msg_TextBox2.TabIndex = 6;
            // 
            // SendMsg_Btn1
            // 
            this.SendMsg_Btn1.Location = new System.Drawing.Point(587, 407);
            this.SendMsg_Btn1.Name = "SendMsg_Btn1";
            this.SendMsg_Btn1.Size = new System.Drawing.Size(69, 27);
            this.SendMsg_Btn1.TabIndex = 7;
            this.SendMsg_Btn1.Text = "Send";
            this.SendMsg_Btn1.UseVisualStyleBackColor = true;
            this.SendMsg_Btn1.Click += new System.EventHandler(this.SendMsg_Btn1_Click);
            this.SendMsg_Btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendMsg_Btn1_KeyDown);
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.SendMsg_Btn1);
            this.Controls.Add(this.Msg_TextBox2);
            this.Controls.Add(this.Chat_TextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChatWindow";
            this.Text = "Yapp!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox Chat_TextBox1;
        private System.Windows.Forms.TextBox Msg_TextBox2;
        private System.Windows.Forms.Button SendMsg_Btn1;
        private System.Windows.Forms.ToolStripMenuItem ConnectionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem BmarkToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem Connect_MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem C_ConnectToolStripMenu1;
        private System.Windows.Forms.ToolStripMenuItem C_ConnectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem C_DisconnectToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem C_QuitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem T_AccDetailsMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem T_OutCLogMenuItem1;
    }
}