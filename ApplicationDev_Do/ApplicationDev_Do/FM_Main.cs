using System;


using System.Windows.Forms;

namespace ApplicationDev_Do
{
    public partial class FM_Main : Form
    {
        public FM_Main()
        {
            InitializeComponent();
            customizeDesign();
            //FM_Login Login = new FM_Login();
            LogIN Login = new LogIN();

            Login.ShowDialog();

            //tssUserName.Text = Login.Tag.ToString();
            if (Login.Tag.ToString() == "FAIL")
            {
                System.Environment.Exit(0);
            }
        

            if (Common.Permission == "S")
            {
                btnStudent.Visible = false;
                btnTeacher.Visible = false;
                btnDiary.Visible = false;
                btnEquipment.Visible = false;
                btnSend_noti.Visible = false;
                
                panelSideMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#F8D948");
                panelInfoSubMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#dec44b");
                panelNoticeSubMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#dec44b");
                btnSearch_noti.BackColor = System.Drawing.ColorTranslator.FromHtml("#dec44b");
                panelSideMenu.ForeColor = System.Drawing.ColorTranslator.FromHtml("controltext");
                btnAttend.ForeColor = System.Drawing.ColorTranslator.FromHtml("controltext");
                btnInfo.ForeColor = System.Drawing.ColorTranslator.FromHtml("controltext");
                btnDiary.ForeColor = System.Drawing.ColorTranslator.FromHtml("controltext");
                btnNotice.ForeColor = System.Drawing.ColorTranslator.FromHtml("controltext");
                btnScore.ForeColor = System.Drawing.ColorTranslator.FromHtml("controltext");
                btnSearch_noti.ForeColor = System.Drawing.ColorTranslator.FromHtml("controltext");
                btnlogout.BackColor = System.Drawing.ColorTranslator.FromHtml("#F8D948");
                btnlogout.ForeColor = System.Drawing.ColorTranslator.FromHtml("controltext");

            }

            else if (Common.Permission == "T")
            {
                
                btnTeacher.Visible = false;
                panelSideMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#4AB34A");
                panelInfoSubMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#369F36");
                panelNoticeSubMenu.BackColor = System.Drawing.ColorTranslator.FromHtml("#369F36");
                btnSearch_noti.BackColor = System.Drawing.ColorTranslator.FromHtml("#369F36");
                btnSend_noti.BackColor = System.Drawing.ColorTranslator.FromHtml("#369F36");

            }
        }
        #region customizeDesign

        private void customizeDesign()
        {
            panelInfoSubMenu.Visible = false;
            panelNoticeSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelInfoSubMenu.Visible == true)
            {
                panelInfoSubMenu.Visible = false;
            }
            if (panelNoticeSubMenu.Visible = true)
            {
                panelNoticeSubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInfoSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Score());

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void btnStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Student());

        }

        private void btnequipment_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Equipment());

        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNoticeSubMenu);
        }

        private void btnSend_noti_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_NoticeSend());
            
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Atte());
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Teacher());

        }

        private void btnDiary_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Diary());
        }
#endregion
        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                hideSubMenu();
            }
        }

        private void btnSearch_noti_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Notice());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃 하시겠습니까?","Log out", MessageBoxButtons.YesNo)== DialogResult.No) return;
            this.Close();
            Application.Restart();
        }
    }
}
