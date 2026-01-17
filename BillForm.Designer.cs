namespace BillSystem
{
    partial class BillForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.gridViewBill = new System.Windows.Forms.DataGridView();
            this.ColDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHinmei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHinmeiCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKindCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.panelAddLine = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkSounyu = new System.Windows.Forms.CheckBox();
            this.numericUpDownLine = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAtode = new System.Windows.Forms.Button();
            this.btnSanshow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textRemarks = new System.Windows.Forms.TextBox();
            this.btnRemarksClear = new System.Windows.Forms.Button();
            this.boxDay = new System.Windows.Forms.ComboBox();
            this.boxKind = new System.Windows.Forms.ComboBox();
            this.btnCompanySearch = new System.Windows.Forms.Button();
            this.labelKind = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.textCompanyCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHinmeiSearch = new System.Windows.Forms.Button();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHinmei = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRituClear = new System.Windows.Forms.Button();
            this.btnTankaClear = new System.Windows.Forms.Button();
            this.btnTemaClear = new System.Windows.Forms.Button();
            this.btnNumClear = new System.Windows.Forms.Button();
            this.textNum = new System.Windows.Forms.TextBox();
            this.radioTanka = new System.Windows.Forms.RadioButton();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelMode = new System.Windows.Forms.Label();
            this.textTanka = new System.Windows.Forms.TextBox();
            this.labelPriceMsg = new System.Windows.Forms.Label();
            this.checkRitu = new System.Windows.Forms.CheckBox();
            this.textRitu = new System.Windows.Forms.TextBox();
            this.labelPriceText = new System.Windows.Forms.Label();
            this.textTema = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.radioTema = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSumPrice = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.printBillData = new System.Drawing.Printing.PrintDocument();
            this.labelSelectCompanyName = new System.Windows.Forms.Label();
            this.labelHaneiMsg = new System.Windows.Forms.Label();
            this.timerMsg = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBill)).BeginInit();
            this.groupBoxSetting.SuspendLayout();
            this.panelAddLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLine)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.ColDay,
            this.ColCompany,
            this.ColHinmei,
            this.ColKind,
            this.ColRemarks,
            this.ColNum,
            this.ColTanka,
            this.ColPrice,
            this.ColOther,
            this.ColCompanyCode,
            this.ColHinmeiCode,
            this.ColKindCode,
            this.ColFlag});
            this.gridViewBill.Location = new System.Drawing.Point(39, 0);
            this.gridViewBill.MultiSelect = false;
            this.gridViewBill.Name = "gridViewBill";
            this.gridViewBill.RowHeadersWidth = 61;
            this.gridViewBill.RowTemplate.Height = 21;
            this.gridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewBill.Size = new System.Drawing.Size(1611, 445);
            this.gridViewBill.TabIndex = 0;
            this.gridViewBill.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewBill_RowPostPaint);
            // 
            // ColDay
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDay.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColDay.Frozen = true;
            this.ColDay.HeaderText = "日";
            this.ColDay.Name = "ColDay";
            this.ColDay.ReadOnly = true;
            this.ColDay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDay.Width = 55;
            // 
            // ColCompany
            // 
            this.ColCompany.Frozen = true;
            this.ColCompany.HeaderText = "会社名";
            this.ColCompany.Name = "ColCompany";
            this.ColCompany.ReadOnly = true;
            this.ColCompany.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCompany.Width = 200;
            // 
            // ColHinmei
            // 
            this.ColHinmei.Frozen = true;
            this.ColHinmei.HeaderText = "品名";
            this.ColHinmei.Name = "ColHinmei";
            this.ColHinmei.ReadOnly = true;
            this.ColHinmei.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHinmei.Width = 390;
            // 
            // ColKind
            // 
            this.ColKind.Frozen = true;
            this.ColKind.HeaderText = "種類";
            this.ColKind.Name = "ColKind";
            this.ColKind.ReadOnly = true;
            this.ColKind.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColKind.Width = 150;
            // 
            // ColRemarks
            // 
            this.ColRemarks.Frozen = true;
            this.ColRemarks.HeaderText = "備考";
            this.ColRemarks.Name = "ColRemarks";
            this.ColRemarks.ReadOnly = true;
            this.ColRemarks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColRemarks.Width = 300;
            // 
            // ColNum
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColNum.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColNum.Frozen = true;
            this.ColNum.HeaderText = "数量";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            this.ColNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNum.Width = 110;
            // 
            // ColTanka
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColTanka.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColTanka.Frozen = true;
            this.ColTanka.HeaderText = "単価";
            this.ColTanka.Name = "ColTanka";
            this.ColTanka.ReadOnly = true;
            this.ColTanka.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTanka.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTanka.Width = 120;
            // 
            // ColPrice
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColPrice.Frozen = true;
            this.ColPrice.HeaderText = "金額";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColPrice.Width = 130;
            // 
            // ColOther
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.NullValue = null;
            this.ColOther.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColOther.Frozen = true;
            this.ColOther.HeaderText = "才数";
            this.ColOther.Name = "ColOther";
            this.ColOther.ReadOnly = true;
            this.ColOther.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColOther.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColOther.Width = 80;
            // 
            // ColCompanyCode
            // 
            this.ColCompanyCode.HeaderText = "会社コード";
            this.ColCompanyCode.Name = "ColCompanyCode";
            this.ColCompanyCode.Visible = false;
            // 
            // ColHinmeiCode
            // 
            this.ColHinmeiCode.HeaderText = "品名コード";
            this.ColHinmeiCode.Name = "ColHinmeiCode";
            this.ColHinmeiCode.Visible = false;
            // 
            // ColKindCode
            // 
            this.ColKindCode.HeaderText = "種類コード";
            this.ColKindCode.Name = "ColKindCode";
            this.ColKindCode.Visible = false;
            // 
            // ColFlag
            // 
            this.ColFlag.HeaderText = "フラグ";
            this.ColFlag.Name = "ColFlag";
            this.ColFlag.Visible = false;
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.AutoSize = true;
            this.groupBoxSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(218)))));
            this.groupBoxSetting.Controls.Add(this.panelAddLine);
            this.groupBoxSetting.Controls.Add(this.panel2);
            this.groupBoxSetting.Controls.Add(this.panel1);
            this.groupBoxSetting.Controls.Add(this.btnCancel);
            this.groupBoxSetting.Controls.Add(this.btnSet);
            this.groupBoxSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxSetting.ForeColor = System.Drawing.Color.Black;
            this.groupBoxSetting.Location = new System.Drawing.Point(39, 515);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(1256, 466);
            this.groupBoxSetting.TabIndex = 1;
            this.groupBoxSetting.TabStop = false;
            // 
            // panelAddLine
            // 
            this.panelAddLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddLine.Controls.Add(this.label4);
            this.panelAddLine.Controls.Add(this.checkSounyu);
            this.panelAddLine.Controls.Add(this.numericUpDownLine);
            this.panelAddLine.Location = new System.Drawing.Point(27, 348);
            this.panelAddLine.Name = "panelAddLine";
            this.panelAddLine.Size = new System.Drawing.Size(151, 94);
            this.panelAddLine.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(96, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "行";
            // 
            // checkSounyu
            // 
            this.checkSounyu.AutoSize = true;
            this.checkSounyu.Location = new System.Drawing.Point(18, 13);
            this.checkSounyu.Name = "checkSounyu";
            this.checkSounyu.Size = new System.Drawing.Size(78, 17);
            this.checkSounyu.TabIndex = 70;
            this.checkSounyu.Text = "途中挿入";
            this.checkSounyu.UseVisualStyleBackColor = true;
            this.checkSounyu.CheckedChanged += new System.EventHandler(this.checkSounyu_CheckedChanged);
            // 
            // numericUpDownLine
            // 
            this.numericUpDownLine.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownLine.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numericUpDownLine.Location = new System.Drawing.Point(18, 49);
            this.numericUpDownLine.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLine.Name = "numericUpDownLine";
            this.numericUpDownLine.Size = new System.Drawing.Size(72, 26);
            this.numericUpDownLine.TabIndex = 71;
            this.numericUpDownLine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAtode);
            this.panel2.Controls.Add(this.btnSanshow);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textRemarks);
            this.panel2.Controls.Add(this.btnRemarksClear);
            this.panel2.Controls.Add(this.boxDay);
            this.panel2.Controls.Add(this.boxKind);
            this.panel2.Controls.Add(this.btnCompanySearch);
            this.panel2.Controls.Add(this.labelKind);
            this.panel2.Controls.Add(this.labelCompany);
            this.panel2.Controls.Add(this.textCompanyCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnHinmeiSearch);
            this.panel2.Controls.Add(this.textCode);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelHinmei);
            this.panel2.Location = new System.Drawing.Point(59, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 332);
            this.panel2.TabIndex = 69;
            // 
            // btnAtode
            // 
            this.btnAtode.BackColor = System.Drawing.Color.DarkRed;
            this.btnAtode.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAtode.ForeColor = System.Drawing.Color.White;
            this.btnAtode.Location = new System.Drawing.Point(400, 305);
            this.btnAtode.Name = "btnAtode";
            this.btnAtode.Size = new System.Drawing.Size(100, 25);
            this.btnAtode.TabIndex = 74;
            this.btnAtode.Text = "後で修正";
            this.btnAtode.UseVisualStyleBackColor = false;
            this.btnAtode.Click += new System.EventHandler(this.btnAtode_Click);
            // 
            // btnSanshow
            // 
            this.btnSanshow.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSanshow.Location = new System.Drawing.Point(453, 123);
            this.btnSanshow.Name = "btnSanshow";
            this.btnSanshow.Size = new System.Drawing.Size(110, 46);
            this.btnSanshow.TabIndex = 73;
            this.btnSanshow.Text = "以前を参照";
            this.btnSanshow.UseVisualStyleBackColor = true;
            this.btnSanshow.Click += new System.EventHandler(this.btnSanshow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(58, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 56;
            this.label3.Text = "日付";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(61, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 27);
            this.label9.TabIndex = 62;
            this.label9.Text = "備考";
            // 
            // textRemarks
            // 
            this.textRemarks.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textRemarks.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textRemarks.Location = new System.Drawing.Point(158, 265);
            this.textRemarks.Name = "textRemarks";
            this.textRemarks.Size = new System.Drawing.Size(365, 34);
            this.textRemarks.TabIndex = 64;
            // 
            // btnRemarksClear
            // 
            this.btnRemarksClear.BackColor = System.Drawing.Color.Black;
            this.btnRemarksClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemarksClear.ForeColor = System.Drawing.Color.White;
            this.btnRemarksClear.Location = new System.Drawing.Point(528, 267);
            this.btnRemarksClear.Name = "btnRemarksClear";
            this.btnRemarksClear.Size = new System.Drawing.Size(35, 38);
            this.btnRemarksClear.TabIndex = 68;
            this.btnRemarksClear.Text = "消";
            this.btnRemarksClear.UseVisualStyleBackColor = false;
            this.btnRemarksClear.Click += new System.EventHandler(this.btnRemarksClear_Click);
            // 
            // boxDay
            // 
            this.boxDay.DropDownHeight = 400;
            this.boxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDay.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.boxDay.FormattingEnabled = true;
            this.boxDay.IntegralHeight = false;
            this.boxDay.ItemHeight = 27;
            this.boxDay.Location = new System.Drawing.Point(158, 2);
            this.boxDay.Name = "boxDay";
            this.boxDay.Size = new System.Drawing.Size(62, 35);
            this.boxDay.TabIndex = 5;
            // 
            // boxKind
            // 
            this.boxKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxKind.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.boxKind.FormattingEnabled = true;
            this.boxKind.Location = new System.Drawing.Point(158, 209);
            this.boxKind.Name = "boxKind";
            this.boxKind.Size = new System.Drawing.Size(183, 34);
            this.boxKind.TabIndex = 66;
            this.boxKind.SelectedIndexChanged += new System.EventHandler(this.boxKind_SelectedIndexChanged);
            // 
            // btnCompanySearch
            // 
            this.btnCompanySearch.Location = new System.Drawing.Point(276, 48);
            this.btnCompanySearch.Name = "btnCompanySearch";
            this.btnCompanySearch.Size = new System.Drawing.Size(35, 35);
            this.btnCompanySearch.TabIndex = 67;
            this.btnCompanySearch.Text = "▲";
            this.btnCompanySearch.UseVisualStyleBackColor = true;
            this.btnCompanySearch.Click += new System.EventHandler(this.btnCompanySearch_Click);
            // 
            // labelKind
            // 
            this.labelKind.AutoSize = true;
            this.labelKind.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelKind.Location = new System.Drawing.Point(61, 209);
            this.labelKind.Name = "labelKind";
            this.labelKind.Size = new System.Drawing.Size(66, 27);
            this.labelKind.TabIndex = 61;
            this.labelKind.Text = "種類";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompany.Location = new System.Drawing.Point(155, 87);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(66, 19);
            this.labelCompany.TabIndex = 65;
            this.labelCompany.Text = "会社名";
            // 
            // textCompanyCode
            // 
            this.textCompanyCode.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCompanyCode.Location = new System.Drawing.Point(158, 49);
            this.textCompanyCode.MaxLength = 5;
            this.textCompanyCode.Name = "textCompanyCode";
            this.textCompanyCode.ReadOnly = true;
            this.textCompanyCode.Size = new System.Drawing.Size(113, 29);
            this.textCompanyCode.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 59;
            this.label2.Text = "会社ｺｰﾄﾞ";
            // 
            // btnHinmeiSearch
            // 
            this.btnHinmeiSearch.Location = new System.Drawing.Point(407, 128);
            this.btnHinmeiSearch.Name = "btnHinmeiSearch";
            this.btnHinmeiSearch.Size = new System.Drawing.Size(35, 35);
            this.btnHinmeiSearch.TabIndex = 7;
            this.btnHinmeiSearch.Text = "▲";
            this.btnHinmeiSearch.UseVisualStyleBackColor = true;
            this.btnHinmeiSearch.Click += new System.EventHandler(this.btnHinmeiSearch_Click);
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCode.Location = new System.Drawing.Point(158, 130);
            this.textCode.Name = "textCode";
            this.textCode.ReadOnly = true;
            this.textCode.Size = new System.Drawing.Size(244, 29);
            this.textCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "品名ｺｰﾄﾞ";
            // 
            // labelHinmei
            // 
            this.labelHinmei.AutoSize = true;
            this.labelHinmei.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHinmei.Location = new System.Drawing.Point(155, 169);
            this.labelHinmei.Name = "labelHinmei";
            this.labelHinmei.Size = new System.Drawing.Size(47, 19);
            this.labelHinmei.TabIndex = 55;
            this.labelHinmei.Text = "品名";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRituClear);
            this.panel1.Controls.Add(this.btnTankaClear);
            this.panel1.Controls.Add(this.btnTemaClear);
            this.panel1.Controls.Add(this.btnNumClear);
            this.panel1.Controls.Add(this.textNum);
            this.panel1.Controls.Add(this.radioTanka);
            this.panel1.Controls.Add(this.labelNum);
            this.panel1.Controls.Add(this.labelMode);
            this.panel1.Controls.Add(this.textTanka);
            this.panel1.Controls.Add(this.labelPriceMsg);
            this.panel1.Controls.Add(this.checkRitu);
            this.panel1.Controls.Add(this.textRitu);
            this.panel1.Controls.Add(this.labelPriceText);
            this.panel1.Controls.Add(this.textTema);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.radioTema);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(660, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 289);
            this.panel1.TabIndex = 60;
            // 
            // btnRituClear
            // 
            this.btnRituClear.BackColor = System.Drawing.Color.Black;
            this.btnRituClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRituClear.ForeColor = System.Drawing.Color.White;
            this.btnRituClear.Location = new System.Drawing.Point(501, 117);
            this.btnRituClear.Name = "btnRituClear";
            this.btnRituClear.Size = new System.Drawing.Size(35, 38);
            this.btnRituClear.TabIndex = 72;
            this.btnRituClear.Text = "消";
            this.btnRituClear.UseVisualStyleBackColor = false;
            this.btnRituClear.Click += new System.EventHandler(this.btnRituClear_Click);
            // 
            // btnTankaClear
            // 
            this.btnTankaClear.BackColor = System.Drawing.Color.Black;
            this.btnTankaClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTankaClear.ForeColor = System.Drawing.Color.White;
            this.btnTankaClear.Location = new System.Drawing.Point(205, 116);
            this.btnTankaClear.Name = "btnTankaClear";
            this.btnTankaClear.Size = new System.Drawing.Size(35, 38);
            this.btnTankaClear.TabIndex = 71;
            this.btnTankaClear.Text = "消";
            this.btnTankaClear.UseVisualStyleBackColor = false;
            this.btnTankaClear.Click += new System.EventHandler(this.btnTankaClear_Click);
            // 
            // btnTemaClear
            // 
            this.btnTemaClear.BackColor = System.Drawing.Color.Black;
            this.btnTemaClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTemaClear.ForeColor = System.Drawing.Color.White;
            this.btnTemaClear.Location = new System.Drawing.Point(205, 234);
            this.btnTemaClear.Name = "btnTemaClear";
            this.btnTemaClear.Size = new System.Drawing.Size(35, 38);
            this.btnTemaClear.TabIndex = 70;
            this.btnTemaClear.Text = "消";
            this.btnTemaClear.UseVisualStyleBackColor = false;
            this.btnTemaClear.Click += new System.EventHandler(this.btnTemaClear_Click);
            // 
            // btnNumClear
            // 
            this.btnNumClear.BackColor = System.Drawing.Color.Black;
            this.btnNumClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumClear.ForeColor = System.Drawing.Color.White;
            this.btnNumClear.Location = new System.Drawing.Point(230, 12);
            this.btnNumClear.Name = "btnNumClear";
            this.btnNumClear.Size = new System.Drawing.Size(35, 38);
            this.btnNumClear.TabIndex = 69;
            this.btnNumClear.Text = "消";
            this.btnNumClear.UseVisualStyleBackColor = false;
            this.btnNumClear.Click += new System.EventHandler(this.btnNumClear_Click);
            // 
            // textNum
            // 
            this.textNum.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textNum.Location = new System.Drawing.Point(108, 12);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(116, 34);
            this.textNum.TabIndex = 8;
            this.textNum.TextChanged += new System.EventHandler(this.textNum_TextChanged);
            this.textNum.Enter += new System.EventHandler(this.textNum_Enter);
            // 
            // radioTanka
            // 
            this.radioTanka.AutoSize = true;
            this.radioTanka.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioTanka.Location = new System.Drawing.Point(15, 73);
            this.radioTanka.Name = "radioTanka";
            this.radioTanka.Size = new System.Drawing.Size(124, 28);
            this.radioTanka.TabIndex = 9;
            this.radioTanka.TabStop = true;
            this.radioTanka.Text = "単価入力";
            this.radioTanka.UseVisualStyleBackColor = true;
            this.radioTanka.CheckedChanged += new System.EventHandler(this.radioTanka_CheckedChanged);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNum.Location = new System.Drawing.Point(9, 15);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(66, 27);
            this.labelNum.TabIndex = 54;
            this.labelNum.Text = "数量";
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMode.ForeColor = System.Drawing.Color.Red;
            this.labelMode.Location = new System.Drawing.Point(350, 10);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(116, 48);
            this.labelMode.TabIndex = 51;
            this.labelMode.Text = "追加";
            // 
            // textTanka
            // 
            this.textTanka.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textTanka.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textTanka.Location = new System.Drawing.Point(33, 115);
            this.textTanka.Name = "textTanka";
            this.textTanka.Size = new System.Drawing.Size(166, 34);
            this.textTanka.TabIndex = 10;
            this.textTanka.TextChanged += new System.EventHandler(this.textTanka_TextChanged);
            // 
            // labelPriceMsg
            // 
            this.labelPriceMsg.AutoSize = true;
            this.labelPriceMsg.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPriceMsg.ForeColor = System.Drawing.Color.Blue;
            this.labelPriceMsg.Location = new System.Drawing.Point(179, 83);
            this.labelPriceMsg.Name = "labelPriceMsg";
            this.labelPriceMsg.Size = new System.Drawing.Size(67, 15);
            this.labelPriceMsg.TabIndex = 50;
            this.labelPriceMsg.Text = "メッセージ";
            // 
            // checkRitu
            // 
            this.checkRitu.AutoSize = true;
            this.checkRitu.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkRitu.Location = new System.Drawing.Point(263, 117);
            this.checkRitu.Name = "checkRitu";
            this.checkRitu.Size = new System.Drawing.Size(77, 28);
            this.checkRitu.TabIndex = 11;
            this.checkRitu.Text = "才数";
            this.checkRitu.UseVisualStyleBackColor = true;
            this.checkRitu.CheckedChanged += new System.EventHandler(this.checkRitu_CheckedChanged);
            // 
            // textRitu
            // 
            this.textRitu.Enabled = false;
            this.textRitu.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textRitu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textRitu.Location = new System.Drawing.Point(356, 114);
            this.textRitu.Name = "textRitu";
            this.textRitu.Size = new System.Drawing.Size(140, 34);
            this.textRitu.TabIndex = 12;
            this.textRitu.TextChanged += new System.EventHandler(this.textRitu_TextChanged);
            // 
            // labelPriceText
            // 
            this.labelPriceText.AutoSize = true;
            this.labelPriceText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPriceText.Location = new System.Drawing.Point(285, 159);
            this.labelPriceText.Name = "labelPriceText";
            this.labelPriceText.Size = new System.Drawing.Size(58, 24);
            this.labelPriceText.TabIndex = 53;
            this.labelPriceText.Text = "合計";
            // 
            // textTema
            // 
            this.textTema.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textTema.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textTema.Location = new System.Drawing.Point(33, 231);
            this.textTema.Name = "textTema";
            this.textTema.Size = new System.Drawing.Size(166, 34);
            this.textTema.TabIndex = 14;
            this.textTema.TextChanged += new System.EventHandler(this.textTema_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPrice.Location = new System.Drawing.Point(356, 159);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(180, 30);
            this.labelPrice.TabIndex = 52;
            this.labelPrice.Text = "0";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioTema
            // 
            this.radioTema.AutoSize = true;
            this.radioTema.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioTema.Location = new System.Drawing.Point(15, 191);
            this.radioTema.Name = "radioTema";
            this.radioTema.Size = new System.Drawing.Size(148, 28);
            this.radioTema.TabIndex = 13;
            this.radioTema.TabStop = true;
            this.radioTema.Text = "手間代入力";
            this.radioTema.UseVisualStyleBackColor = true;
            this.radioTema.CheckedChanged += new System.EventHandler(this.radioTema_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(771, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 70);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSet.Location = new System.Drawing.Point(360, 362);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(200, 70);
            this.btnSet.TabIndex = 15;
            this.btnSet.Text = "反映";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDel.Location = new System.Drawing.Point(433, 451);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(130, 50);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "削除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpd.Location = new System.Drawing.Point(573, 451);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(130, 50);
            this.btnUpd.TabIndex = 3;
            this.btnUpd.Text = "修正";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.Location = new System.Drawing.Point(853, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.Location = new System.Drawing.Point(1442, 763);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 90);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1442, 867);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 90);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("ＭＳ ゴシック", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelYear.Location = new System.Drawing.Point(37, 445);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(97, 38);
            this.labelYear.TabIndex = 59;
            this.labelYear.Text = "2000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(150, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 29);
            this.label6.TabIndex = 60;
            this.label6.Text = "年";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("ＭＳ ゴシック", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMonth.Location = new System.Drawing.Point(212, 445);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(57, 38);
            this.labelMonth.TabIndex = 61;
            this.labelMonth.Text = "07";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ＭＳ ゴシック", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(288, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 29);
            this.label7.TabIndex = 62;
            this.label7.Text = "月";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrint.Location = new System.Drawing.Point(1442, 537);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(200, 70);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "印刷";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(1264, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "合計";
            // 
            // labelSumPrice
            // 
            this.labelSumPrice.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSumPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSumPrice.Location = new System.Drawing.Point(1351, 453);
            this.labelSumPrice.Name = "labelSumPrice";
            this.labelSumPrice.Size = new System.Drawing.Size(291, 48);
            this.labelSumPrice.TabIndex = 64;
            this.labelSumPrice.Text = "10000";
            this.labelSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.LightGreen;
            this.btnUp.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUp.Location = new System.Drawing.Point(4, 111);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(28, 80);
            this.btnUp.TabIndex = 20;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.LightGreen;
            this.btnDown.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDown.Location = new System.Drawing.Point(4, 197);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(28, 80);
            this.btnDown.TabIndex = 21;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // printBillData
            // 
            this.printBillData.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printBillData_PrintPage);
            // 
            // labelSelectCompanyName
            // 
            this.labelSelectCompanyName.AutoSize = true;
            this.labelSelectCompanyName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSelectCompanyName.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelSelectCompanyName.Location = new System.Drawing.Point(40, 487);
            this.labelSelectCompanyName.Name = "labelSelectCompanyName";
            this.labelSelectCompanyName.Size = new System.Drawing.Size(82, 24);
            this.labelSelectCompanyName.TabIndex = 66;
            this.labelSelectCompanyName.Text = "会社名";
            // 
            // labelHaneiMsg
            // 
            this.labelHaneiMsg.AutoSize = true;
            this.labelHaneiMsg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHaneiMsg.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelHaneiMsg.ForeColor = System.Drawing.Color.Red;
            this.labelHaneiMsg.Location = new System.Drawing.Point(635, 291);
            this.labelHaneiMsg.Name = "labelHaneiMsg";
            this.labelHaneiMsg.Size = new System.Drawing.Size(388, 64);
            this.labelHaneiMsg.TabIndex = 67;
            this.labelHaneiMsg.Text = "反映しました。";
            // 
            // timerMsg
            // 
            this.timerMsg.Interval = 2000;
            this.timerMsg.Tick += new System.EventHandler(this.timerMsg_Tick);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1654, 963);
            this.Controls.Add(this.labelHaneiMsg);
            this.Controls.Add(this.labelSelectCompanyName);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.labelSumPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.groupBoxSetting);
            this.Controls.Add(this.gridViewBill);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "請求書の作成";
            this.Load += new System.EventHandler(this.BillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBill)).EndInit();
            this.groupBoxSetting.ResumeLayout(false);
            this.panelAddLine.ResumeLayout(false);
            this.panelAddLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLine)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewBill;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Button btnHinmeiSearch;
        private System.Windows.Forms.ComboBox boxDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHinmei;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.RadioButton radioTema;
        private System.Windows.Forms.RadioButton radioTanka;
        private System.Windows.Forms.TextBox textTema;
        private System.Windows.Forms.TextBox textTanka;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPriceText;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textRitu;
        private System.Windows.Forms.CheckBox checkRitu;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSumPrice;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Drawing.Printing.PrintDocument printBillData;
        private System.Windows.Forms.Label labelPriceMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelKind;
        private System.Windows.Forms.TextBox textRemarks;
        private System.Windows.Forms.TextBox textCompanyCode;
        private System.Windows.Forms.ComboBox boxKind;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Button btnCompanySearch;
        private System.Windows.Forms.Button btnRemarksClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNumClear;
        private System.Windows.Forms.Button btnTemaClear;
        private System.Windows.Forms.Button btnTankaClear;
        private System.Windows.Forms.Button btnRituClear;
        private System.Windows.Forms.Label labelSelectCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAddLine;
        private System.Windows.Forms.NumericUpDown numericUpDownLine;
        private System.Windows.Forms.CheckBox checkSounyu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHinmei;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompanyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHinmeiCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKindCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFlag;
        private System.Windows.Forms.Label labelHaneiMsg;
        private System.Windows.Forms.Timer timerMsg;
        private System.Windows.Forms.Button btnSanshow;
        private System.Windows.Forms.Button btnAtode;
    }
}