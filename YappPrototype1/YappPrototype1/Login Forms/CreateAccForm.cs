using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YappPrototype1
{
    public partial class CreateAccForm : Form
    {

        DbCommands db = new DbCommands();

        public CreateAccForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateAccBtn2_Click(object sender, EventArgs e)
        {
            if (!EmailEmpty() && !UnameEmpty() && !PwordEmpty() && PwordMatch())
            {
                if (db.Insert(Email_TxtBox1.Text, Uname_TxtBox2.Text, ConfirmPword_TxtBox4.Text))
                {
                    Close();
                }
            }
        }

        private bool EmailEmpty()
        {
            if (Email_TxtBox1.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool UnameEmpty()
        {
            if (Uname_TxtBox2.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PwordEmpty()
        {
            if (Pword_TxtBox3.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PwordMatch()
        {
            if (ConfirmPword_TxtBox4.Text == Pword_TxtBox3.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
