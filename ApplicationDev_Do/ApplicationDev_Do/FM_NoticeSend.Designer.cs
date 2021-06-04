
namespace ApplicationDev_Do
{
    partial class FM_NoticeSend
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbStudent = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cboNoticeClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtNotice = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lbStudent);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.cboNoticeClass);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rtxtNotice);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(900, 600);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbStudent
            // 
            this.lbStudent.FormattingEnabled = true;
            this.lbStudent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lbStudent.ItemHeight = 20;
            this.lbStudent.Location = new System.Drawing.Point(401, 37);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbStudent.Size = new System.Drawing.Size(136, 24);
            this.lbStudent.TabIndex = 11;
            this.lbStudent.Click += new System.EventHandler(this.lbStudent_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(664, 28);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(129, 59);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "보내기";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cboNoticeClass
            // 
            this.cboNoticeClass.FormattingEnabled = true;
            this.cboNoticeClass.Items.AddRange(new object[] {
            "전체",
            "스마트팩토리",
            "빅데이터"});
            this.cboNoticeClass.Location = new System.Drawing.Point(107, 37);
            this.cboNoticeClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNoticeClass.Name = "cboNoticeClass";
            this.cboNoticeClass.Size = new System.Drawing.Size(136, 28);
            this.cboNoticeClass.TabIndex = 8;
            this.cboNoticeClass.SelectedValueChanged += new System.EventHandler(this.cboNoticeClass_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(76, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "반";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(356, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "학생";
            // 
            // rtxtNotice
            // 
            this.rtxtNotice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtNotice.Location = new System.Drawing.Point(3, 103);
            this.rtxtNotice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtNotice.Name = "rtxtNotice";
            this.rtxtNotice.Size = new System.Drawing.Size(894, 493);
            this.rtxtNotice.TabIndex = 0;
            this.rtxtNotice.Text = "";
            this.rtxtNotice.Click += new System.EventHandler(this.rtxtNotice_Click);
            // 
            // FM_NoticeSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FM_NoticeSend";
            this.Text = "FM_NoticeSend";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtNotice;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cboNoticeClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbStudent;
    }
}