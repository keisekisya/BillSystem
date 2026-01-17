namespace BillSystem
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCodeClear = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.btnCompanyFormUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.btnBillCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boxMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxYear = new System.Windows.Forms.ComboBox();
            this.btnHinmeiAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSumShow = new System.Windows.Forms.Button();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.btnAddressSet = new System.Windows.Forms.Button();
            this.btnKindAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.btnCodeClear);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.btnCompanyFormUp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCode);
            this.groupBox1.Controls.Add(this.btnBillCreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.boxMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.boxYear);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(34, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(435, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請求書の作成";
            // 
            // btnCodeClear
            // 
            this.btnCodeClear.BackColor = System.Drawing.Color.Black;
            this.btnCodeClear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCodeClear.ForeColor = System.Drawing.Color.White;
            this.btnCodeClear.Location = new System.Drawing.Point(273, 63);
            this.btnCodeClear.Name = "btnCodeClear";
            this.btnCodeClear.Size = new System.Drawing.Size(35, 38);
            this.btnCodeClear.TabIndex = 16;
            this.btnCodeClear.Text = "消";
            this.btnCodeClear.UseVisualStyleBackColor = false;
            this.btnCodeClear.Click += new System.EventHandler(this.btnCodeClear_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelName.Location = new System.Drawing.Point(126, 104);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 22);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "その他";
            // 
            // btnCompanyFormUp
            // 
            this.btnCompanyFormUp.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCompanyFormUp.Location = new System.Drawing.Point(237, 61);
            this.btnCompanyFormUp.Name = "btnCompanyFormUp";
            this.btnCompanyFormUp.Size = new System.Drawing.Size(30, 40);
            this.btnCompanyFormUp.TabIndex = 13;
            this.btnCompanyFormUp.Text = "▲";
            this.btnCompanyFormUp.UseVisualStyleBackColor = true;
            this.btnCompanyFormUp.Click += new System.EventHandler(this.btnCompanyFormUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "会社ｺｰﾄﾞ";
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textCode.Location = new System.Drawing.Point(131, 61);
            this.textCode.MaxLength = 5;
            this.textCode.Name = "textCode";
            this.textCode.ReadOnly = true;
            this.textCode.Size = new System.Drawing.Size(100, 29);
            this.textCode.TabIndex = 5;
            // 
            // btnBillCreate
            // 
            this.btnBillCreate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBillCreate.Location = new System.Drawing.Point(106, 240);
            this.btnBillCreate.Name = "btnBillCreate";
            this.btnBillCreate.Size = new System.Drawing.Size(150, 50);
            this.btnBillCreate.TabIndex = 4;
            this.btnBillCreate.Text = "作成";
            this.btnBillCreate.UseVisualStyleBackColor = true;
            this.btnBillCreate.Click += new System.EventHandler(this.btnBillCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(259, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // boxMonth
            // 
            this.boxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.boxMonth.FormattingEnabled = true;
            this.boxMonth.Location = new System.Drawing.Point(179, 179);
            this.boxMonth.Name = "boxMonth";
            this.boxMonth.Size = new System.Drawing.Size(74, 32);
            this.boxMonth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(125, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "年";
            // 
            // boxYear
            // 
            this.boxYear.DropDownHeight = 300;
            this.boxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.boxYear.FormattingEnabled = true;
            this.boxYear.IntegralHeight = false;
            this.boxYear.Location = new System.Drawing.Point(21, 179);
            this.boxYear.Name = "boxYear";
            this.boxYear.Size = new System.Drawing.Size(98, 32);
            this.boxYear.TabIndex = 0;
            // 
            // btnHinmeiAdd
            // 
            this.btnHinmeiAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnHinmeiAdd.Location = new System.Drawing.Point(515, 94);
            this.btnHinmeiAdd.Name = "btnHinmeiAdd";
            this.btnHinmeiAdd.Size = new System.Drawing.Size(257, 50);
            this.btnHinmeiAdd.TabIndex = 0;
            this.btnHinmeiAdd.Text = "品名登録";
            this.btnHinmeiAdd.UseVisualStyleBackColor = true;
            this.btnHinmeiAdd.Click += new System.EventHandler(this.btnHinmeiAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Location = new System.Drawing.Point(366, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 90);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSumShow
            // 
            this.btnSumShow.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSumShow.Location = new System.Drawing.Point(515, 150);
            this.btnSumShow.Name = "btnSumShow";
            this.btnSumShow.Size = new System.Drawing.Size(257, 50);
            this.btnSumShow.TabIndex = 3;
            this.btnSumShow.Text = "総額一覧";
            this.btnSumShow.UseVisualStyleBackColor = true;
            this.btnSumShow.Click += new System.EventHandler(this.btnSumShow_Click);
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCompanyAdd.Location = new System.Drawing.Point(515, 35);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(257, 55);
            this.btnCompanyAdd.TabIndex = 4;
            this.btnCompanyAdd.Text = "会社登録";
            this.btnCompanyAdd.UseVisualStyleBackColor = true;
            this.btnCompanyAdd.Click += new System.EventHandler(this.btnCompanyAdd_Click);
            // 
            // btnAddressSet
            // 
            this.btnAddressSet.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddressSet.Location = new System.Drawing.Point(710, 327);
            this.btnAddressSet.Name = "btnAddressSet";
            this.btnAddressSet.Size = new System.Drawing.Size(146, 50);
            this.btnAddressSet.TabIndex = 5;
            this.btnAddressSet.Text = "住所登録";
            this.btnAddressSet.UseVisualStyleBackColor = true;
            this.btnAddressSet.Click += new System.EventHandler(this.btnAddressSet_Click);
            // 
            // btnKindAdd
            // 
            this.btnKindAdd.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKindAdd.Location = new System.Drawing.Point(710, 266);
            this.btnKindAdd.Name = "btnKindAdd";
            this.btnKindAdd.Size = new System.Drawing.Size(146, 55);
            this.btnKindAdd.TabIndex = 6;
            this.btnKindAdd.Text = "種類登録";
            this.btnKindAdd.UseVisualStyleBackColor = true;
            this.btnKindAdd.Click += new System.EventHandler(this.btnKindAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(476, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 103);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 480);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnKindAdd);
            this.Controls.Add(this.btnAddressSet);
            this.Controls.Add(this.btnCompanyAdd);
            this.Controls.Add(this.btnHinmeiAdd);
            this.Controls.Add(this.btnSumShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "請求書システム";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxYear;
        private System.Windows.Forms.Button btnBillCreate;
        private System.Windows.Forms.Button btnHinmeiAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSumShow;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.Button btnAddressSet;
        private System.Windows.Forms.Button btnKindAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Button btnCompanyFormUp;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnCodeClear;
        private System.Windows.Forms.Button btnSearch;
    }
}

