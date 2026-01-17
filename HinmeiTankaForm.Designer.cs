namespace BillSystem
{
    partial class HinmeiTankaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewHinmei = new System.Windows.Forms.DataGridView();
            this.ColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHinmei)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewHinmei
            // 
            this.gridViewHinmei.AllowUserToAddRows = false;
            this.gridViewHinmei.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gridViewHinmei.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewHinmei.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewHinmei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHinmei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColYear,
            this.ColMonth,
            this.ColKind,
            this.ColNum,
            this.ColTanka,
            this.ColPrice});
            this.gridViewHinmei.Location = new System.Drawing.Point(10, 55);
            this.gridViewHinmei.MultiSelect = false;
            this.gridViewHinmei.Name = "gridViewHinmei";
            this.gridViewHinmei.RowHeadersWidth = 60;
            this.gridViewHinmei.RowTemplate.Height = 21;
            this.gridViewHinmei.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewHinmei.Size = new System.Drawing.Size(869, 484);
            this.gridViewHinmei.TabIndex = 0;
            this.gridViewHinmei.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewCompanySearch_RowPostPaint);
            // 
            // ColYear
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColYear.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColYear.Frozen = true;
            this.ColYear.HeaderText = "年";
            this.ColYear.Name = "ColYear";
            this.ColYear.ReadOnly = true;
            this.ColYear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColYear.Width = 80;
            // 
            // ColMonth
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColMonth.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColMonth.Frozen = true;
            this.ColMonth.HeaderText = "月";
            this.ColMonth.Name = "ColMonth";
            this.ColMonth.ReadOnly = true;
            this.ColMonth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColMonth.Width = 50;
            // 
            // ColKind
            // 
            this.ColKind.HeaderText = "種類";
            this.ColKind.Name = "ColKind";
            this.ColKind.ReadOnly = true;
            this.ColKind.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColKind.Width = 200;
            // 
            // ColNum
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColNum.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColNum.HeaderText = "数量";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            this.ColNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNum.Width = 150;
            // 
            // ColTanka
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColTanka.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColTanka.HeaderText = "単価";
            this.ColTanka.Name = "ColTanka";
            this.ColTanka.ReadOnly = true;
            this.ColTanka.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTanka.Width = 150;
            // 
            // ColPrice
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColPrice.HeaderText = "金額";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColPrice.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(360, 547);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(204, 75);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "閉じる";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(25, 19);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 24);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "品名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 542);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "※最大100行まで表示";
            // 
            // HinmeiTankaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(906, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gridViewHinmei);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "HinmeiTankaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "品名参照一覧";
            this.Load += new System.EventHandler(this.HinmeiTankaForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HinmeiTankaForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHinmei)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewHinmei;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.Label label1;
    }
}