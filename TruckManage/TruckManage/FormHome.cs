using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TruckManage
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Check textbox Empty
            if (string.IsNullOrEmpty(txtUser.Text) | string.IsNullOrEmpty(txtPassword.Text))
            {
                //if empty, show error
                MessageBox.Show("Don't empty username or password.");
            }
            else 
            {
                //if not empty
                //check valid account
                var acc = TM.GetListOfAccount();
                var rs = acc.Where(s => (s.USERNAME.Trim() == txtUser.Text) & (s.PASSWORD.Trim() == MD5.CreateMD5(txtPassword.Text))).SingleOrDefault();
                if (rs != null)
                {
                    //1: is Admin, 2: is Driver
                    if (rs.TYPEID == 1)
                    {
                        //1: status actived, 2: blocked
                        if (rs.STATUS == 1)
                        {
                            //Show notification
                            MessageBox.Show("Sign in success as Admin");
                            //call form admin manage
                            Menu fmn = new Menu((int)rs.ID);
                            fmn.StartPosition = FormStartPosition.CenterScreen;
                            fmn.FormClosed += new FormClosedEventHandler(fmn_FormClosed);
                            Hide();
                            fmn.ShowDialog();
                        }
                        else 
                        {
                            MessageBox.Show("Account is blocked");
                        }
                    }
                    else if(rs.TYPEID == 2)
                    {
                        //1: status actived, 2: blocked
                        if (rs.STATUS == 1)
                        {
                            //Show notification
                            MessageBox.Show("Sign in success as Driver");
                            //call form admin manage
                            FormDriver fd = new FormDriver((int)rs.ID);
                            fd.StartPosition = FormStartPosition.CenterScreen;
                            fd.FormClosed += new FormClosedEventHandler(fd_FormClosed);
                            Hide();
                            fd.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Account is blocked");
                        }
                    }

                }
                else
                {
                    //Show Exception
                    MessageBox.Show("Username or Password is incorrect!");
                }
            }
        }

        void fd_FormClosed(object sender, EventArgs e)
        {
            Show();
        }

        void fmn_FormClosed(object sender, EventArgs e)
        {
           Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //when click signup
            //call form signup
            FormSignup fsu = new FormSignup();
            fsu.StartPosition = FormStartPosition.CenterScreen;
            fsu.ShowDialog();
        }
    }
}
