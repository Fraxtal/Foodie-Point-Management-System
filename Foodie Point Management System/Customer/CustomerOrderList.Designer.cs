namespace Foodie_Point_Management_System.Customer
{
    partial class CustomerOrderList
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.OrderListGrid = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // txtOID
            // 
            this.txtOID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOID.Location = new System.Drawing.Point(157, 142);
            this.txtOID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOID.Name = "txtOID";
            this.txtOID.ReadOnly = true;
            this.txtOID.Size = new System.Drawing.Size(146, 29);
            this.txtOID.TabIndex = 4;
            // 
            // txtFood
            // 
            this.txtFood.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFood.Location = new System.Drawing.Point(157, 204);
            this.txtFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFood.Name = "txtFood";
            this.txtFood.ReadOnly = true;
            this.txtFood.Size = new System.Drawing.Size(146, 29);
            this.txtFood.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(157, 270);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(146, 29);
            this.txtQuantity.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(157, 489);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 46);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // OrderListGrid
            // 
            this.OrderListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrderListGrid.Location = new System.Drawing.Point(331, 107);
            this.OrderListGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderListGrid.MultiSelect = false;
            this.OrderListGrid.Name = "OrderListGrid";
            this.OrderListGrid.ReadOnly = true;
            this.OrderListGrid.RowHeadersWidth = 51;
            this.OrderListGrid.Size = new System.Drawing.Size(616, 352);
            this.OrderListGrid.TabIndex = 8;
            this.OrderListGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderListGrid_CellClick);
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(751, 489);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(196, 63);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(36, 37);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 40);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Remarks: ";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(157, 341);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(146, 118);
            this.txtRemarks.TabIndex = 12;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(969, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(19, 20);
            this.lblExit.TabIndex = 30;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // CustomerOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.OrderListGrid);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.txtOID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Order List";
            this.Load += new System.EventHandler(this.CustomerOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView OrderListGrid;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblExit;
    }
}