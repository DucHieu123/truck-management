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
    public partial class FormDriver : Form
    {
        int id;
        public FormDriver()
        {
            InitializeComponent();
        }
        public FormDriver(int idDriver)
        {
            InitializeComponent();
            id = idDriver;
        }

        private void FormDriver_Load(object sender, EventArgs e)
        {
            //load info of Driver signed in
            var ls = TM.GetListOfDriver();
            var rs = ls.Where(s => s.ID == id).SingleOrDefault();
            if (rs != null)
            {
                lblFullname.Text = rs.NAME;
                lblIDCard.Text = rs.IDCARD;
                lblAddress.Text = rs.ADDRESS;
                lblPhone.Text = rs.PHONE;
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            //when click update button
            //call form update
            FormUpdateInfoDriver fu = new FormUpdateInfoDriver(id);
            fu.StartPosition = FormStartPosition.CenterScreen;
            fu.ShowDialog();
            OnLoad(e);
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            //when click change pass
            //call form change pass
            FormChangePass fcp = new FormChangePass(id);
            fcp.StartPosition = FormStartPosition.CenterScreen;
            fcp.ShowDialog();
        }
    }
}
