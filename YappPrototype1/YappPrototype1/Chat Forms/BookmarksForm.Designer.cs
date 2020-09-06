namespace YappPrototype1.Chat_Forms
{
    partial class BookmarksForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.Connect_Btn1 = new System.Windows.Forms.Button();
            this.Add_Btn2 = new System.Windows.Forms.Button();
            this.Cancel_Btn3 = new System.Windows.Forms.Button();
            this.Name_TxtBox1 = new System.Windows.Forms.TextBox();
            this.IP_TxtBox2 = new System.Windows.Forms.TextBox();
            this.Port_TxtBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP Address";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Port";
            this.columnHeader3.Width = 100;
            // 
            // Connect_Btn1
            // 
            this.Connect_Btn1.Location = new System.Drawing.Point(393, 12);
            this.Connect_Btn1.Name = "Connect_Btn1";
            this.Connect_Btn1.Size = new System.Drawing.Size(82, 42);
            this.Connect_Btn1.TabIndex = 1;
            this.Connect_Btn1.Text = "Connect";
            this.Connect_Btn1.UseVisualStyleBackColor = true;
            this.Connect_Btn1.Click += new System.EventHandler(this.Connect_Btn1_Click);
            // 
            // Add_Btn2
            // 
            this.Add_Btn2.Location = new System.Drawing.Point(261, 446);
            this.Add_Btn2.Name = "Add_Btn2";
            this.Add_Btn2.Size = new System.Drawing.Size(82, 52);
            this.Add_Btn2.TabIndex = 2;
            this.Add_Btn2.Text = "Add";
            this.Add_Btn2.UseVisualStyleBackColor = true;
            this.Add_Btn2.Click += new System.EventHandler(this.Add_Btn2_Click);
            // 
            // Cancel_Btn3
            // 
            this.Cancel_Btn3.Location = new System.Drawing.Point(393, 70);
            this.Cancel_Btn3.Name = "Cancel_Btn3";
            this.Cancel_Btn3.Size = new System.Drawing.Size(82, 42);
            this.Cancel_Btn3.TabIndex = 3;
            this.Cancel_Btn3.Text = "Cancel";
            this.Cancel_Btn3.UseVisualStyleBackColor = true;
            this.Cancel_Btn3.Click += new System.EventHandler(this.Cancel_Btn3_Click);
            // 
            // Name_TxtBox1
            // 
            this.Name_TxtBox1.Location = new System.Drawing.Point(12, 446);
            this.Name_TxtBox1.Name = "Name_TxtBox1";
            this.Name_TxtBox1.Size = new System.Drawing.Size(243, 23);
            this.Name_TxtBox1.TabIndex = 4;
            this.Name_TxtBox1.Text = "Name";
            // 
            // IP_TxtBox2
            // 
            this.IP_TxtBox2.Location = new System.Drawing.Point(12, 475);
            this.IP_TxtBox2.Name = "IP_TxtBox2";
            this.IP_TxtBox2.Size = new System.Drawing.Size(166, 23);
            this.IP_TxtBox2.TabIndex = 5;
            this.IP_TxtBox2.Text = "IP Address";
            // 
            // Port_TxtBox3
            // 
            this.Port_TxtBox3.Location = new System.Drawing.Point(184, 475);
            this.Port_TxtBox3.Name = "Port_TxtBox3";
            this.Port_TxtBox3.Size = new System.Drawing.Size(71, 23);
            this.Port_TxtBox3.TabIndex = 6;
            this.Port_TxtBox3.Text = "Port";
            // 
            // BookmarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 505);
            this.Controls.Add(this.Port_TxtBox3);
            this.Controls.Add(this.IP_TxtBox2);
            this.Controls.Add(this.Name_TxtBox1);
            this.Controls.Add(this.Cancel_Btn3);
            this.Controls.Add(this.Add_Btn2);
            this.Controls.Add(this.Connect_Btn1);
            this.Controls.Add(this.listView1);
            this.Name = "BookmarksForm";
            this.Text = "Yapp! Bookmarks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button Connect_Btn1;
        private System.Windows.Forms.Button Add_Btn2;
        private System.Windows.Forms.Button Cancel_Btn3;
        private System.Windows.Forms.TextBox Name_TxtBox1;
        private System.Windows.Forms.TextBox IP_TxtBox2;
        private System.Windows.Forms.TextBox Port_TxtBox3;
    }
}