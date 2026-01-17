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
    public partial class CompanyForm : Form
    {
        private int btnFlag = 0;

        private const int GRID_CODE = 0;
        private const int GRID_NAME = 1;
        private const int GRID_DEL_FLG = 2;

        public CompanyForm()
        {
            InitializeComponent();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            radioCode.Checked = true;
            // 行の高さを設定
            gridViewCompany.RowTemplate.Height = 36;

            // フォントを設定
            gridViewCompany.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // DBよりデータを取得
            search_func("", 0);
            if (gridViewCompany.Rows.Count > 19)
            {
                gridViewCompany.FirstDisplayedScrollingRowIndex = gridViewCompany.Rows.Count - 18;
            }
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
                                           gridViewCompany.RowHeadersWidth - 4,
                                           e.RowBounds.Height);

            // 上記の長方形内に行番号を縦方向中央＆右詰めで描画する
            // フォントや前景色は行ヘッダの既定値を使用する
            TextRenderer.DrawText(e.Graphics,
                                  (e.RowIndex + 1).ToString(),
                                  gridViewCompany.RowHeadersDefaultCellStyle.Font,
                                  rect,
                                  gridViewCompany.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /////////////////////////////////////////////////////
        // 削除ボタン押下時
        /////////////////////////////////////////////////////
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridViewCompany.SelectedRows.Count == 0)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in gridViewCompany.SelectedRows)
            {
                setGridRowData(row);
                break;
            }

            gridViewCompany.Enabled = false; // テーブル
            groupSearch.Enabled = false;     // 検索部
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
            if (gridViewCompany.SelectedRows.Count == 0)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in gridViewCompany.SelectedRows)
            {
                setGridRowData(row);
                break;
            }

            gridViewCompany.Enabled = false; // テーブル
            groupSearch.Enabled = false;     // 検索部
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
            textCode.Text = (string)row.Cells[GRID_CODE].Value;
            textName.Text = (string)row.Cells[GRID_NAME].Value;
            checkDelFlg.Checked = (bool)row.Cells[GRID_DEL_FLG].Value;
        }

        /////////////////////////////////////////////////////
        // 新規追加ボタン押下時
        /////////////////////////////////////////////////////
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gridViewCompany.Enabled = true; // テーブル
            groupSearch.Enabled = true;     // 検索部
            panel1.Enabled = true;
            panel2.Enabled = true;

            btnCreate.Text = "登録";
            labelMode.Text = "新規";
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
                         del_func(textCode.Text);
                     }
                     break;

                // 修正
                case ModoConst.UPD:
                     textName.Text = textName.Text.Trim();
                     if (textName.Text == "")
                     {
                         bufMsg.Append("会社名を入力して下さい。\n");
                     }
                     if (bufMsg.Length != 0)
                     {
                         MessageBox.Show(bufMsg.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                     }

                    upd_func(textCode.Text, textName.Text.Trim(), checkDelFlg.Checked);
                    break;

                // 新規追加
                case ModoConst.ADD:
                    textCode.Text = textCode.Text.Trim();
                    if (textCode.Text == "")
                    {
                        bufMsg.Append("コードを入力して下さい。\n");
                    }
                    else
                    {
                        if (!checkString.IsCode(textCode.Text))
                        {
                            bufMsg.Append("コードは半角英数字のみを入力して下さい。\n");
                        }
                    }
                    textName.Text = textName.Text.Trim();
                    if (textName.Text == "")
                    {
                        bufMsg.Append("会社名を入力して下さい。\n");
                    }
                    if (bufMsg.Length != 0)
                    {
                        MessageBox.Show(bufMsg.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    add_func(textCode.Text.ToUpper(), textName.Text, checkDelFlg.Checked);
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
        private void del_func(string paramCode)
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
                    // コードの使用チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT COUNT(*) FROM TBLM_HINMEI WHERE COMPANY_CODE = @code";
                    com.Parameters.AddWithValue("@code", paramCode);

                    SqlDataReader cReader = com.ExecuteReader();

                    while (cReader.Read())
                    {
                        if (cReader[0].ToString() != "0")
                        {
                            cReader.Close();
                            MessageBox.Show("その会社は使用されている為、削除出来ません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    cReader.Close();

                    // トランザクション開始
                    tran = conn.BeginTransaction();

                    com.Connection = conn;
                    com.Transaction = tran;

                    com.CommandText = "DELETE FROM TBLM_COMPANY WHERE CODE=@code";

                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    foreach (DataGridViewRow row in gridViewCompany.SelectedRows)
                    {
                        int index = row.Index;
                        gridViewCompany.Rows.Remove(row);
                        if (index != 0)
                        {
                            gridViewCompany.Rows[index - 1].Selected = true;
                        }
                        btnDel_Click(null, null);
                        break;
                    }

                    MessageBox.Show("削除しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void upd_func(string pramCode, string paramName, bool del_flg)
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

                    com.CommandText = "UPDATE TBLM_COMPANY SET NAME=@name, DEL_FLG=@del_flg WHERE CODE=@code";

                    com.Parameters.AddWithValue("@code", pramCode);
                    com.Parameters.AddWithValue("@del_flg", UtilString.changeDelFlg(del_flg));
                    com.Parameters.AddWithValue("@name", paramName);
                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    foreach (DataGridViewRow row in gridViewCompany.SelectedRows)
                    {
                        row.Cells[GRID_CODE].Value = pramCode;
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
        private void add_func(string pramCode, string paramName, bool del_flg)
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
                    // コードの存在チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT COUNT(*) FROM TBLM_COMPANY WHERE CODE=@code";
                    com.Parameters.AddWithValue("@code", pramCode);

                    SqlDataReader cReader = com.ExecuteReader();

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
                    com.CommandText = "INSERT INTO TBLM_COMPANY(CODE,NAME,SHOW_NUM,DEL_FLG) values(@code,@name,@show_num,@del_flg)";

                    com.Parameters.AddWithValue("@name", paramName);
                    com.Parameters.AddWithValue("@del_flg", UtilString.changeDelFlg(del_flg));
                    com.Parameters.AddWithValue("@show_num", 1);
                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    gridViewCompany.Rows.Add(pramCode, paramName, del_flg);
                    gridViewCompany.Rows[gridViewCompany.Rows.Count - 1].Selected = true;
                    if (gridViewCompany.Rows.Count > 19)
                    {
                        gridViewCompany.FirstDisplayedScrollingRowIndex = gridViewCompany.Rows.Count - 18;
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
        // 検索テキスト変更時
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
                MessageBox.Show("コードか会社名を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            search_func(textSearch.Text.ToUpper(), flag);
        }

        /////////////////////////////////////////////////////
        // 検索処理
        /////////////////////////////////////////////////////
        private void search_func(string paramValue, int serachFlg)
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
                    sqlbuf.Append("SELECT CODE,NAME,DEL_FLG FROM TBLM_COMPANY");
                    switch (serachFlg)
                    {
                        case 1:
                            sqlbuf.Append(" WHERE CODE LIKE @code ORDER BY CODE");
                            com.Parameters.AddWithValue("@code", paramValue + "%");
                            break;
                        case 2:
                            sqlbuf.Append(" WHERE NAME LIKE @name ORDER BY CODE");
                            com.Parameters.AddWithValue("@name", "%" + paramValue + "%");
                            break;
                        default:
                            sqlbuf.Append(" ORDER BY CODE");
                            break;
                    }
                    com.CommandText = sqlbuf.ToString();
                    com.Connection = conn;
                    SqlDataReader cReader = com.ExecuteReader();

                    gridViewCompany.Rows.Clear();
                    bool del_flg;
                    while (cReader.Read())
                    {
                        if (cReader[2].ToString() == "1")
                        {
                            del_flg = true;
                        }
                        else
                        {
                            del_flg = false;
                        }
                        gridViewCompany.Rows.Add(cReader[0].ToString(),
                                                 cReader[1].ToString(), del_flg);
                    }
                    cReader.Close();
                    btnAdd_Click(null, null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("検索に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // コード消ボタン押下時
        /////////////////////////////////////////////////////
        private void btnCodeClear_Click(object sender, EventArgs e)
        {
            textCode.Text = "";
            textCode.Select();
        }

        /////////////////////////////////////////////////////
        // 会社名消ボタン押下時
        /////////////////////////////////////////////////////
        private void btnNameClear_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textName.Select();
        }

        /////////////////////////////////////////////////////
        // 検索名消ボタン押下時
        /////////////////////////////////////////////////////
        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            textSearch.Text = "";
            textSearch.Select();
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

    }
}
