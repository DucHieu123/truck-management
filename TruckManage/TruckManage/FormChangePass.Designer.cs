﻿namespace TruckManage
{
    partial class FormChangePass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPassRepeat = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repeat:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(141, 14);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(244, 20);
            this.txtPass.TabIndex = 0;
            // 
            // txtPassRepeat
            // 
            this.txtPassRepeat.Location = new System.Drawing.Point(141, 47);
            this.txtPassRepeat.Name = "txtPassRepeat";
            this.txtPassRepeat.Size = new System.Drawing.Size(244, 20);
            this.txtPassRepeat.TabIndex = 1;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(158, 87);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(117, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 122);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtPassRepeat);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormChangePass";
            this.Text = "Change password";
            this.Load += new System.EventHandler(this.FormChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtPassRepeat;
        private System.Windows.Forms.Button btnChange;
    }
}