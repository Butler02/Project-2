﻿namespace Project2_Shopping
{
    partial class Form1
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
            this.gbDeals = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dtpExpireDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddDeal = new System.Windows.Forms.Button();
            this.txtProductToAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtAddUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchDeal = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.grpLikeDislike = new System.Windows.Forms.GroupBox();
            this.radDislikeDeal = new System.Windows.Forms.RadioButton();
            this.radLikeDeal = new System.Windows.Forms.RadioButton();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lstDeals = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDeals.SuspendLayout();
            this.gbLogin.SuspendLayout();
            this.gbRegister.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.grpLikeDislike.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDeals
            // 
            this.gbDeals.Controls.Add(this.txtPrice);
            this.gbDeals.Controls.Add(this.dtpExpireDate);
            this.gbDeals.Controls.Add(this.btnAddDeal);
            this.gbDeals.Controls.Add(this.txtProductToAdd);
            this.gbDeals.Controls.Add(this.label4);
            this.gbDeals.Controls.Add(this.label5);
            this.gbDeals.Controls.Add(this.label6);
            this.gbDeals.Location = new System.Drawing.Point(228, 12);
            this.gbDeals.Name = "gbDeals";
            this.gbDeals.Size = new System.Drawing.Size(230, 226);
            this.gbDeals.TabIndex = 2;
            this.gbDeals.TabStop = false;
            this.gbDeals.Text = "Deals";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(19, 103);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // dtpExpireDate
            // 
            this.dtpExpireDate.CustomFormat = "MM/dd/yyyy";
            this.dtpExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpireDate.Location = new System.Drawing.Point(9, 182);
            this.dtpExpireDate.Name = "dtpExpireDate";
            this.dtpExpireDate.Size = new System.Drawing.Size(110, 22);
            this.dtpExpireDate.TabIndex = 8;
            this.dtpExpireDate.Value = new System.DateTime(2016, 10, 13, 0, 0, 0, 0);
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.Location = new System.Drawing.Point(152, 114);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(75, 23);
            this.btnAddDeal.TabIndex = 7;
            this.btnAddDeal.Text = "Add Deal";
            this.btnAddDeal.UseVisualStyleBackColor = true;
            this.btnAddDeal.Click += new System.EventHandler(this.btnAddDeal_Click);
            // 
            // txtProductToAdd
            // 
            this.txtProductToAdd.Location = new System.Drawing.Point(21, 43);
            this.txtProductToAdd.Name = "txtProductToAdd";
            this.txtProductToAdd.Size = new System.Drawing.Size(100, 22);
            this.txtProductToAdd.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expires:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Product to Add:";
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.btnLogout);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.txtLogin);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Location = new System.Drawing.Point(12, 138);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(210, 100);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.Location = new System.Drawing.Point(127, 58);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(125, 22);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(21, 58);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 22);
            this.txtLogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Username:";
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.btnAddUser);
            this.gbRegister.Controls.Add(this.txtAddUsername);
            this.gbRegister.Controls.Add(this.label1);
            this.gbRegister.Location = new System.Drawing.Point(12, 12);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(210, 100);
            this.gbRegister.TabIndex = 0;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(125, 43);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtAddUsername
            // 
            this.txtAddUsername.Location = new System.Drawing.Point(21, 43);
            this.txtAddUsername.Name = "txtAddUsername";
            this.txtAddUsername.Size = new System.Drawing.Size(100, 22);
            this.txtAddUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username to Add:";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnSearchDeal);
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Location = new System.Drawing.Point(717, 241);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(200, 100);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            // 
            // btnSearchDeal
            // 
            this.btnSearchDeal.Location = new System.Drawing.Point(112, 43);
            this.btnSearchDeal.Name = "btnSearchDeal";
            this.btnSearchDeal.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDeal.TabIndex = 9;
            this.btnSearchDeal.Text = "Search Deal";
            this.btnSearchDeal.UseVisualStyleBackColor = true;
            this.btnSearchDeal.Click += new System.EventHandler(this.btnSearchDeal_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(6, 43);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 22);
            this.tbSearch.TabIndex = 5;
            // 
            // grpLikeDislike
            // 
            this.grpLikeDislike.Controls.Add(this.radDislikeDeal);
            this.grpLikeDislike.Controls.Add(this.radLikeDeal);
            this.grpLikeDislike.Controls.Add(this.btnChoose);
            this.grpLikeDislike.Enabled = false;
            this.grpLikeDislike.Location = new System.Drawing.Point(478, 241);
            this.grpLikeDislike.Name = "grpLikeDislike";
            this.grpLikeDislike.Size = new System.Drawing.Size(226, 100);
            this.grpLikeDislike.TabIndex = 1;
            this.grpLikeDislike.TabStop = false;
            // 
            // radDislikeDeal
            // 
            this.radDislikeDeal.AutoSize = true;
            this.radDislikeDeal.Location = new System.Drawing.Point(115, 21);
            this.radDislikeDeal.Name = "radDislikeDeal";
            this.radDislikeDeal.Size = new System.Drawing.Size(103, 21);
            this.radDislikeDeal.TabIndex = 10;
            this.radDislikeDeal.Text = "Dislike Deal";
            this.radDislikeDeal.UseVisualStyleBackColor = true;
            // 
            // radLikeDeal
            // 
            this.radLikeDeal.AutoSize = true;
            this.radLikeDeal.Checked = true;
            this.radLikeDeal.Location = new System.Drawing.Point(21, 21);
            this.radLikeDeal.Name = "radLikeDeal";
            this.radLikeDeal.Size = new System.Drawing.Size(88, 21);
            this.radLikeDeal.TabIndex = 9;
            this.radLikeDeal.TabStop = true;
            this.radLikeDeal.Text = "Like Deal";
            this.radLikeDeal.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(77, 61);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 8;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lstDeals
            // 
            this.lstDeals.FormattingEnabled = true;
            this.lstDeals.ItemHeight = 16;
            this.lstDeals.Location = new System.Drawing.Point(464, 15);
            this.lstDeals.Name = "lstDeals";
            this.lstDeals.Size = new System.Drawing.Size(453, 212);
            this.lstDeals.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(205, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 365);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblstatus
            // 
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 387);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDeals);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.grpLikeDislike);
            this.Controls.Add(this.gbDeals);
            this.Name = "Form1";
            this.Text = "Shopping Deals";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDeals.ResumeLayout(false);
            this.gbDeals.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.grpLikeDislike.ResumeLayout(false);
            this.grpLikeDislike.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDeals;
        private System.Windows.Forms.DateTimePicker dtpExpireDate;
        private System.Windows.Forms.Button btnAddDeal;
        private System.Windows.Forms.TextBox txtProductToAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtAddUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearchDeal;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox grpLikeDislike;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ListBox lstDeals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radDislikeDeal;
        private System.Windows.Forms.RadioButton radLikeDeal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

