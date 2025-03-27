namespace Foodie_Point_Management_System.Admin
{
    partial class frmAdminUserManagement
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
            System.Windows.Forms.Label lblEmail;
            this.radiobtnCustomer = new System.Windows.Forms.RadioButton();
            this.radiobtnEmployee = new System.Windows.Forms.RadioButton();
            this.umdw = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.umdw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(42, 248);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(52, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // radiobtnCustomer
            // 
            this.radiobtnCustomer.AutoSize = true;
            this.radiobtnCustomer.Checked = true;
            this.radiobtnCustomer.Location = new System.Drawing.Point(340, 48);
            this.radiobtnCustomer.Name = "radiobtnCustomer";
            this.radiobtnCustomer.Size = new System.Drawing.Size(103, 24);
            this.radiobtnCustomer.TabIndex = 0;
            this.radiobtnCustomer.TabStop = true;
            this.radiobtnCustomer.Text = "Customer";
            this.radiobtnCustomer.UseVisualStyleBackColor = true;
            this.radiobtnCustomer.CheckedChanged += new System.EventHandler(this.radiobtnCustomer_CheckedChanged);
            // 
            // radiobtnEmployee
            // 
            this.radiobtnEmployee.AutoSize = true;
            this.radiobtnEmployee.Location = new System.Drawing.Point(474, 48);
            this.radiobtnEmployee.Name = "radiobtnEmployee";
            this.radiobtnEmployee.Size = new System.Drawing.Size(104, 24);
            this.radiobtnEmployee.TabIndex = 1;
            this.radiobtnEmployee.Text = "Employee";
            this.radiobtnEmployee.UseVisualStyleBackColor = true;
            this.radiobtnEmployee.CheckedChanged += new System.EventHandler(this.radiobtnEmployee_CheckedChanged);
            // 
            // umdw
            // 
            this.umdw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.umdw.Location = new System.Drawing.Point(304, 94);
            this.umdw.MultiSelect = false;
            this.umdw.Name = "umdw";
            this.umdw.RowHeadersWidth = 62;
            this.umdw.RowTemplate.Height = 28;
            this.umdw.Size = new System.Drawing.Size(638, 363);
            this.umdw.TabIndex = 2;
            this.umdw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.umdw_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(548, 485);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 51);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(770, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 248);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(126, 185);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(148, 26);
            this.txtFullname.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(126, 128);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(148, 26);
            this.txtUsername.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fullname:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 134);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username:";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Location = new System.Drawing.Point(124, 371);
            this.txtDateCreated.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(148, 26);
            this.txtDateCreated.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 312);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(148, 26);
            this.txtPassword.TabIndex = 16;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(48, 445);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 20);
            this.lblRole.TabIndex = 15;
            this.lblRole.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "DateCreated:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 312);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Chef",
            "Reservation Coordinator",
            "",
            "Manager",
            "Admin"});
            this.cbRole.Location = new System.Drawing.Point(124, 442);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(148, 28);
            this.cbRole.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(324, 485);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 51);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "User Id: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 72);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(148, 26);
            this.txtID.TabIndex = 22;
            // 
            // frmAdminUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 580);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.umdw);
            this.Controls.Add(this.radiobtnEmployee);
            this.Controls.Add(this.radiobtnCustomer);
            this.Name = "frmAdminUserManagement";
            this.Text = "frmAdminUserManagement";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.umdw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnCustomer;
        private System.Windows.Forms.RadioButton radiobtnEmployee;
        private System.Windows.Forms.DataGridView umdw;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
    }
}