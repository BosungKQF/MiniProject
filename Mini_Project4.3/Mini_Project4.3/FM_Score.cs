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
using Mini_Project4._3;


namespace Mini_Project4._3
{
    public partial class FM_Score : Form
    {
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion
        public FM_Score()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                string StName = txtName.Text;
                string sSemester = CbSemester.Text;
                #endregion

                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT StCode" +
                                                                   "SEMESTER" +
                                                                   "HW" +
                                                                   "PROJECT" +
                                                                   "FINAL" +
                                                                   "ATTENDANCE" +
                                                                   "SCORE" +
                                                                   "GRADE" +
                                                                   "FROM TB_5_SCORE WITH(NOLOCK) " +
                                                                   $"WHERE STNAME LIKE '%{StName}%' " +
                                                                   $"AND SEMESTER LIKE '%{sSemester}%' ", Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("검색 조건에 맞는 데이터가 없습니다.");
                    dgvScore.DataSource = null;
                    return;
                }
                dgvScore.DataSource = DtTemp;
                #endregion

                #region Column Set
                dgvScore.Columns["StCode"].HeaderText = "학생 코드";
                dgvScore.Columns["SEMESTER"].HeaderText = "분기";
                dgvScore.Columns["HW"].HeaderText = "과제";
                dgvScore.Columns["PROJECT"].HeaderText = "프로젝트";
                dgvScore.Columns["FINAL"].HeaderText = "최종시험";
                dgvScore.Columns["ATTENDANCE"].HeaderText = "출결";
                dgvScore.Columns["SCORE"].HeaderText = "총점";
                dgvScore.Columns["GRADE"].HeaderText = "등급";


                dgvScore.Columns[0].Width = 100;
                dgvScore.Columns[1].Width = 100;
                dgvScore.Columns[2].Width = 200;
                dgvScore.Columns[3].Width = 200;
                dgvScore.Columns[4].Width = 100;

                dgvScore.Columns["STCODE"].ReadOnly = true;
                dgvScore.Columns["SEMESTER"].ReadOnly = true;
                dgvScore.Columns["HW"].ReadOnly = true;
                dgvScore.Columns["PROJECT"].ReadOnly = true;
                dgvScore.Columns["FINAL"].ReadOnly = true;
                dgvScore.Columns["ATTENDANCE"].ReadOnly = true;
                dgvScore.Columns["SCORE"].ReadOnly = true;
                dgvScore.Columns["GRADE"].ReadOnly = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            {

                if (dgvScore.Rows.Count == 0) return;
                if (MessageBox.Show("선택된 데이터를 저장하시겠습니까??", "Save", MessageBoxButtons.YesNo) == DialogResult.No) return;

                #region Variable Init
                string sSTCODE = dgvScore.CurrentRow.Cells["STCODE"].Value.ToString();
                string sSEMESTER = dgvScore.CurrentRow.Cells["SEMESTER"].Value.ToString();
                string sHW = dgvScore.CurrentRow.Cells["HW"].Value.ToString();
                string sPROJECT = dgvScore.CurrentRow.Cells["PROJECT"].Value.ToString();
                string sFINAL = dgvScore.CurrentRow.Cells["FINAL"].Value.ToString();
                string sATTENDANCE = dgvScore.CurrentRow.Cells["ATTENDANCE"].Value.ToString();
                string sSCORE = dgvScore.CurrentRow.Cells["SCORE"].Value.ToString();
                string sGRADE = dgvScore.CurrentRow.Cells["GRADE"].Value.ToString();

                if (sSTCODE == "" || sSEMESTER == "")
                {
                    MessageBox.Show("'학생 코드', '분기'는 빈칸으로 남겨둘 수 없습니다.");
                    return;
                }

                if (sSEMESTER == "") sSEMESTER = "1";

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
                Cmd.CommandText = "UPDATE TB_CUST_HGU                     " +
                                 $"   SET STCODE      = '{sSTCODE}',       " +
                                 $"       SEMESTER    = '{sSEMESTER}',       " +
                                 $"       HW          = '{sHW}',        " +
                                 $"       PROJECT     = '{sPROJECT}',        " +
                                 $"       FINAL       = '{sFINAL}',      " +
                                 $"       ATTENDANCE  = '{sATTENDANCE}'," +
                                 $"       SCORE       = '{sSCORE}'           " +
                                 $"       GRADE       = '{sGRADE}'           " +
                                 $" WHERE STCODE      = '{sSTCODE}'         " + 
                                 $"   AND SEMSETER    = '{sSEMESTER}',         " + 
                                 " IF (@@ROWCOUNT =0)                     " +
                                 " INSERT INTO TB_5_SCORE (STCODE,     SEMESTER,     HW,     PROJECT,     FINAL,     ATTENDANCE,     SCORE,   GRADE) " +
                                 $"VALUES (               '{sSTCODE}' , '{sSEMESTER}', '{sHW}', '{sPROJECT}', '{sFINAL}', '{sATTENDANCE}', '{sSCORE}', '{sGRADE})";
                Cmd.ExecuteNonQuery();
                Txn.Commit();
                #endregion

                MessageBox.Show("성공적으로 저장하였습니다.");
                Conn.Close();
            }
        }
    }
}