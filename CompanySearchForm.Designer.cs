namespace BillSystem
{
    partial class CompanySearchForm
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
            this.gridViewCompanySearch = new System.Windows.Forms.DataGridView();
            this.ColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioCode = new System.Windows.Forms.RadioButton();
            this.radioName = new System.Windows.Forms.RadioButton();
            this.btnSearchClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompanySearch)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewCompanySearch
            // 
            this.gridViewCompanySearch.AllowUserToAddRows = false;
            this.gridViewCompanySearch.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gridViewCompanySearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewCompanySearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCompanySearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCode,
            this.ColName});
            this.gridViewCompanySearch.Location = new System.Drawing.Point(31, 108);
            this.gridViewCompanySearch.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewCompanySearch.MultiSelect = false;
            this.gridViewCompanySearch.Name = "gridViewCompanySearch";
            this.gridViewCompanySearch.RowHeadersWidth = 60;
            this.gridViewCompanySearch.RowTemplate.Height = 21;
            this.gridViewCompanySearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCompanySearch.Size = new System.Drawing.Size(736, 672);
            this.gridViewCompanySearch.TabIndex = 0;
            this.gridViewCompanySearch.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewCompanySearch_RowPostPaint);
            this.gridViewCompanySearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewCompanySearch_CellMouseDoubleClick);
            this.gridViewCompanySearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridViewCompanySearch_KeyPress);
            // 
            // ColCode
            // 
            this.ColCode.Frozen = true;
            this.ColCode.HeaderText = "コード";
            this.ColCode.Name = "ColCode";
            this.ColCode.ReadOnly = true;
            this.ColCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCode.Width = 200;
            // 
            // ColName
            // 
            this.ColName.Frozen = true;
            this.ColName.HeaderText = "会社名";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColName.Width = 600;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOK.Location = new System.Drawing.Point(200, 811);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 50);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "選択";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(447, 811);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "閉じる";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSearch.Location = new System.Drawing.Point(63, 57);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(482, 37);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(617, 49);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // radioCode
            // 
            this.radioCode.AutoSize = true;
            this.radioCode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioCode.Location = new System.Drawing.Point(31, 15);
            this.radioCode.Margin = new System.Windows.Forms.Padding(4);
            this.radioCode.Name = "radioCode";
            this.radioCode.Size = new System.Drawing.Size(101, 34);
            this.radioCode.TabIndex = 5;
            this.radioCode.TabStop = true;
            this.radioCode.Text = "コード";
            this.radioCode.UseVisualStyleBackColor = true;
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioName.Location = new System.Drawing.Point(153, 15);
            this.radioName.Margin = new System.Windows.Forms.Padding(4);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(124, 34);
            this.radioName.TabIndex = 6;
            this.radioName.TabStop = true;
            this.radioName.Text = "会社名";
            this.radioName.UseVisualStyleBackColor = true;
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackColor = System.Drawing.Color.Black;
            this.btnSearchClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearchClear.ForeColor = System.Drawing.Color.White;
            this.btnSearchClear.Location = new System.Drawing.Point(552, 57);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(35, 38);
            this.btnSearchClear.TabIndex = 13;
            this.btnSearchClear.Text = "消";
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // CompanySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 891);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.radioName);
            this.Controls.Add(this.radioCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gridViewCompanySearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompanySearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会社コード検索";
            this.Load += new System.EventHandler(this.CompanySearchForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CompanySearchForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompanySearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewCompanySearch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioCode;
        private System.Windows.Forms.RadioButton radioName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.Button btnSearchClear;
    }
}