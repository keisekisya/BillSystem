namespace BillSystem
{
    partial class CompanyForm
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
            this.gridViewCompany = new System.Windows.Forms.DataGridView();
            this.ColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelFlg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNameZenkaku = new System.Windows.Forms.Button();
            this.btnNameHankaku = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.btnNameClear = new System.Windows.Forms.Button();
            this.checkDelFlg = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCodeClear = new System.Windows.Forms.Button();
            this.textCode = new System.Windows.Forms.TextBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.radioCode = new System.Windows.Forms.RadioButton();
            this.radioHinmei = new System.Windows.Forms.RadioButton();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
            this.gpInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewCompany
            // 
            this.gridViewCompany.AllowUserToAddRows = false;
            this.gridViewCompany.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gridViewCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCode,
            this.ColName,
            this.ColDelFlg});
            this.gridViewCompany.Location = new System.Drawing.Point(16, 201);
            this.gridViewCompany.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewCompany.MultiSelect = false;
            this.gridViewCompany.Name = "gridViewCompany";
            this.gridViewCompany.RowTemplate.Height = 21;
            this.gridViewCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCompany.Size = new System.Drawing.Size(760, 744);
            this.gridViewCompany.TabIndex = 0;
            this.gridViewCompany.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewHinmei_RowPostPaint);
            // 
            // ColCode
            // 
            this.ColCode.Frozen = true;
            this.ColCode.HeaderText = "コード";
            this.ColCode.Name = "ColCode";
            this.ColCode.ReadOnly = true;
            this.ColCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColName
            // 
            this.ColName.Frozen = true;
            this.ColName.HeaderText = "会社名";
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
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDel.Location = new System.Drawing.Point(1126, 143);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(160, 50);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "削除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnUpd.Location = new System.Drawing.Point(1294, 143);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(160, 50);
            this.btnUpd.TabIndex = 2;
            this.btnUpd.Text = "修正";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.Location = new System.Drawing.Point(1462, 143);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新規追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gpInfo
            // 
            this.gpInfo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.gpInfo.Controls.Add(this.panel2);
            this.gpInfo.Controls.Add(this.panel1);
            this.gpInfo.Controls.Add(this.labelMode);
            this.gpInfo.Controls.Add(this.btnCancel);
            this.gpInfo.Controls.Add(this.btnCreate);
            this.gpInfo.Location = new System.Drawing.Point(820, 201);
            this.gpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gpInfo.Size = new System.Drawing.Size(802, 459);
            this.gpInfo.TabIndex = 4;
            this.gpInfo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnNameZenkaku);
            this.panel2.Controls.Add(this.btnNameHankaku);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Controls.Add(this.btnNameClear);
            this.panel2.Controls.Add(this.checkDelFlg);
            this.panel2.Location = new System.Drawing.Point(14, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 158);
            this.panel2.TabIndex = 13;
            // 
            // btnNameZenkaku
            // 
            this.btnNameZenkaku.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNameZenkaku.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameZenkaku.ForeColor = System.Drawing.Color.White;
            this.btnNameZenkaku.Location = new System.Drawing.Point(80, 56);
            this.btnNameZenkaku.Name = "btnNameZenkaku";
            this.btnNameZenkaku.Size = new System.Drawing.Size(35, 38);
            this.btnNameZenkaku.TabIndex = 19;
            this.btnNameZenkaku.Text = "全";
            this.btnNameZenkaku.UseVisualStyleBackColor = false;
            this.btnNameZenkaku.Click += new System.EventHandler(this.btnNameZenkaku_Click);
            // 
            // btnNameHankaku
            // 
            this.btnNameHankaku.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNameHankaku.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameHankaku.ForeColor = System.Drawing.Color.White;
            this.btnNameHankaku.Location = new System.Drawing.Point(39, 56);
            this.btnNameHankaku.Name = "btnNameHankaku";
            this.btnNameHankaku.Size = new System.Drawing.Size(35, 38);
            this.btnNameHankaku.TabIndex = 18;
            this.btnNameHankaku.Text = "半";
            this.btnNameHankaku.UseVisualStyleBackColor = false;
            this.btnNameHankaku.Click += new System.EventHandler(this.btnNameHankaku_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "会社名";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textName.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.textName.Location = new System.Drawing.Point(126, 4);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.MaxLength = 50;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(552, 37);
            this.textName.TabIndex = 3;
            // 
            // btnNameClear
            // 
            this.btnNameClear.BackColor = System.Drawing.Color.Black;
            this.btnNameClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameClear.ForeColor = System.Drawing.Color.White;
            this.btnNameClear.Location = new System.Drawing.Point(685, 5);
            this.btnNameClear.Name = "btnNameClear";
            this.btnNameClear.Size = new System.Drawing.Size(35, 38);
            this.btnNameClear.TabIndex = 11;
            this.btnNameClear.Text = "消";
            this.btnNameClear.UseVisualStyleBackColor = false;
            this.btnNameClear.Click += new System.EventHandler(this.btnNameClear_Click);
            // 
            // checkDelFlg
            // 
            this.checkDelFlg.AutoSize = true;
            this.checkDelFlg.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkDelFlg.Location = new System.Drawing.Point(126, 114);
            this.checkDelFlg.Name = "checkDelFlg";
            this.checkDelFlg.Size = new System.Drawing.Size(206, 28);
            this.checkDelFlg.TabIndex = 6;
            this.checkDelFlg.Text = "リストに表示しない";
            this.checkDelFlg.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCodeClear);
            this.panel1.Controls.Add(this.textCode);
            this.panel1.Location = new System.Drawing.Point(14, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 81);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "コード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "(5文字以内)";
            // 
            // btnCodeClear
            // 
            this.btnCodeClear.BackColor = System.Drawing.Color.Black;
            this.btnCodeClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCodeClear.ForeColor = System.Drawing.Color.White;
            this.btnCodeClear.Location = new System.Drawing.Point(256, 12);
            this.btnCodeClear.Name = "btnCodeClear";
            this.btnCodeClear.Size = new System.Drawing.Size(35, 38);
            this.btnCodeClear.TabIndex = 9;
            this.btnCodeClear.Text = "消";
            this.btnCodeClear.UseVisualStyleBackColor = false;
            this.btnCodeClear.Click += new System.EventHandler(this.btnCodeClear_Click);
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textCode.Location = new System.Drawing.Point(126, 13);
            this.textCode.Margin = new System.Windows.Forms.Padding(4);
            this.textCode.MaxLength = 5;
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(114, 37);
            this.textCode.TabIndex = 2;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMode.ForeColor = System.Drawing.Color.Gold;
            this.labelMode.Location = new System.Drawing.Point(632, 26);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(145, 60);
            this.labelMode.TabIndex = 8;
            this.labelMode.Text = "追加";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(452, 355);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 70);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCreate.Location = new System.Drawing.Point(146, 355);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 70);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "設定";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(1422, 855);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 90);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // radioCode
            // 
            this.radioCode.AutoSize = true;
            this.radioCode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioCode.Location = new System.Drawing.Point(22, 40);
            this.radioCode.Name = "radioCode";
            this.radioCode.Size = new System.Drawing.Size(101, 34);
            this.radioCode.TabIndex = 6;
            this.radioCode.TabStop = true;
            this.radioCode.Text = "コード";
            this.radioCode.UseVisualStyleBackColor = true;
            // 
            // radioHinmei
            // 
            this.radioHinmei.AutoSize = true;
            this.radioHinmei.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioHinmei.Location = new System.Drawing.Point(129, 40);
            this.radioHinmei.Name = "radioHinmei";
            this.radioHinmei.Size = new System.Drawing.Size(124, 34);
            this.radioHinmei.TabIndex = 7;
            this.radioHinmei.TabStop = true;
            this.radioHinmei.Text = "会社名";
            this.radioHinmei.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSearch.Location = new System.Drawing.Point(41, 90);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(497, 37);
            this.textSearch.TabIndex = 8;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(597, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(143, 50);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupSearch
            // 
            this.groupSearch.BackColor = System.Drawing.Color.HotPink;
            this.groupSearch.Controls.Add(this.btnSearchClear);
            this.groupSearch.Controls.Add(this.textSearch);
            this.groupSearch.Controls.Add(this.btnSearch);
            this.groupSearch.Controls.Add(this.radioCode);
            this.groupSearch.Controls.Add(this.radioHinmei);
            this.groupSearch.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupSearch.Location = new System.Drawing.Point(30, 19);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(746, 162);
            this.groupSearch.TabIndex = 10;
            this.groupSearch.TabStop = false;
            this.groupSearch.Text = "検索";
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.BackColor = System.Drawing.Color.Black;
            this.btnSearchClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearchClear.ForeColor = System.Drawing.Color.White;
            this.btnSearchClear.Location = new System.Drawing.Point(544, 90);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(35, 38);
            this.btnSearchClear.TabIndex = 12;
            this.btnSearchClear.Text = "消";
            this.btnSearchClear.UseVisualStyleBackColor = false;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "(50文字以内)";
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1655, 969);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.gridViewCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会社登録";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewCompany;
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
        private System.Windows.Forms.CheckBox checkDelFlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button btnCodeClear;
        private System.Windows.Forms.Button btnNameClear;
        private System.Windows.Forms.Button btnSearchClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColDelFlg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNameHankaku;
        private System.Windows.Forms.Button btnNameZenkaku;
        private System.Windows.Forms.Label label4;
    }
}