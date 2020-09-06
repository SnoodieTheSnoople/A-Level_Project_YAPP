using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YappPrototype1.Login_Forms.Forgot_Password;

namespace YappPrototype1.Chat_Forms
{
    public partial class AccDetails : Form
    {
        string uname;
        string email;
        DbCommands db = new DbCommands();

        public AccDetails(string username, string email)
        {
            InitializeComponent();
            uname = username;
            this.email = email;
            label3.Text = $"After deleting your account the application will close and if you\nwish to use the application again, you must create a new account.";

            EmailDisplay_TxtBox1.Text = this.email;
            UnameDisplay_TxtBox2.Text = uname;

            DeleteAcc_Btn2.Enabled = false;
        }

        private void ChangePword_Btn1_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword(email);
            forgotPassword.Show();
        }

        private void DeleteAcc_chkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteAcc_chkBox1.Checked)
            {
                DeleteAcc_Btn2.Enabled = true;
            }
            else
            {
                DeleteAcc_Btn2.Enabled = false;
            }
        }

        private void DeleteAcc_Btn2_Click(object sender, EventArgs e)
        {
            if (db.DeleteAcc(this.email, this.uname))
            {
                MessageBox.Show("Success!", "Yapp!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Failed to delete account...", "Yapp! Error");
            }
        }

        private void Close_Btn3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
