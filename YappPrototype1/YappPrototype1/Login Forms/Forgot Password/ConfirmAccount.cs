using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using YappPrototype1.Login_Forms.Forgot_Password;

namespace YappPrototype1
{
    public partial class ConfirmAccount : Form
    {
        DbCommands db = new DbCommands();

        public ConfirmAccount()
        {
            InitializeComponent();
        }

        private void CancelBtn1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitBtn2_Click(object sender, EventArgs e)
        {
            if (db.ConfirmDetails(Email_TxtBox1.Text, Uname_TxtBox2.Text))
            {
                var forgotPwordForm = new ForgotPassword(Email_TxtBox1.Text);
                forgotPwordForm.Show();
                Close();
            }

        }

        //NOT FINAL - TEMPORARY


    }
}
