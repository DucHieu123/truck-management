using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TruckManage
{
    public partial class FormSignup : Form
    {
        public FormSignup()
        {
            InitializeComponent();
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //insert on Account.
            if (!TM.AddAccount(txtUsername.Text, MD5.CreateMD5(txtPassword.Text), 2, 1))
            {
                //if add faild, show notification
                MessageBox.Show("Failed");
            }
            else 
            {
                //get id of it
                var rs = TM.GetListOfAccount().OrderByDescending(s => s.ID).First();
                //insert on Driver.
                if (!TM.AddDriver((int)rs.ID, txtFullname.Text, txtIDCard.Text, txtAddress.Text, txtPhone.Text))
                {
                    //if add failed. show notification
                    MessageBox.Show("Add info failed, please sign in and update your profile");
                }
                else 
                {
                    //if 2 success, show notification
                    MessageBox.Show("Sign up successed");
                }
            }
        }
    }
}
