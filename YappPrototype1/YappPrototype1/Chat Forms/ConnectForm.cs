using Org.BouncyCastle.Utilities.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace YappPrototype1.Chat_Forms
{
    public partial class ConnectForm : Form
    {
        public TcpClient clientSocket = new TcpClient();

        public System.Net.IPAddress IP { get; private set; }
        public Int32 port { get; private set; }
        public bool connectedFlag { get; private set; }

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void Cancel_Btn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Connect_Btn2_Click(object sender, EventArgs e)
        {
            try
            {
                IP = System.Net.IPAddress.Parse(IP_TxtBox1.Text);
                port = Int32.Parse(PortNo_TxtBox2.Text);
                clientSocket.Connect(IP, port);
                connectedFlag = true;
                Close();
            }
            catch (SocketException)
            {
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid IP address/port number.", "Yapp! Error");
            }
        }
    }
}
