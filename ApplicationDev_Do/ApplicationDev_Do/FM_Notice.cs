using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApplicationDev_Do
{
    public partial class FM_Notice : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion

        public FM_Notice()
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







                
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAKER" +
                                                            "     , CLASS" + 
                                                            "     , MAKER" +
                                                            "  FROM TB_5_STUDENT AS N " + 
                                                            "  LEFT OUTER JOIN TB_5_STUDENT AS S " +
                                                            "    ON N.USERCODE = S.USERCODE", Conn);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                
                cboSNoticeClass.DataSource = dtTemp;
                cboSNoticeClass.DisplayMember = "CLASS"; 
                cboSNoticeClass.ValueMember = "CLASS";

                cboSNoticeMaker.DataSource = dtTemp;
                cboSNoticeMaker.DisplayMember = "MAKER";
                cboSNoticeMaker.ValueMember = "MAKER";



                dtpNoticStart.Text = string.Format("{0:yyyy-MM-01}", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
        }

        private void btnNoticeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNotice.DataSource = null;
                Conn = new SqlConnection(ConnInfo);
                Conn.Open();


                if (Conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }
                // 조회를 위한 파라매터 설정
                string sNoticeClass = cboSNoticeClass.Text;
                string sNoticeMaker = cboSNoticeMaker.Text;
                string sNoticeStart = dtpNoticStart.Text;     
                string sNoticeEnd = dtpNoticeEnd.Text;
                

                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT NOTICEDATE,  " +
                                                            "       CLASS,  " +
                                                            "       USERNAME,  " +
                                                            "       MAKER, " +
                                                            "       NOTICE  " +
                                                            "  FROM TB_5_NOTICE " +
                                                            $"WHERE CLASS = '{sNoticeClass}' AND MAKER = '{sNoticeMaker}'", Conn);

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp);

                if (dtTemp.Rows.Count == 0)
                {
                    dgvNotice.DataSource = null;
                    return;
                }
                dgvNotice.DataSource = dtTemp;
                // 데이터 그리드 뷰에  데이터 테이블 등록
                // 그리드뷰 헤더 명칭 선언
                dgvNotice.Columns["NOTICEDATE"].HeaderText = "보낸 날짜";
                dgvNotice.Columns["CLASS"].HeaderText = "반";
                dgvNotice.Columns["USERNAME"].HeaderText = "이름";
                dgvNotice.Columns["MAKER"].HeaderText = "작성자";
                dgvNotice.Columns["NOTICE"].HeaderText = "상세내용";


                // 그리드 뷰의 폭 지정
                dgvNotice.Columns[0].Width = 200;
                dgvNotice.Columns[1].Width = 100;
                dgvNotice.Columns[2].Width = 100;
                dgvNotice.Columns[3].Width = 100;
                dgvNotice.Columns[4].Width = 200;

                // 컬럼의 수정 여부를 NOTICEDATE 한다
                dgvNotice.Columns["NOTICEDATE"].ReadOnly = true;
                dgvNotice.Columns["CLASS"].ReadOnly = true;
                dgvNotice.Columns["USERNAME"].ReadOnly = true;
                dgvNotice.Columns["MAKER"].ReadOnly = true;
                dgvNotice.Columns["NOTICE"].ReadOnly = true;

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

        private void cboSNoticeMaker_SelectedValueChanged(object sender, EventArgs e)
        {
 
        }

        private void cboSNoticeClass_SelectedValueChanged(object sender, EventArgs e)
        {
            cboSNoticeMaker.Items.Clear();
            #region Connection Open
            Conn = new SqlConnection(ConnInfo);
            Conn.Open();
            #endregion

            string sNoticeClass = cboSNoticeClass.SelectedItem.ToString();
            if (sNoticeClass == "전체") sNoticeClass = "";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT NAME FROM TB_5_STUDENT WHERE CLASS LIKE '%" + sNoticeClass + "%' ORDER BY CLASS, NAME", Conn);
            DataTable dtTemp = new DataTable();
            adapter.Fill(dtTemp);


            for (int i = 0; i < dtTemp.Rows.Count; i++)
            {
                cboSNoticeMaker.Items.Add(dtTemp.Rows[i]["NAME"].ToString());
            }

            Conn.Close();
        }
    }
}
