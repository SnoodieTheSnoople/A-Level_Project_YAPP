using Org.BouncyCastle.Utilities.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace YappPrototype1.Chat_Forms
{
    class BookmarkList
    {
        string name;
        System.Net.IPAddress IP;
        Int32 port;

        public bool NoFile { get; private set; }
        
        public void WriteFile(string name, System.Net.IPAddress IP, Int32 portnum)
        {
            this.name = name;
            this.IP = IP;
            this.port = portnum;
            try
            {
                var sw = new StreamWriter("bookmarks.txt", true, Encoding.UTF8);
                sw.WriteLine($"{this.name}, {this.IP}, {this.port}");
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Yapp! Error");
            }
        }

        //Return list and parse System.Net.IPAddress AND Int32
        public List<string> ReadFile()
        {
            List<string> info = new List<string>();
            if (File.Exists("bookmarks.txt"))
            {
                NoFile = false;
                try
                {
                    var sr = new StreamReader("bookmarks.txt");

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(",");

                        foreach (string s in words)
                        {
                            info.Add(s);
                        }
                    }
                    return info;
                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message, "Yapp! Error");
                }
                return info;
            }
            else
            {
                NoFile = true;
                return info;
            }
        }
    }
}
