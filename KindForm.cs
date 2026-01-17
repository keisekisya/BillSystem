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
    public partial class KindForm : Form
    {
        private int btnFlag = 0;

        private const int GRID_CODE = 0;
        private const int GRID_NAME = 1;
        private const int GRID_DEL_FLG = 2;

        public KindForm()
        {
            InitializeComponent();
        }

        private void KindForm_Load(object sender, EventArgs e)
        {
            // 行の高さを設定
            gridViewKind.RowTemplate.Height = 36;

            // フォントを設定
            gridViewKind.Font = new System.Drawing.Font("MS UI Gothic", 13.80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));

            // DBよりデータを取得
            search_func();
            btnAdd_Click(null, null);
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
                                           gridViewKind.RowHeadersWidth - 4,
                                           e.RowBounds.Height);

            // 上記の長方形内に行番号を縦方向中央＆右詰めで描画する
            // フォントや前景色は行ヘッダの既定値を使用する
            TextRenderer.DrawText(e.Graphics,
                                  (e.RowIndex + 1).ToString(),
                                  gridViewKind.RowHeadersDefaultCellStyle.Font,
                                  rect,
                                  gridViewKind.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /////////////////////////////////////////////////////
        // 削除ボタン押下時
        /////////////////////////////////////////////////////
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (gridViewKind.SelectedRows.Count == 0)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in gridViewKind.SelectedRows)
            {
                setGridRowData(row);
                break;
            }

            gridViewKind.Enabled = false;    // テーブル
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
            if (gridViewKind.SelectedRows.Count == 0)
            {
                MessageBox.Show("行を選択して下さい。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in gridViewKind.SelectedRows)
            {
                setGridRowData(row);
                break;
            }

            gridViewKind.Enabled = false;    // テーブル
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
            gridViewKind.Enabled = true;    // テーブル
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
                         bufMsg.Append("種類を入力して下さい。\n");
                     }
                     if (bufMsg.Length != 0)
                     {
                         MessageBox.Show(bufMsg.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                     }

                    upd_func(textCode.Text, textName.Text, checkDelFlg.Checked);
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
                        bufMsg.Append("種類を入力して下さい。\n");
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
                    com.CommandText = "SELECT COUNT(*) FROM TBLT_PRICE WHERE KIND_CODE = @code";
                    com.Parameters.AddWithValue("@code", paramCode);

                    SqlDataReader cReader = com.ExecuteReader();

                    while (cReader.Read())
                    {
                        if (cReader[0].ToString() != "0")
                        {
                            cReader.Close();
                            MessageBox.Show("その種類は使用されている為、削除出来ません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    cReader.Close();

                    // トランザクション開始
                    tran = conn.BeginTransaction();

                    com.Connection = conn;
                    com.Transaction = tran;

                    com.CommandText = "DELETE FROM TBLM_KIND WHERE CODE=@code";

                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    MessageBox.Show("削除しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (DataGridViewRow row in gridViewKind.SelectedRows)
                    {
                        int index = row.Index;
                        gridViewKind.Rows.Remove(row);
                        if (index != 0)
                        {
                            gridViewKind.Rows[index - 1].Selected = true;
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

                    ////////////////////////////////////////////////////
                    // 名称の存在チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT COUNT(*) FROM TBLM_KIND WHERE NAME=@name AND CODE <> @code";
                    com.Parameters.AddWithValue("@name", paramName);
                    com.Parameters.AddWithValue("@code", pramCode);

                    SqlDataReader cReader = com.ExecuteReader();

                    if (cReader.Read())
                    {
                        if (cReader[0].ToString() != "0")
                        {
                            cReader.Close();
                            MessageBox.Show("その名称は既に使用されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    cReader.Close();

                    // トランザクション開始
                    tran = conn.BeginTransaction();

                    com.Connection = conn;
                    com.Transaction = tran;

                    com.CommandText = "UPDATE TBLM_KIND SET NAME=@name, DEL_FLG=@del_flg WHERE CODE=@code";

                    com.Parameters.AddWithValue("@del_flg", UtilString.changeDelFlg(del_flg));
                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    MessageBox.Show("修正しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (DataGridViewRow row in gridViewKind.SelectedRows)
                    {
                        row.Cells[GRID_CODE].Value = pramCode;
                        row.Cells[GRID_NAME].Value = paramName;
                        row.Cells[GRID_DEL_FLG].Value = del_flg;
                        break;
                    }
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
                    com.CommandText = "SELECT COUNT(*) FROM TBLM_KIND WHERE CODE=@code";
                    com.Parameters.AddWithValue("@code", pramCode);

                    SqlDataReader cReader = com.ExecuteReader();

                    if (cReader.Read())
                    {
                        if (cReader[0].ToString() != "0")
                        {
                            cReader.Close();
                            MessageBox.Show("そのコードは既に使用されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    cReader.Close();

                    ////////////////////////////////////////////////////
                    // 名称の存在チェックを行う
                    ////////////////////////////////////////////////////
                    com.CommandText = "SELECT COUNT(*) FROM TBLM_KIND WHERE NAME=@name";
                    com.Parameters.AddWithValue("@name", paramName);

                    cReader = com.ExecuteReader();

                    if (cReader.Read())
                    {
                        if (cReader[0].ToString() != "0")
                        {
                            cReader.Close();
                            MessageBox.Show("その名称は既に使用されています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    com.CommandText = "INSERT INTO TBLM_KIND(CODE,NAME,DEL_FLG) values(@code,@name,@del_flg)";

                    com.Parameters.AddWithValue("@del_flg", UtilString.changeDelFlg(del_flg));
                    com.ExecuteNonQuery();

                    // コミット
                    tran.Commit();

                    gridViewKind.Rows.Add(pramCode, paramName, del_flg);
                    gridViewKind.Rows[gridViewKind.Rows.Count - 1].Selected = true;
                    MessageBox.Show("登録しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (tran != null)
                    {
                        tran.Rollback();
                    }
                    MessageBox.Show("登録に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        // 検索処理
        /////////////////////////////////////////////////////
        private void search_func()
        {
            // DBよりデータを取得
            using (SqlConnection conn = new SqlConnection(BillFormConst.CONNECT))
            {
                SqlCommand com = null;

                try
                {
                    conn.Open();

                    com = conn.CreateCommand();
                    com.CommandText = "SELECT CODE,NAME,DEL_FLG FROM TBLM_KIND ORDER BY CODE";
                    com.Connection = conn;
                    SqlDataReader cReader = com.ExecuteReader();

                    gridViewKind.Rows.Clear();
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
                        gridViewKind.Rows.Add(cReader[0].ToString(),
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
        }

        /////////////////////////////////////////////////////
        // 種類名消ボタン押下時
        /////////////////////////////////////////////////////
        private void btnNameClear_Click(object sender, EventArgs e)
        {
            textName.Text = "";
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
