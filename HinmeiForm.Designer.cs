namespace BillSystem
{
    partial class HinmeiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HinmeiForm));
            this.gridViewHinmei = new System.Windows.Forms.DataGridView();
            this.ColCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelFlg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColCompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.btnCompanyUpFormSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textCompany = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNameLouuer = new System.Windows.Forms.Button();
            this.btnNameUpper = new System.Windows.Forms.Button();
            this.checkDelFlg = new System.Windows.Forms.CheckBox();
            this.btnNameZenkaku = new System.Windows.Forms.Button();
            this.btnNameHankaku = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.radioCode = new System.Windows.Forms.RadioButton();
            this.radioHinmei = new System.Windows.Forms.RadioButton();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textCompanySearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.btnCompanySearchClear = new System.Windows.Forms.Button();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.labelCompanySearchName = new System.Windows.Forms.Label();
            this.btnCompanyFormUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHinmei)).BeginInit();
            this.gpInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupSearch.SuspendLayout();
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
            this.ColCompanyName,
            this.ColCode,
            this.ColName,
            this.ColDelFlg,
            this.ColCompanyCode});
            this.gridViewHinmei.Location = new System.Drawing.Point(10, 213);
            this.gridViewHinmei.MultiSelect = false;
            this.gridViewHinmei.Name = "gridViewHinmei";
            this.gridViewHinmei.RowHeadersWidth = 67;
            this.gridViewHinmei.RowTemplate.Height = 21;
            this.gridViewHinmei.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewHinmei.Size = new System.Drawing.Size(1104, 557);
            this.gridViewHinmei.TabIndex = 0;
            this.gridViewHinmei.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewHinmei_RowPostPaint);
            // 
            // ColCompanyName
            // 
            this.ColCompanyName.HeaderText = "会社名";
            this.ColCompanyName.Name = "ColCompanyName";
            this.ColCompanyName.Width = 180;
            // 
            // ColCode
            // 
            this.ColCode.HeaderText = "品名コード";
            this.ColCode.Name = "ColCode";
            this.ColCode.ReadOnly = true;
            this.ColCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCode.Width = 250;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "品名";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColName.Width = 500;
            // 
            // ColDelFlg
            // 
            this.ColDelFlg.HeaderText = "非表示";
            this.ColDelFlg.Name = "ColDelFlg";
            this.ColDelFlg.ReadOnly = true;
            this.ColDelFlg.Width = 90;
            // 
            // ColCompanyCode
            // 
            this.ColCompanyCode.HeaderText = "会社コード";
            this.ColCompanyCode.Name = "ColCompanyCode";
            this.ColCompanyCode.ReadOnly = true;
            this.ColCompanyCode.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDel.Location = new System.Drawing.Point(1246, 158);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 40);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "削除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpd.Location = new System.Drawing.Point(1371, 158);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(120, 40);
            this.btnUpd.TabIndex = 2;
            this.btnUpd.Text = "修正";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.Location = new System.Drawing.Point(1497, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新規追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpInfo
            // 
            this.gpInfo.BackColor = System.Drawing.Color.PaleGreen;
            this.gpInfo.Controls.Add(this.panel1);
            this.gpInfo.Controls.Add(this.panel2);
            this.gpInfo.Controls.Add(this.labelMode);
            this.gpInfo.Controls.Add(this.btnCancel);
            this.gpInfo.Controls.Add(this.btnCreate);
            this.gpInfo.Location = new System.Drawing.Point(1125, 213);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Size = new System.Drawing.Size(514, 445);
            this.gpInfo.TabIndex = 4;
            this.gpInfo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textCode);
            this.panel1.Controls.Add(this.labelCompanyName);
            this.panel1.Controls.Add(this.btnCompanyUpFormSet);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textCompany);
            this.panel1.Location = new System.Drawing.Point(14, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 131);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "(20文字以内)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(342, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "消";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(4, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "品名ｺｰﾄﾞ";
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textCode.Location = new System.Drawing.Point(116, 89);
            this.textCode.MaxLength = 20;
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(222, 31);
            this.textCode.TabIndex = 2;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompanyName.Location = new System.Drawing.Point(112, 49);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(66, 19);
            this.labelCompanyName.TabIndex = 9;
            this.labelCompanyName.Text = "会社名";
            // 
            // btnCompanyUpFormSet
            // 
            this.btnCompanyUpFormSet.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCompanyUpFormSet.Location = new System.Drawing.Point(205, 10);
            this.btnCompanyUpFormSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompanyUpFormSet.Name = "btnCompanyUpFormSet";
            this.btnCompanyUpFormSet.Size = new System.Drawing.Size(22, 32);
            this.btnCompanyUpFormSet.TabIndex = 8;
            this.btnCompanyUpFormSet.Text = "▲";
            this.btnCompanyUpFormSet.UseVisualStyleBackColor = true;
            this.btnCompanyUpFormSet.Click += new System.EventHandler(this.btnCompanyUpFormSet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "会社ｺｰﾄﾞ";
            // 
            // textCompany
            // 
            this.textCompany.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCompany.Location = new System.Drawing.Point(115, 10);
            this.textCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCompany.MaxLength = 5;
            this.textCompany.Name = "textCompany";
            this.textCompany.ReadOnly = true;
            this.textCompany.Size = new System.Drawing.Size(84, 31);
            this.textCompany.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNameLouuer);
            this.panel2.Controls.Add(this.btnNameUpper);
            this.panel2.Controls.Add(this.checkDelFlg);
            this.panel2.Controls.Add(this.btnNameZenkaku);
            this.panel2.Controls.Add(this.btnNameHankaku);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Location = new System.Drawing.Point(14, 194);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 162);
            this.panel2.TabIndex = 11;
            // 
            // btnNameLouuer
            // 
            this.btnNameLouuer.BackColor = System.Drawing.Color.Olive;
            this.btnNameLouuer.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameLouuer.ForeColor = System.Drawing.Color.White;
            this.btnNameLouuer.Location = new System.Drawing.Point(196, 54);
            this.btnNameLouuer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNameLouuer.Name = "btnNameLouuer";
            this.btnNameLouuer.Size = new System.Drawing.Size(75, 30);
            this.btnNameLouuer.TabIndex = 19;
            this.btnNameLouuer.Text = "小文字";
            this.btnNameLouuer.UseVisualStyleBackColor = false;
            this.btnNameLouuer.Click += new System.EventHandler(this.btnNameLouuer_Click);
            // 
            // btnNameUpper
            // 
            this.btnNameUpper.BackColor = System.Drawing.Color.Olive;
            this.btnNameUpper.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameUpper.ForeColor = System.Drawing.Color.White;
            this.btnNameUpper.Location = new System.Drawing.Point(116, 54);
            this.btnNameUpper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNameUpper.Name = "btnNameUpper";
            this.btnNameUpper.Size = new System.Drawing.Size(75, 30);
            this.btnNameUpper.TabIndex = 18;
            this.btnNameUpper.Text = "大文字";
            this.btnNameUpper.UseVisualStyleBackColor = false;
            this.btnNameUpper.Click += new System.EventHandler(this.btnNameUpper_Click);
            // 
            // checkDelFlg
            // 
            this.checkDelFlg.AutoSize = true;
            this.checkDelFlg.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkDelFlg.Location = new System.Drawing.Point(116, 110);
            this.checkDelFlg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkDelFlg.Name = "checkDelFlg";
            this.checkDelFlg.Size = new System.Drawing.Size(166, 23);
            this.checkDelFlg.TabIndex = 13;
            this.checkDelFlg.Text = "リストに表示しない";
            this.checkDelFlg.UseVisualStyleBackColor = true;
            // 
            // btnNameZenkaku
            // 
            this.btnNameZenkaku.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNameZenkaku.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameZenkaku.ForeColor = System.Drawing.Color.White;
            this.btnNameZenkaku.Location = new System.Drawing.Point(78, 54);
            this.btnNameZenkaku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNameZenkaku.Name = "btnNameZenkaku";
            this.btnNameZenkaku.Size = new System.Drawing.Size(26, 30);
            this.btnNameZenkaku.TabIndex = 18;
            this.btnNameZenkaku.Text = "全";
            this.btnNameZenkaku.UseVisualStyleBackColor = false;
            this.btnNameZenkaku.Click += new System.EventHandler(this.btnNameZenkaku_Click);
            // 
            // btnNameHankaku
            // 
            this.btnNameHankaku.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNameHankaku.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameHankaku.ForeColor = System.Drawing.Color.White;
            this.btnNameHankaku.Location = new System.Drawing.Point(47, 54);
            this.btnNameHankaku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNameHankaku.Name = "btnNameHankaku";
            this.btnNameHankaku.Size = new System.Drawing.Size(26, 30);
            this.btnNameHankaku.TabIndex = 17;
            this.btnNameHankaku.Text = "半";
            this.btnNameHankaku.UseVisualStyleBackColor = false;
            this.btnNameHankaku.Click += new System.EventHandler(this.btnNameHankaku_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(460, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(43, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "品名";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textName.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textName.Location = new System.Drawing.Point(116, 16);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(339, 31);
            this.textName.TabIndex = 3;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMode.ForeColor = System.Drawing.Color.Red;
            this.labelMode.Location = new System.Drawing.Point(400, 7);
            this.labelMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(116, 48);
            this.labelMode.TabIndex = 10;
            this.labelMode.Text = "追加";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(283, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 56);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCreate.Location = new System.Drawing.Point(92, 370);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 56);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "設定";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1469, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 72);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radioCode
            // 
            this.radioCode.AutoSize = true;
            this.radioCode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioCode.Location = new System.Drawing.Point(27, 106);
            this.radioCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioCode.Name = "radioCode";
            this.radioCode.Size = new System.Drawing.Size(82, 28);
            this.radioCode.TabIndex = 6;
            this.radioCode.TabStop = true;
            this.radioCode.Text = "コード";
            this.radioCode.UseVisualStyleBackColor = true;
            // 
            // radioHinmei
            // 
            this.radioHinmei.AutoSize = true;
            this.radioHinmei.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioHinmei.Location = new System.Drawing.Point(118, 106);
            this.radioHinmei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioHinmei.Name = "radioHinmei";
            this.radioHinmei.Size = new System.Drawing.Size(76, 28);
            this.radioHinmei.TabIndex = 7;
            this.radioHinmei.TabStop = true;
            this.radioHinmei.Text = "品名";
            this.radioHinmei.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSearch.Location = new System.Drawing.Point(118, 148);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(318, 31);
            this.textSearch.TabIndex = 8;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(536, 142);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textCompanySearch
            // 
            this.textCompanySearch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCompanySearch.Location = new System.Drawing.Point(145, 31);
            this.textCompanySearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCompanySearch.MaxLength = 5;
            this.textCompanySearch.Name = "textCompanySearch";
            this.textCompanySearch.Size = new System.Drawing.Size(92, 31);
            this.textCompanySearch.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(23, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "会社コード";
            // 
            // groupSearch
            // 
            this.groupSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupSearch.Controls.Add(this.btnCompanySearchClear);
            this.groupSearch.Controls.Add(this.btnSearchClear);
            this.groupSearch.Controls.Add(this.labelCompanySearchName);
            this.groupSearch.Controls.Add(this.btnCompanyFormUp);
            this.groupSearch.Controls.Add(this.label3);
            this.groupSearch.Controls.Add(this.btnSearch);
            this.groupSearch.Controls.Add(this.textCompanySearch);
            this.groupSearch.Controls.Add(this.textSearch);
            this.groupSearch.Controls.Add(this.radioCode);
            this.groupSearch.Controls.Add(this.radioHinmei);
            this.groupSearch.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupSearch.Location = new System.Drawing.Point(32, 10);
            this.groupSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupSearch.Size = new System.Drawing.Size(649, 198);
            this.groupSearch.TabIndex = 12;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "検索";
            // 
            // btnCompanySearchClear
            // 
            this.btnCompanySearchClear.BackColor = System.Drawing.Color.Black;
            this.btnCompanySearchClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCompanySearchClear.ForeColor = System.Drawing.Color.White;
            this.btnCompanySearchClear.Location = new System.Drawing.Point(268, 34);
            this.btnCompanySearchClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompanySearchClear.Name = "btnCompanySearchClear";
            this.btnCompanySearchClear.Size = new System.Drawing.Size(26, 30);
            this.btnCompanySearchClear.TabIndex = 15;
            this.btnCompanySearchClear.Text = "消";
            this.btnCompanySearchClear.UseVisualStyleBackColor = false;
            this.btnCompanySearchClear.Click += new System.EventHandler(this.btnCompanySearchClear_Click);
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackColor = System.Drawing.Color.Black;
            this.btnSearchClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearchClear.ForeColor = System.Drawing.Color.White;
            this.btnSearchClear.Location = new System.Drawing.Point(439, 149);
            this.btnSearchClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(26, 30);
            this.btnSearchClear.TabIndex = 14;
            this.btnSearchClear.Text = "消";
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // labelCompanySearchName
            // 
            this.labelCompanySearchName.AutoSize = true;
            this.labelCompanySearchName.Location = new System.Drawing.Point(142, 74);
            this.labelCompanySearchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompanySearchName.Name = "labelCompanySearchName";
            this.labelCompanySearchName.Size = new System.Drawing.Size(66, 19);
            this.labelCompanySearchName.TabIndex = 13;
            this.labelCompanySearchName.Text = "会社名";
            // 
            // btnCompanyFormUp
            // 
            this.btnCompanyFormUp.Location = new System.Drawing.Point(241, 31);
            this.btnCompanyFormUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompanyFormUp.Name = "btnCompanyFormUp";
            this.btnCompanyFormUp.Size = new System.Drawing.Size(22, 32);
            this.btnCompanyFormUp.TabIndex = 12;
            this.btnCompanyFormUp.Text = "▲";
            this.btnCompanyFormUp.UseVisualStyleBackColor = true;
            this.btnCompanyFormUp.Click += new System.EventHandler(this.btnCompanyFormUp_Click);
            // 
            // HinmeiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1660, 780);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.gridViewHinmei);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HinmeiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "品名登録";
            this.Load += new System.EventHandler(this.HinmeiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHinmei)).EndInit();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewHinmei;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radioCode;
        private System.Windows.Forms.RadioButton radioHinmei;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textCompanySearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.Button btnCompanyFormUp;
        private System.Windows.Forms.Label labelCompanySearchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompanyUpFormSet;
        private System.Windows.Forms.TextBox textCompany;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNameZenkaku;
        private System.Windows.Forms.Button btnNameHankaku;
        private System.Windows.Forms.CheckBox checkDelFlg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColDelFlg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCompanyCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompanySearchClear;
        private System.Windows.Forms.Button btnNameUpper;
        private System.Windows.Forms.Button btnNameLouuer;
    }
}