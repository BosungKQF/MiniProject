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
            rtxtNoticeDetail.ReadOnly = false;
            rtxtNoticeDetail.Text = Common.notice;
            rtxtNoticeDetail.ReadOnly = true;
        }

        private void rtxtNoticeDetail_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
