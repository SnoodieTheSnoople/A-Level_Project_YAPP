using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ChatWindow
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default;
        string readData = null;
        IPAddress IP;
        Int32 portNum;
        string uName;

        /*
         * MACBOOK AIR IP = 192.168.1.66
         * CONNECT TO 192.168.1.66:2693
         * 
         * TO DO:-
         * - Grey out the connect boxes when already connected to a server
         * - After disconnecting, allow the user to connect to another/the same server
         * 
         * KNOWN ISSUES:-
         * - Clicking the disconnect button multiple times causes the program to crash
         * - Cannot disconnect and connect to another/same server
         * - Once disconnecting, the server echoes the last transmission
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void GetUsername()
        {
            uName = EnterUNameBox.Text;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetUsername();
                IP = IPAddress.Parse(EnterIPBox.Text);
                portNum = Int32.Parse(EnterPortBox.Text);
                readData = $"Connected to Chat Server:\nIP: {IP}\nPort: {portNum}";
                ServerMsg();
                clientSocket.Connect(IP, portNum);
                serverStream = clientSocket.GetStream();

                //This outStream sends username to the server
                byte[] outStream = Encoding.ASCII.GetBytes(uName + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                //Clears the serverStream

                Thread ctThread = new Thread(GetMessage);
                ctThread.Start();
            }
            catch (SocketException)
            {
                readData = $"Connection to server failure...\nCould not connect to server {IP}:{portNum}";
                ServerMsg();
            }
            
        }

        /*
         * getMessage receives and reads the message from the server
         */
        private void GetMessage()
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
                catch(System.IO.IOException)
                {
                    break;
                }
            }
        }

        private void ServerMsg()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(ServerMsg));
            }
            else
            {
                string time = GetTime();
                //Chat creates new line -> [TIME] name: MESSAGE
                ChatDisplayBox.AppendText($"{Environment.NewLine}[{time}] {readData}");
                ChatDisplayBox.ScrollToCaret();
            }
        }

        private void SendMsgButton_Click(object sender, EventArgs e)
        {
            if (!SendMsgBox.Text.Equals(""))
            {
                try
                {
                    serverStream = clientSocket.GetStream();
                    byte[] outStream = Encoding.ASCII.GetBytes(SendMsgBox.Text + "$");
                    serverStream.Write(outStream, 0, outStream.Length);
                    serverStream.Flush();

                    SendMsgBox.Clear();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Cannot send message.", "Yapp!");
                    SendMsgBox.Clear();
                }
            }
        }

        private string GetTime()
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            return time;
        }

        //WINDOW FUNCTIONS & EVENTS

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you would like to exit?", "Exit", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                clientSocket.Close();
                Application.ExitThread();
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        //CLOSES CONNECTION
        private void DisconnectServerBtn_Click(object sender, EventArgs e)
        {
            serverStream.Close();
            clientSocket.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void SendMsgButton_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        //ENTERS MESSAGE WHEN ENTER BUTTON PRESSED
        private void SendMsgBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMsgButton_Click(this, new EventArgs());
                //e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
