using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BillSystem.Const;
using Microsoft.VisualBasic;

namespace BillSystem
{
    public partial class HinmeiForm : Form
    {
        private int btnFlag = 0;

        private const int GRID_COMPANY_NAME = 0;
        private const int GRID_CODE = 1;
        private const int GRID_NAME = 2;
        private const int GRID_DEL_FLG = 3;
        private const int GRID_COMPANY_CODE = 4;

        public HinmeiForm()
        {
            InitializeComponent();
        }

        private void HinmeiForm_Load(object sender, EventArgs e)
        {
            radioCode.Checked = true;
            // 行の高さを設定
            gridViewHinmei.RowTemplate.Height = 36;

            // フォントを設定
            gridViewHinmei.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            labelCompanyName.Text = "";
            labelCompanySearchName.Text = "";

            // DBよりデータを取得
            search_func("", "", 0);

            if (gridViewHinmei.Rows.Count > 18)
            {
                gridViewHinmei.FirstDisplayedScrollingRowIndex = gridViewHinmei.Rows.Count - 17;
            }

            // 初期は追加モード
            btnAdd_Click(null, null);

            textSearch.Select();
        }

        /////////////////////////////////////////////////////
        // グリッド行番号を表示
        /////////////////////////////////////////////////////
        private void gridViewHinmei_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // 行ヘッダのセル領域を、行番号を描画する長方形とする
            // （ただし右端に4ドットのすき間を空ける）
            Rectangle rect = new Rectangle(e.RowBounds.Location.X,
                                           e.RowBounds.Location.Y,
                                           gridViewHinmei.RowHeadersWidth - 4,
                                           e.RowBounds.Height);

            // 上記の長方形内に行番号を縦方向中央＆右詰めで描画する
            // フォントや前景色は行ヘッダの既定値を使用する
            TextRenderer.DrawText(e.Graphics,
                                  (e.RowIndex + 1).ToString(),
                                  gridViewHinmei.RowHeadersDefaultCellStyle.Font,
                                  rect,
                                  gridViewHinmei.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /////////////////////////////////////////////////////
        // 削除ボタン押下時
        /////////////////////////////////////////////////////
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridViewHinmei.SelectedRows.Count == 0)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in gridViewHinmei.SelectedRows)
            {
                setGridRowData(row);
                break;
            }

            gridViewHinmei.Enabled = false;      // テーブル
            groupSearch.Enabled = false;         // 検索部

            panel1.Enabled = false;
            panel2.Enabled = false;

