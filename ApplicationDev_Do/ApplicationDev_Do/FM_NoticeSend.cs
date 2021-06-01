using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApplicationDev_Do
{
    public partial class FM_NoticeSend : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion
        public FM_NoticeSend()
        {
            InitializeComponent();

            cboNoticeClass.SelectedValueChanged += cboNoticeClass_SelectedValueChanged;
        }
        private void FM_Notice_Load(object sender, EventArgs e)
        {
            
            try
            {

                Conn = new SqlConnection(ConnInfo);
                Conn.Open();

                if (Conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT CLASS FROM TB_5_STUDENT", Conn);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);


                cboNoticeClass.DataSource = dtTemp;
                cboNoticeClass.DisplayMember = "CLASS";
                cboNoticeClass.ValueMember = "CLASS";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                
            }

        }
        
        private void cboNoticeClass_SelectedValueChanged(object sender, EventArgs e)
        {
            #region Connection Open
            Conn = new SqlConnection(ConnInfo);
            Conn.Open();
            #endregion
            string sNoticeClass = cboNoticeClass.SelectedItem.ToString();
            if (sNoticeClass == "전체")
                sNoticeClass = "";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT  NAME FROM TB_5_STUDENT WHERE CLASS LIKE '%" + sNoticeClass + "%' ORDER BY CLASS, NAME", Conn);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);

            /*for (int i = 1; i < dtTemp.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(dtTemp.Rows[i].ToString());
            }*/

            //checkedListBox1.DisplayMember = "NAME";
            //checkedListBox1.ValueMember = "NAME";
            cboNoticeStudent.DataSource = dtTemp;
            cboNoticeStudent.DisplayMember = "NAME";
            cboNoticeStudent.ValueMember = "NAME";

            Conn.Close();
        }

        private void cboNoticeStudent_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboNoticeStudent_DropDown(object sender, EventArgs e)
        {
            checkedListBox1.Visible = true;
           
        }

        private void cboNoticeStudent_DropDownClosed(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }



        /*private void btnSend_Click(object sender, EventArgs e)
        {


            if (rtxtNotice.Text.Length == 0) { MessageBox.Show("내용을 입력하세요"); return; }
            if (MessageBox.Show("알림장을 보내시겠습니까?", "취소하였습니다",
                                 MessageBoxButtons.YesNo) == DialogResult.No) return;


            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Conn = new SqlConnection(ConnInfo);
            Conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * CLASS FROM TB_5_STUDENT WHERE USERNAME = '" + cboNoticeStudent + "'", Conn);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);

            List<>

            foreach (var name in collection)
            {

            }

            string sUserCode = dtTemp.Columns["USERCODE"].ToString();
            string sUserName = dtTemp.Columns["USERNAME"].ToString();
            string sNoticeDate =
            string sMaker = Common.LogInId;
            string sNotice = rtxtNotice.Text;




            //트랜잭션 설정
            Tran = Conn.BeginTransaction("TestTran");
            cmd.Transaction = Tran;
            cmd.Connection = Conn;

            #region @@ROWCOUNT 활용
            cmd.CommandText = "UPDATE TB_TestItem_PSS                                 " +
                              "   SET ITEMNAME  = '" + sItemName + "',     " +
                              "       ITEMDESC  = '" + sItemDesc + "',     " +
                              "       ITEMDESC2 = '" + sItemDesc2 + "',     " +
                              "       ENDFLAG   = '" + "N" + "',     " +
                              "       PRODDATE  = '" + sProdDate + "',     " +
                              "       EDITOR    = '" + Common.LogInID + "',     " +
                              "       EDITDATE  = GETDATE()                           " +
                              " WHERE ITEMCODE  = '" + sItemCode + "'      " +
                              "    IF (@@ROWCOUNT =0) " +
                              "INSERT INTO TB_TestItem_PSS(ITEMCODE, ITEMNAME, ITEMDESC, ITEMDESC2, ENDFLAG, PRODDATE, MAKEDATE, MAKER) " +
                              "VALUES ('" + sItemCode + "','" + sItemName + "','" + sItemDesc + "','" + sItemDesc2 + "','" + "N" + "','" + sProdDate + "',GETDATE(),'" + Common.LogInID + "')";
            #endregion


            cmd.ExecuteNonQuery();

            // 성공시 DB commit
            Tran.Commit();
            MessageBox.Show("정상적으로 등록 하였습니다.");
            Conn.Close();
        }*/
    }


}
