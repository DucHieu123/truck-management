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
    public partial class Menu : Form
    {
        int id;
        public Menu()
        {
            InitializeComponent();
        }

        public Menu(int idAdmin)
        {
            InitializeComponent();
            id = idAdmin;
            //intialize data grid view of account driver
            DataGridViewTextBoxColumn tb1 = new DataGridViewTextBoxColumn();
            tb1.HeaderText = "Id";
            tb1.DataPropertyName = "ID";
            dgvAccountDriver.Columns.Add(tb1);
            DataGridViewTextBoxColumn tb2 = new DataGridViewTextBoxColumn();
            tb2.HeaderText = "Username";
            tb2.DataPropertyName = "USERNAME";
            dgvAccountDriver.Columns.Add(tb2);
            DataGridViewTextBoxColumn tb3 = new DataGridViewTextBoxColumn();
            tb3.HeaderText = "Status";
            tb3.DataPropertyName = "STATUS";
            dgvAccountDriver.Columns.Add(tb3);
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //load list driver
            var ls = TM.GetListOfDriver();
            dgvDriverData.DataSource = ls;

            //load list account driver
            var ls2 = TM.GetListOfAccount().Where(s=>s.TYPEID == 2).ToList();
            dgvAccountDriver.AutoGenerateColumns = false;
            dgvAccountDriver.DataSource = ls2;
            if (String.IsNullOrEmpty(txtFullname.Text))
            {
                btnDel.Enabled = btnUpdate.Enabled = false;
                btnSubmit.Enabled = false;
            }
        }

        private void dgvDriverData_SelectionChanged(object sender, EventArgs e)
        {
            //when click a row on grid driver
            int rowindex = dgvDriverData.CurrentRow.Index;
            lblIDdr.Text = dgvDriverData[0, rowindex].Value.ToString();
            txtFullname.Text = dgvDriverData[1, rowindex].Value.ToString().Trim();
            txtIDCard.Text = dgvDriverData[2, rowindex].Value.ToString().Trim();
            txtAddress.Text = dgvDriverData[3, rowindex].Value.ToString().Trim();
            txtPhone.Text = dgvDriverData[4, rowindex].Value.ToString().Trim() ;
        }

        private void dgvAccountDriver_SelectionChanged(object sender, EventArgs e)
        {
            //when click a row on grid account driver
            int rowindex = dgvAccountDriver.CurrentRow.Index;
            lblID.Text = dgvAccountDriver[0, rowindex].Value.ToString().Trim();
            lblUsername.Text = dgvAccountDriver[1, rowindex].Value.ToString().Trim();
            if ((int)dgvAccountDriver[2, rowindex].Value == 1)
            {
                rdActive.Checked = true;
                rdBlock.Checked = !rdActive.Checked;
            }
            else
            {
                rdBlock.Checked = true;
                rdActive.Checked = !rdBlock.Checked;
            }
        }

        private void rdActive_Click(object sender, EventArgs e)
        {
            rdActive.Checked = true;
            rdBlock.Checked = false;
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            //Delete Infomation
            //1. Delete info
            //2. delete account
            if (TM.DeleteDriver(int.Parse(lblIDdr.Text)))
            {
                //1.
                if (TM.DeleteAccount(int.Parse(lblIDdr.Text)))
                {
                    //2.
                    MessageBox.Show("Delete Successed!");
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
            }
            else
            {
                MessageBox.Show("Delete failed!");
            }
            //reload to update on form
            OnLoad(e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update information
            if (TM.UpdateInfoDriver(int.Parse(lblIDdr.Text), txtFullname.Text.ToString().Trim(), txtIDCard.Text.ToString().Trim(), txtAddress.Text.ToString().Trim(), txtPhone.Text.ToString().Trim()))
            {
                MessageBox.Show("Update successed!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
            
            Reload_Data();
        }

        private void rdBlock_Click(object sender, EventArgs e)
        {
            rdBlock.Checked = true;
            rdActive.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Update status account
            if (TM.UpdateStatusAccount(int.Parse(lblID.Text), rdActive.Checked == true ? 1 : 2))
            {
                MessageBox.Show("Update successed!");
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
            Reload_Data();
        }

        void Reload_Data() 
        {
            var ls = TM.GetListOfDriver();
            dgvDriverData.DataSource = ls;
            var ls2 = TM.GetListOfAccount().Where(s => s.TYPEID == 2).ToList();
            dgvAccountDriver.AutoGenerateColumns = false;
            dgvAccountDriver.DataSource = ls2;
        }

    }
}
