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
    public partial class FM_Student : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion

        public FM_Student()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow Dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(Dr);
            dgvGrid.Columns["USERCODE"].ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Variable Init
            string studCode = dgvGrid.CurrentRow.Cells["USERCODE"].Value.ToString();
            string studName = dgvGrid.CurrentRow.Cells["NAME"].Value.ToString();
            string sClass = dgvGrid.CurrentRow.Cells["CLASS"].Value.ToString();
            string firstDate = dgvGrid.CurrentRow.Cells["FIRSTDATE"].Value.ToString();

            if (studCode == "" || firstDate == "")
            {
                MessageBox.Show("'거래처 코드', '수강일자' 는 빈칸으로 남겨둘 수 없습니다.");
                return;
            }
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
            Cmd.CommandText = "UPDATE TB_5_STUDENT                      " +
                             $"   SET NAME   = '{studName}',       " +
                             $"       CLASS   = '{sClass}',       " +
                             $"       FIRSTDATE  = '{firstDate}',      " +
                             $"       EDITOR     = '{Common.LogInId}'," +
                             $"       EDITDATE   = GETDATE()           " +
                             $" WHERE USERCODE  = '{studCode}'         " +
                             " IF (@@ROWCOUNT =0)                     " +
                             " INSERT INTO TB_5_STUDENT (USERCODE,     NAME,     CLASS,    FIRSTDATE,   MAKEDATE,   MAKER) " +
                             $"VALUES (               '{studCode}','{studName}', '{sClass}', '{firstDate}', GETDATE(), '{Common.LogInId}')";
            Cmd.ExecuteNonQuery();
            Txn.Commit();
            #endregion

            MessageBox.Show("성공적으로 저장하였습니다.");
            Conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvGrid.Rows.Count == 0) return;
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
                string delCustCode = dgvGrid.CurrentRow.Cells["USERCODE"].Value.ToString();

                #region Transaction Commit
                Cmd.CommandText = $"DELETE TB_5_STUDENT_1 WHERE CUSTCODE = '{delCustCode}'";
                Cmd.ExecuteNonQuery();
                Txn.Commit();
                #endregion

                MessageBox.Show("성공적으로 데이터를 삭제하였습니다.");
                btnSearch_Click_1(null, null);
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

        private void btnSearch_Click_1(object sender, EventArgs e)
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

                #region Variable Init
                string studCode = txtStudCode.Text;
                string studName = txtStudName.Text;
                string startDate = dtpStart.Text.ToString();
                string endDate = dtpEnd.Text.ToString();
                string sClass = "";

                if (rdoSF.Checked == true) sClass = "스마트팩토리";
                else if (rdoBD.Checked == true) sClass = "빅데이터";
                else sClass = "";
                #endregion

                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT USERCODE, " +
                                                                   "NAME, " +
                                                                   "CLASS, " +
                                                                   "FIRSTDATE, " +
                                                                   "MAKEDATE, " +
                                                                   "MAKER, " +
                                                                   "EDITDATE, " +
                                                                   "EDITOR " +
                                                                   "FROM TB_5_STUDENT WITH(NOLOCK) " +
                                                                   $"WHERE USERCODE LIKE '%{studCode}%' " +
                                                                   $"AND NAME LIKE '%{studName}%' " +
                                                                   $"AND CLASS LIKE '%{sClass}%' " +
                                                                   $"AND FIRSTDATE BETWEEN '{startDate}' AND '{endDate}'",
                                                                   Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dgvGrid.DataSource = null;
                    return;
                }
                dgvGrid.DataSource = DtTemp;
                #endregion

                #region Column Set
                dgvGrid.Columns["USERCODE"].HeaderText = "학생코드";
                dgvGrid.Columns["NAME"].HeaderText = "학생명";
                dgvGrid.Columns["CLASS"].HeaderText = "반";
                dgvGrid.Columns["FIRSTDATE"].HeaderText = "수강일자";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 100;
                dgvGrid.Columns[2].Width = 200;
                dgvGrid.Columns[3].Width = 200;
                dgvGrid.Columns[4].Width = 100;

                dgvGrid.Columns["USERCODE"].ReadOnly = true;
                dgvGrid.Columns["MAKER"].ReadOnly = true;
                dgvGrid.Columns["MAKEDATE"].ReadOnly = true;
                dgvGrid.Columns["EDITOR"].ReadOnly = true;
                dgvGrid.Columns["EDITDATE"].ReadOnly = true;
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
    }
}
