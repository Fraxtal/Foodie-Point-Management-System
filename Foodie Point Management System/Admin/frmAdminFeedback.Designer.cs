namespace Foodie_Point_Management_System.Admin
{
    partial class frmAdminFeedback
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
            this.lblfeedbacks = new System.Windows.Forms.Label();
            this.feedbackView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackView)).BeginInit();
            this.SuspendLayout();

            // 
            // lblfeedbacks
            // 
            this.lblfeedbacks.AutoSize = true;
            this.lblfeedbacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedbacks.Location = new System.Drawing.Point(308, 53);
            this.lblfeedbacks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfeedbacks.Name = "lblfeedbacks";
            this.lblfeedbacks.Size = new System.Drawing.Size(158, 33);
            this.lblfeedbacks.TabIndex = 4;
            this.lblfeedbacks.Text = "Feedbacks";
            // 
            // feedbackView
            // 
            this.feedbackView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackView.Location = new System.Drawing.Point(60, 102);
            this.feedbackView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedbackView.Name = "feedbackView";
            this.feedbackView.RowHeadersWidth = 62;
            this.feedbackView.Size = new System.Drawing.Size(690, 382);
            this.feedbackView.TabIndex = 5;
            this.feedbackView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feedbackView_CellDoubleClick);
            // 
            // frmAdminFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 580);
            this.Controls.Add(this.feedbackView);
            this.Controls.Add(this.lblfeedbacks);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminFeedback";
            this.Text = "frmAdminFeedback";
            this.Load += new System.EventHandler(this.unreadfeedbacks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblfeedbacks;
        private System.Windows.Forms.DataGridView feedbackView;
    }
}