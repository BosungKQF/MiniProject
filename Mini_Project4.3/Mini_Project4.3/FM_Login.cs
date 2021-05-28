﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project4._3
{
    public partial class FM_Login : Form
    {
        private SqlConnection Connect = null;
        public FM_Login()
        {
            InitializeComponent();
            this.Tag = "FAIL";
        }

        private Point mousePoint;
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
         
        }
        public int failcount = 0;
        private void button1_Click(object sender, EventArgs e)
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


            String sLogid = string.Empty;
            string sPerPw = string.Empty;

            sLogid = txtUID.Text;
            sPerPw = txtPW.Text;



            SqlDataAdapter adapter = new SqlDataAdapter("SELECT PW,USERNAME FROM TB_USER_KBS WHERE " +
               "USERID = '" + sLogid + "'", Connect);
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

            else if (DtTemp.Rows[0]["PW"].ToString() != sPerPw)//row는 이름을 때릴 수 있다네?
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




            else if ((DtTemp.Rows[0]["PW"].ToString() == sPerPw))
            {
                MessageBox.Show("환영합니다!");
                Common.LogInID = txtUID.Text;
                Common.LogInName = DtTemp.Rows[0]["USERNAME"].ToString();
                this.Tag = DtTemp.Rows[0]["USERNAME"].ToString(); //요건 종료될때까지 살아있나? 아니다.
                this.Close();



            }






        }
    }
}