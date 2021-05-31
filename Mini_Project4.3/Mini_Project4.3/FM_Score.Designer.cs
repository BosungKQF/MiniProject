
namespace Mini_Project4._3
{
    partial class FM_Score
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.CbSemester = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "학생 이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "분기";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 25);
            this.txtName.TabIndex = 4;
            // 
            // CbSemester
            // 
            this.CbSemester.FormattingEnabled = true;
            this.CbSemester.Items.AddRange(new object[] {
            "전체",
            "1분기",
            "2분기",
            "3분기",
            "4분기"});
            this.CbSemester.Location = new System.Drawing.Point(130, 94);
            this.CbSemester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbSemester.Name = "CbSemester";
            this.CbSemester.Size = new System.Drawing.Size(138, 23);
            this.CbSemester.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(346, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSearch.Size = new System.Drawing.Size(86, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(458, 94);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbSemester);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(914, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적조회";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvScore);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 175);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(914, 279);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성적";
            // 
            // dgvScore
            // 
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvScore.Location = new System.Drawing.Point(3, 22);
            this.dgvScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.RowHeadersWidth = 51;
            this.dgvScore.RowTemplate.Height = 23;
            this.dgvScore.Size = new System.Drawing.Size(908, 210);
            this.dgvScore.TabIndex = 0;
            // 
            // FM_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FM_Score";
            this.Text = "성적 관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox CbSemester;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvScore;
    }
}