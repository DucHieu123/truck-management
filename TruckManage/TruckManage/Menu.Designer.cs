namespace TruckManage
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDdr = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDriverData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rdBlock = new System.Windows.Forms.RadioButton();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAccountDriver = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDdr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvDriverData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtIDCard);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtFullname);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Infomation Manage";
            // 
            // lblIDdr
            // 
            this.lblIDdr.AutoSize = true;
            this.lblIDdr.Location = new System.Drawing.Point(247, 102);
            this.lblIDdr.Name = "lblIDdr";
            this.lblIDdr.Size = new System.Drawing.Size(28, 13);
            this.lblIDdr.TabIndex = 7;
            this.lblIDdr.Text = "ldlID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(363, 127);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(138, 127);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            // 
            // dgvDriverData
            // 
            this.dgvDriverData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDriverData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriverData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FULLNAME,
            this.IDCARD,
            this.ADDRESS,
            this.PHONE});
            this.dgvDriverData.Location = new System.Drawing.Point(6, 212);
            this.dgvDriverData.MultiSelect = false;
            this.dgvDriverData.Name = "dgvDriverData";
            this.dgvDriverData.ReadOnly = true;
            this.dgvDriverData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriverData.ShowCellToolTips = false;
            this.dgvDriverData.Size = new System.Drawing.Size(577, 150);
            this.dgvDriverData.TabIndex = 2;
            this.dgvDriverData.SelectionChanged += new System.EventHandler(this.dgvDriverData_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FULLNAME
            // 
            this.FULLNAME.DataPropertyName = "NAME";
            this.FULLNAME.HeaderText = "Full name";
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.ReadOnly = true;
            // 
            // IDCARD
            // 
            this.IDCARD.DataPropertyName = "IDCARD";
            this.IDCARD.HeaderText = "ID Card";
            this.IDCARD.Name = "IDCARD";
            this.IDCARD.ReadOnly = true;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "Address";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "Phone";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID card:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(379, 64);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(118, 20);
            this.txtPhone.TabIndex = 0;
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(379, 39);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(118, 20);
            this.txtIDCard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(138, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(118, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(138, 39);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(118, 20);
            this.txtFullname.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 390);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Driver Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Driver Account";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.rdBlock);
            this.groupBox2.Controls.Add(this.rdActive);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvAccountDriver);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 352);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driver Account Manage";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(244, 136);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rdBlock
            // 
            this.rdBlock.AutoSize = true;
            this.rdBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdBlock.ForeColor = System.Drawing.Color.Red;
            this.rdBlock.Location = new System.Drawing.Point(378, 96);
            this.rdBlock.Name = "rdBlock";
            this.rdBlock.Size = new System.Drawing.Size(72, 17);
            this.rdBlock.TabIndex = 3;
            this.rdBlock.Text = "Block(2)";
            this.rdBlock.UseVisualStyleBackColor = true;
            this.rdBlock.Click += new System.EventHandler(this.rdBlock_Click);
            // 
            // rdActive
            // 
            this.rdActive.AutoSize = true;
            this.rdActive.Checked = true;
            this.rdActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdActive.ForeColor = System.Drawing.Color.Lime;
            this.rdActive.Location = new System.Drawing.Point(108, 96);
            this.rdActive.Name = "rdActive";
            this.rdActive.Size = new System.Drawing.Size(76, 17);
            this.rdActive.TabIndex = 3;
            this.rdActive.TabStop = true;
            this.rdActive.Text = "Active(1)";
            this.rdActive.UseVisualStyleBackColor = true;
            this.rdActive.Click += new System.EventHandler(this.rdActive_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(222, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "lblID";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(338, 36);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "lblUsername";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID Account:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username:";
            // 
            // dgvAccountDriver
            // 
            this.dgvAccountDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountDriver.Location = new System.Drawing.Point(6, 176);
            this.dgvAccountDriver.MultiSelect = false;
            this.dgvAccountDriver.Name = "dgvAccountDriver";
            this.dgvAccountDriver.ReadOnly = true;
            this.dgvAccountDriver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountDriver.Size = new System.Drawing.Size(572, 170);
            this.dgvAccountDriver.TabIndex = 0;
            this.dgvAccountDriver.SelectionChanged += new System.EventHandler(this.dgvAccountDriver_SelectionChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 403);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBlock;
        private System.Windows.Forms.RadioButton rdActive;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvDriverData;
        private System.Windows.Forms.DataGridView dgvAccountDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.Label lblIDdr;
        private System.Windows.Forms.Label label6;
    }
}