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
    public partial class FM_GradeChart : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion

        public FM_GradeChart()
        {
            InitializeComponent();
        }

        private Point mousePoint;

        private void FM_GradeChart_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePoint.X = e.X;
                mousePoint.Y = e.Y;
            }
        }

        private void FM_GradeChart_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - mousePoint.X),

                this.Location.Y + (e.Y - mousePoint.Y));
            }
        }


        private void FM_GradeChart_Load(object sender, EventArgs e)
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
                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT USERCODE, " +
                                                                   "SEMESTER, " +
                                                                   "HW, " +
                                                                   "PROJECT, " +
                                                                   "FINAL, " +
                                                                   "ATTENDANCE, " +
                                                                   "SCORE, " +
                                                                   "GRADE " +
                                                                   "FROM TB_5_SCORE WITH(NOLOCK) " +
                                                                   $"WHERE USERCODE LIKE '{Common.sCode}' ",
                                                                   Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dgvGrade.DataSource = null;
                    this.Close();
                    return;
                }
                dgvGrade.DataSource = DtTemp;
                #endregion

                #region Column Set
                dgvGrade.Columns["USERCODE"].HeaderText = "학생코드";
                dgvGrade.Columns["SEMESTER"].HeaderText = "학기";
                dgvGrade.Columns["HW"].HeaderText = "과제";
                dgvGrade.Columns["PROJECT"].HeaderText = "프로젝트";
                dgvGrade.Columns["FINAL"].HeaderText = "기말고사";
                dgvGrade.Columns["ATTENDANCE"].HeaderText = "출석";
                dgvGrade.Columns["SCORE"].HeaderText = "점수";
                dgvGrade.Columns["GRADE"].HeaderText = "등급";

                dgvGrade.Columns[0].Width = 100;
                dgvGrade.Columns[1].Width = 100;
                dgvGrade.Columns[2].Width = 200;
                dgvGrade.Columns[3].Width = 200;
                dgvGrade.Columns[4].Width = 100;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
