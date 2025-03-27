namespace Foodie_Point_Management_System.ReservationCoordinator
{
    partial class ReservationCoordinatorDashboard
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
            this.lnkmanage = new System.Windows.Forms.LinkLabel();
            this.lnksearch = new System.Windows.Forms.LinkLabel();
            this.lnkcustomer = new System.Windows.Forms.LinkLabel();
            this.lnksettings = new System.Windows.Forms.LinkLabel();
            this.monthlyreservation = new System.Windows.Forms.MonthCalendar();
            this.lblmonthly = new System.Windows.Forms.Label();
            this.lnkout = new System.Windows.Forms.LinkLabel();
            this.upcoming = new System.Windows.Forms.DataGridView();
            this.lblpending = new System.Windows.Forms.Label();
            this.radconfirm = new System.Windows.Forms.RadioButton();
            this.radpending = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.upcoming)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // lnkmanage
            // 
            this.lnkmanage.AutoSize = true;
            this.lnkmanage.LinkColor = System.Drawing.Color.Black;
            this.lnkmanage.Location = new System.Drawing.Point(15, 96);
            this.lnkmanage.Name = "lnkmanage";
            this.lnkmanage.Size = new System.Drawing.Size(180, 22);
            this.lnkmanage.TabIndex = 1;
            this.lnkmanage.TabStop = true;
            this.lnkmanage.Text = "Manage Reservations";
            this.lnkmanage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkmanage_LinkClicked);
            // 
            // lnksearch
            // 
            this.lnksearch.AutoSize = true;
            this.lnksearch.LinkColor = System.Drawing.Color.Black;
            this.lnksearch.Location = new System.Drawing.Point(15, 161);
            this.lnksearch.Name = "lnksearch";
            this.lnksearch.Size = new System.Drawing.Size(172, 22);
            this.lnksearch.TabIndex = 2;
            this.lnksearch.TabStop = true;
            this.lnksearch.Text = "Search Reservations";
            this.lnksearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnksearch_LinkClicked);
            // 
            // lnkcustomer
            // 
            this.lnkcustomer.AutoSize = true;
            this.lnkcustomer.LinkColor = System.Drawing.Color.Black;
            this.lnkcustomer.Location = new System.Drawing.Point(15, 223);
            this.lnkcustomer.Name = "lnkcustomer";
            this.lnkcustomer.Size = new System.Drawing.Size(159, 22);
            this.lnkcustomer.TabIndex = 3;
            this.lnkcustomer.TabStop = true;
            this.lnkcustomer.Text = "Customer Requests";
            this.lnkcustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkcustomer_LinkClicked);
            // 
            // lnksettings
            // 
            this.lnksettings.AutoSize = true;
            this.lnksettings.LinkColor = System.Drawing.Color.Black;
            this.lnksettings.Location = new System.Drawing.Point(15, 284);
            this.lnksettings.Name = "lnksettings";
            this.lnksettings.Size = new System.Drawing.Size(74, 22);
            this.lnksettings.TabIndex = 4;
            this.lnksettings.TabStop = true;
            this.lnksettings.Text = "Settings";
            this.lnksettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnksettings_LinkClicked);
            // 
            // monthlyreservation
            // 
            this.monthlyreservation.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthlyreservation.Location = new System.Drawing.Point(242, 68);
            this.monthlyreservation.Name = "monthlyreservation";
            this.monthlyreservation.TabIndex = 6;
            this.monthlyreservation.TitleBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.monthlyreservation.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.monthlyreservation.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthlyreservation_DateChanged);
            // 
            // lblmonthly
            // 
            this.lblmonthly.AutoSize = true;
            this.lblmonthly.Location = new System.Drawing.Point(238, 46);
            this.lblmonthly.Name = "lblmonthly";
            this.lblmonthly.Size = new System.Drawing.Size(179, 22);
            this.lblmonthly.TabIndex = 7;
            this.lblmonthly.Text = "Monthly Reservation";
            // 
            // lnkout
            // 
            this.lnkout.AutoSize = true;
            this.lnkout.LinkColor = System.Drawing.Color.Black;
            this.lnkout.Location = new System.Drawing.Point(12, 474);
            this.lnkout.Name = "lnkout";
            this.lnkout.Size = new System.Drawing.Size(67, 22);
            this.lnkout.TabIndex = 8;
            this.lnkout.TabStop = true;
            this.lnkout.Text = "Logout";
            // 
            // upcoming
            // 
            this.upcoming.AllowUserToAddRows = false;
            this.upcoming.AllowUserToDeleteRows = false;
            this.upcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcoming.Location = new System.Drawing.Point(242, 337);
            this.upcoming.Name = "upcoming";
            this.upcoming.ReadOnly = true;
            this.upcoming.RowHeadersWidth = 51;
            this.upcoming.RowTemplate.Height = 24;
            this.upcoming.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.upcoming.Size = new System.Drawing.Size(679, 149);
            this.upcoming.TabIndex = 9;
            this.upcoming.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upcoming_CellContentClick);
            // 
            // lblpending
            // 
            this.lblpending.AutoSize = true;
            this.lblpending.Location = new System.Drawing.Point(238, 300);
            this.lblpending.Name = "lblpending";
            this.lblpending.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblpending.Size = new System.Drawing.Size(112, 22);
            this.lblpending.TabIndex = 12;
            this.lblpending.Text = "Reservations";
            // 
            // radconfirm
            // 
            this.radconfirm.AutoSize = true;
            this.radconfirm.Location = new System.Drawing.Point(683, 298);
            this.radconfirm.Name = "radconfirm";
            this.radconfirm.Size = new System.Drawing.Size(116, 26);
            this.radconfirm.TabIndex = 13;
            this.radconfirm.TabStop = true;
            this.radconfirm.Text = "Confirmed";
            this.radconfirm.UseVisualStyleBackColor = true;
            this.radconfirm.CheckedChanged += new System.EventHandler(this.radconfirm_CheckedChanged);
            // 
            // radpending
            // 
            this.radpending.AutoSize = true;
            this.radpending.Location = new System.Drawing.Point(805, 298);
            this.radpending.Name = "radpending";
            this.radpending.Size = new System.Drawing.Size(99, 26);
            this.radpending.TabIndex = 14;
            this.radpending.TabStop = true;
            this.radpending.Text = "Pending";
            this.radpending.UseVisualStyleBackColor = true;
            this.radpending.CheckedChanged += new System.EventHandler(this.radpending_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(606, 298);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(57, 26);
            this.radAll.TabIndex = 15;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // ReservationCoordinatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 520);
            this.Controls.Add(this.radAll);
            this.Controls.Add(this.radpending);
            this.Controls.Add(this.radconfirm);
            this.Controls.Add(this.lblpending);
            this.Controls.Add(this.upcoming);
            this.Controls.Add(this.lnkout);
            this.Controls.Add(this.lblmonthly);
            this.Controls.Add(this.monthlyreservation);
            this.Controls.Add(this.lnksettings);
            this.Controls.Add(this.lnkcustomer);
            this.Controls.Add(this.lnksearch);
            this.Controls.Add(this.lnkmanage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationCoordinatorDashboard";
            this.Text = "ReservationCoordinatorDashboard";
            this.Load += new System.EventHandler(this.ReservationCoordinatorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upcoming)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkmanage;
        private System.Windows.Forms.LinkLabel lnksearch;
        private System.Windows.Forms.LinkLabel lnkcustomer;
        private System.Windows.Forms.LinkLabel lnksettings;
        private System.Windows.Forms.MonthCalendar monthlyreservation;
        private System.Windows.Forms.Label lblmonthly;
        private System.Windows.Forms.LinkLabel lnkout;
        private System.Windows.Forms.DataGridView upcoming;
        private System.Windows.Forms.Label lblpending;
        private System.Windows.Forms.RadioButton radconfirm;
        private System.Windows.Forms.RadioButton radpending;
        private System.Windows.Forms.RadioButton radAll;
    }
}