            btnCreate.Text = "削除";
            labelMode.Text = "削除";
            this.btnFlag = ModoConst.DEL;
        }

        /////////////////////////////////////////////////////
        // 修正ボタン押下時
        /////////////////////////////////////////////////////
        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (gridViewHinmei.SelectedRows.Count == 0)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in gridViewHinmei.SelectedRows)
            {
                setGridRowData(row);
                break;
            }

            gridViewHinmei.Enabled = false;      // テーブル
            groupSearch.Enabled = false;         // 検索部
            panel1.Enabled = false;
            panel2.Enabled = true;

            btnCreate.Text = "修正";
            labelMode.Text = "修正";
            this.btnFlag = ModoConst.UPD;
        }

        /////////////////////////////////////////////////////
        // 選択したグリッドの情報をテキストボックス等に反映
        /////////////////////////////////////////////////////
        private void setGridRowData(DataGridViewRow row)
        {
            labelCompanyName.Text = (string)row.Cells[GRID_COMPANY_NAME].Value;
            textCode.Text = (string)row.Cells[GRID_CODE].Value;
            textName.Text = (string)row.Cells[GRID_NAME].Value;
            checkDelFlg.Checked = (bool)row.Cells[GRID_DEL_FLG].Value;
            textCompany.Text = (string)row.Cells[GRID_COMPANY_CODE].Value;
        }

        /////////////////////////////////////////////////////
        // 新規追加ボタン押下時
        /////////////////////////////////////////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gridViewHinmei.Enabled = true;      // テーブル
            groupSearch.Enabled = true;         // 検索部
            panel1.Enabled = true;
            panel2.Enabled = true;

            btnCreate.Text = "登録";
            labelMode.Text = "追加";

            this.btnFlag = ModoConst.ADD;
        }

        /////////////////////////////////////////////////////
        // 設定ボタン押下時
        /////////////////////////////////////////////////////
        private void btnCreate_Click(object sender, EventArgs e)
        {
            StringBuilder bufMsg = new StringBuilder();

            switch (btnFlag)
            {
                // 削除
                case ModoConst.DEL:
                     DialogResult ret = MessageBox.Show("削除してよろしいでしょうか？",
                                                        "削除",
                                                        MessageBoxButtons.OKCancel,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2);
                     if (ret == DialogResult.OK)
                     {
                         del_func(textCompany.Text, textCode.Text);
                     }
                     break;

                // 修正
                case ModoConst.UPD:
                     textName.Text = textName.Text.Trim();
                    if (textName.Text == "")
                    {
                        bufMsg.Append("品名を入力して下さい。\n");
                    }
                    if (bufMsg.Length != 0)
                    {
                        MessageBox.Show(bufMsg.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                    upd_func(textCompany.Text, textCode.Text, textName.Text, checkDelFlg.Checked);
                    break;

                // 新規追加
                case ModoConst.ADD:
                    textCompany.Text = textCompany.Text.Trim();
                    if (textCompany.Text == "")
                    {
                        bufMsg.Append("会社コードを入力して下さい。\n");
                    }
                    textCode.Text = textCode.Text.Trim();
                    if (textCode.Text == "")
                    {
                        bufMsg.Append("品名コードを入力して下さい。\n");
                    }
                    else
                    {
                        if (!checkString.IsCode(textCode.Text))
                        {
                            bufMsg.Append("品名コードは半角英数字のみを入力して下さい。\n");
                        }
                    }

                    textName.Text = textName.Text.Trim();
                    if (textName.Text == "")
                    {
                        bufMsg.Append("品名を入力して下さい。\n");
                    }
                    if (bufMsg.Length != 0)
                    {
                        MessageBox.Show(bufMsg.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    add_func(textCompany.Text.ToUpper(), textCode.Text.ToUpper(), textName.Text, checkDelFlg.Checked);
                    break;

                default:
                    break;
            }
        }

        /////////////////////////////////////////////////////
        // キャンセルボタン押下時
        /////////////////////////////////////////////////////
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
        }

        /////////////////////////////////////////////////////
        // 閉じるボタン押下時
        /////////////////////////////////////////////////////
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /////////////////////////////////////////////////////
        // 削除処理
        /////////////////////////////////////////////////////
        private void del_func(string paramCompanyCode, string paramCode)
        {
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;
                SqlTransaction tran = null;
                try
                {
                    // マウスを砂時計に
                    Cursor.Current = Cursors.WaitCursor;

                    conn.Open();
                    com = conn.CreateCommand();

                    ////////////////////////////////////////////////////
                    // コードの存在チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT COUNT(*) FROM TBLT_PRICE WHERE COMPANY_CODE = @company_code AND HINMEI_CODE = @code";
                    com.Parameters.AddWithValue("@company_code", paramCompanyCode);
                    com.Parameters.AddWithValue("@code", paramCode);

                    SqlDataReader cReader = com.ExecuteReader();

                    while (cReader.Read())
                    {
                        if (cReader[0].ToString() != "0")
                        {
                            cReader.Close();
                            MessageBox.Show("その品名は使用されている為、削除出来ません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    cReader.Close();

                    // トランザクション開始
                    tran = conn.BeginTransaction();

                    com.Connection = conn;
                    com.Transaction = tran;

                    com.CommandText = "DELETE FROM TBLM_HINMEI WHERE COMPANY_CODE=@company_code AND CODE=@code";
                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    MessageBox.Show("削除しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (DataGridViewRow row in gridViewHinmei.SelectedRows)
                    {
                        int index = row.Index;
                        gridViewHinmei.Rows.Remove(row);
                        if (index != 0)
                        {
                            gridViewHinmei.Rows[index - 1].Selected = true;
                        }
                        btnDel_Click(null, null);
                        break;
                    }
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }
                    MessageBox.Show("削除に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                }
                finally
                {
                    if (tran != null)
                    {
                        tran.Dispose();
                    }
                    if (com != null)
                    {
                        com.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        /////////////////////////////////////////////////////
        // 更新処理
        /////////////////////////////////////////////////////
        private void upd_func(string paramCompanyCode, string pramCode, string paramName, bool del_flg)
        {
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;
                SqlTransaction tran = null;
                try
                {
                    // マウスを砂時計に
                    Cursor.Current = Cursors.WaitCursor;

                    conn.Open();
                    com = conn.CreateCommand();

                    // トランザクション開始
                    tran = conn.BeginTransaction();

                    com.Connection = conn;
                    com.Transaction = tran;

                    com.CommandText = "UPDATE TBLM_HINMEI SET NAME=@name,DEL_FLG=@del_flg WHERE COMPANY_CODE=@company_code AND CODE=@code";

                    com.Parameters.AddWithValue("@company_code", paramCompanyCode);
                    com.Parameters.AddWithValue("@code", pramCode);
                    com.Parameters.AddWithValue("@name", paramName);
                    com.Parameters.AddWithValue("@del_flg", UtilString.changeDelFlg(del_flg));
                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    foreach (DataGridViewRow row in gridViewHinmei.SelectedRows)
                    {
                        row.Cells[GRID_NAME].Value = paramName;
                        row.Cells[GRID_DEL_FLG].Value = del_flg;
                        break;
                    }
                    MessageBox.Show("修正しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }
                    MessageBox.Show("修正に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                }
                finally
                {
                    if (tran != null)
                    {
                        tran.Dispose();
                    }
                    if (com != null)
                    {
                        com.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        /////////////////////////////////////////////////////
        // 追加処理
        /////////////////////////////////////////////////////
        private void add_func(string paramCompanyCode, string pramCode, string paramName, bool del_flg)
        {
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlTransaction tran = null;
                SqlCommand com = null;
                try
                {
                    // マウスを砂時計に
                    Cursor.Current = Cursors.WaitCursor;

                    conn.Open();
                    com = conn.CreateCommand();
                    com.Connection = conn;

                    ////////////////////////////////////////////////////
                    // 会社コードの存在チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT NAME FROM TBLM_COMPANY WHERE CODE=@company_code";
                    com.Parameters.AddWithValue("@company_code", paramCompanyCode);

                    SqlDataReader cReader = com.ExecuteReader();

                    if (cReader.Read() == false)
                    {
                        cReader.Close();
                        MessageBox.Show("その会社コードは存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    labelCompanyName.Text = cReader[0].ToString();
                    cReader.Close();

                    ////////////////////////////////////////////////////
                    // コードの存在チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT COUNT(*) FROM TBLM_HINMEI WHERE COMPANY_CODE=@company_code AND CODE=@code";
                    com.Parameters.AddWithValue("@code", pramCode);

                    cReader = com.ExecuteReader();

                    while (cReader.Read())
                    {
                        if (cReader[0].ToString() != "0")
                        {
                            cReader.Close();
                            MessageBox.Show("そのコードは既に使用されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    cReader.Close();

                    // トランザクション開始
                    tran = conn.BeginTransaction();
                    com.Transaction = tran;

                    ////////////////////////////////////////////////////
                    // データの登録を行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "INSERT INTO TBLM_HINMEI(COMPANY_CODE,CODE,NAME,DEL_FLG) values(@company_code,@code,@name,@del_flg)";

                    com.Parameters.AddWithValue("@name", paramName);
                    com.Parameters.AddWithValue("@del_flg", UtilString.changeDelFlg(del_flg));
                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    gridViewHinmei.Rows.Add(labelCompanyName.Text, pramCode, paramName, del_flg, paramCompanyCode);
                    gridViewHinmei.Rows[gridViewHinmei.Rows.Count - 1].Selected = true;
                    if (gridViewHinmei.Rows.Count > 18)
                    {
                        gridViewHinmei.FirstDisplayedScrollingRowIndex = gridViewHinmei.Rows.Count - 17;
                    }
                    MessageBox.Show("保存しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }
                    MessageBox.Show("保存に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex);
                }
                finally
                {
                    if (tran != null)
                    {
                        tran.Dispose();
                    }
                    if (com != null)
                    {
                        com.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        /////////////////////////////////////////////////////
        // 検索ボタン押下時
        /////////////////////////////////////////////////////
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search_com();
        }

        /////////////////////////////////////////////////////
        // 品名入力時
        /////////////////////////////////////////////////////
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            search_com();
        }

        /////////////////////////////////////////////////////
        // 検索処理
        /////////////////////////////////////////////////////
        private void search_com()
        {
            int flag = 0;
            if (radioCode.Checked == true)
            {
                flag = 1;
            }
            else if (radioHinmei.Checked == true)
            {
                flag = 2;
            }
            else
            {
                MessageBox.Show("コードか品名を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            search_func(textCompanySearch.Text.ToUpper(), textSearch.Text.ToUpper(), flag);
        }

        /////////////////////////////////////////////////////
        // 検索処理
        /////////////////////////////////////////////////////
        private void search_func(string paramCompany, string paramValue, int serachFlg)
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    conn.Open();
                    com = conn.CreateCommand();
                    StringBuilder sqlbuf = new StringBuilder();
                    sqlbuf.Append("SELECT B.NAME COMPANY_NAME,A.CODE,A.NAME,B.CODE COMPANY_CODE,A.DEL_FLG FROM TBLM_HINMEI A, TBLM_COMPANY B WHERE A.COMPANY_CODE = B.CODE ");
                    
                    if (paramCompany.Length != 0)
                    {
                        sqlbuf.Append("  AND B.CODE = @c_code ");
                        com.Parameters.AddWithValue("@c_code", paramCompany);
                    }
                    switch (serachFlg)
                    {
                        case 1:
                            sqlbuf.Append("  AND A.CODE LIKE @code");
                            com.Parameters.AddWithValue("@code", paramValue + "%");
                            break;
                        case 2:
                            sqlbuf.Append("  AND A.NAME LIKE @name");
                            com.Parameters.AddWithValue("@name", "%" + paramValue + "%");
                            break;
                        default:
                            break;
                    }
                    sqlbuf.Append(" ORDER BY B.CODE,A.CODE");
                    com.CommandText = sqlbuf.ToString();
                    com.Connection = conn;
                    SqlDataReader cReader = com.ExecuteReader();

                    gridViewHinmei.Rows.Clear();
                    bool del_flg;
                    while (cReader.Read())
                    {
                        if (cReader["DEL_FLG"].ToString() == "1")
                        {
                            del_flg = true;
                        }
                        else
                        {
                            del_flg = false;
                        }

                        gridViewHinmei.Rows.Add(cReader["COMPANY_NAME"].ToString(),
                                                cReader["CODE"].ToString(),
                                                cReader["NAME"].ToString(),
                                                del_flg,
                                                cReader["COMPANY_CODE"].ToString());
                    }
                    cReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    if (com != null)
                    {
                        com.Dispose();
                    }
                    conn.Close();
                    conn.Dispose();
                }
            }
        }

        /////////////////////////////////////////////////////
        // 会社コード一覧表示ボタン押下時(検索用)
        /////////////////////////////////////////////////////
        private void btnCompanyFormUp_Click(object sender, EventArgs e)
        {
            // コード検索画面をモーダル表示
            CompanySearchForm form = new CompanySearchForm();
            form.searchValue = textCompanySearch.Text;
            form.BackColor = groupSearch.BackColor;
            form.ShowDialog(this);
            if (form.selectFlg)
            {
                textCompanySearch.Text = form.selectCode;
                labelCompanySearchName.Text = form.selectName;
                search_com();
            }
        }

        /////////////////////////////////////////////////////
        // 会社コード一覧表示ボタン押下時
        /////////////////////////////////////////////////////
        private void btnCompanyUpFormSet_Click(object sender, EventArgs e)
        {
            // コード検索画面をモーダル表示
            CompanySearchForm form = new CompanySearchForm();
            form.searchValue = textCompany.Text;
            form.BackColor = gpInfo.BackColor;
            form.ShowDialog(this);
            if (form.selectFlg)
            {
                textCompany.Text = form.selectCode;
                labelCompanyName.Text = form.selectName;
            }
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            textSearch.Text = "";
            textSearch.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textCode.Text = "";
            textCode.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textName.Select();
        }

        /////////////////////////////////////////////
        // 品名半角ボタン
        /////////////////////////////////////////////
        private void btnNameHankaku_Click(object sender, EventArgs e)
        {
            textName.Text = Strings.StrConv(textName.Text, VbStrConv.Narrow, 0);
        }

        /////////////////////////////////////////////
        // 品名全角ボタン
        /////////////////////////////////////////////
        private void btnNameZenkaku_Click(object sender, EventArgs e)
        {
            textName.Text = Strings.StrConv(textName.Text, VbStrConv.Wide, 0);
        }

        private void btnCompanySearchClear_Click(object sender, EventArgs e)
        {
            textCompanySearch.Text = "";
            textCompanySearch.Select();
        }

        private void btnNameUpper_Click(object sender, EventArgs e)
        {
            textName.Text = textName.Text.ToUpper();
        }

        private void btnNameLouuer_Click(object sender, EventArgs e)
        {
            textName.Text = textName.Text.ToLower();
        }
    }
}
