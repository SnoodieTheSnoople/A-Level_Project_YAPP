using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace YappPrototype1.Chat_Forms
{
    public partial class BookmarksForm : Form
    {
        BookmarkList bl = new BookmarkList();
        List<string> info;

        public BookmarksForm()
        {
            InitializeComponent();
            ShowList();
        }

        private void ShowList()
        {
            info = bl.ReadFile();

            if (info.Count != 0)
            {
                var x = 1;

                for (int i = 0; i < info.Count; i++)
                {
                    if (x % 3 == 0)
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { info[x - 3], info[x - 2], info[x - 1] }));
                    }
                    x++;
                }
            }
            else
            {
                listView1.Items.Add(new ListViewItem(new string[] { "Nothing here..." }));
            }
            
        }

        private void Cancel_Btn3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Btn2_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress IP = IPAddress.Parse(IP_TxtBox2.Text);
                Int32 port = Int32.Parse(Port_TxtBox3.Text);
                bl.WriteFile(Name_TxtBox1.Text, IP, port);
                ShowList();
                listView1.Refresh();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid IP address/port number...", "Yapp! Error");
            }
            
        }

        private void Connect_Btn1_Click(object sender, EventArgs e)
        {
            //TO DO
        }
    }
}
