using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApplicationDev_Do
{
    public partial class NoticeDetail : Form
    {
        
        #region Connection Init
        private SqlConnection Conn = null;
        private string ConnInfo = Common.DbPath;
        #endregion
        public NoticeDetail()
        {
            InitializeComponent();
        }

        private void NoticeDetail_Load(object sender, EventArgs e)
        {
            try
            {
                #region Connection Open
                Conn = new SqlConnection(ConnInfo);
                Conn.Open();

                rtxtNoticeDetail.ReadOnly = false;
                if (Conn.State != System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Failed to connect to database.");
                    return;
                }
                #endregion
                string name = Common.LogInName;
                string code = Common.Ucode;
                #region Fill Data
                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT NOTICE " +
                                                            "  FROM TB_5_NOTICE " +
                                                           $"WHERE USERNAME LIKE '%{name}%' " +
                                                           $"AND USERCODE LIKE '%{code}%' ",Conn);
                DataTable DtTemp = new DataTable();
                Adapter.Fill(DtTemp);
                #endregion

                #region Show Data
                if (DtTemp.Rows.Count == 0)
                {
                    return;
                }
                rtxtNoticeDetail.Text = DtTemp.Rows[0]["NOTICE"].ToString();
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
            rtxtNoticeDetail.ReadOnly = true;
        }
    }
}
