using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDev_Do
{
    public partial class FM_Main : Form
    {
        public FM_Main()
        {
            InitializeComponent();
            customizeDesign();
            FM_Login Login = new FM_Login();

            Login.ShowDialog();

            //tssUserName.Text = Login.Tag.ToString();
            if (Login.Tag.ToString() == "FAIL")
            {
                System.Environment.Exit(0);
            }
        }

        #region customizeDesign

        private void customizeDesign()
        {
            panelInfoSubMenu.Visible = false;
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

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Student());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new FM_Equipment());
        }
    }
}
