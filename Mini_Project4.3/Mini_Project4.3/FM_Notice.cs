using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApplicationDev_Do
{
    public partial class FM_Notice : Form
    {
        private SqlConnection Connect = null;   
        
        private string strConn = "Data Source=222.235.141.8; Initial Catalog=AppDev;User ID=kfqs1;Password=1234";
        public FM_Notice()
        {
            InitializeComponent();
        }
        private void FM_ITEM_Load(object sender, EventArgs e)
        {
            try
            {
                
                Connect = new SqlConnection(strConn);
                Connect.Open();

                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT CLASS FROM TB_5_NOTICE", Connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);

                

                cboNoticeClass.DataSource = dtTemp;
                cboNoticeClass.DisplayMember = "CLASS"; 
                cboNoticeClass.ValueMember = "CLASS";   
                cboNoticeClass.Text = "";

                cboNoticeMaker.DataSource = dtTemp;
                cboNoticeMaker.DisplayMember = "USERNAME"; 
                cboNoticeMaker.ValueMember = "USERNAME";   
                cboNoticeMaker.Text = "";


                dtpNoticStart.Text = string.Format("{0:yyyy-MM-01}", DateTime.Now);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnNoticeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNotice.DataSource = null;
                Connect = new SqlConnection(strConn);
                Connect.Open();


                if (Connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }
                // 조회를 위한 파라매터 설정
                string sNoticeClass = cboNoticeClass.Text;
                string sNoticeMaker = cboNoticeMaker.Text;
                string sNoticeStart = dtpNoticStart.Text;     
                string sNoticeEnd = dtpNoticeEnd.Text;
                

                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT NOTICEDATE,  " +
                                                            "       CLASS,  " +
                                                            "       USERNAME,  " +
                                                            "       MAKER, " +
                                                            "       NOTICE,  " +
                                                            "  FROM TB_5_NOTICE WITH(NOLOCK) " +
                                                            " WHERE CLASS LIKE '%" + sNoticeClass + "%' " +
                                                            "   AND MAKER LIKE '%" + sNoticeMaker + "%' " +
                                                            "   AND NOTICEDATE BETWEEN '" + sNoticeStart + "' AND '" + sNoticeEnd + "'", Connect);

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
                dgvNotice.Columns["ITEMCODE"].ReadOnly = true;
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
                Connect.Close();
            }
        }

        private void btnNoticSend_Click(object sender, EventArgs e)
        {

        }
    }
}
