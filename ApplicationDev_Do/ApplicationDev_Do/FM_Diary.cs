using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDev_Do
{
    public partial class FM_Diary : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion
        public FM_Diary()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                #region Connection Open
                Conn = new SqlConnection(ConnInfo);
                Conn.Open();

                if (Conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Failed to connect to database.");
                    return;
                }
                #endregion
                string sCLASS = "";

                if (rdB1.Checked == true) sCLASS = "스마트팩토리";
                else if (rdB2.Checked == true) sCLASS = "빅데이터";


                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT USERCODE, " +
                                                                   "DIARYDATE, " +
                                                                   "CLASS, " +
                                                                   "DIARY, " +
                                                                   "MAKEDATE, " +
                                                                   "MAKER,  " +
                                                                   "EDITDATE, " +
                                                                   "EDITOR " +
                                                                   "FROM TB_5_DIARY WITH(NOLOCK) " +
                                                                   " WHERE CLASS LIKE '%" + sCLASS + "%' ", Conn);

                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dgvDiary.DataSource = null;
                    return;
                }
                dgvDiary.DataSource = DtTemp;
                #endregion

                #region Column Set
                dgvDiary.Columns["USERCODE"].HeaderText = "선생님 이름";
                dgvDiary.Columns["DIARYDATE"].HeaderText = "근무 일자";
                dgvDiary.Columns["CLASS"].HeaderText = "반";
                dgvDiary.Columns["DIARY"].HeaderText = "내용";
                dgvDiary.Columns["MAKEDATE"].HeaderText = "작성 일자";
                dgvDiary.Columns["MAKER"].HeaderText = "작성자";
                dgvDiary.Columns["EDITDATE"].HeaderText = "수정 일자";
                dgvDiary.Columns["EDITOR"].HeaderText = "수정자";

                dgvDiary.Columns[0].Width = 100;
                dgvDiary.Columns[1].Width = 100;
                dgvDiary.Columns[2].Width = 200;
                dgvDiary.Columns[3].Width = 200;
                dgvDiary.Columns[4].Width = 100;

                dgvDiary.Columns["USERCODE"].ReadOnly = true;
                dgvDiary.Columns["DIARYDATE"].ReadOnly = true;
                dgvDiary.Columns["MAKER"].ReadOnly = true;
                dgvDiary.Columns["MAKEDATE"].ReadOnly = true;
                dgvDiary.Columns["EDITOR"].ReadOnly = true;
                dgvDiary.Columns["EDITDATE"].ReadOnly = true;
                dgvDiary.Columns["CLASS"].ReadOnly = true;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvDiary.Rows.Count == 0) return;
            DataRow Dr = ((DataTable)dgvDiary.DataSource).NewRow();
            ((DataTable)dgvDiary.DataSource).Rows.Add(Dr);

            int MaxRow = dgvDiary.Rows.Count - 1;
            dgvDiary.Rows[MaxRow].Selected = true;
            dgvDiary.CurrentCell = dgvDiary.Rows[MaxRow].Cells[0];
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvDiary.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Variable Init
            string sTEACHERCODE = Common.LogInName;
            string sDIARYDATE = dtpDiary.Text;
            string sCLASS = "";
            string sMAKER = dgvDiary.CurrentRow.Cells["MAKER"].Value.ToString();

            if (txtDiary.Text == "")
            {
                MessageBox.Show("근무 일지 내용을 비워둘 수 없습니다.");
                return;
            }

            if (rdB1.Checked == true) sCLASS = "스마트팩토리";
            else if (rdB2.Checked == true) sCLASS = "빅데이터";
            #endregion

            #region Transaction Decl
            SqlCommand Cmd = new SqlCommand();
            SqlTransaction Txn;
            #endregion

            #region Connection Open
            Conn = new SqlConnection(ConnInfo);
            Conn.Open();
            #endregion

            #region Transaction Init
            Txn = Conn.BeginTransaction("Test Transaction");
            Cmd.Transaction = Txn;
            Cmd.Connection = Conn;
            #endregion

            #region Transaction Commit
            Cmd.CommandText = "UPDATE TB_5_DIARY                     " +
                             $"   SET USERCODE   = '{sTEACHERCODE}',       " +
                             $"       DIARYDATE   = '{sDIARYDATE}',       " +
                             $"       CLASS    = '{sCLASS}',        " +
                             $"       DIARY  = '{txtDiary.Text}',      " +
                             $"       EDITOR     = '{Common.LogInName}'," +
                             $"       EDITDATE   = GETDATE()           " +
                             $" WHERE USERCODE  = '{sTEACHERCODE}' AND DIARYDATE = '{sDIARYDATE}' " +
                             " IF (@@ROWCOUNT =0)                     " +
                             " INSERT INTO TB_5_DIARY (USERCODE,     DIARYDATE,     CLASS,     DIARY,     MAKER,     MAKEDATE) " +
                             $"VALUES (               '{sTEACHERCODE}', '{sDIARYDATE}', '{sCLASS}', '{txtDiary.Text}', '{Common.LogInName}', GETDATE())";
            Cmd.ExecuteNonQuery();
            Txn.Commit();
            #endregion

            MessageBox.Show("성공적으로 저장하였습니다.");
            Conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvDiary.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 삭제하시겠습니까?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Transaction Decl
            SqlCommand Cmd = new SqlCommand();
            SqlTransaction Txn;
            #endregion

            #region Connection Open
            Conn = new SqlConnection(ConnInfo);
            Conn.Open();
            #endregion

            #region Transaction Init
            Txn = Conn.BeginTransaction("Begin Transaction");
            Cmd.Transaction = Txn;
            Cmd.Connection = Conn;
            #endregion

            try
            {
                string delCode = dgvDiary.CurrentRow.Cells["USERCODE"].Value.ToString();
                string delCode2 = dgvDiary.CurrentRow.Cells["DIARYDATE"].Value.ToString();
                #region Transaction Commit
                Cmd.CommandText = $"DELETE TB_5_DIARY WHERE USERCODE = '{delCode}' AND DIARYDATE = '{delCode2}'";
                Cmd.ExecuteNonQuery();
                Txn.Commit();
                #endregion

                MessageBox.Show("성공적으로 데이터를 삭제하였습니다.");
                btnSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                Txn.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

        private void dgvDiary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}