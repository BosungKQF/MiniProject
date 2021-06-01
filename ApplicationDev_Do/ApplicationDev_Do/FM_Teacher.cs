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
    public partial class FM_Teacher : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion

        public FM_Teacher()
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

                #region Variable Init
                string userCode = txtUserCode.Text;
                string userName = txtUserName.Text;
                string startDate = dtpStart.Text.ToString();
                string endDate = dtpEnd.Text.ToString();
                string sClass = "";

                if (rdoSF.Checked == true) sClass = "스마트팩토리";
                else if (rdoBD.Checked == true) sClass = "빅데이터";
                else sClass = "";
                #endregion

                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT USERCODE, " +
                                                                   "USERID, " +
                                                                   "NAME, " +
                                                                   "PASSWORD, " +
                                                                   "CLASS, " +
                                                                   "REGISTDATE, " +
                                                                   "PERMISSION, " +
                                                                   "PHONE, " +
                                                                   "ADDRESS " +
                                                                   "FROM TB_5_TEACHER WITH(NOLOCK) " +
                                                                   $"WHERE USERCODE LIKE '%{userCode}%' " +
                                                                   $"AND NAME LIKE '%{userName}%' " +
                                                                   $"AND CLASS LIKE '%{sClass}%' " +
                                                                   $"AND REGISTDATE BETWEEN '{startDate}' AND '{endDate}'",
                                                                   Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dataGridView1Grid.DataSource = null;
                    return;
                }
                dataGridView1Grid.DataSource = DtTemp;
                #endregion

                #region Column Set
                dataGridView1Grid.Columns["USERCODE"].HeaderText = "교사코드";
                dataGridView1Grid.Columns["USERID"].HeaderText = "아이디";
                dataGridView1Grid.Columns["NAME"].HeaderText = "교사명";
                dataGridView1Grid.Columns["PASSWORD"].HeaderText = "비밀번호";
                dataGridView1Grid.Columns["CLASS"].HeaderText = "반";
                dataGridView1Grid.Columns["REGISTDATE"].HeaderText = "등록일자";
                dataGridView1Grid.Columns["PERMISSION"].HeaderText = "권한";
                dataGridView1Grid.Columns["PHONE"].HeaderText = "핸드폰번호";
                dataGridView1Grid.Columns["ADDRESS"].HeaderText = "주소";

                dataGridView1Grid.Columns[0].Width = 100;
                dataGridView1Grid.Columns[1].Width = 100;
                dataGridView1Grid.Columns[2].Width = 200;
                dataGridView1Grid.Columns[3].Width = 200;
                dataGridView1Grid.Columns[4].Width = 100;

                dataGridView1Grid.Columns["USERCODE"].ReadOnly = true;
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
            DataRow Dr = ((DataTable)dataGridView1Grid.DataSource).NewRow();
            ((DataTable)dataGridView1Grid.DataSource).Rows.Add(Dr);
            dataGridView1Grid.Columns["USERCODE"].ReadOnly = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1Grid.Rows.Count == 0) return;
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
                string delUserCode = dataGridView1Grid.CurrentRow.Cells["USERCODE"].Value.ToString();

                #region Transaction Commit
                Cmd.CommandText = $"DELETE TB_5_TEACHER WHERE USERCODE = '{delUserCode}'";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1Grid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Variable Init
            string userCode = dataGridView1Grid.CurrentRow.Cells["USERCODE"].Value.ToString();
            string userId = dataGridView1Grid.CurrentRow.Cells["USERID"].Value.ToString();
            string userName = dataGridView1Grid.CurrentRow.Cells["NAME"].Value.ToString();
            string userPw = dataGridView1Grid.CurrentRow.Cells["PASSWORD"].Value.ToString();
            string sClass = dataGridView1Grid.CurrentRow.Cells["CLASS"].Value.ToString();
            string regiDate = dataGridView1Grid.CurrentRow.Cells["REGISTDATE"].Value.ToString();
            string permission = dataGridView1Grid.CurrentRow.Cells["PERMISSION"].Value.ToString();

            if (userCode == "" || regiDate == "")
            {
                MessageBox.Show("'교사코드', '등록일자' 는 빈칸으로 남겨둘 수 없습니다.");
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
            string sDate = regiDate.Substring(0, 10);
            Cmd.CommandText = "UPDATE TB_5_TEACHER                     " +
                             $"   SET NAME   = '{userName}',           " +
                             $"       USERID   = '{userId}',           " +
                             $"       CLASS   = '{sClass}',            " +
                             $"       PASSWORD   = '{userPw}',         " +
                             $"       REGISTDATE  = '{sDate}',          " +
                             $"       PERMISSION  = '{permission}'     " +
                             $" WHERE USERCODE  = '{userCode}'         " +
                             " IF (@@ROWCOUNT =0)                      " +
                             " INSERT INTO TB_5_TEACHER (USERCODE,      USERID,      PASSWORD,         NAME,     CLASS,    REGISTDATE, PERMISSION) " +
                             $"VALUES (               '{userCode}',     '{userId}',  '{userPw}', '{userName}', '{sClass}', '{sDate}', '{permission}')";
            Cmd.ExecuteNonQuery();
            Txn.Commit();
            #endregion

            MessageBox.Show("성공적으로 저장하였습니다.");
            Conn.Close();
        }
    }
}
