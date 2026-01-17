namespace BillSystem
{
    partial class SumDetilForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SumDetilForm));
            this.labelYear = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridViewDetil = new System.Windows.Forms.DataGridView();
            this.ColCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelSumPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTaxPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSumTaxKomiPrice = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrice = new System.Windows.Forms.TabPage();
            this.tabPageSetDetail = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkReadOnly = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetil)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePrice.SuspendLayout();
            this.tabPageSetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("ＭＳ ゴシック", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelYear.Location = new System.Drawing.Point(12, 9);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(120, 48);
            this.labelYear.TabIndex = 60;
            this.labelYear.Text = "2000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(138, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 37);
            this.label6.TabIndex = 61;
            this.label6.Text = "年";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("ＭＳ ゴシック", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMonth.Location = new System.Drawing.Point(200, 9);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(70, 48);
            this.labelMonth.TabIndex = 62;
            this.labelMonth.Text = "07";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(276, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 37);
            this.label7.TabIndex = 63;
            this.label7.Text = "月";
            // 
            // gridViewDetil
            // 
            this.gridViewDetil.AllowUserToAddRows = false;
            this.gridViewDetil.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gridViewDetil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewDetil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewDetil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewDetil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCompany,
            this.ColLine,
            this.ColPrice});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewDetil.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewDetil.Location = new System.Drawing.Point(8, 153);
            this.gridViewDetil.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewDetil.MultiSelect = false;
            this.gridViewDetil.Name = "gridViewDetil";
            this.gridViewDetil.RowHeadersWidth = 50;
            this.gridViewDetil.RowTemplate.Height = 21;
            this.gridViewDetil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewDetil.Size = new System.Drawing.Size(850, 477);
            this.gridViewDetil.TabIndex = 64;
            this.gridViewDetil.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewHinmei_RowPostPaint);
            // 
            // ColCompany
            // 
            this.ColCompany.Frozen = true;
            this.ColCompany.HeaderText = "会社名";
            this.ColCompany.Name = "ColCompany";
            this.ColCompany.ReadOnly = true;
            this.ColCompany.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCompany.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCompany.Width = 425;
            // 
            // ColLine
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColLine.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColLine.Frozen = true;
            this.ColLine.HeaderText = "総行数";
            this.ColLine.Name = "ColLine";
            this.ColLine.ReadOnly = true;
            this.ColLine.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColLine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPrice
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColPrice.Frozen = true;
            this.ColPrice.HeaderText = "合計金額";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPrice.Width = 250;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(361, 781);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(207, 80);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "閉じる";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelSumPrice
            // 
            this.labelSumPrice.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSumPrice.Location = new System.Drawing.Point(625, 12);
            this.labelSumPrice.Name = "labelSumPrice";
            this.labelSumPrice.Size = new System.Drawing.Size(233, 33);
            this.labelSumPrice.TabIndex = 66;
            this.labelSumPrice.Text = "\\0";
            this.labelSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(351, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "税抜合計金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(450, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 68;
            this.label2.Text = "消費税";
            // 
            // labelTaxPrice
            // 
            this.labelTaxPrice.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTaxPrice.Location = new System.Drawing.Point(625, 55);
            this.labelTaxPrice.Name = "labelTaxPrice";
            this.labelTaxPrice.Size = new System.Drawing.Size(233, 33);
            this.labelTaxPrice.TabIndex = 69;
            this.labelTaxPrice.Text = "\\0";
            this.labelTaxPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(351, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 33);
            this.label3.TabIndex = 70;
            this.label3.Text = "税込合計金額";
            // 
            // labelSumTaxKomiPrice
            // 
            this.labelSumTaxKomiPrice.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSumTaxKomiPrice.Location = new System.Drawing.Point(625, 104);
            this.labelSumTaxKomiPrice.Name = "labelSumTaxKomiPrice";
            this.labelSumTaxKomiPrice.Size = new System.Drawing.Size(233, 33);
            this.labelSumTaxKomiPrice.TabIndex = 71;
            this.labelSumTaxKomiPrice.Text = "\\0";
            this.labelSumTaxKomiPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrice);
            this.tabControl1.Controls.Add(this.tabPageSetDetail);
            this.tabControl1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(20, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 681);
            this.tabControl1.TabIndex = 72;
            // 
            // tabPagePrice
            // 
            this.tabPagePrice.BackColor = System.Drawing.Color.Thistle;
            this.tabPagePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPagePrice.Controls.Add(this.labelSumPrice);
            this.tabPagePrice.Controls.Add(this.labelTaxPrice);
            this.tabPagePrice.Controls.Add(this.gridViewDetil);
            this.tabPagePrice.Controls.Add(this.label1);
            this.tabPagePrice.Controls.Add(this.label3);
            this.tabPagePrice.Controls.Add(this.label2);
            this.tabPagePrice.Controls.Add(this.labelSumTaxKomiPrice);
            this.tabPagePrice.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPagePrice.Location = new System.Drawing.Point(4, 34);
            this.tabPagePrice.Name = "tabPagePrice";
            this.tabPagePrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrice.Size = new System.Drawing.Size(880, 643);
            this.tabPagePrice.TabIndex = 0;
            this.tabPagePrice.Text = "総額詳細";
            // 
            // tabPageSetDetail
            // 
            this.tabPageSetDetail.BackColor = System.Drawing.Color.LightCyan;
            this.tabPageSetDetail.Controls.Add(this.btnSave);
            this.tabPageSetDetail.Controls.Add(this.checkReadOnly);
            this.tabPageSetDetail.Location = new System.Drawing.Point(4, 34);
            this.tabPageSetDetail.Name = "tabPageSetDetail";
            this.tabPageSetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetDetail.Size = new System.Drawing.Size(880, 643);
            this.tabPageSetDetail.TabIndex = 1;
            this.tabPageSetDetail.Text = "設定";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.Location = new System.Drawing.Point(196, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "適用";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkReadOnly
            // 
            this.checkReadOnly.AutoSize = true;
            this.checkReadOnly.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkReadOnly.Location = new System.Drawing.Point(29, 45);
            this.checkReadOnly.Name = "checkReadOnly";
            this.checkReadOnly.Size = new System.Drawing.Size(141, 34);
            this.checkReadOnly.TabIndex = 0;
            this.checkReadOnly.Text = "読み取り";
            this.checkReadOnly.UseVisualStyleBackColor = true;
            // 
            // SumDetilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 874);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SumDetilForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "詳細";
            this.Load += new System.EventHandler(this.SumDetilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetil)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrice.ResumeLayout(false);
            this.tabPagePrice.PerformLayout();
            this.tabPageSetDetail.ResumeLayout(false);
            this.tabPageSetDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridViewDetil;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelSumPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTaxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSumTaxKomiPrice;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePrice;
        private System.Windows.Forms.TabPage tabPageSetDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkReadOnly;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
    }
}