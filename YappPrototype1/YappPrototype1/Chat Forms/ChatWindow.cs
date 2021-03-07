using Org.BouncyCastle.Utilities.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
//using System.Net.Sockets.Shutdown;

namespace YappPrototype1.Chat_Forms
{
    public partial class ChatWindow : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default;
        string readData = null;
        System.Net.IPAddress IP;
        Int32 portNum;
        string username;
        string email;

        public ChatWindow(string username, string email)
        {
            InitializeComponent();
            this.username = username;
            this.email = email;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

//------------------------------------------------------------------------

        private void ConnectWindow()
        {
            ConnectForm connect = new ConnectForm();
            connect.ShowDialog();

            if (connect.connectedFlag)
            {
                IP = connect.IP;
                portNum = connect.port;
                clientSocket = connect.clientSocket;


                readData = $"Connected to server {IP}:{portNum}";
                ServerMsg();

                serverStream = clientSocket.GetStream();

                byte[] outStream = Encoding.ASCII.GetBytes(username + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();

                Thread ctThread = new Thread(GetMsg);
                ctThread.Start();
            }
            else
            {
                readData = $"Failed to connect...";
                ServerMsg();
                readData = null;
            }
        }

        private void GetMsg()
        {
            while (true)
            {
                try
                {
                    serverStream = clientSocket.GetStream();
                    int buffSize = clientSocket.ReceiveBufferSize;
                    byte[] inStream = new byte[buffSize];
                    serverStream.Read(inStream, 0, buffSize);

                    string returnData = Encoding.ASCII.GetString(inStream);
                    readData = "" + returnData;
                    ServerMsg();
                }
                catch (IOException)
                {
                    break;
                }
            }
        }

        private void ServerMsg()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(ServerMsg));
            }
            else
            {
                string time = GetTime();
                Chat_TextBox1.AppendText($"{Environment.NewLine}[{time}] {readData}");
                Chat_TextBox1.ScrollToCaret();
            }
        }

        private string GetTime()
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            return time;
        }

        private void Disconnect()
        {
            clientSocket.Client.Disconnect(true);
            clientSocket.Close();

            readData = $"Disconnected from server...";
            ServerMsg();
        }

//------------------------------------------------------------------------

        private void Chat_TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendMsg_Btn1_Click(object sender, EventArgs e)
        {
            if (!Msg_TextBox2.Text.Equals(""))
            {
                try
                {
                    serverStream = clientSocket.GetStream();
                    byte[] outStream = Encoding.ASCII.GetBytes(Msg_TextBox2.Text + "$");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();

                    Msg_TextBox2.Clear();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Cannot send message...", "Yapp! Error");
                    Msg_TextBox2.Clear();
                }
            }
        }

        private void C_ConnectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConnectWindow();
        }

        private void C_DisconnectToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void BmarkToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BookmarksForm bookmarksForm = new BookmarksForm();
            bookmarksForm.Show();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Show tools");
        }

        private void C_QuitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Disconnect();
            Close();
        }

        private void SendMsg_Btn1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMsg_Btn1_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }

        private void T_AccDetailsMenuItem1_Click(object sender, EventArgs e)
        {
            AccDetails acc = new AccDetails(username, email);
            acc.Show();
        }

        private void T_OutCLogMenuItem1_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Would you like to log the chat in a text file?", "Yapp!", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "chatLog.txt";
                var sr = new StreamWriter(path);
                sr.Write(Chat_TextBox1.Text);
                sr.Close();
            }
        }
    }
}
