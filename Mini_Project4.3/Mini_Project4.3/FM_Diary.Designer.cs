
namespace Mini_Project4._3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "내용";
            // 
            // txtDiary
            // 
            this.txtDiary.Location = new System.Drawing.Point(91, 50);
            this.txtDiary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiary.Multiline = true;
            this.txtDiary.Name = "txtDiary";
            this.txtDiary.Size = new System.Drawing.Size(308, 416);
            this.txtDiary.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(432, 562);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "근무일지 작성";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dgvDiary);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(482, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(432, 562);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "근무일지 목록";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(302, 424);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 424);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(117, 424);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(24, 424);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvDiary
            // 
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDiary.Location = new System.Drawing.Point(3, 22);
            this.dgvDiary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.RowHeadersWidth = 51;
            this.dgvDiary.RowTemplate.Height = 23;
            this.dgvDiary.Size = new System.Drawing.Size(426, 362);
            this.dgvDiary.TabIndex = 0;
            // 
            // FM_Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}
