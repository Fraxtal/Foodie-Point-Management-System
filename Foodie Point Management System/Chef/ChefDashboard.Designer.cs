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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.linklblProfSettings = new System.Windows.Forms.LinkLabel();
            this.linklblInventory = new System.Windows.Forms.LinkLabel();
            this.linklblViewOrder = new System.Windows.Forms.LinkLabel();
            this.lblInvenSummary = new System.Windows.Forms.Label();
            this.grpbxOrders = new System.Windows.Forms.GroupBox();
            this.lblFulOrders = new System.Windows.Forms.Label();
            this.lblUnfulOrders = new System.Windows.Forms.Label();
            this.lblUnfulfilled = new System.Windows.Forms.Label();
            this.lblFulfilled = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.dgvDashInven = new System.Windows.Forms.DataGridView();
            this.ingredientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grpbxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashInven)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.linklblProfSettings);
            this.panel1.Controls.Add(this.linklblInventory);
            this.panel1.Controls.Add(this.linklblViewOrder);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 459);
            this.panel1.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(15, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(253, 44);
            this.lblWelcome.TabIndex = 16;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(80, 397);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 46);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(16, 397);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(46, 46);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Exit";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // linklblProfSettings
            // 
            this.linklblProfSettings.AutoSize = true;
            this.linklblProfSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblProfSettings.Location = new System.Drawing.Point(77, 271);
            this.linklblProfSettings.Name = "linklblProfSettings";
            this.linklblProfSettings.Size = new System.Drawing.Size(96, 16);
            this.linklblProfSettings.TabIndex = 2;
            this.linklblProfSettings.TabStop = true;
            this.linklblProfSettings.Text = "Profile Settings";
            this.linklblProfSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblProfSettings_LinkClicked);
            // 
            // linklblInventory
            // 
            this.linklblInventory.AutoSize = true;
            this.linklblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblInventory.Location = new System.Drawing.Point(77, 203);
            this.linklblInventory.Name = "linklblInventory";
            this.linklblInventory.Size = new System.Drawing.Size(61, 16);
            this.linklblInventory.TabIndex = 1;
            this.linklblInventory.TabStop = true;
            this.linklblInventory.Text = "Inventory";
            this.linklblInventory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblInventory_LinkClicked);
            // 
            // linklblViewOrder
            // 
            this.linklblViewOrder.AutoSize = true;
            this.linklblViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblViewOrder.Location = new System.Drawing.Point(77, 137);
            this.linklblViewOrder.Name = "linklblViewOrder";
            this.linklblViewOrder.Size = new System.Drawing.Size(80, 16);
            this.linklblViewOrder.TabIndex = 0;
            this.linklblViewOrder.TabStop = true;
            this.linklblViewOrder.Text = "View Orders";
            this.linklblViewOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblViewOrder_LinkClicked);
            // 
            // lblInvenSummary
            // 
            this.lblInvenSummary.AutoSize = true;
            this.lblInvenSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvenSummary.Location = new System.Drawing.Point(353, 265);
            this.lblInvenSummary.Name = "lblInvenSummary";
            this.lblInvenSummary.Size = new System.Drawing.Size(121, 16);
            this.lblInvenSummary.TabIndex = 1;
            this.lblInvenSummary.Text = "Inventory Summary";
            // 
            // grpbxOrders
            // 
            this.grpbxOrders.Controls.Add(this.lblFulOrders);
            this.grpbxOrders.Controls.Add(this.lblUnfulOrders);
            this.grpbxOrders.Controls.Add(this.lblUnfulfilled);
            this.grpbxOrders.Controls.Add(this.lblFulfilled);
            this.grpbxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxOrders.Location = new System.Drawing.Point(345, 62);
            this.grpbxOrders.Name = "grpbxOrders";
            this.grpbxOrders.Size = new System.Drawing.Size(408, 180);
            this.grpbxOrders.TabIndex = 3;
            this.grpbxOrders.TabStop = false;
            this.grpbxOrders.Text = "Orders";
            // 
            // lblFulOrders
            // 
            this.lblFulOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulOrders.Location = new System.Drawing.Point(225, 79);
            this.lblFulOrders.Name = "lblFulOrders";
            this.lblFulOrders.Size = new System.Drawing.Size(149, 40);
            this.lblFulOrders.TabIndex = 8;
            this.lblFulOrders.Text = "Placeholder : Encore";
            this.lblFulOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFulOrders.Click += new System.EventHandler(this.lblFulOrders_Click);
            // 
            // lblUnfulOrders
            // 
            this.lblUnfulOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfulOrders.Location = new System.Drawing.Point(32, 79);
            this.lblUnfulOrders.Name = "lblUnfulOrders";
            this.lblUnfulOrders.Size = new System.Drawing.Size(149, 40);
            this.lblUnfulOrders.TabIndex = 7;
            this.lblUnfulOrders.Text = "Placeholder for centering";
            this.lblUnfulOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnfulOrders.Click += new System.EventHandler(this.lblUnfulOrders_Click);
            // 
            // lblUnfulfilled
            // 
            this.lblUnfulfilled.AutoSize = true;
            this.lblUnfulfilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnfulfilled.Location = new System.Drawing.Point(71, 50);
            this.lblUnfulfilled.Name = "lblUnfulfilled";
            this.lblUnfulfilled.Size = new System.Drawing.Size(71, 18);
            this.lblUnfulfilled.TabIndex = 5;
            this.lblUnfulfilled.Text = "Unfulfilled";
            this.lblUnfulfilled.Click += new System.EventHandler(this.lblUnfulfilled_Click);
            // 
            // lblFulfilled
            // 
            this.lblFulfilled.AutoSize = true;
            this.lblFulfilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulfilled.Location = new System.Drawing.Point(272, 50);
            this.lblFulfilled.Name = "lblFulfilled";
            this.lblFulfilled.Size = new System.Drawing.Size(57, 18);
            this.lblFulfilled.TabIndex = 6;
            this.lblFulfilled.Text = "Fulfilled";
            this.lblFulfilled.Click += new System.EventHandler(this.lblFulfilled_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(299, 19);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(117, 25);
            this.lblDashboard.TabIndex = 4;
            this.lblDashboard.Text = "Dashboard";
            // 
            // dgvDashInven
            // 
            this.dgvDashInven.AllowUserToAddRows = false;
            this.dgvDashInven.AllowUserToDeleteRows = false;
            this.dgvDashInven.AutoGenerateColumns = false;
            this.dgvDashInven.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDashInven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashInven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvDashInven.Location = new System.Drawing.Point(345, 284);
            this.dgvDashInven.Name = "dgvDashInven";
            this.dgvDashInven.ReadOnly = true;
            this.dgvDashInven.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashInven.Size = new System.Drawing.Size(408, 156);
            this.dgvDashInven.TabIndex = 11;

            // ingredientIDDataGridViewTextBoxColumn
            // 
            this.ingredientIDDataGridViewTextBoxColumn.DataPropertyName = "IngredientID";
            this.ingredientIDDataGridViewTextBoxColumn.HeaderText = "IngredientID";
            this.ingredientIDDataGridViewTextBoxColumn.Name = "ingredientIDDataGridViewTextBoxColumn";
            this.ingredientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmChefDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDashInven);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.grpbxOrders);
            this.Controls.Add(this.lblInvenSummary);
            this.Controls.Add(this.panel1);
            this.Name = "frmChefDashboard";
            this.Text = "Dashboard - Chef";
            this.Load += new System.EventHandler(this.frmChefDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpbxOrders.ResumeLayout(false);
            this.grpbxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashInven)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklblProfSettings;
        private System.Windows.Forms.LinkLabel linklblInventory;
        private System.Windows.Forms.LinkLabel linklblViewOrder;
        private System.Windows.Forms.Label lblInvenSummary;
        private System.Windows.Forms.GroupBox grpbxOrders;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblFulOrders;
        private System.Windows.Forms.Label lblUnfulOrders;
        private System.Windows.Forms.Label lblUnfulfilled;
        private System.Windows.Forms.Label lblFulfilled;
        private System.Windows.Forms.DataGridView dgvDashInven;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}