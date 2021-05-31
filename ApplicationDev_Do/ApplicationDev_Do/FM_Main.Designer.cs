
namespace ApplicationDev_Do
{
    partial class FM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelNoticeSubMenu = new System.Windows.Forms.Panel();
            this.btnSearch_noti = new System.Windows.Forms.Button();
            this.btnSend_noti = new System.Windows.Forms.Button();
            this.btnNotice = new System.Windows.Forms.Button();
            this.btnDiary = new System.Windows.Forms.Button();
            this.panelInfoSubMenu = new System.Windows.Forms.Panel();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnAttend = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelNoticeSubMenu.SuspendLayout();
            this.panelInfoSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelSideMenu.Controls.Add(this.panelNoticeSubMenu);
            this.panelSideMenu.Controls.Add(this.btnNotice);
            this.panelSideMenu.Controls.Add(this.btnDiary);
            this.panelSideMenu.Controls.Add(this.panelInfoSubMenu);
            this.panelSideMenu.Controls.Add(this.btnInfo);
            this.panelSideMenu.Controls.Add(this.btnAttend);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 731);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelNoticeSubMenu
            // 
            this.panelNoticeSubMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.panelNoticeSubMenu.Controls.Add(this.btnSearch_noti);
            this.panelNoticeSubMenu.Controls.Add(this.btnSend_noti);
            this.panelNoticeSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNoticeSubMenu.Location = new System.Drawing.Point(0, 420);
            this.panelNoticeSubMenu.Name = "panelNoticeSubMenu";
            this.panelNoticeSubMenu.Size = new System.Drawing.Size(250, 86);
            this.panelNoticeSubMenu.TabIndex = 6;
            // 
            // btnSearch_noti
            // 
            this.btnSearch_noti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch_noti.FlatAppearance.BorderSize = 0;
            this.btnSearch_noti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_noti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch_noti.Location = new System.Drawing.Point(0, 40);
            this.btnSearch_noti.Name = "btnSearch_noti";
            this.btnSearch_noti.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSearch_noti.Size = new System.Drawing.Size(250, 40);
            this.btnSearch_noti.TabIndex = 1;
            this.btnSearch_noti.Text = "조회";
            this.btnSearch_noti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_noti.UseVisualStyleBackColor = true;
            this.btnSearch_noti.Click += new System.EventHandler(this.btnSearch_noti_Click);
            // 
            // btnSend_noti
            // 
            this.btnSend_noti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSend_noti.FlatAppearance.BorderSize = 0;
            this.btnSend_noti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend_noti.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSend_noti.Location = new System.Drawing.Point(0, 0);
            this.btnSend_noti.Name = "btnSend_noti";
            this.btnSend_noti.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSend_noti.Size = new System.Drawing.Size(250, 40);
            this.btnSend_noti.TabIndex = 0;
            this.btnSend_noti.Text = "보내기";
            this.btnSend_noti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend_noti.UseVisualStyleBackColor = true;
            this.btnSend_noti.Click += new System.EventHandler(this.btnSend_noti_Click);
            // 
            // btnNotice
            // 
            this.btnNotice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotice.FlatAppearance.BorderSize = 0;
            this.btnNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNotice.Location = new System.Drawing.Point(0, 375);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNotice.Size = new System.Drawing.Size(250, 45);
            this.btnNotice.TabIndex = 5;
            this.btnNotice.Text = "알림장";
            this.btnNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotice.UseVisualStyleBackColor = true;
            this.btnNotice.Click += new System.EventHandler(this.btnNotice_Click);
            // 
            // btnDiary
            // 
            this.btnDiary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiary.FlatAppearance.BorderSize = 0;
            this.btnDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDiary.Location = new System.Drawing.Point(0, 330);
            this.btnDiary.Name = "btnDiary";
            this.btnDiary.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDiary.Size = new System.Drawing.Size(250, 45);
            this.btnDiary.TabIndex = 4;
            this.btnDiary.Text = "근무일지";
            this.btnDiary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiary.UseVisualStyleBackColor = true;
            // 
            // panelInfoSubMenu
            // 
            this.panelInfoSubMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.panelInfoSubMenu.Controls.Add(this.btnEquipment);
            this.panelInfoSubMenu.Controls.Add(this.btnTeacher);
            this.panelInfoSubMenu.Controls.Add(this.btnStudent);
            this.panelInfoSubMenu.Controls.Add(this.btnScore);
            this.panelInfoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoSubMenu.Location = new System.Drawing.Point(0, 168);
            this.panelInfoSubMenu.Name = "panelInfoSubMenu";
            this.panelInfoSubMenu.Size = new System.Drawing.Size(250, 162);
            this.panelInfoSubMenu.TabIndex = 3;
            // 
            // btnEquipment
            // 
            this.btnEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipment.FlatAppearance.BorderSize = 0;
            this.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEquipment.Location = new System.Drawing.Point(0, 120);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEquipment.Size = new System.Drawing.Size(250, 40);
            this.btnEquipment.TabIndex = 3;
            this.btnEquipment.Text = "비품관리";
            this.btnEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnequipment_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeacher.Location = new System.Drawing.Point(0, 80);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTeacher.Size = new System.Drawing.Size(250, 40);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.Text = "교사관리";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.UseVisualStyleBackColor = true;
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStudent.Location = new System.Drawing.Point(0, 40);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(250, 40);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "학생관리";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnScore
            // 
            this.btnScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScore.Location = new System.Drawing.Point(0, 0);
            this.btnScore.Name = "btnScore";
            this.btnScore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnScore.Size = new System.Drawing.Size(250, 40);
            this.btnScore.TabIndex = 0;
            this.btnScore.Text = "성적관리";
            this.btnScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnInfo.Location = new System.Drawing.Point(0, 123);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(250, 45);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "개인정보관리";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAttend
            // 
            this.btnAttend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttend.FlatAppearance.BorderSize = 0;
            this.btnAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttend.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAttend.Location = new System.Drawing.Point(0, 78);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAttend.Size = new System.Drawing.Size(250, 45);
            this.btnAttend.TabIndex = 0;
            this.btnAttend.Text = "출결관리";
            this.btnAttend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::ApplicationDev_Do.Properties.Resources.qqemge_nmjq_h08kbt_logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 78);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1010, 731);
            this.panelChildForm.TabIndex = 1;
            // 
            // FM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 731);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FM_Main";
            this.Text = "FM_Main";
            this.panelSideMenu.ResumeLayout(false);
            this.panelNoticeSubMenu.ResumeLayout(false);
            this.panelInfoSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.Button btnDiary;
        private System.Windows.Forms.Panel panelInfoSubMenu;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAttend;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelNoticeSubMenu;
        private System.Windows.Forms.Button btnSearch_noti;
        private System.Windows.Forms.Button btnSend_noti;
    }
}