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
    public partial class FormChangePass : Form
    {
        int id;
        public FormChangePass()
        {
            InitializeComponent();
        }

        public FormChangePass(int idDriver)
        {
            InitializeComponent();
            id = idDriver;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //dont care
        }

        private void FormChangePass_Load(object sender, EventArgs e)
        {
            //dont care
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //when click change pass button
            //check empty textbox
            if (String.IsNullOrEmpty(txtPass.Text) || String.IsNullOrEmpty(txtPassRepeat.Text))
            {
                MessageBox.Show("Please don't let empty");
            }
            else 
            {
                //compare password and passrepeat
                if (String.Compare(txtPassRepeat.Text, txtPass.Text) != 0)
                {
                    MessageBox.Show("Password and Repeat-Password are not matched");
                }
                else
                {
                    //update
                    if(TM.UpdatePasswordAccount(id, MD5.CreateMD5(txtPass.Text.Trim())))
                    {
                        MessageBox.Show("Update successed");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Update failed! Please try again");
                    }
                }
            }
        }
    }
}
