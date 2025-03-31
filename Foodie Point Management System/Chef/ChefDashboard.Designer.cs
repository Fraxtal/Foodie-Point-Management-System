namespace Foodie_Point_Management_System.Chef
{
    partial class frmChefDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblInvenSummary = new System.Windows.Forms.Label();
            this.grpbxOrders = new System.Windows.Forms.GroupBox();
            this.lblFulOrders = new System.Windows.Forms.Label();
            this.lblUnfulOrders = new System.Windows.Forms.Label();
            this.lblUnfulfilled = new System.Windows.Forms.Label();
            this.lblFulfilled = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.dgvDashInven = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.grpbxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashInven)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(177)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnViewOrder);
            this.panel1.Controls.Add(this.btnDash);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 600);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(177)))), ((int)(((byte)(151)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 543);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(255, 57);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblInvenSummary
            // 
            this.lblInvenSummary.AutoSize = true;
            this.lblInvenSummary.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvenSummary.Location = new System.Drawing.Point(294, 334);
            this.lblInvenSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvenSummary.Name = "lblInvenSummary";
            this.lblInvenSummary.Size = new System.Drawing.Size(171, 22);
            this.lblInvenSummary.TabIndex = 1;
            this.lblInvenSummary.Text = "Inventory Summary";
            // 
            // grpbxOrders
            // 
            this.grpbxOrders.Controls.Add(this.lblFulOrders);
            this.grpbxOrders.Controls.Add(this.lblUnfulOrders);
            this.grpbxOrders.Controls.Add(this.lblUnfulfilled);
            this.grpbxOrders.Controls.Add(this.lblFulfilled);
            this.grpbxOrders.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxOrders.Location = new System.Drawing.Point(298, 90);
            this.grpbxOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxOrders.Name = "grpbxOrders";
            this.grpbxOrders.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpbxOrders.Size = new System.Drawing.Size(661, 222);
            this.grpbxOrders.TabIndex = 3;
            this.grpbxOrders.TabStop = false;
            this.grpbxOrders.Text = "Orders";
            // 
            // lblFulOrders
            // 
            this.lblFulOrders.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulOrders.Location = new System.Drawing.Point(377, 95);
            this.lblFulOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFulOrders.Name = "lblFulOrders";
            this.lblFulOrders.Size = new System.Drawing.Size(199, 72);
            this.lblFulOrders.TabIndex = 8;
            this.lblFulOrders.Text = "Placeholder : Encore";
            this.lblFulOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFulOrders.Click += new System.EventHandler(this.lblFulOrders_Click);
            // 
            // lblUnfulOrders
            // 
            this.lblUnfulOrders.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfulOrders.Location = new System.Drawing.Point(120, 95);
            this.lblUnfulOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnfulOrders.Name = "lblUnfulOrders";
            this.lblUnfulOrders.Size = new System.Drawing.Size(199, 72);
            this.lblUnfulOrders.TabIndex = 7;
            this.lblUnfulOrders.Text = "Placeholder for centering";
            this.lblUnfulOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnfulOrders.Click += new System.EventHandler(this.lblUnfulOrders_Click);
            // 
            // lblUnfulfilled
            // 
            this.lblUnfulfilled.AutoSize = true;
            this.lblUnfulfilled.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfulfilled.Location = new System.Drawing.Point(172, 60);
            this.lblUnfulfilled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnfulfilled.Name = "lblUnfulfilled";
            this.lblUnfulfilled.Size = new System.Drawing.Size(101, 22);
            this.lblUnfulfilled.TabIndex = 5;
            this.lblUnfulfilled.Text = "Unfulfilled";
            this.lblUnfulfilled.Click += new System.EventHandler(this.lblUnfulfilled_Click);
            // 
            // lblFulfilled
            // 
            this.lblFulfilled.AutoSize = true;
            this.lblFulfilled.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulfilled.Location = new System.Drawing.Point(440, 60);
            this.lblFulfilled.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFulfilled.Name = "lblFulfilled";
            this.lblFulfilled.Size = new System.Drawing.Size(81, 22);
            this.lblFulfilled.TabIndex = 6;
            this.lblFulfilled.Text = "Fulfilled";
            this.lblFulfilled.Click += new System.EventHandler(this.lblFulfilled_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(293, 40);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(136, 30);
            this.lblDashboard.TabIndex = 4;
            this.lblDashboard.Text = "Dashboard";
            // 
            // dgvDashInven
            // 
            this.dgvDashInven.AllowUserToAddRows = false;
            this.dgvDashInven.AllowUserToDeleteRows = false;
            this.dgvDashInven.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashInven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashInven.Location = new System.Drawing.Point(298, 364);
            this.dgvDashInven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDashInven.Name = "dgvDashInven";
            this.dgvDashInven.ReadOnly = true;
            this.dgvDashInven.RowHeadersWidth = 51;
            this.dgvDashInven.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashInven.Size = new System.Drawing.Size(661, 192);
            this.dgvDashInven.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 172);
            this.panel2.TabIndex = 16;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "🍵";
            // 
            // btnDash
            // 
            this.btnDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.Location = new System.Drawing.Point(0, 172);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(255, 54);
            this.btnDash.TabIndex = 34;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrder.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Location = new System.Drawing.Point(0, 226);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(255, 54);
            this.btnViewOrder.TabIndex = 35;
            this.btnViewOrder.Text = "View Orders";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(0, 280);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(255, 54);
            this.btnInventory.TabIndex = 36;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 334);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(255, 54);
            this.btnProfile.TabIndex = 37;
            this.btnProfile.Text = "Profile Settings";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(969, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 20);
            this.lblExit.TabIndex = 28;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(17, 406);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(216, 121);
            this.lblWelcome.TabIndex = 16;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 171);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(5, 100);
            this.pnlNav.TabIndex = 38;
            // 
            // frmChefDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.dgvDashInven);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.grpbxOrders);
            this.Controls.Add(this.lblInvenSummary);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChefDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard - Chef";
            this.Load += new System.EventHandler(this.frmChefDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.grpbxOrders.ResumeLayout(false);
            this.grpbxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashInven)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInvenSummary;
        private System.Windows.Forms.GroupBox grpbxOrders;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblFulOrders;
        private System.Windows.Forms.Label lblUnfulOrders;
        private System.Windows.Forms.Label lblUnfulfilled;
        private System.Windows.Forms.Label lblFulfilled;
        private System.Windows.Forms.DataGridView dgvDashInven;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlNav;
    }
}