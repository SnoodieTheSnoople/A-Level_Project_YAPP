using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_LoginForm_PROTOTYPE
{
    public partial class Form1 : Form
    {
        DbConn db = new DbConn(); 


        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Btn2_Click(object sender, EventArgs e)
        {
            if (EmailCheck() && UsernameCheck() && PasswordCheck())
            {
                if (db.Select(emailTxtBox3.Text, uNameTxtBx1.Text, PwordTxtBx2.Text))
                {
                    MessageBox.Show("Success", "Yapp!");
                    //Close this window and then open the chat app.
                }
            }
            
        }

        //Checks if the email textbox is filled.
        private bool EmailCheck()
        {
            if (emailTxtBox3.Text == "")
            {
                MessageBox.Show("Please enter your email/username.", "Yapp! Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Checks if the username textbox is filled.
        private bool UsernameCheck()
        {
            if (uNameTxtBx1.Text == "")
            {
                MessageBox.Show("Please enter your username.", "Yapp! Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Checks if the password textbox is filled.
        private bool PasswordCheck()
        {
            if (PwordTxtBx2.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Yapp! Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CreateAcc_Btn3_Click(object sender, EventArgs e)
        {
            var createAccWindow = new CreateAccForm();
            createAccWindow.Show();
        }

        private void Quit_Btn1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
