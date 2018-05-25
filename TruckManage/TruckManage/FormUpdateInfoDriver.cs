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
    public partial class FormUpdateInfoDriver : Form
    {
        int id;
        public FormUpdateInfoDriver()
        {
            InitializeComponent();
        }
        public FormUpdateInfoDriver(int idDriver)
        {
            InitializeComponent();
            id = idDriver;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //when click update button
            //check empty textbox
            if (String.IsNullOrEmpty(txtFullname.Text) || String.IsNullOrEmpty(txtIDCard.Text)
                || String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please input");
            }
            else
            {
                //update
                if (TM.UpdateInfoDriver(id, txtFullname.Text.ToString().Trim(), txtIDCard.Text.ToString().Trim(), txtAddress.Text.ToString().Trim(), txtPhone.Text.ToString().Trim()))
                {
                    MessageBox.Show("Update successed!");
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }
            }
        }

        private void FormUpdateInfoDriver_Load(object sender, EventArgs e)
        {
            //when form load
            //load info of driver
            var ls = TM.GetListOfDriver();
            var rs = ls.Where(s => s.ID == id).SingleOrDefault();
            if (rs != null)
            {
                txtFullname.Text = rs.NAME;
                txtIDCard.Text = rs.IDCARD;
                txtAddress.Text = rs.ADDRESS;
                txtPhone.Text = rs.PHONE;
            }
            else 
            {
                btnUpdate.Enabled = false;
            }
        }

    }
}
