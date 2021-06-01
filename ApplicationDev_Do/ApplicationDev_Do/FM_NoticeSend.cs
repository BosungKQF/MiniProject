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
            if (sNoticeClass == "전체") sNoticeClass = "";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT  NAME FROM TB_5_STUDENT WHERE CLASS LIKE '%" + sNoticeClass + "%' ORDER BY CLASS, NAME", Conn);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);

            //lbStudent.DataSource = dtTemp;

            //lbStudent.DisplayMember = "NAME";
            //lbStudent.ValueMember = "NAME";

            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                lbStudent.Items.Add(dtTemp.Rows[i]["NAME"].ToString());
            }

            Conn.Close();
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtxtNotice.Text.Length == 0) { MessageBox.Show("내용을 입력하세요"); return; }
            if (MessageBox.Show("알림장을 보내시겠습니까?", "취소하였습니다",
                                 MessageBoxButtons.YesNo) == DialogResult.No) return;


            string sStudent = string.Empty;
            string sUserCode = string.Empty;
            string sMaker = string.Empty;
            string sNotice = string.Empty;
            foreach (int i in lbStudent.SelectedIndices)
            {

                Conn = new SqlConnection(ConnInfo);
                Conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT USERCODE, NAME, CLASS FROM TB_5_STUDENT WHERE NAME = '" + lbStudent.Items[i].ToString() + "'", Conn);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                sStudent = lbStudent.Items[i].ToString();
                sUserCode = dtTemp.Columns[0].ToString();
                sMaker = Common.LogInId;
                sNotice = rtxtNotice.Text;

                SqlCommand cmd = new SqlCommand();
                SqlTransaction Tran;
                Tran = Conn.BeginTransaction("TestTran");
                cmd.Transaction = Tran;
                cmd.Connection = Conn;
                cmd.CommandText = "INSERT INTO TB_5_NOTICE(USERCODE, USERNAME, NOTICEDATE, MAKER, NOTICE) " +
                              "VALUES ('" + sUserCode + "','" + sStudent + "',GETDATE(),'" + sMaker + "','" + sNotice + "')";

                cmd.ExecuteNonQuery();

                Tran.Commit();

            }  
            MessageBox.Show("정상적으로 등록 하였습니다.");
            Conn.Close();
        }
    }
}
