namespace BillSystem
{
    partial class HinmeiSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HinmeiSearchForm));
            this.gridViewHinmeiSearch = new System.Windows.Forms.DataGridView();
            this.ColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.radioCode = new System.Windows.Forms.RadioButton();
            this.radioHinmei = new System.Windows.Forms.RadioButton();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.radioCode2 = new System.Windows.Forms.RadioButton();
            this.btnRujiSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnErease = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHinmeiSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewHinmeiSearch
            // 
            this.gridViewHinmeiSearch.AllowUserToAddRows = false;
            this.gridViewHinmeiSearch.AllowUserToDeleteRows = false;
            this.gridViewHinmeiSearch.AllowUserToOrderColumns = true;
            this.gridViewHinmeiSearch.AllowUserToResizeColumns = false;
            this.gridViewHinmeiSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gridViewHinmeiSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewHinmeiSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHinmeiSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCode,
            this.ColName});
            this.gridViewHinmeiSearch.Location = new System.Drawing.Point(13, 147);
            this.gridViewHinmeiSearch.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewHinmeiSearch.MultiSelect = false;
            this.gridViewHinmeiSearch.Name = "gridViewHinmeiSearch";
            this.gridViewHinmeiSearch.RowHeadersWidth = 70;
            this.gridViewHinmeiSearch.RowTemplate.Height = 21;
            this.gridViewHinmeiSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewHinmeiSearch.Size = new System.Drawing.Size(848, 728);
            this.gridViewHinmeiSearch.TabIndex = 0;
            this.gridViewHinmeiSearch.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewHinmeiSearch_RowPostPaint);
            this.gridViewHinmeiSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewHinmeiSearch_CellMouseDoubleClick);
            this.gridViewHinmeiSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridViewHinmeiSearch_KeyPress);
            // 
            // ColCode
            // 
            this.ColCode.Frozen = true;
            this.ColCode.HeaderText = "コード";
            this.ColCode.Name = "ColCode";
            this.ColCode.ReadOnly = true;
            this.ColCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCode.Width = 250;
            // 
            // ColName
            // 
            this.ColName.Frozen = true;
            this.ColName.HeaderText = "品名";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColName.Width = 500;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOK.Location = new System.Drawing.Point(183, 883);
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
            this.btnCancel.Location = new System.Drawing.Point(553, 883);
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
            this.textSearch.Location = new System.Drawing.Point(63, 45);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(483, 37);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(617, 37);
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
            this.radioCode.Location = new System.Drawing.Point(31, 3);
            this.radioCode.Margin = new System.Windows.Forms.Padding(4);
            this.radioCode.Name = "radioCode";
            this.radioCode.Size = new System.Drawing.Size(239, 34);
            this.radioCode.TabIndex = 5;
            this.radioCode.TabStop = true;
            this.radioCode.Text = "コード(前方一致)";
            this.radioCode.UseVisualStyleBackColor = true;
            // 
            // radioHinmei
            // 
            this.radioHinmei.AutoSize = true;
            this.radioHinmei.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioHinmei.Location = new System.Drawing.Point(401, 3);
            this.radioHinmei.Margin = new System.Windows.Forms.Padding(4);
            this.radioHinmei.Name = "radioHinmei";
            this.radioHinmei.Size = new System.Drawing.Size(94, 34);
            this.radioHinmei.TabIndex = 6;
            this.radioHinmei.TabStop = true;
            this.radioHinmei.Text = "品名";
            this.radioHinmei.UseVisualStyleBackColor = true;
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackColor = System.Drawing.Color.Black;
            this.btnSearchClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearchClear.ForeColor = System.Drawing.Color.White;
            this.btnSearchClear.Location = new System.Drawing.Point(553, 46);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(35, 38);
            this.btnSearchClear.TabIndex = 14;
            this.btnSearchClear.Text = "消";
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // radioCode2
            // 
            this.radioCode2.AutoSize = true;
            this.radioCode2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioCode2.Location = new System.Drawing.Point(278, 3);
            this.radioCode2.Margin = new System.Windows.Forms.Padding(4);
            this.radioCode2.Name = "radioCode2";
            this.radioCode2.Size = new System.Drawing.Size(101, 34);
            this.radioCode2.TabIndex = 16;
            this.radioCode2.TabStop = true;
            this.radioCode2.Text = "コード";
            this.radioCode2.UseVisualStyleBackColor = true;
            // 
            // btnRujiSearch
            // 
            this.btnRujiSearch.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRujiSearch.Location = new System.Drawing.Point(63, 89);
            this.btnRujiSearch.Name = "btnRujiSearch";
            this.btnRujiSearch.Size = new System.Drawing.Size(202, 51);
            this.btnRujiSearch.TabIndex = 17;
            this.btnRujiSearch.Text = "コード類似検索";
            this.btnRujiSearch.UseVisualStyleBackColor = true;
            this.btnRujiSearch.Click += new System.EventHandler(this.btnRujiSearch_Click);
            this.btnRujiSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRujiSearch_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnErease);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(300, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 51);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "末尾";
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownNum.Location = new System.Drawing.Point(72, 15);
            this.numericUpDownNum.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(51, 30);
            this.numericUpDownNum.TabIndex = 1;
            this.numericUpDownNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(129, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "桁を";
            // 
            // btnErease
            // 
            this.btnErease.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnErease.Location = new System.Drawing.Point(189, 13);
            this.btnErease.Name = "btnErease";
            this.btnErease.Size = new System.Drawing.Size(85, 34);
            this.btnErease.TabIndex = 3;
            this.btnErease.Text = "消す";
            this.btnErease.UseVisualStyleBackColor = true;
            this.btnErease.Click += new System.EventHandler(this.btnErease_Click);
            // 
            // HinmeiSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 956);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRujiSearch);
            this.Controls.Add(this.radioCode2);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.radioHinmei);
            this.Controls.Add(this.radioCode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gridViewHinmeiSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HinmeiSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "品名コード検索";
            this.Load += new System.EventHandler(this.HinmeiSearchForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HinmeiSearchForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHinmeiSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewHinmeiSearch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radioCode;
        private System.Windows.Forms.RadioButton radioHinmei;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.RadioButton radioCode2;
        private System.Windows.Forms.Button btnRujiSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnErease;
    }
}