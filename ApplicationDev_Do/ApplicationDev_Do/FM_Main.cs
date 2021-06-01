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
           /* FM_Login Login = new FM_Login();

            Login.ShowDialog();

            //tssUserName.Text = Login.Tag.ToString();
            if (Login.Tag.ToString() == "FAIL")
            {
                System.Environment.Exit(0);
            }*/
        

            if (Common.Permission == "S")
            {
                btnStudent.Visible = false;
                btnTeacher.Visible = false;
                btnDiary.Visible = false;
                btnEquipment.Visible = false;
                btnSend_noti.Visible = false;


            }

            else if (Common.Permission == "T")
            {
                
                btnTeacher.Visible = false;
                
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
            //
            //
            //...
            hideSubMenu();
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
        #endregion

        private void btnStudent_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Student());
            hideSubMenu();
        }

        private void btnequipment_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Equipment());
            hideSubMenu();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Notice());
            showSubMenu(panelNoticeSubMenu);
        }

        private void btnSend_noti_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_NoticeSend());
            hideSubMenu();
        }

        private void btnSearch_noti_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Notice());
            hideSubMenu();
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Atte());
            hideSubMenu();

        }

        
    }
}
