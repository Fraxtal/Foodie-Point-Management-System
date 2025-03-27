namespace Foodie_Point_Management_System.Chef
{
    partial class frmChefViewOrders
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
            this.rbtnOngoing = new System.Windows.Forms.RadioButton();
            this.rbtnPast = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchOrder = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbboxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtbxOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.chkbxMe = new System.Windows.Forms.CheckBox();
            this.rbtnQueue = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnOngoing
            // 
            this.rbtnOngoing.AutoSize = true;
            this.rbtnOngoing.Location = new System.Drawing.Point(571, 26);
            this.rbtnOngoing.Name = "rbtnOngoing";
            this.rbtnOngoing.Size = new System.Drawing.Size(120, 20);
            this.rbtnOngoing.TabIndex = 32;
            this.rbtnOngoing.TabStop = true;
            this.rbtnOngoing.Text = "Ongoing Orders";
            this.rbtnOngoing.UseVisualStyleBackColor = true;
            this.rbtnOngoing.CheckedChanged += new System.EventHandler(this.rbtnOngoing_CheckedChanged);
            // 
            // rbtnPast
            // 
            this.rbtnPast.AutoSize = true;
            this.rbtnPast.Location = new System.Drawing.Point(705, 26);
            this.rbtnPast.Name = "rbtnPast";
            this.rbtnPast.Size = new System.Drawing.Size(96, 20);
            this.rbtnPast.TabIndex = 31;
            this.rbtnPast.TabStop = true;
            this.rbtnPast.Text = "Past Orders";
            this.rbtnPast.UseVisualStyleBackColor = true;
            this.rbtnPast.CheckedChanged += new System.EventHandler(this.rbtnPast_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(385, 26);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(40, 20);
            this.rbtnAll.TabIndex = 30;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.Location = new System.Drawing.Point(21, 52);
            this.dgvOrderList.MultiSelect = false;
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(780, 238);
            this.dgvOrderList.TabIndex = 25;
            this.dgvOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellClick);

            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lblSearchOrder);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.cmbboxStatus);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.txtbxOrderID);
            this.panel1.Controls.Add(this.lblOrderID);
            this.panel1.Location = new System.Drawing.Point(818, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 249);
            this.panel1.TabIndex = 28;
            // 
            // lblSearchOrder
            // 
            this.lblSearchOrder.AutoSize = true;
            this.lblSearchOrder.Location = new System.Drawing.Point(19, 13);
            this.lblSearchOrder.Name = "lblSearchOrder";
            this.lblSearchOrder.Size = new System.Drawing.Size(87, 16);
            this.lblSearchOrder.TabIndex = 8;
            this.lblSearchOrder.Text = "Search Order";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(83, 176);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 46);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbboxStatus
            // 
            this.cmbboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxStatus.FormattingEnabled = true;
            this.cmbboxStatus.Items.AddRange(new object[] {
            "In Progress",
            "Completed"});
            this.cmbboxStatus.Location = new System.Drawing.Point(107, 120);
            this.cmbboxStatus.Name = "cmbboxStatus";
            this.cmbboxStatus.Size = new System.Drawing.Size(144, 24);
            this.cmbboxStatus.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // txtbxOrderID
            // 
            this.txtbxOrderID.Location = new System.Drawing.Point(107, 54);
            this.txtbxOrderID.Name = "txtbxOrderID";
            this.txtbxOrderID.Size = new System.Drawing.Size(144, 22);
            this.txtbxOrderID.TabIndex = 4;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(28, 57);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(60, 16);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "Order ID:";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(18, 27);
            this.lblOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(77, 25);
            this.lblOrders.TabIndex = 27;
            this.lblOrders.Text = "Orders";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(990, 316);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 46);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // chkbxMe
            // 
            this.chkbxMe.AutoSize = true;
            this.chkbxMe.Location = new System.Drawing.Point(682, 296);
            this.chkbxMe.Name = "chkbxMe";
            this.chkbxMe.Size = new System.Drawing.Size(119, 20);
            this.chkbxMe.TabIndex = 38;
            this.chkbxMe.Text = "Assigned to Me";
            this.chkbxMe.UseVisualStyleBackColor = true;
            this.chkbxMe.CheckedChanged += new System.EventHandler(this.chkbxMe_CheckedChanged);
            // 
            // rbtnQueue
            // 
            this.rbtnQueue.AutoSize = true;
            this.rbtnQueue.Location = new System.Drawing.Point(440, 26);
            this.rbtnQueue.Name = "rbtnQueue";
            this.rbtnQueue.Size = new System.Drawing.Size(117, 20);
            this.rbtnQueue.TabIndex = 39;
            this.rbtnQueue.TabStop = true;
            this.rbtnQueue.Text = "Queued Orders";
            this.rbtnQueue.UseVisualStyleBackColor = true;
            this.rbtnQueue.CheckedChanged += new System.EventHandler(this.rbtnQueue_CheckedChanged);
            // 
            // frmChefViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 375);
            this.Controls.Add(this.rbtnQueue);
            this.Controls.Add(this.chkbxMe);
            this.Controls.Add(this.rbtnOngoing);
            this.Controls.Add(this.rbtnPast);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.btnReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChefViewOrders";
            this.Text = "View Orders - Chef";
            this.Load += new System.EventHandler(this.frmChefViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnOngoing;
        private System.Windows.Forms.RadioButton rbtnPast;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchOrder;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbboxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtbxOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox chkbxMe;
        private System.Windows.Forms.RadioButton rbtnQueue;
    }
}