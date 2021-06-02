
namespace ApplicationDev_Do
{
    partial class FM_Diary
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiary = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdB3 = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdB2 = new System.Windows.Forms.RadioButton();
            this.rdB1 = new System.Windows.Forms.RadioButton();
            this.dtpDiary = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "내용";
            // 
            // txtDiary
            // 
            this.txtDiary.Location = new System.Drawing.Point(458, 63);
            this.txtDiary.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDiary.Multiline = true;
            this.txtDiary.Name = "txtDiary";
            this.txtDiary.Size = new System.Drawing.Size(553, 261);
            this.txtDiary.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdB3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.rdB2);
            this.groupBox1.Controls.Add(this.rdB1);
            this.groupBox1.Controls.Add(this.dtpDiary);
            this.groupBox1.Controls.Add(this.txtDiary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(1040, 372);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "근무일지 작성";
            // 
            // rdB3
            // 
            this.rdB3.AutoSize = true;
            this.rdB3.Checked = true;
            this.rdB3.Location = new System.Drawing.Point(38, 156);
            this.rdB3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdB3.Name = "rdB3";
            this.rdB3.Size = new System.Drawing.Size(60, 24);
            this.rdB3.TabIndex = 8;
            this.rdB3.TabStop = true;
            this.rdB3.Text = "전체";
            this.rdB3.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(233, 301);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "근무일자";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 254);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdB2
            // 
            this.rdB2.AutoSize = true;
            this.rdB2.Location = new System.Drawing.Point(38, 220);
            this.rdB2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdB2.Name = "rdB2";
            this.rdB2.Size = new System.Drawing.Size(90, 24);
            this.rdB2.TabIndex = 4;
            this.rdB2.Text = "빅데이터";
            this.rdB2.UseVisualStyleBackColor = true;
            // 
            // rdB1
            // 
            this.rdB1.AutoSize = true;
            this.rdB1.Location = new System.Drawing.Point(38, 188);
            this.rdB1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdB1.Name = "rdB1";
            this.rdB1.Size = new System.Drawing.Size(120, 24);
            this.rdB1.TabIndex = 3;
            this.rdB1.Text = "스마트팩토리";
            this.rdB1.UseVisualStyleBackColor = true;
            // 
            // dtpDiary
            // 
            this.dtpDiary.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiary.Location = new System.Drawing.Point(120, 76);
            this.dtpDiary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDiary.Name = "dtpDiary";
            this.dtpDiary.Size = new System.Drawing.Size(178, 27);
            this.dtpDiary.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(336, 303);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(233, 254);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDiary);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(1040, 232);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "근무일지 목록";
            // 
            // dgvDiary
            // 
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.Location = new System.Drawing.Point(3, 29);
            this.dgvDiary.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.RowHeadersWidth = 51;
            this.dgvDiary.RowTemplate.Height = 23;
            this.dgvDiary.Size = new System.Drawing.Size(1386, 448);
            this.dgvDiary.TabIndex = 0;
            this.dgvDiary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiary_CellDoubleClick);
            // 
            // FM_Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 960);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FM_Diary";
            this.Text = "근무일지";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdB2;
        private System.Windows.Forms.RadioButton rdB1;
        private System.Windows.Forms.DateTimePicker dtpDiary;
        private System.Windows.Forms.RadioButton rdB3;
    }
}
