using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatWindow
{
    public partial class Form2 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default;
        string readData = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //CONNECT BUTTON
        {
            readData = "Connected to chat server...";
            Msg();
            //192.168.1.66:2693
            //127.0.0.1:8888
            IPAddress IP = IPAddress.Parse("192.168.1.66");
            Int32 port = Int32.Parse("2693");
            clientSocket.Connect(IP, port);
            serverStream = clientSocket.GetStream();

            byte[] outStream = Encoding.ASCII.GetBytes(textBox1.Text + "$"); //SENDING USERNAME
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(GetMessage);
            ctThread.Start();
        }

        private void GetMessage(object obj)
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = clientSocket.ReceiveBufferSize;
                byte[] inStream = new byte[buffSize];
                serverStream.Read(inStream, 0, buffSize);
                string returnData = Encoding.ASCII.GetString(inStream);
                readData = "" + returnData;
                Msg();
            }
        }

        private void Msg()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(Msg));
            }
            else
            {
                textBox3.Text = textBox3.Text + Environment.NewLine + " >> " + readData;
            }
        }

        private void button2_Click(object sender, EventArgs e) //SEND BUTTON
        {
            byte[] outStream = Encoding.ASCII.GetBytes(textBox2.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
    }
}
