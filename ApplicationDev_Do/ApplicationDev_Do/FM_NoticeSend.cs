using System;
using System.Collections.Generic;
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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT  NAME FROM TB_5_STUDENT WHERE CLASS LIKE '%" + sNoticeClass + "%' ORDER BY CLASS, NAME", Conn);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);

            lbStudent.DataSource = dtTemp;
            lbStudent.DisplayMember = "NAME";
            lbStudent.ValueMember = "NAME";

            Conn.Close();
        }


        private void cboNoticeStudent_DropDown(object sender, EventArgs e)
        {
            lbStudent.Visible = true;

        }

        private void cboNoticeStudent_DropDownClosed(object sender, EventArgs e)
        {
            lbStudent.Visible = false;

        }

        private void lbStudent_Click(object sender, EventArgs e)
        {
            lbStudent.Size = new System.Drawing.Size(136, 280);
            lbStudent.BringToFront();
            textBox1.ReadOnly = false;



        }

        private void rtxtNotice_Click(object sender, EventArgs e)
        {


            lbStudent.Size = new System.Drawing.Size(136, 28);

            textBox1.ReadOnly = true;

        }

        private void lbStudent_SelectedValueChanged(object sender, EventArgs e)
        {



        }

        /*private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtxtNotice.Text.Length == 0) { MessageBox.Show("내용을 입력하세요"); return; }
            if (MessageBox.Show("알림장을 보내시겠습니까?", "취소하였습니다",
                                 MessageBoxButtons.YesNo) == DialogResult.No) return;



            Conn = new SqlConnection(ConnInfo);
            Conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * CLASS FROM TB_5_STUDENT WHERE USERNAME = '" + lbStudent.SelectedValue.ToString() + "'", Conn);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);

            SqlCommand cmd = new SqlCommand();
            SqlTransaction Tran;

            Tran = Conn.BeginTransaction("TestTran");
            cmd.Transaction = Tran;
            cmd.Connection = Conn;

            string USERCODE = dtTemp.Columns[""].;
            string USERNAME = lbStudent.SelectedValue.ToString();
            string MAKER = Common.LogInId;
            string NOTICE = rtxtNotice.Text;

            cmd.CommandText = "INSERT INTO TB_NOTICE(USERCODE, USERNAME, NOTICEDATE, MAKER, NOTICE) " +
                              "VALUES ('" + USERCODE + "','" + USERNAME + "',GETDATE(),'" + MAKER + "','" + NOTICE + "')";

            cmd.ExecuteNonQuery();

            Tran.Commit();
            MessageBox.Show("정상적으로 등록 하였습니다.");
            Conn.Close();

        }*/

    }


}
