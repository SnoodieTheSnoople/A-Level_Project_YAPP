using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YappPrototype1.Login_Forms.Forgot_Password
{
    public partial class ForgotPassword : Form
    {
        DbCommands db = new DbCommands();
        string email;

        public ForgotPassword(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void CancelBtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitBtn2_Click(object sender, EventArgs e)
        {
            if (PwordMatch())
            {
                if (db.UpdatePassword(email, Cnpword_TxtBox2.Text))
                {
                    Close();
                }
            }
        }

        private bool PwordMatch()
        {
            if (Cnpword_TxtBox2.Text.Equals(Npword_TxtBox1.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Passwords do not match.", "Yapp! Error");
                return false;
            }
        }
    }
}
