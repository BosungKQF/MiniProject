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
 
    public partial class FM_Score : Form
    {

        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion
        public FM_Score()
        {
            InitializeComponent();
            if (Common.Permission == "S")
            {
                btnSave.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
            }

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

                #region Variable Init
                string StName = "";
                string sAttendance = "";
                if (Common.Permission == "S")
                {
                    StName = Common.LogInName;
                    txtName.Text = StName;
                }
                else
                {
                    StName = txtName.Text;
                }

                string sSemester = CbSemester.Text;


                #endregion

                #region Fill Data
                String sSql = "SELECT A.USERCODE," +
                                                                   " B.NAME," +
                                                                   " A.SEMESTER," +
                                                                   " A.HW," +
                                                                   " A.PROJECT," +
                                                                   " A.FINAL," +
                                                                   " A.ATTENDANCE," +
                                                                   " A.SCORE," +
                                                                   " A.GRADE " +
                                                                   " FROM TB_5_SCORE A WITH(NOLOCK) " +
                                                                   " LEFT JOIN TB_5_STUDENT B WITH (NOLOCK) ON A.USERCODE = B.USERCODE" +
                                                                   " WHERE B.NAME LIKE '%" + StName + "%' " +
                                                                   " AND A.SEMESTER LIKE '%" + sSemester + "%' ";
                SqlDataAdapter Adapter = new SqlDataAdapter(sSql, Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dgvScore.DataSource = null;
                    return;
                }
                dgvScore.DataSource = DtTemp;
                #endregion

                #region Column Set
                dgvScore.Columns["USERCODE"].HeaderText = "학생 코드";
                dgvScore.Columns["NAME"].HeaderText = "학생 이름";
                dgvScore.Columns["SEMESTER"].HeaderText = "분기";
                dgvScore.Columns["HW"].HeaderText = "과제(20)";
                dgvScore.Columns["PROJECT"].HeaderText = "프로젝트(30)";
                dgvScore.Columns["FINAL"].HeaderText = "최종시험(40)";
                dgvScore.Columns["ATTENDANCE"].HeaderText = "출결(10)";
                dgvScore.Columns["SCORE"].HeaderText = "총점(100)";
                dgvScore.Columns["GRADE"].HeaderText = "등급";



                dgvScore.Columns[0].Width = 100;
                dgvScore.Columns[1].Width = 100;
                dgvScore.Columns[2].Width = 200;
                dgvScore.Columns[3].Width = 200;
                dgvScore.Columns[4].Width = 100;


                if (Common.Permission == "S")
                {
                    dgvScore.Columns["USERCODE"].ReadOnly = true;
                    dgvScore.Columns["SEMESTER"].ReadOnly = true;
                    dgvScore.Columns["HW"].ReadOnly = true;
                    dgvScore.Columns["PROJECT"].ReadOnly = true;
                    dgvScore.Columns["FINAL"].ReadOnly = true;
                    dgvScore.Columns["ATTENDANCE"].ReadOnly = true;
                    dgvScore.Columns["SCORE"].ReadOnly = true;
                    dgvScore.Columns["GRADE"].ReadOnly = true;
                }
                else
                {
                    dgvScore.Columns["USERCODE"].ReadOnly = false;
                    dgvScore.Columns["SEMESTER"].ReadOnly = false;
                    dgvScore.Columns["HW"].ReadOnly = false;
                    dgvScore.Columns["PROJECT"].ReadOnly = false;
                    dgvScore.Columns["FINAL"].ReadOnly = false;
                    dgvScore.Columns["ATTENDANCE"].ReadOnly = false;
                    dgvScore.Columns["SCORE"].ReadOnly = false;
                    dgvScore.Columns["GRADE"].ReadOnly = false;
                }
            }
            #endregion

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvScore.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Variable Init
            string sSTCODE = dgvScore.CurrentRow.Cells["USERCODE"].Value.ToString();
            string sSEMESTER = dgvScore.CurrentRow.Cells["SEMESTER"].Value.ToString();
            string sHW = dgvScore.CurrentRow.Cells["HW"].Value.ToString();
            string sPROJECT = dgvScore.CurrentRow.Cells["PROJECT"].Value.ToString();
            string sFINAL = dgvScore.CurrentRow.Cells["FINAL"].Value.ToString();
            string sATTENDANCE = dgvScore.CurrentRow.Cells["ATTENDANCE"].Value.ToString();
            string sSCORE = dgvScore.CurrentRow.Cells["SCORE"].Value.ToString();
            string sGRADE = dgvScore.CurrentRow.Cells["GRADE"].Value.ToString();

            try
            {
                if (sSCORE == "") sSCORE = "0";
                if (sHW == "") sHW = "0";
                if (sPROJECT == "") sPROJECT = "0";
                if (sFINAL == "") sFINAL = "0";
                if (sATTENDANCE == "") sATTENDANCE = "0";
                if (int.Parse(sHW) > 20 || int.Parse(sPROJECT) > 30 || int.Parse(sFINAL) > 40 || int.Parse(sATTENDANCE) > 10)
                {
                    MessageBox.Show("최대 점수보다 높습니다.");
                    return;
                }
            }
            catch  
            {
                MessageBox.Show("숫자로만 입력하세요");
                return;
            }





            if (sSTCODE == "" || sSEMESTER == "")
            {
                MessageBox.Show("'학생 코드', '분기'는 빈칸으로 남겨둘 수 없습니다.");
                return;
            }

            if (sSEMESTER == "") sSEMESTER = "1";

            if (int.Parse(sSCORE) >= 90) sGRADE = "A";
            else if (int.Parse(sSCORE) >= 80) sGRADE = "B";
            else if (int.Parse(sSCORE) >= 70) sGRADE = "C";
            else if (int.Parse(sSCORE) >= 60) sGRADE = "D";
            else sGRADE = "F";





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
            Cmd.CommandText = "UPDATE TB_5_SCORE                     " +
                             $"   SET USERCODE      = '{sSTCODE}',       " +
                             $"       SEMESTER    = '{sSEMESTER}',       " +
                             $"       HW          = '{sHW}',        " +
                             $"       PROJECT     = '{sPROJECT}',        " +
                             $"       FINAL       = '{sFINAL}',      " +
                             $"       ATTENDANCE  = '{sATTENDANCE}'," +
                             $"       SCORE       = '{sSCORE}' ,          " +
                             $"       GRADE       = '{sGRADE}'           " +
                             $" WHERE USERCODE      = '{sSTCODE}'         " +
                             $"   AND SEMESTER    = '{sSEMESTER}'         " +
                             " IF (@@ROWCOUNT =0)                     " +
                             " INSERT INTO TB_5_SCORE (USERCODE,SEMESTER,HW,PROJECT,FINAL,ATTENDANCE,SCORE,GRADE)" +
                             $"VALUES ('{sSTCODE}','{sSEMESTER}','{sHW}','{sPROJECT}','{sFINAL}','{sATTENDANCE}','{sSCORE}','{sGRADE}')";
            Cmd.ExecuteNonQuery();
            Txn.Commit();
            #endregion

            MessageBox.Show("성공적으로 저장하였습니다.");
            Conn.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow Dr = ((DataTable)dgvScore.DataSource).NewRow();
            ((DataTable)dgvScore.DataSource).Rows.Add(Dr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvScore.Rows.Count == 0) return;
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
                string delCode = dgvScore.CurrentRow.Cells["USERCODE"].Value.ToString();

                #region Transaction Commit
                Cmd.CommandText = $"DELETE TB_5_SCORE WHERE USERCODE = '{delCode}'";
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

        private void dgvScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}