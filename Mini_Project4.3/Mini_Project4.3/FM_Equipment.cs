using Mini_Project4._3;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApplicationDev_Do
{
    public partial class FM_Equipment : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion

        public FM_Equipment()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow Dr = ((DataTable)dgvGrid.DataSource).NewRow();
            ((DataTable)dgvGrid.DataSource).Rows.Add(Dr);
            dgvGrid.Columns["EQUIPCODE"].ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvGrid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Variable Init
            string equipCode = dgvGrid.CurrentRow.Cells["EQUIPCODE"].Value.ToString();
            string equipName = dgvGrid.CurrentRow.Cells["EQUIPNAME"].Value.ToString();
            string equipType = dgvGrid.CurrentRow.Cells["EQUIPTYPE"].Value.ToString();
            string purchaseDate = dgvGrid.CurrentRow.Cells["PURCHASEDATE"].Value.ToString();

            if (equipCode == "" || equipType == "" || purchaseDate == "")
            {
                MessageBox.Show("'비품코드', '비품타입', '구매일자' 는 빈칸으로 남겨둘 수 없습니다.");
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
            Cmd.CommandText = "UPDATE TB_5_EQUIPMENT                      " +
                             $"   SET EQUIPNAME   = '{equipName}',       " +
                             $"       EQUIPTYPE   = '{equipType}',       " +
                             $"       PURCHASEDATE  = '{purchaseDate}',      " +
                             $"       EDITOR     = '{Common.LogInID}'," +
                             $"       EDITDATE   = GETDATE()           " +
                             $" WHERE EQUIPCODE  = '{equipCode}'         " +
                             " IF (@@ROWCOUNT =0)                     " +
                             " INSERT INTO TB_5_EQUIPMENT (EQUIPCODE,     EQUIPTYPE,     EQUIPNAME,     PURCHASEDATE,   MAKEDATE,   MAKER) " +
                             $"VALUES (               '{equipCode}', '{equipType}', '{equipName}', '{purchaseDate}', GETDATE(), '{Common.LogInID}')";
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
                string delCustCode = dgvGrid.CurrentRow.Cells["EQUIPCODE"].Value.ToString();

                #region Transaction Commit
                Cmd.CommandText = $"DELETE TB_5_EQUIPMENT WHERE EQUIPCODE = '{delCustCode}'";
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
                string equipCode = txtEuipCode.Text;
                string equipName = txtEquipName.Text;
                string startDate = dtpStart.Text.ToString();
                string endDate = dtpEnd.Text.ToString();
                string equipType = "";

                if (rdoBook.Checked == true) equipType = "교재";
                else if (rdoTool.Checked == true) equipType = "교보재";
                else if (rdoEquip.Checked == true) equipType = "비품";
                else equipType = "";
                #endregion

                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT EQUIPCODE, " +
                                                                   "EQUIPNAME, " +
                                                                   "COUNT, " +
                                                                   "PURCHASEDATE, " +
                                                                   "MAKEDATE, " +
                                                                   "MAKER, " +
                                                                   "EDITDATE, " +
                                                                   "EDITOR " +
                                                                   "FROM TB_5_EQUIPMENT WITH(NOLOCK) " +
                                                                   $"WHERE EQUIPCODE LIKE '%{equipCode}%' " +
                                                                   $"AND EQUIPNAME LIKE '%{equipName}%' " +
                                                                   $"AND EQUIPTYPE LIKE '%{equipType}%' " +
                                                                   $"AND PURCHASEDATE BETWEEN '{startDate}' AND '{endDate}'",
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
                dgvGrid.Columns["EQUIPCODE"].HeaderText = "거래처 코드";
                dgvGrid.Columns["EQUIPNAME"].HeaderText = "비품명";
                dgvGrid.Columns["PURCHASEDATE"].HeaderText = "구매일자";
                dgvGrid.Columns["MAKEDATE"].HeaderText = "등록일시";
                dgvGrid.Columns["MAKER"].HeaderText = "등록자";
                dgvGrid.Columns["EDITDATE"].HeaderText = "수정일시";
                dgvGrid.Columns["EDITOR"].HeaderText = "수정자";

                dgvGrid.Columns[0].Width = 100;
                dgvGrid.Columns[1].Width = 100;
                dgvGrid.Columns[2].Width = 200;
                dgvGrid.Columns[3].Width = 200;
                dgvGrid.Columns[4].Width = 100;

                dgvGrid.Columns["EQUIPCODE"].ReadOnly = true;
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
