namespace cafe_billing
{
    partial class frmReceipt
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvReceipt = new DataGridView();
            clmName = new DataGridViewTextBoxColumn();
            clmCount = new DataGridViewTextBoxColumn();
            clmUnit_Price = new DataGridViewTextBoxColumn();
            clmTotal_Price = new DataGridViewTextBoxColumn();
            pnlHeader = new Panel();
            lblSeller = new Label();
            lblNameOfRestaurant = new Label();
            lblTitle = new Label();
            lblTime = new Label();
            lblDate = new Label();
            tmrClock = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvReceipt).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReceipt
            // 
            dgvReceipt.AllowUserToResizeColumns = false;
            dgvReceipt.AllowUserToResizeRows = false;
            dgvReceipt.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceipt.Columns.AddRange(new DataGridViewColumn[] { clmName, clmCount, clmUnit_Price, clmTotal_Price });
            dgvReceipt.Location = new Point(3, 138);
            dgvReceipt.Name = "dgvReceipt";
            dgvReceipt.ReadOnly = true;
            dgvReceipt.RightToLeft = RightToLeft.Yes;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReceipt.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReceipt.RowHeadersWidth = 90;
            dgvReceipt.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvReceipt.RowTemplate.Height = 60;
            dgvReceipt.RowTemplate.ReadOnly = true;
            dgvReceipt.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvReceipt.Size = new Size(504, 444);
            dgvReceipt.TabIndex = 4;
            // 
            // clmName
            // 
            clmName.HeaderText = "شرح کالا";
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            clmName.Resizable = DataGridViewTriState.False;
            clmName.Width = 103;
            // 
            // clmCount
            // 
            clmCount.HeaderText = "تعداد";
            clmCount.Name = "clmCount";
            clmCount.ReadOnly = true;
            clmCount.Resizable = DataGridViewTriState.False;
            clmCount.Width = 103;
            // 
            // clmUnit_Price
            // 
            clmUnit_Price.HeaderText = "قیمت واحد";
            clmUnit_Price.Name = "clmUnit_Price";
            clmUnit_Price.ReadOnly = true;
            clmUnit_Price.Resizable = DataGridViewTriState.False;
            clmUnit_Price.Width = 103;
            // 
            // clmTotal_Price
            // 
            clmTotal_Price.HeaderText = "قیمت کل";
            clmTotal_Price.Name = "clmTotal_Price";
            clmTotal_Price.ReadOnly = true;
            clmTotal_Price.Resizable = DataGridViewTriState.False;
            clmTotal_Price.Width = 103;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblSeller);
            pnlHeader.Controls.Add(lblNameOfRestaurant);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblTime);
            pnlHeader.Controls.Add(lblDate);
            pnlHeader.Location = new Point(3, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(504, 135);
            pnlHeader.TabIndex = 6;
            // 
            // lblSeller
            // 
            lblSeller.AutoSize = true;
            lblSeller.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSeller.Location = new Point(404, 109);
            lblSeller.Name = "lblSeller";
            lblSeller.RightToLeft = RightToLeft.Yes;
            lblSeller.Size = new Size(50, 18);
            lblSeller.TabIndex = 4;
            lblSeller.Text = "label1";
            // 
            // lblNameOfRestaurant
            // 
            lblNameOfRestaurant.AutoSize = true;
            lblNameOfRestaurant.Font = new Font("Arial Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameOfRestaurant.ForeColor = Color.FromArgb(0, 192, 0);
            lblNameOfRestaurant.Location = new Point(144, 9);
            lblNameOfRestaurant.Name = "lblNameOfRestaurant";
            lblNameOfRestaurant.Size = new Size(230, 50);
            lblNameOfRestaurant.TabIndex = 3;
            lblNameOfRestaurant.Text = "کافه رستوران";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(196, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 32);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "فاکتور فروش";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Arial", 12F);
            lblTime.Location = new Point(9, 109);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(50, 18);
            lblTime.TabIndex = 1;
            lblTime.Text = "label2";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial", 12F);
            lblDate.Location = new Point(9, 68);
            lblDate.Name = "lblDate";
            lblDate.RightToLeft = RightToLeft.Yes;
            lblDate.Size = new Size(50, 18);
            lblDate.TabIndex = 0;
            lblDate.Text = "label1";
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 500;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // frmReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 641);
            Controls.Add(pnlHeader);
            Controls.Add(dgvReceipt);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmReceipt";
            Text = "frmReceipt";
            Load += frmReceipt_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReceipt).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private DataGridView dgvReceipt;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblTime;
        private Label lblDate;
        private System.Windows.Forms.Timer tmrClock;
        private Label lblNameOfRestaurant;
        private Label lblSeller;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCount;
        private DataGridViewTextBoxColumn clmUnit_Price;
        private DataGridViewTextBoxColumn clmTotal_Price;
    }
}



