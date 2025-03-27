namespace Foodie_Point_Management_System.Manager
{
    partial class ManagerDashboard
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
            this.llblmenu = new System.Windows.Forms.LinkLabel();
            this.llblhalls = new System.Windows.Forms.LinkLabel();
            this.llblreports = new System.Windows.Forms.LinkLabel();
            this.llblsettings = new System.Windows.Forms.LinkLabel();
            this.llbllogout = new System.Windows.Forms.LinkLabel();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHalls = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // llblmenu
            // 
            this.llblmenu.AutoSize = true;
            this.llblmenu.Location = new System.Drawing.Point(52, 163);
            this.llblmenu.Name = "llblmenu";
            this.llblmenu.Size = new System.Drawing.Size(40, 16);
            this.llblmenu.TabIndex = 0;
            this.llblmenu.TabStop = true;
            this.llblmenu.Text = "Menu";
            this.llblmenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblmenu_LinkClicked);
            // 
            // llblhalls
            // 
            this.llblhalls.AutoSize = true;
            this.llblhalls.Location = new System.Drawing.Point(50, 213);
            this.llblhalls.Name = "llblhalls";
            this.llblhalls.Size = new System.Drawing.Size(38, 16);
            this.llblhalls.TabIndex = 1;
            this.llblhalls.TabStop = true;
            this.llblhalls.Text = "Halls";
            this.llblhalls.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblhalls_LinkClicked);
            // 
            // llblreports
            // 
            this.llblreports.AutoSize = true;
            this.llblreports.Location = new System.Drawing.Point(52, 262);
            this.llblreports.Name = "llblreports";
            this.llblreports.Size = new System.Drawing.Size(55, 16);
            this.llblreports.TabIndex = 2;
            this.llblreports.TabStop = true;
            this.llblreports.Text = "Reports";
            this.llblreports.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblreports_LinkClicked);
            // 
            // llblsettings
            // 
            this.llblsettings.AutoSize = true;
            this.llblsettings.Location = new System.Drawing.Point(52, 309);
            this.llblsettings.Name = "llblsettings";
            this.llblsettings.Size = new System.Drawing.Size(55, 16);
            this.llblsettings.TabIndex = 3;
            this.llblsettings.TabStop = true;
            this.llblsettings.Text = "Settings";
            this.llblsettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblsettings_LinkClicked);
            // 
            // llbllogout
            // 
            this.llbllogout.AutoSize = true;
            this.llbllogout.Location = new System.Drawing.Point(54, 486);
            this.llbllogout.Name = "llbllogout";
            this.llbllogout.Size = new System.Drawing.Size(53, 16);
            this.llbllogout.TabIndex = 4;
            this.llbllogout.TabStop = true;
            this.llbllogout.Text = "Log Out";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.llblmenu);
            this.pnlNavigation.Controls.Add(this.llblsettings);
            this.pnlNavigation.Controls.Add(this.llblreports);
            this.pnlNavigation.Controls.Add(this.llbllogout);
            this.pnlNavigation.Location = new System.Drawing.Point(-2, -1);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(250, 547);
            this.pnlNavigation.TabIndex = 5;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(335, 114);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(243, 128);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHalls
            // 
            this.btnHalls.Location = new System.Drawing.Point(335, 297);
            this.btnHalls.Name = "btnHalls";
            this.btnHalls.Size = new System.Drawing.Size(243, 128);
            this.btnHalls.TabIndex = 8;
            this.btnHalls.Text = "Halls";
            this.btnHalls.UseVisualStyleBackColor = true;
            this.btnHalls.Click += new System.EventHandler(this.btnHalls_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(688, 114);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(243, 128);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "Sales Report";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(688, 297);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(243, 128);
            this.btnReservations.TabIndex = 10;
            this.btnReservations.Text = "Reservations Reports";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 542);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnHalls);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.llblhalls);
            this.Controls.Add(this.pnlNavigation);
            this.Name = "ManagerDashboard";
            this.Text = "ManagerDashboard";
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblmenu;
        private System.Windows.Forms.LinkLabel llblhalls;
        private System.Windows.Forms.LinkLabel llblreports;
        private System.Windows.Forms.LinkLabel llblsettings;
        private System.Windows.Forms.LinkLabel llbllogout;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnHalls;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnReservations;
    }
}