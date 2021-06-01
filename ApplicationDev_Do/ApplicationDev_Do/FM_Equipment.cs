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
                                                                   "EQUIPTYPE, " +
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
                    dataGridView1Grid.DataSource = null;
                    return;
                }
                dataGridView1Grid.DataSource = DtTemp;
                #endregion

                #region Column Set
                dataGridView1Grid.Columns["EQUIPCODE"].HeaderText = "비품 코드";
                dataGridView1Grid.Columns["EQUIPTYPE"].HeaderText = "비품 종류";
                dataGridView1Grid.Columns["EQUIPNAME"].HeaderText = "비품명";
                dataGridView1Grid.Columns["COUNT"].HeaderText = "개수";
                dataGridView1Grid.Columns["PURCHASEDATE"].HeaderText = "구매일자";
                dataGridView1Grid.Columns["MAKEDATE"].HeaderText = "등록일시";
                dataGridView1Grid.Columns["MAKER"].HeaderText = "등록자";
                dataGridView1Grid.Columns["EDITDATE"].HeaderText = "수정일시";
                dataGridView1Grid.Columns["EDITOR"].HeaderText = "수정자";

                dataGridView1Grid.Columns[0].Width = 100;
                dataGridView1Grid.Columns[1].Width = 100;
                dataGridView1Grid.Columns[2].Width = 200;
                dataGridView1Grid.Columns[3].Width = 200;
                dataGridView1Grid.Columns[4].Width = 100;

                dataGridView1Grid.Columns["EQUIPCODE"].ReadOnly = true;
                dataGridView1Grid.Columns["MAKER"].ReadOnly = true;
                dataGridView1Grid.Columns["MAKEDATE"].ReadOnly = true;
                dataGridView1Grid.Columns["EDITOR"].ReadOnly = true;
                dataGridView1Grid.Columns["EDITDATE"].ReadOnly = true;
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            DataRow Dr = ((DataTable)dataGridView1Grid.DataSource).NewRow();
            ((DataTable)dataGridView1Grid.DataSource).Rows.Add(Dr);
            dataGridView1Grid.Columns["EQUIPCODE"].ReadOnly = false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1Grid.Rows.Count == 0) return;
            if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

            #region Variable Init
            string equipCode = dataGridView1Grid.CurrentRow.Cells["EQUIPCODE"].Value.ToString();
            string equipName = dataGridView1Grid.CurrentRow.Cells["EQUIPNAME"].Value.ToString();
            string equipType = dataGridView1Grid.CurrentRow.Cells["EQUIPTYPE"].Value.ToString();
            string count = dataGridView1Grid.CurrentRow.Cells["COUNT"].Value.ToString();
            string purchaseDate = dataGridView1Grid.CurrentRow.Cells["PURCHASEDATE"].Value.ToString();

            if (equipCode == "" || purchaseDate == "")
            {
                MessageBox.Show("'비품코드', '구매일자' 는 빈칸으로 남겨둘 수 없습니다.");
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
            string sDate =  purchaseDate.Substring(0, 10);
            Cmd.CommandText = "UPDATE TB_5_EQUIPMENT                      " +
                             $"   SET EQUIPNAME   = '{equipName}',       " +
                             $"       EQUIPTYPE   = '{equipType}',       " +
                             $"       COUNT   = '{count}',       " +
                             $"       PURCHASEDATE  = '{sDate}',      " +
                             $"       EDITOR     = '{Common.LogInId}'," +
                             $"       EDITDATE   = GETDATE()           " +
                             $" WHERE EQUIPCODE  = '{equipCode}'         " +
                             " IF (@@ROWCOUNT =0)                     " +
                             " INSERT INTO TB_5_EQUIPMENT (EQUIPCODE,     EQUIPTYPE,    COUNT,     EQUIPNAME,     PURCHASEDATE,   MAKEDATE,   MAKER) " +

                             $"VALUES (               '{equipCode}', '{equipType}',  '{count}', '{equipName}', '{sDate}', GETDATE(), '{Common.LogInId}')";  
                            // $"VALUES (               '{equipCode}', '{equipType}',  '{count}', '{equipName}', GETDATE(), GETDATE(), '{Common.LogInId}')";
            Cmd.ExecuteNonQuery();
            Txn.Commit();
            #endregion

            MessageBox.Show("성공적으로 저장하였습니다.");
            Conn.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
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
                string delEquipCode = dataGridView1Grid.CurrentRow.Cells["EQUIPCODE"].Value.ToString();

                #region Transaction Commit
                Cmd.CommandText = $"DELETE TB_5_EQUIPMENT WHERE EQUIPCODE = '{delEquipCode}'";
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
    }
}
