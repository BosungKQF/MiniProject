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
    public partial class FM_Atte : Form
    {
        public FM_Atte()
        {
            InitializeComponent();

            if (Common.Permission == "S")
            {
                btnSave_Atte.Visible = false;
                btnSearch_Atte.Visible = false;
                txtExtra.Visible = false;
                lblClass.Visible = false;
                lblStudent.Visible = false;
                cmbClass_atte.Visible = false;
                cmbStudent_atte.Visible = false;
                rbAbs.Visible = false;
                rbAtte.Visible = false;

            }
        }
    }
}
