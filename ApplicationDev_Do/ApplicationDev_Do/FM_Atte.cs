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
    public partial class FM_Atte : Form
    {

        private SqlConnection connect = null; //접속 정보 객체 명명 
        string strCon = "Data Source = 222.235.141.8; " +
                "Initial Catalog = AppDev;" +
                "User ID=kfqs1;Password=1234";
        public FM_Atte()
        {
            InitializeComponent();

            if (Common.Permission == "S")
            {
                btnSave_Atte.Visible = false;
                
                txtExtra.Visible = false;
                lblClass.Visible = false;
                lblStudent.Visible = false;
                cmbClass_atte.Visible = false;
                cmbStudent_atte.Visible = false;
                rbAbs.Visible = false;
                rbAtte.Visible = false;

            }
        }

        private void FM_Atte_Load(object sender, EventArgs e)
        {


            try
            {

                connect = new SqlConnection(strCon);
                connect.Open();
                dtpStart_atte.Text = string.Format("{0:2020-01-01}", DateTime.Now);
                if (connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;
                }
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT NAME,STUDENTCODE,CLASS,ATTE,ATTEDATE,EXTRA FROM TB_5_ATT", connect);
                DataTable dtTemp = new DataTable();
                adapter.Fill(dtTemp);



                cmbStudent_atte.DataSource = dtTemp;
                cmbStudent_atte.DisplayMember = "NAME"; // 눈으로 보여줄 항목
                cmbStudent_atte.ValueMember = "NAME"; // 실제 데이터를 처리할 코드 항목 
                cmbStudent_atte.Text = "";

            }

            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT ITEMDETAIL FROM TB_TESTITEM_KBS ", connect);
            //DataTable dtTemp = new DataTable();
            //adapter.Fill(dtTemp);
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnAtte_Atte_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnSearch_Atte_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.DataSource = null;
                connect = new SqlConnection(strCon);
                connect.Open();

                if (connect.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("데이터 베이스 연결에 실패 하였습니다.");
                    return;

                }

                //조회를 위한 파라미터 설정

                string sStuCode = null;
                string bAttend = null;
                string sSD = dtpStart_atte.Text.ToString(); //date-time picker
                string sED = dtpEnd_atte.Text.ToString();
                string sNow = DateTime.Now.ToString();
                string sExtra = null;
                string sClass = null;
                string sName = null;
                //나머진 읽고 알아듣는게..
                if (Common.Permission == "S")
                {
                    sStuCode = Common.Ucode;
                    bAttend = "Y";
                }
                if (rbAtte.Checked == true) bAttend = "Y";
                else if (rbAbs.Checked == true) bAttend = "N";


                sClass = cmbClass_atte.Text;
                
                sName = cmbStudent_atte.Text;
                //SQL 제어구문 
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT NAME,  " +
                                                            
                                                            "       ATTEDATE,  " +
                                                            "       CLASS, "+
                                                            "       EXTRA, " +
                                                            
                                                            "       CASE WHEN ATTE = 'Y' THEN '출석'" +
                                                            "            WHEN ATTE = 'N' THEN '결석'" +
                                                            "            END AS 출결               " +

                                                            
                                                            "  FROM TB_5_ATT WITH(NOLOCK)  " +
                                                            " WHERE NAME LIKE '%" + sName + "%' " +

                                                            "   AND CLASS LIKE '%" + sClass + "%' " +
                                                            
                                                            "   AND ATTEDATE BETWEEN'" + sSD + "'AND'" + sED + "'"

                                                            , connect);
                //해당 sql문을 connect 스트링에 적혀있는 주소로 쿼리해줄 객체 생성
                //시스템에서 열리는 화면 한개를 한 본이라고 부른다.

                DataTable dtTemp = new DataTable();
                Adapter.Fill(dtTemp); //앞에서 해보았듯이, 빈 그릇을 챙겨와서...
                //adapter 객체가 해당 데이터테이블을 채우도록 해준다.

                if (dtTemp.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;

                    return; //아래 else 안해도 되도록...
                }

                //없으면 이 이벤트 종-료
                dataGridView1.DataSource = dtTemp; // 데이터 그리드 뷰에 (아까 채운) 데이터 테이블 등록

                // 그리드뷰의 헤더 명칭 선언
                
                dataGridView1.Columns["NAME"].HeaderText = "이름";
                dataGridView1.Columns["CLASS"].HeaderText = "반";
                
                dataGridView1.Columns["ATTE"].HeaderText = "출석여부";
                dataGridView1.Columns["ATTEDATE"].HeaderText = "출석일자";
                dataGridView1.Columns["EXTRA"].HeaderText = "비고";
                // 그리드 뷰의 폭 지정
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].Width = 200;
               
           

                // 컬럼의 수정 여부를 지정 한다


                
                dataGridView1.Columns["ATTEDATE"].ReadOnly = true;









            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connect.Close();

            }
        }
    }
}
