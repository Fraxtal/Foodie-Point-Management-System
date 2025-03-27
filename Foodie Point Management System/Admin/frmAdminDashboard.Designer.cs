namespace Foodie_Point_Management_System.Admin
{
    partial class frmAdminDashboard
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
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.linklblUserManagement = new System.Windows.Forms.LinkLabel();
            this.linklblSalesReport = new System.Windows.Forms.LinkLabel();
            this.linklblViewFeeback = new System.Windows.Forms.LinkLabel();
            this.linklblAdminProfile = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(455, 64);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(302, 179);
            this.btnUserManagement.TabIndex = 0;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(285, 278);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(302, 179);
            this.btnSalesReport.TabIndex = 1;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(625, 278);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(302, 179);
            this.btnFeedback.TabIndex = 2;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // linklblUserManagement
            // 
            this.linklblUserManagement.AutoSize = true;
            this.linklblUserManagement.Location = new System.Drawing.Point(63, 118);
            this.linklblUserManagement.Name = "linklblUserManagement";
            this.linklblUserManagement.Size = new System.Drawing.Size(141, 20);
            this.linklblUserManagement.TabIndex = 3;
            this.linklblUserManagement.TabStop = true;
            this.linklblUserManagement.Text = "User Management";
            this.linklblUserManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblUserManagement_LinkClicked);
            // 
            // linklblSalesReport
            // 
            this.linklblSalesReport.AutoSize = true;
            this.linklblSalesReport.Location = new System.Drawing.Point(64, 193);
            this.linklblSalesReport.Name = "linklblSalesReport";
            this.linklblSalesReport.Size = new System.Drawing.Size(102, 20);
            this.linklblSalesReport.TabIndex = 4;
            this.linklblSalesReport.TabStop = true;
            this.linklblSalesReport.Text = "Sales Report";
            this.linklblSalesReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSalesReport_LinkClicked);
            // 
            // linklblViewFeeback
            // 
            this.linklblViewFeeback.AutoSize = true;
            this.linklblViewFeeback.Location = new System.Drawing.Point(64, 266);
            this.linklblViewFeeback.Name = "linklblViewFeeback";
            this.linklblViewFeeback.Size = new System.Drawing.Size(80, 20);
            this.linklblViewFeeback.TabIndex = 5;
            this.linklblViewFeeback.TabStop = true;
            this.linklblViewFeeback.Text = "Feedback";
            this.linklblViewFeeback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblViewFeeback_LinkClicked);
            // 
            // linklblAdminProfile
            // 
            this.linklblAdminProfile.AutoSize = true;
            this.linklblAdminProfile.Location = new System.Drawing.Point(64, 342);
            this.linklblAdminProfile.Name = "linklblAdminProfile";
            this.linklblAdminProfile.Size = new System.Drawing.Size(102, 20);
            this.linklblAdminProfile.TabIndex = 6;
            this.linklblAdminProfile.TabStop = true;
            this.linklblAdminProfile.Text = "Admin Profile";
            this.linklblAdminProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblAdminProfile_LinkClicked);
            // 
            // frmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 582);
            this.Controls.Add(this.linklblAdminProfile);
            this.Controls.Add(this.linklblViewFeeback);
            this.Controls.Add(this.linklblSalesReport);
            this.Controls.Add(this.linklblUserManagement);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnUserManagement);
            this.Name = "frmAdminDashboard";
            this.Text = "frmAdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.LinkLabel linklblUserManagement;
        private System.Windows.Forms.LinkLabel linklblSalesReport;
        private System.Windows.Forms.LinkLabel linklblViewFeeback;
        private System.Windows.Forms.LinkLabel linklblAdminProfile;
    }
}