namespace BillSystem
{
    partial class AddressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textFromTel = new System.Windows.Forms.TextBox();
            this.textFromName = new System.Windows.Forms.TextBox();
            this.textFromAddress2 = new System.Windows.Forms.TextBox();
            this.textFromAddress1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textToName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textFromInvoice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.textFromInvoice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textFromTel);
            this.groupBox1.Controls.Add(this.textFromName);
            this.groupBox1.Controls.Add(this.textFromAddress2);
            this.groupBox1.Controls.Add(this.textFromAddress1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(16, 279);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(534, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請求元";
            // 
            // textFromTel
            // 
            this.textFromTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFromTel.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textFromTel.Location = new System.Drawing.Point(100, 152);
            this.textFromTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFromTel.MaxLength = 20;
            this.textFromTel.Name = "textFromTel";
            this.textFromTel.Size = new System.Drawing.Size(178, 34);
            this.textFromTel.TabIndex = 5;
            // 
            // textFromName
            // 
            this.textFromName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFromName.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textFromName.Location = new System.Drawing.Point(100, 111);
            this.textFromName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFromName.MaxLength = 50;
            this.textFromName.Name = "textFromName";
            this.textFromName.Size = new System.Drawing.Size(414, 34);
            this.textFromName.TabIndex = 4;
            // 
            // textFromAddress2
            // 
            this.textFromAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFromAddress2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textFromAddress2.Location = new System.Drawing.Point(100, 74);
            this.textFromAddress2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFromAddress2.MaxLength = 50;
            this.textFromAddress2.Name = "textFromAddress2";
            this.textFromAddress2.Size = new System.Drawing.Size(414, 34);
            this.textFromAddress2.TabIndex = 3;
            // 
            // textFromAddress1
            // 
            this.textFromAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFromAddress1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textFromAddress1.Location = new System.Drawing.Point(100, 34);
            this.textFromAddress1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFromAddress1.MaxLength = 50;
            this.textFromAddress1.Name = "textFromAddress1";
            this.textFromAddress1.Size = new System.Drawing.Size(414, 34);
            this.textFromAddress1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "電話番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "会社名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "住所2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "住所１";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.textToName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(16, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(534, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "請求先";
            // 
            // textToName
            // 
            this.textToName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textToName.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textToName.Location = new System.Drawing.Point(100, 54);
            this.textToName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textToName.MaxLength = 50;
            this.textToName.Name = "textToName";
            this.textToName.Size = new System.Drawing.Size(414, 34);
            this.textToName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "会社名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(32, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "ここで入力された情報は、請求書の印刷時に使用されます。";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.Location = new System.Drawing.Point(116, 536);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(338, 536);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "インボイス";
            // 
            // textFromInvoice
            // 
            this.textFromInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFromInvoice.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textFromInvoice.Location = new System.Drawing.Point(100, 197);
            this.textFromInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.textFromInvoice.MaxLength = 20;
            this.textFromInvoice.Name = "textFromInvoice";
            this.textFromInvoice.Size = new System.Drawing.Size(256, 34);
            this.textFromInvoice.TabIndex = 7;
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 611);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "住所登録";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textFromTel;
        private System.Windows.Forms.TextBox textFromName;
        private System.Windows.Forms.TextBox textFromAddress2;
        private System.Windows.Forms.TextBox textFromAddress1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textToName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox textFromInvoice;
        private System.Windows.Forms.Label label7;
    }
}