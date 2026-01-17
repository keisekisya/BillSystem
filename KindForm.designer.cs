namespace BillSystem
{
    partial class KindForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridViewKind = new System.Windows.Forms.DataGridView();
            this.ColCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDelFlg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpInfo = new System.Windows.Forms.GroupBox();
            this.btnNameClear = new System.Windows.Forms.Button();
            this.btnCodeClear = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkDelFlg = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNameHankaku = new System.Windows.Forms.Button();
            this.btnNameZenkaku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKind)).BeginInit();
            this.gpInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewKind
            // 
            this.gridViewKind.AllowUserToAddRows = false;
            this.gridViewKind.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gridViewKind.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewKind.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewKind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewKind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCode,
            this.ColName,
            this.ColDelFlg});
            this.gridViewKind.Location = new System.Drawing.Point(22, 34);
            this.gridViewKind.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewKind.MultiSelect = false;
            this.gridViewKind.Name = "gridViewKind";
            this.gridViewKind.RowTemplate.Height = 21;
            this.gridViewKind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewKind.Size = new System.Drawing.Size(391, 672);
            this.gridViewKind.TabIndex = 0;
            this.gridViewKind.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewHinmei_RowPostPaint);
            // 
            // ColCode
            // 
            this.ColCode.Frozen = true;
            this.ColCode.HeaderText = "コード";
            this.ColCode.Name = "ColCode";
            this.ColCode.ReadOnly = true;
            this.ColCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColCode.Width = 80;
            // 
            // ColName
            // 
            this.ColName.Frozen = true;
            this.ColName.HeaderText = "種類";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColName.Width = 140;
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
            this.btnDel.Location = new System.Drawing.Point(445, 66);
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
            this.btnUpd.Location = new System.Drawing.Point(613, 66);
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
            this.btnAdd.Location = new System.Drawing.Point(781, 66);
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
            this.gpInfo.BackColor = System.Drawing.Color.Goldenrod;
            this.gpInfo.Controls.Add(this.panel2);
            this.gpInfo.Controls.Add(this.panel1);
            this.gpInfo.Controls.Add(this.labelMode);
            this.gpInfo.Controls.Add(this.btnCancel);
            this.gpInfo.Controls.Add(this.btnCreate);
            this.gpInfo.Location = new System.Drawing.Point(445, 150);
            this.gpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gpInfo.Name = "gpInfo";
            this.gpInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gpInfo.Size = new System.Drawing.Size(518, 450);
            this.gpInfo.TabIndex = 4;
            this.gpInfo.TabStop = false;
            // 
            // btnNameClear
            // 
            this.btnNameClear.BackColor = System.Drawing.Color.Black;
            this.btnNameClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameClear.ForeColor = System.Drawing.Color.White;
            this.btnNameClear.Location = new System.Drawing.Point(351, 9);
            this.btnNameClear.Name = "btnNameClear";
            this.btnNameClear.Size = new System.Drawing.Size(35, 38);
            this.btnNameClear.TabIndex = 11;
            this.btnNameClear.Text = "消";
            this.btnNameClear.UseVisualStyleBackColor = false;
            this.btnNameClear.Click += new System.EventHandler(this.btnNameClear_Click);
            // 
            // btnCodeClear
            // 
            this.btnCodeClear.BackColor = System.Drawing.Color.Black;
            this.btnCodeClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCodeClear.ForeColor = System.Drawing.Color.White;
            this.btnCodeClear.Location = new System.Drawing.Point(240, 8);
            this.btnCodeClear.Name = "btnCodeClear";
            this.btnCodeClear.Size = new System.Drawing.Size(35, 38);
            this.btnCodeClear.TabIndex = 9;
            this.btnCodeClear.Text = "消";
            this.btnCodeClear.UseVisualStyleBackColor = false;
            this.btnCodeClear.Click += new System.EventHandler(this.btnCodeClear_Click);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = System.Drawing.Color.Goldenrod;
            this.labelMode.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelMode.ForeColor = System.Drawing.Color.Crimson;
            this.labelMode.Location = new System.Drawing.Point(352, 29);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(145, 60);
            this.labelMode.TabIndex = 8;
            this.labelMode.Text = "追加";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "(3文字以内)";
            // 
            // checkDelFlg
            // 
            this.checkDelFlg.AutoSize = true;
            this.checkDelFlg.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkDelFlg.Location = new System.Drawing.Point(118, 112);
            this.checkDelFlg.Name = "checkDelFlg";
            this.checkDelFlg.Size = new System.Drawing.Size(206, 28);
            this.checkDelFlg.TabIndex = 6;
            this.checkDelFlg.Text = "リストに表示しない";
            this.checkDelFlg.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCancel.Location = new System.Drawing.Point(272, 349);
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
            this.btnCreate.Location = new System.Drawing.Point(53, 349);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(200, 70);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "設定";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textName.Location = new System.Drawing.Point(118, 8);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(226, 37);
            this.textName.TabIndex = 3;
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCode.Location = new System.Drawing.Point(119, 9);
            this.textCode.Margin = new System.Windows.Forms.Padding(4);
            this.textCode.MaxLength = 3;
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(114, 37);
            this.textCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "種類";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "コード";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(772, 642);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 90);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textCode);
            this.panel1.Controls.Add(this.btnCodeClear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 66);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNameZenkaku);
            this.panel2.Controls.Add(this.btnNameHankaku);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Controls.Add(this.btnNameClear);
            this.panel2.Controls.Add(this.checkDelFlg);
            this.panel2.Location = new System.Drawing.Point(8, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 160);
            this.panel2.TabIndex = 13;
            // 
            // btnNameHankaku
            // 
            this.btnNameHankaku.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNameHankaku.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameHankaku.ForeColor = System.Drawing.Color.White;
            this.btnNameHankaku.Location = new System.Drawing.Point(34, 55);
            this.btnNameHankaku.Name = "btnNameHankaku";
            this.btnNameHankaku.Size = new System.Drawing.Size(35, 38);
            this.btnNameHankaku.TabIndex = 18;
            this.btnNameHankaku.Text = "半";
            this.btnNameHankaku.UseVisualStyleBackColor = false;
            this.btnNameHankaku.Click += new System.EventHandler(this.btnNameHankaku_Click);
            // 
            // btnNameZenkaku
            // 
            this.btnNameZenkaku.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNameZenkaku.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNameZenkaku.ForeColor = System.Drawing.Color.White;
            this.btnNameZenkaku.Location = new System.Drawing.Point(75, 55);
            this.btnNameZenkaku.Name = "btnNameZenkaku";
            this.btnNameZenkaku.Size = new System.Drawing.Size(35, 38);
            this.btnNameZenkaku.TabIndex = 19;
            this.btnNameZenkaku.Text = "全";
            this.btnNameZenkaku.UseVisualStyleBackColor = false;
            this.btnNameZenkaku.Click += new System.EventHandler(this.btnNameZenkaku_Click);
            // 
            // KindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(985, 745);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gpInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.gridViewKind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会社登録";
            this.Load += new System.EventHandler(this.KindForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKind)).EndInit();
            this.gpInfo.ResumeLayout(false);
            this.gpInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewKind;
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
        private System.Windows.Forms.CheckBox checkDelFlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button btnCodeClear;
        private System.Windows.Forms.Button btnNameClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColDelFlg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNameHankaku;
        private System.Windows.Forms.Button btnNameZenkaku;
    }
}