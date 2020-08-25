using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySQL_LoginForm_PROTOTYPE
{
    public partial class CreateAccForm : Form
    {
        DbConn db = new DbConn();

        public CreateAccForm()
        {
            InitializeComponent();
        }

        //False if empty
        private bool CheckEmail()
        {
            if (EmailTxtBox1.Text == "")
            {
                MessageBox.Show("Email field empty.", "Yapp! Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        //False if empty
        private bool CheckUname()
        {
            if (UnameTxtBox2.Text == "")
            {
                MessageBox.Show("Username field empty.", "Yapp! Error");
                return false;
            }
            else
            {
                return true;
            }
        }
        
        //False if empty
        private bool CheckPwords()
        {
            if (PwordTxtBox3.Text == "")
            {
                MessageBox.Show("Password field empty.", "Yapp! Error");
                return false;
            }
            else
            {
                SamePword();
                return true;
            }
        }

        private bool SamePword()
        {
            if (PwordTxtBox3.Text == ConfirmpwordTxtBox4.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Passwords not the same.", "Yapp! Error");
                return false;
            }
        }

        private void CreateAccBtn2_Click(object sender, EventArgs e)
        {
            if (CheckEmail() && CheckUname() && CheckPwords() && SamePword())
            {
                if (db.Insert(EmailTxtBox1.Text, UnameTxtBox2.Text, PwordTxtBox3.Text))
                {
                    MessageBox.Show("Successfully created!", "Yapp!");
                    Close();
                }
            }
        }

        private void CancelBtn1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
