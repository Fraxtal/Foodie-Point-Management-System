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
            this.upcoming = new System.Windows.Forms.DataGridView();
            this.lblpending = new System.Windows.Forms.Label();
            this.radconfirm = new System.Windows.Forms.RadioButton();
            this.radpending = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnSearchReser = new System.Windows.Forms.Button();
            this.btnReserManage = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upcoming)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // upcoming
            // 
            this.upcoming.AllowUserToAddRows = false;
            this.upcoming.AllowUserToDeleteRows = false;
            this.upcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.upcoming.Location = new System.Drawing.Point(287, 172);
            this.upcoming.Name = "upcoming";
            this.upcoming.ReadOnly = true;
            this.upcoming.RowHeadersWidth = 51;
            this.upcoming.RowTemplate.Height = 24;
            this.upcoming.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.upcoming.Size = new System.Drawing.Size(679, 361);
            this.upcoming.TabIndex = 9;
            this.upcoming.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.upcoming_CellContentClick);
            // 
            // lblpending
            // 
            this.lblpending.AutoSize = true;
            this.lblpending.Location = new System.Drawing.Point(286, 137);
            this.lblpending.Name = "lblpending";
            this.lblpending.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblpending.Size = new System.Drawing.Size(112, 22);
            this.lblpending.TabIndex = 12;
            this.lblpending.Text = "Reservations";
            this.lblpending.Click += new System.EventHandler(this.lblpending_Click);
            // 
            // radconfirm
            // 
            this.radconfirm.AutoSize = true;
            this.radconfirm.Location = new System.Drawing.Point(745, 135);
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
            this.radpending.Location = new System.Drawing.Point(867, 135);
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
            this.radAll.Location = new System.Drawing.Point(668, 135);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(57, 26);
            this.radAll.TabIndex = 15;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(969, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 20);
            this.lblExit.TabIndex = 29;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(177)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnRequest);
            this.panel1.Controls.Add(this.btnSearchReser);
            this.panel1.Controls.Add(this.btnReserManage);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 600);
            this.panel1.TabIndex = 30;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 172);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 100);
            this.pnlNav.TabIndex = 34;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(0, 546);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(255, 54);
            this.btnLogOut.TabIndex = 38;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 388);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(255, 54);
            this.btnProfile.TabIndex = 37;
            this.btnProfile.Text = "Settings";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(0, 334);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(255, 54);
            this.btnRequest.TabIndex = 36;
            this.btnRequest.Text = "Customer Requests";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnSearchReser
            // 
            this.btnSearchReser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchReser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchReser.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReser.Location = new System.Drawing.Point(0, 280);
            this.btnSearchReser.Name = "btnSearchReser";
            this.btnSearchReser.Size = new System.Drawing.Size(255, 54);
            this.btnSearchReser.TabIndex = 35;
            this.btnSearchReser.Text = "Search Reservations";
            this.btnSearchReser.UseVisualStyleBackColor = true;
            this.btnSearchReser.Click += new System.EventHandler(this.btnSearchReser_Click);
            // 
            // btnReserManage
            // 
            this.btnReserManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserManage.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserManage.Location = new System.Drawing.Point(0, 226);
            this.btnReserManage.Name = "btnReserManage";
            this.btnReserManage.Size = new System.Drawing.Size(255, 54);
            this.btnReserManage.TabIndex = 34;
            this.btnReserManage.Text = "Manage Reservations";
            this.btnReserManage.UseVisualStyleBackColor = true;
            this.btnReserManage.Click += new System.EventHandler(this.btnReserManage_Click);
            // 
            // btnDash
            // 
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Location = new System.Drawing.Point(0, 172);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(255, 54);
            this.btnDash.TabIndex = 33;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 172);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Foodie Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 91);
            this.label4.TabIndex = 0;
            this.label4.Text = "🍵";
            // 
            // ReservationCoordinatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.radAll);
            this.Controls.Add(this.radpending);
            this.Controls.Add(this.radconfirm);
            this.Controls.Add(this.lblpending);
            this.Controls.Add(this.upcoming);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationCoordinatorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationCoordinatorDashboard";
            this.Load += new System.EventHandler(this.ReservationCoordinatorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upcoming)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView upcoming;
        private System.Windows.Forms.Label lblpending;
        private System.Windows.Forms.RadioButton radconfirm;
        private System.Windows.Forms.RadioButton radpending;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnSearchReser;
        private System.Windows.Forms.Button btnReserManage;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}