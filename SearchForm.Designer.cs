namespace BillSystem
{
    partial class SearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.gridViewBill = new System.Windows.Forms.DataGridView();
            this.textSelCompanyCode = new System.Windows.Forms.TextBox();
            this.btnCompanyFormUp = new System.Windows.Forms.Button();
            this.labelSelCompanyName = new System.Windows.Forms.Label();
            this.btnCodeClear = new System.Windows.Forms.Button();
            this.boxMonth = new System.Windows.Forms.ComboBox();
            this.boxYear = new System.Windows.Forms.ComboBox();
            this.groupSelCompany = new System.Windows.Forms.GroupBox();
            this.checkSelCompany = new System.Windows.Forms.CheckBox();
            this.groupYear = new System.Windows.Forms.GroupBox();
            this.checkYear = new System.Windows.Forms.CheckBox();
            this.groupMonth = new System.Windows.Forms.GroupBox();
            this.checkMonth = new System.Windows.Forms.CheckBox();
            this.checkComHinmeiCode = new System.Windows.Forms.CheckBox();
            this.groupComHinmeiCode = new System.Windows.Forms.GroupBox();
            this.btnCodeClear3 = new System.Windows.Forms.Button();
            this.btnHinmeiFormUp = new System.Windows.Forms.Button();
            this.textHinmeiCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHinmei = new System.Windows.Forms.Label();
            this.btnCodeClear2 = new System.Windows.Forms.Button();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.btnCompanyFormUp2 = new System.Windows.Forms.Button();
            this.textCompanyCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupKind = new System.Windows.Forms.GroupBox();
            this.boxKind = new System.Windows.Forms.ComboBox();
            this.checkKind = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSelectCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHinmei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBill)).BeginInit();
            this.groupSelCompany.SuspendLayout();
            this.groupYear.SuspendLayout();
            this.groupMonth.SuspendLayout();
            this.groupComHinmeiCode.SuspendLayout();
            this.groupKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewBill
            // 
            this.gridViewBill.AllowUserToAddRows = false;
            this.gridViewBill.AllowUserToDeleteRows = false;
            this.gridViewBill.AllowUserToOrderColumns = true;
            this.gridViewBill.AllowUserToResizeColumns = false;
            this.gridViewBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gridViewBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewBill.ColumnHeadersHeight = 30;
            this.gridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColYear,
            this.ColMonth,
            this.ColSelectCompany,
            this.ColLine,
            this.ColDay,
            this.ColCompany,
            this.ColHinmei,
            this.ColKind,
            this.ColNum,
            this.ColTanka,
            this.ColPrice,
            this.ColOther,
            this.ColRemarks});
            this.gridViewBill.Location = new System.Drawing.Point(5, 279);
            this.gridViewBill.MultiSelect = false;
            this.gridViewBill.Name = "gridViewBill";
            this.gridViewBill.RowHeadersWidth = 61;
            this.gridViewBill.RowTemplate.Height = 21;
            this.gridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewBill.Size = new System.Drawing.Size(1642, 672);
            this.gridViewBill.TabIndex = 1;
            this.gridViewBill.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewBill_RowPostPaint);
            // 
            // textSelCompanyCode
            // 
            this.textSelCompanyCode.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSelCompanyCode.Location = new System.Drawing.Point(6, 18);
            this.textSelCompanyCode.MaxLength = 5;
            this.textSelCompanyCode.Name = "textSelCompanyCode";
            this.textSelCompanyCode.ReadOnly = true;
            this.textSelCompanyCode.Size = new System.Drawing.Size(100, 34);
            this.textSelCompanyCode.TabIndex = 17;
            // 
            // btnCompanyFormUp
            // 
            this.btnCompanyFormUp.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCompanyFormUp.Location = new System.Drawing.Point(112, 18);
            this.btnCompanyFormUp.Name = "btnCompanyFormUp";
            this.btnCompanyFormUp.Size = new System.Drawing.Size(30, 40);
            this.btnCompanyFormUp.TabIndex = 19;
            this.btnCompanyFormUp.Text = "▲";
            this.btnCompanyFormUp.UseVisualStyleBackColor = true;
            this.btnCompanyFormUp.Click += new System.EventHandler(this.btnCompanyFormUp_Click);
            // 
            // labelSelCompanyName
            // 
            this.labelSelCompanyName.AutoSize = true;
            this.labelSelCompanyName.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSelCompanyName.Location = new System.Drawing.Point(6, 55);
            this.labelSelCompanyName.Name = "labelSelCompanyName";
            this.labelSelCompanyName.Size = new System.Drawing.Size(72, 24);
            this.labelSelCompanyName.TabIndex = 20;
            this.labelSelCompanyName.Text = "その他";
            // 
            // btnCodeClear
            // 
            this.btnCodeClear.BackColor = System.Drawing.Color.Black;
            this.btnCodeClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCodeClear.ForeColor = System.Drawing.Color.White;
            this.btnCodeClear.Location = new System.Drawing.Point(148, 18);
            this.btnCodeClear.Name = "btnCodeClear";
            this.btnCodeClear.Size = new System.Drawing.Size(35, 38);
            this.btnCodeClear.TabIndex = 21;
            this.btnCodeClear.Text = "消";
            this.btnCodeClear.UseVisualStyleBackColor = false;
            this.btnCodeClear.Click += new System.EventHandler(this.btnCodeClear_Click);
            // 
            // boxMonth
            // 
            this.boxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.boxMonth.FormattingEnabled = true;
            this.boxMonth.Location = new System.Drawing.Point(24, 30);
            this.boxMonth.Name = "boxMonth";
            this.boxMonth.Size = new System.Drawing.Size(74, 38);
            this.boxMonth.TabIndex = 24;
            // 
            // boxYear
            // 
            this.boxYear.DropDownHeight = 300;
            this.boxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.boxYear.FormattingEnabled = true;
            this.boxYear.IntegralHeight = false;
            this.boxYear.Location = new System.Drawing.Point(20, 30);
            this.boxYear.Name = "boxYear";
            this.boxYear.Size = new System.Drawing.Size(98, 38);
            this.boxYear.TabIndex = 22;
            // 
            // groupSelCompany
            // 
            this.groupSelCompany.Controls.Add(this.btnCodeClear);
            this.groupSelCompany.Controls.Add(this.labelSelCompanyName);
            this.groupSelCompany.Controls.Add(this.btnCompanyFormUp);
            this.groupSelCompany.Controls.Add(this.textSelCompanyCode);
            this.groupSelCompany.Location = new System.Drawing.Point(336, 44);
            this.groupSelCompany.Name = "groupSelCompany";
            this.groupSelCompany.Size = new System.Drawing.Size(369, 85);
            this.groupSelCompany.TabIndex = 27;
            this.groupSelCompany.TabStop = false;
            // 
            // checkSelCompany
            // 
            this.checkSelCompany.AutoSize = true;
            this.checkSelCompany.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkSelCompany.Location = new System.Drawing.Point(336, 12);
            this.checkSelCompany.Name = "checkSelCompany";
            this.checkSelCompany.Size = new System.Drawing.Size(292, 32);
            this.checkSelCompany.TabIndex = 28;
            this.checkSelCompany.Text = "請求書単位会社コード";
            this.checkSelCompany.UseVisualStyleBackColor = true;
            this.checkSelCompany.CheckedChanged += new System.EventHandler(this.checkSelCompany_CheckedChanged);
            // 
            // groupYear
            // 
            this.groupYear.Controls.Add(this.boxYear);
            this.groupYear.Location = new System.Drawing.Point(31, 44);
            this.groupYear.Name = "groupYear";
            this.groupYear.Size = new System.Drawing.Size(157, 85);
            this.groupYear.TabIndex = 29;
            this.groupYear.TabStop = false;
            // 
            // checkYear
            // 
            this.checkYear.AutoSize = true;
            this.checkYear.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkYear.Location = new System.Drawing.Point(31, 12);
            this.checkYear.Name = "checkYear";
            this.checkYear.Size = new System.Drawing.Size(62, 32);
            this.checkYear.TabIndex = 30;
            this.checkYear.Text = "年";
            this.checkYear.UseVisualStyleBackColor = true;
            this.checkYear.CheckedChanged += new System.EventHandler(this.checkYear_CheckedChanged);
            // 
            // groupMonth
            // 
            this.groupMonth.Controls.Add(this.boxMonth);
            this.groupMonth.Location = new System.Drawing.Point(203, 44);
            this.groupMonth.Name = "groupMonth";
            this.groupMonth.Size = new System.Drawing.Size(127, 85);
            this.groupMonth.TabIndex = 31;
            this.groupMonth.TabStop = false;
            // 
            // checkMonth
            // 
            this.checkMonth.AutoSize = true;
            this.checkMonth.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkMonth.Location = new System.Drawing.Point(203, 12);
            this.checkMonth.Name = "checkMonth";
            this.checkMonth.Size = new System.Drawing.Size(62, 32);
            this.checkMonth.TabIndex = 32;
            this.checkMonth.Text = "月";
            this.checkMonth.UseVisualStyleBackColor = true;
            this.checkMonth.CheckedChanged += new System.EventHandler(this.checkMonth_CheckedChanged);
            // 
            // checkComHinmeiCode
            // 
            this.checkComHinmeiCode.AutoSize = true;
            this.checkComHinmeiCode.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkComHinmeiCode.Location = new System.Drawing.Point(31, 149);
            this.checkComHinmeiCode.Name = "checkComHinmeiCode";
            this.checkComHinmeiCode.Size = new System.Drawing.Size(227, 32);
            this.checkComHinmeiCode.TabIndex = 33;
            this.checkComHinmeiCode.Text = "会社、品名コード";
            this.checkComHinmeiCode.UseVisualStyleBackColor = true;
            this.checkComHinmeiCode.CheckedChanged += new System.EventHandler(this.checkComHinmeiCode_CheckedChanged);
            // 
            // groupComHinmeiCode
            // 
            this.groupComHinmeiCode.Controls.Add(this.btnCodeClear3);
            this.groupComHinmeiCode.Controls.Add(this.btnHinmeiFormUp);
            this.groupComHinmeiCode.Controls.Add(this.textHinmeiCode);
            this.groupComHinmeiCode.Controls.Add(this.label3);
            this.groupComHinmeiCode.Controls.Add(this.labelHinmei);
            this.groupComHinmeiCode.Controls.Add(this.btnCodeClear2);
            this.groupComHinmeiCode.Controls.Add(this.labelCompanyName);
            this.groupComHinmeiCode.Controls.Add(this.btnCompanyFormUp2);
            this.groupComHinmeiCode.Controls.Add(this.textCompanyCode);
            this.groupComHinmeiCode.Controls.Add(this.label2);
            this.groupComHinmeiCode.Location = new System.Drawing.Point(31, 183);
            this.groupComHinmeiCode.Name = "groupComHinmeiCode";
            this.groupComHinmeiCode.Size = new System.Drawing.Size(894, 85);
            this.groupComHinmeiCode.TabIndex = 34;
            this.groupComHinmeiCode.TabStop = false;
            // 
            // btnCodeClear3
            // 
            this.btnCodeClear3.BackColor = System.Drawing.Color.Black;
            this.btnCodeClear3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCodeClear3.ForeColor = System.Drawing.Color.White;
            this.btnCodeClear3.Location = new System.Drawing.Point(788, 15);
            this.btnCodeClear3.Name = "btnCodeClear3";
            this.btnCodeClear3.Size = new System.Drawing.Size(35, 38);
            this.btnCodeClear3.TabIndex = 70;
            this.btnCodeClear3.Text = "消";
            this.btnCodeClear3.UseVisualStyleBackColor = false;
            this.btnCodeClear3.Click += new System.EventHandler(this.btnCodeClear3_Click);
            // 
            // btnHinmeiFormUp
            // 
            this.btnHinmeiFormUp.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHinmeiFormUp.Location = new System.Drawing.Point(752, 14);
            this.btnHinmeiFormUp.Name = "btnHinmeiFormUp";
            this.btnHinmeiFormUp.Size = new System.Drawing.Size(30, 40);
            this.btnHinmeiFormUp.TabIndex = 69;
            this.btnHinmeiFormUp.Text = "▲";
            this.btnHinmeiFormUp.UseVisualStyleBackColor = true;
            this.btnHinmeiFormUp.Click += new System.EventHandler(this.btnHinmeiFormUp_Click);
            // 
            // textHinmeiCode
            // 
            this.textHinmeiCode.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textHinmeiCode.Location = new System.Drawing.Point(502, 15);
            this.textHinmeiCode.Name = "textHinmeiCode";
            this.textHinmeiCode.ReadOnly = true;
            this.textHinmeiCode.Size = new System.Drawing.Size(244, 34);
            this.textHinmeiCode.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(376, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 68;
            this.label3.Text = "品名ｺｰﾄﾞ";
            // 
            // labelHinmei
            // 
            this.labelHinmei.AutoSize = true;
            this.labelHinmei.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHinmei.Location = new System.Drawing.Point(498, 52);
            this.labelHinmei.Name = "labelHinmei";
            this.labelHinmei.Size = new System.Drawing.Size(58, 24);
            this.labelHinmei.TabIndex = 67;
            this.labelHinmei.Text = "品名";
            // 
            // btnCodeClear2
            // 
            this.btnCodeClear2.BackColor = System.Drawing.Color.Black;
            this.btnCodeClear2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCodeClear2.ForeColor = System.Drawing.Color.White;
            this.btnCodeClear2.Location = new System.Drawing.Point(275, 15);
            this.btnCodeClear2.Name = "btnCodeClear2";
            this.btnCodeClear2.Size = new System.Drawing.Size(35, 38);
            this.btnCodeClear2.TabIndex = 64;
            this.btnCodeClear2.Text = "消";
            this.btnCodeClear2.UseVisualStyleBackColor = false;
            this.btnCodeClear2.Click += new System.EventHandler(this.btnCodeClear2_Click);
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompanyName.Location = new System.Drawing.Point(128, 52);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(72, 24);
            this.labelCompanyName.TabIndex = 63;
            this.labelCompanyName.Text = "その他";
            // 
            // btnCompanyFormUp2
            // 
            this.btnCompanyFormUp2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCompanyFormUp2.Location = new System.Drawing.Point(239, 15);
            this.btnCompanyFormUp2.Name = "btnCompanyFormUp2";
            this.btnCompanyFormUp2.Size = new System.Drawing.Size(30, 40);
            this.btnCompanyFormUp2.TabIndex = 62;
            this.btnCompanyFormUp2.Text = "▲";
            this.btnCompanyFormUp2.UseVisualStyleBackColor = true;
            this.btnCompanyFormUp2.Click += new System.EventHandler(this.btnCompanyFormUp2_Click);
            // 
            // textCompanyCode
            // 
            this.textCompanyCode.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCompanyCode.Location = new System.Drawing.Point(133, 15);
            this.textCompanyCode.MaxLength = 5;
            this.textCompanyCode.Name = "textCompanyCode";
            this.textCompanyCode.ReadOnly = true;
            this.textCompanyCode.Size = new System.Drawing.Size(100, 34);
            this.textCompanyCode.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "会社ｺｰﾄﾞ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(1170, 178);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 90);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupKind
            // 
            this.groupKind.Controls.Add(this.boxKind);
            this.groupKind.Location = new System.Drawing.Point(931, 183);
            this.groupKind.Name = "groupKind";
            this.groupKind.Size = new System.Drawing.Size(221, 85);
            this.groupKind.TabIndex = 36;
            this.groupKind.TabStop = false;
            // 
            // boxKind
            // 
            this.boxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxKind.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.boxKind.FormattingEnabled = true;
            this.boxKind.Location = new System.Drawing.Point(18, 26);
            this.boxKind.Name = "boxKind";
            this.boxKind.Size = new System.Drawing.Size(183, 41);
            this.boxKind.TabIndex = 67;
            // 
            // checkKind
            // 
            this.checkKind.AutoSize = true;
            this.checkKind.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkKind.Location = new System.Drawing.Point(931, 149);
            this.checkKind.Name = "checkKind";
            this.checkKind.Size = new System.Drawing.Size(90, 32);
            this.checkKind.TabIndex = 37;
            this.checkKind.Text = "種類";
            this.checkKind.UseVisualStyleBackColor = true;
            this.checkKind.CheckedChanged += new System.EventHandler(this.checkKind_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1447, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 90);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.ColYear.Width = 60;
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
            this.ColMonth.Width = 45;
            // 
            // ColSelectCompany
            // 
            this.ColSelectCompany.Frozen = true;
            this.ColSelectCompany.HeaderText = "請求書単位会社名";
            this.ColSelectCompany.Name = "ColSelectCompany";
            this.ColSelectCompany.ReadOnly = true;
            this.ColSelectCompany.Width = 210;
            // 
            // ColLine
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColLine.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColLine.Frozen = true;
            this.ColLine.HeaderText = "行";
            this.ColLine.Name = "ColLine";
            this.ColLine.ReadOnly = true;
            this.ColLine.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColLine.Width = 55;
            // 
            // ColDay
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDay.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColDay.Frozen = true;
            this.ColDay.HeaderText = "日";
            this.ColDay.Name = "ColDay";
            this.ColDay.ReadOnly = true;
            this.ColDay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDay.Width = 45;
            // 
            // ColCompany
            // 
            this.ColCompany.Frozen = true;
            this.ColCompany.HeaderText = "会社名";
            this.ColCompany.Name = "ColCompany";
            this.ColCompany.ReadOnly = true;
            this.ColCompany.Width = 210;
            // 
            // ColHinmei
            // 
            this.ColHinmei.Frozen = true;
            this.ColHinmei.HeaderText = "品名";
            this.ColHinmei.Name = "ColHinmei";
            this.ColHinmei.ReadOnly = true;
            this.ColHinmei.Width = 370;
            // 
            // ColKind
            // 
            this.ColKind.Frozen = true;
            this.ColKind.HeaderText = "種類";
            this.ColKind.Name = "ColKind";
            this.ColKind.ReadOnly = true;
            // 
            // ColNum
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.NullValue = null;
            this.ColNum.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColNum.HeaderText = "数量";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            this.ColNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNum.Width = 110;
            // 
            // ColTanka
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColTanka.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColTanka.HeaderText = "単価";
            this.ColTanka.Name = "ColTanka";
            this.ColTanka.ReadOnly = true;
            this.ColTanka.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTanka.Width = 120;
            // 
            // ColPrice
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColPrice.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColPrice.HeaderText = "金額";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColPrice.Width = 130;
            // 
            // ColOther
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.NullValue = null;
            this.ColOther.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColOther.HeaderText = "才数";
            this.ColOther.Name = "ColOther";
            this.ColOther.ReadOnly = true;
            this.ColOther.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColOther.Width = 80;
            // 
            // ColRemarks
            // 
            this.ColRemarks.HeaderText = "備考";
            this.ColRemarks.Name = "ColRemarks";
            this.ColRemarks.ReadOnly = true;
            this.ColRemarks.Width = 270;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1654, 963);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkKind);
            this.Controls.Add(this.groupKind);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupComHinmeiCode);
            this.Controls.Add(this.checkComHinmeiCode);
            this.Controls.Add(this.checkMonth);
            this.Controls.Add(this.groupMonth);
            this.Controls.Add(this.checkYear);
            this.Controls.Add(this.groupYear);
            this.Controls.Add(this.checkSelCompany);
            this.Controls.Add(this.groupSelCompany);
            this.Controls.Add(this.gridViewBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "検索画面";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBill)).EndInit();
            this.groupSelCompany.ResumeLayout(false);
            this.groupSelCompany.PerformLayout();
            this.groupYear.ResumeLayout(false);
            this.groupMonth.ResumeLayout(false);
            this.groupComHinmeiCode.ResumeLayout(false);
            this.groupComHinmeiCode.PerformLayout();
            this.groupKind.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewBill;
        private System.Windows.Forms.TextBox textSelCompanyCode;
        private System.Windows.Forms.Button btnCompanyFormUp;
        private System.Windows.Forms.Label labelSelCompanyName;
        private System.Windows.Forms.Button btnCodeClear;
        private System.Windows.Forms.ComboBox boxMonth;
        private System.Windows.Forms.ComboBox boxYear;
        private System.Windows.Forms.CheckBox checkSelCompany;
        private System.Windows.Forms.GroupBox groupSelCompany;
        private System.Windows.Forms.GroupBox groupYear;
        private System.Windows.Forms.CheckBox checkYear;
        private System.Windows.Forms.GroupBox groupMonth;
        private System.Windows.Forms.CheckBox checkMonth;
        private System.Windows.Forms.CheckBox checkComHinmeiCode;
        private System.Windows.Forms.GroupBox groupComHinmeiCode;
        private System.Windows.Forms.Button btnCodeClear2;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button btnCompanyFormUp2;
        private System.Windows.Forms.TextBox textCompanyCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCodeClear3;
        private System.Windows.Forms.Button btnHinmeiFormUp;
        private System.Windows.Forms.TextBox textHinmeiCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHinmei;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupKind;
        private System.Windows.Forms.ComboBox boxKind;
        private System.Windows.Forms.CheckBox checkKind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSelectCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHinmei;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarks;
    }
}