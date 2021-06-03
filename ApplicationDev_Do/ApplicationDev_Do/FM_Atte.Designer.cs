
namespace ApplicationDev_Do
{
    partial class FM_Atte
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Groupbox_ATTE = new System.Windows.Forms.GroupBox();
            this.btnAtte_Atte = new System.Windows.Forms.Button();
            this.btnSearch_Atte = new System.Windows.Forms.Button();
            this.btnSave_Atte = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAbs = new System.Windows.Forms.RadioButton();
            this.rbAtte = new System.Windows.Forms.RadioButton();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStart_atte = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd_atte = new System.Windows.Forms.DateTimePicker();
            this.cmbClass_atte = new System.Windows.Forms.ComboBox();
            this.cmbStudent_atte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Groupbox_ATTE.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(827, 223);
            this.dataGridView1.TabIndex = 1;
            // 
            // Groupbox_ATTE
            // 
            this.Groupbox_ATTE.Controls.Add(this.btnAtte_Atte);
            this.Groupbox_ATTE.Controls.Add(this.btnSearch_Atte);
            this.Groupbox_ATTE.Dock = System.Windows.Forms.DockStyle.Top;
            this.Groupbox_ATTE.Location = new System.Drawing.Point(0, 336);
            this.Groupbox_ATTE.Name = "Groupbox_ATTE";
            this.Groupbox_ATTE.Size = new System.Drawing.Size(827, 117);
            this.Groupbox_ATTE.TabIndex = 2;
            this.Groupbox_ATTE.TabStop = false;
            // 
            // btnAtte_Atte
            // 
            this.btnAtte_Atte.BackColor = System.Drawing.SystemColors.Window;
            this.btnAtte_Atte.Location = new System.Drawing.Point(291, 23);
            this.btnAtte_Atte.Name = "btnAtte_Atte";
            this.btnAtte_Atte.Size = new System.Drawing.Size(240, 50);
            this.btnAtte_Atte.TabIndex = 1;
            this.btnAtte_Atte.Text = "출석";
            this.btnAtte_Atte.UseVisualStyleBackColor = false;
            this.btnAtte_Atte.Click += new System.EventHandler(this.btnAtte_Atte_Click);
            // 
            // btnSearch_Atte
            // 
            this.btnSearch_Atte.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch_Atte.Location = new System.Drawing.Point(25, 23);
            this.btnSearch_Atte.Name = "btnSearch_Atte";
            this.btnSearch_Atte.Size = new System.Drawing.Size(243, 50);
            this.btnSearch_Atte.TabIndex = 0;
            this.btnSearch_Atte.Text = "조회";
            this.btnSearch_Atte.UseVisualStyleBackColor = false;
            this.btnSearch_Atte.Click += new System.EventHandler(this.btnSearch_Atte_Click);
            // 
            // btnSave_Atte
            // 
            this.btnSave_Atte.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave_Atte.Location = new System.Drawing.Point(554, 26);
            this.btnSave_Atte.Name = "btnSave_Atte";
            this.btnSave_Atte.Size = new System.Drawing.Size(242, 47);
            this.btnSave_Atte.TabIndex = 2;
            this.btnSave_Atte.Text = "변경사항 저장";
            this.btnSave_Atte.UseVisualStyleBackColor = false;
            this.btnSave_Atte.Click += new System.EventHandler(this.btnSave_Atte_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAbs);
            this.groupBox2.Controls.Add(this.rbAtte);
            this.groupBox2.Controls.Add(this.txtExtra);
            this.groupBox2.Controls.Add(this.btnSave_Atte);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // rbAbs
            // 
            this.rbAbs.AutoSize = true;
            this.rbAbs.Location = new System.Drawing.Point(25, 49);
            this.rbAbs.Name = "rbAbs";
            this.rbAbs.Size = new System.Drawing.Size(60, 24);
            this.rbAbs.TabIndex = 5;
            this.rbAbs.TabStop = true;
            this.rbAbs.Text = "결석";
            this.rbAbs.UseVisualStyleBackColor = true;
            // 
            // rbAtte
            // 
            this.rbAtte.AutoSize = true;
            this.rbAtte.Location = new System.Drawing.Point(25, 26);
            this.rbAtte.Name = "rbAtte";
            this.rbAtte.Size = new System.Drawing.Size(60, 24);
            this.rbAtte.TabIndex = 4;
            this.rbAtte.TabStop = true;
            this.rbAtte.Text = "출석";
            this.rbAtte.UseVisualStyleBackColor = true;
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(171, 36);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(298, 27);
            this.txtExtra.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(54, 23);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(24, 20);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "반";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(430, 23);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(39, 20);
            this.lblStudent.TabIndex = 1;
            this.lblStudent.Text = "학생";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "날짜";
            // 
            // dtpStart_atte
            // 
            this.dtpStart_atte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart_atte.Location = new System.Drawing.Point(449, 61);
            this.dtpStart_atte.Name = "dtpStart_atte";
            this.dtpStart_atte.Size = new System.Drawing.Size(144, 27);
            this.dtpStart_atte.TabIndex = 3;
            // 
            // dtpEnd_atte
            // 
            this.dtpEnd_atte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd_atte.Location = new System.Drawing.Point(618, 61);
            this.dtpEnd_atte.Name = "dtpEnd_atte";
            this.dtpEnd_atte.Size = new System.Drawing.Size(152, 27);
            this.dtpEnd_atte.TabIndex = 4;
            // 
            // cmbClass_atte
            // 
            this.cmbClass_atte.FormattingEnabled = true;
            this.cmbClass_atte.Items.AddRange(new object[] {
            "전체",
            "스마트팩토리",
            "빅데이터"});
            this.cmbClass_atte.Location = new System.Drawing.Point(84, 18);
            this.cmbClass_atte.Name = "cmbClass_atte";
            this.cmbClass_atte.Size = new System.Drawing.Size(242, 28);
            this.cmbClass_atte.TabIndex = 5;
            this.cmbClass_atte.SelectedIndexChanged += new System.EventHandler(this.cmbClass_atte_SelectedValueChanged);
            this.cmbClass_atte.SelectedValueChanged += new System.EventHandler(this.cmbClass_atte_SelectedValueChanged_1);
            // 
            // cmbStudent_atte
            // 
            this.cmbStudent_atte.FormattingEnabled = true;
            this.cmbStudent_atte.Location = new System.Drawing.Point(475, 18);
            this.cmbStudent_atte.Name = "cmbStudent_atte";
            this.cmbStudent_atte.Size = new System.Drawing.Size(242, 28);
            this.cmbStudent_atte.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "~";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbStudent_atte);
            this.groupBox1.Controls.Add(this.cmbClass_atte);
            this.groupBox1.Controls.Add(this.dtpEnd_atte);
            this.groupBox1.Controls.Add(this.dtpStart_atte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblStudent);
            this.groupBox1.Controls.Add(this.lblClass);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // FM_Atte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Groupbox_ATTE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_Atte";
            this.Text = "FM_Atte";
            this.Load += new System.EventHandler(this.FM_Atte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Groupbox_ATTE.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Groupbox_ATTE;
        private System.Windows.Forms.Button btnAtte_Atte;
        private System.Windows.Forms.Button btnSearch_Atte;
        private System.Windows.Forms.Button btnSave_Atte;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAbs;
        private System.Windows.Forms.RadioButton rbAtte;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart_atte;
        private System.Windows.Forms.DateTimePicker dtpEnd_atte;
        private System.Windows.Forms.ComboBox cmbClass_atte;
        private System.Windows.Forms.ComboBox cmbStudent_atte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}