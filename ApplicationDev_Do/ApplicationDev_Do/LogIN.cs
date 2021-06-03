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
    public partial class LogIN : Form
    {
        private SqlConnection Connect = null;
        public LogIN()
        {
            InitializeComponent();
            this.Tag = "FAIL";
        }

        public int failcount = 0;
        


        private void label3_Click(object sender, EventArgs e)
        {
            FM_Credit credit = new FM_Credit();
            credit.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FM_Credit credit = new FM_Credit();
            credit.Show();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string strCon = "Data Source = 222.235.141.8; " +
                "Initial Catalog = AppDev;" +
                "User ID=kfqs1;Password=1234";
            Connect = new SqlConnection(strCon);

            Connect.Open();//데이터베이스에 접속한다.
            if (Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터베이스 연결 실패. ");
                return;

            }


            String sLogInId = string.Empty;
            string sPerPw = string.Empty;


            sLogInId = txtUID.Text;
            sPerPw = txtPW.Text;



            SqlDataAdapter adapter = new SqlDataAdapter("SELECT CLASS,PERMISSION,NAME,PASSWORD,USERID,USERCODE FROM TB_5_USER WHERE USERID = '" + sLogInId + "'", Connect);
            //데이터를 담을 그릇

            DataTable DtTemp = new DataTable();
            //어댑터 실행 후 그릇의 데이터 담기
            adapter.Fill(DtTemp);

            // 데이터가 없는 경우 사용자가 없다고 메세지 및 리턴


            if (DtTemp.Rows.Count == 0)
            {
                MessageBox.Show("사용자 정보가 없습니다.");
                failcount = failcount + 1;
                if (failcount == 3)
                {
                    MessageBox.Show("3회 실패!");
                    Application.Exit();
                    return;
                }



            }

            else if (DtTemp.Rows[0]["PASSWORD"].ToString() != sPerPw)//row는 이름을 때릴 수 있다네?
            {

                MessageBox.Show("ID 또는 비밀번호가 일치하지 않습니다.");

                failcount = failcount + 1;
                if (failcount == 3)
                {
                    MessageBox.Show("3회 실패!");
                    Application.Exit();
                    return;
                }
            }

            else if ((DtTemp.Rows[0]["PASSWORD"].ToString() == sPerPw))
            {
                MessageBox.Show("환영합니다!");
                Common.LogInId = txtUID.Text;
                Common.LogInName = DtTemp.Rows[0]["NAME"].ToString();
                Common.Permission = DtTemp.Rows[0]["PERMISSION"].ToString();
                Common.Ucode = DtTemp.Rows[0]["USERCODE"].ToString();
                Common.Class = DtTemp.Rows[0]["CLASS"].ToString();

                this.Tag = DtTemp.Rows[0]["NAME"].ToString();
                this.Close();

                Connect.Close();

            }
        }
        private Point mousePoint;
        private void LogIN_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void LogIN_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void LogIN_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click_1(null, null);
            }
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
    }
}
