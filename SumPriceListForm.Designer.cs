namespace BillSystem
{
    partial class SumPriceListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SumPriceListForm));
            this.gridSumPriceList = new System.Windows.Forms.DataGridView();
            this.ColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSumPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSumPriceTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printBillCompanyData = new System.Drawing.Printing.PrintDocument();
            this.btnDetil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSumPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSumPriceList
            // 
            this.gridSumPriceList.AllowUserToAddRows = false;
            this.gridSumPriceList.AllowUserToDeleteRows = false;
            this.gridSumPriceList.AllowUserToResizeColumns = false;
            this.gridSumPriceList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gridSumPriceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSumPriceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridSumPriceList.ColumnHeadersHeight = 30;
            this.gridSumPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridSumPriceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColYear,
            this.ColMonth,
            this.ColSumPrice,
            this.ColSumPriceTax});
            this.gridSumPriceList.Location = new System.Drawing.Point(27, 23);
            this.gridSumPriceList.Margin = new System.Windows.Forms.Padding(2);
            this.gridSumPriceList.MultiSelect = false;
            this.gridSumPriceList.Name = "gridSumPriceList";
            this.gridSumPriceList.ReadOnly = true;
            this.gridSumPriceList.RowHeadersVisible = false;
            this.gridSumPriceList.RowTemplate.Height = 24;
            this.gridSumPriceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSumPriceList.Size = new System.Drawing.Size(589, 406);
            this.gridSumPriceList.TabIndex = 0;
            // 
            // ColYear
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColYear.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColYear.HeaderText = "年";
            this.ColYear.Name = "ColYear";
            this.ColYear.ReadOnly = true;
            this.ColYear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColYear.Width = 80;
            // 
            // ColMonth
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColMonth.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColMonth.HeaderText = "月";
            this.ColMonth.Name = "ColMonth";
            this.ColMonth.ReadOnly = true;
            this.ColMonth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColMonth.Width = 80;
            // 
            // ColSumPrice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColSumPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColSumPrice.HeaderText = "合計金額(税抜)";
            this.ColSumPrice.Name = "ColSumPrice";
            this.ColSumPrice.ReadOnly = true;
            this.ColSumPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSumPrice.Width = 200;
            // 
            // ColSumPriceTax
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColSumPriceTax.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColSumPriceTax.HeaderText = "合計金額(税込)";
            this.ColSumPriceTax.Name = "ColSumPriceTax";
            this.ColSumPriceTax.ReadOnly = true;
            this.ColSumPriceTax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSumPriceTax.Width = 200;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(370, 468);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 64);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrint.Location = new System.Drawing.Point(27, 468);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 64);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "印刷";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printBillCompanyData
            // 
            this.printBillCompanyData.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printBillCompanyData_PrintPage);
            // 
            // btnDetil
            // 
            this.btnDetil.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDetil.Location = new System.Drawing.Point(631, 180);
            this.btnDetil.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetil.Name = "btnDetil";
            this.btnDetil.Size = new System.Drawing.Size(46, 83);
            this.btnDetil.TabIndex = 3;
            this.btnDetil.Text = "詳細";
            this.btnDetil.UseVisualStyleBackColor = true;
            this.btnDetil.Click += new System.EventHandler(this.btnDetil_Click);
            // 
            // SumPriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 545);
            this.Controls.Add(this.btnDetil);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridSumPriceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SumPriceListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "総額一覧";
            this.Load += new System.EventHandler(this.SumPriceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSumPriceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridSumPriceList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printBillCompanyData;
        private System.Windows.Forms.Button btnDetil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSumPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSumPriceTax;
    }
}