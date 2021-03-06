
namespace ApplicationDev_Do
{
    partial class FM_Notice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNoticeSearch = new System.Windows.Forms.Button();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.cboNoticeMaker = new System.Windows.Forms.ComboBox();
            this.cboNoticeClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNoticeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpNoticStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNoticeSearch);
            this.groupBox1.Controls.Add(this.dgvNotice);
            this.groupBox1.Controls.Add(this.cboNoticeMaker);
            this.groupBox1.Controls.Add(this.cboNoticeClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpNoticeEnd);
            this.groupBox1.Controls.Add(this.dtpNoticStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(914, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "알림장 조회";
            // 
            // btnNoticeSearch
            // 
            this.btnNoticeSearch.Location = new System.Drawing.Point(405, 84);
            this.btnNoticeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNoticeSearch.Name = "btnNoticeSearch";
            this.btnNoticeSearch.Size = new System.Drawing.Size(111, 35);
            this.btnNoticeSearch.TabIndex = 11;
            this.btnNoticeSearch.Text = "조회";
            this.btnNoticeSearch.UseVisualStyleBackColor = true;
            this.btnNoticeSearch.Click += new System.EventHandler(this.btnNoticeSearch_Click);
            // 
            // dgvNotice
            // 
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNotice.Location = new System.Drawing.Point(3, 141);
            this.dgvNotice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.RowHeadersWidth = 51;
            this.dgvNotice.RowTemplate.Height = 23;
            this.dgvNotice.Size = new System.Drawing.Size(908, 404);
            this.dgvNotice.TabIndex = 10;
            // 
            // cboNoticeMaker
            // 
            this.cboNoticeMaker.FormattingEnabled = true;
            this.cboNoticeMaker.Location = new System.Drawing.Point(306, 36);
            this.cboNoticeMaker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNoticeMaker.Name = "cboNoticeMaker";
            this.cboNoticeMaker.Size = new System.Drawing.Size(142, 23);
            this.cboNoticeMaker.TabIndex = 9;
            // 
            // cboNoticeClass
            // 
            this.cboNoticeClass.FormattingEnabled = true;
            this.cboNoticeClass.Location = new System.Drawing.Point(65, 35);
            this.cboNoticeClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNoticeClass.Name = "cboNoticeClass";
            this.cboNoticeClass.Size = new System.Drawing.Size(142, 23);
            this.cboNoticeClass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "보낸날짜";
            // 
            // dtpNoticeEnd
            // 
            this.dtpNoticeEnd.Location = new System.Drawing.Point(732, 35);
            this.dtpNoticeEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNoticeEnd.Name = "dtpNoticeEnd";
            this.dtpNoticeEnd.Size = new System.Drawing.Size(143, 25);
            this.dtpNoticeEnd.TabIndex = 5;
            this.dtpNoticeEnd.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // dtpNoticStart
            // 
            this.dtpNoticStart.Location = new System.Drawing.Point(566, 35);
            this.dtpNoticStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNoticStart.Name = "dtpNoticStart";
            this.dtpNoticStart.Size = new System.Drawing.Size(141, 25);
            this.dtpNoticStart.TabIndex = 4;
            this.dtpNoticStart.Value = new System.DateTime(2021, 5, 31, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "작성자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "반";
            // 
            // FM_Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FM_Notice";
            this.Text = "FM_Notice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNoticeEnd;
        private System.Windows.Forms.DateTimePicker dtpNoticStart;
        private System.Windows.Forms.DataGridView dgvNotice;
        private System.Windows.Forms.ComboBox cboNoticeMaker;
        private System.Windows.Forms.ComboBox cboNoticeClass;
        private System.Windows.Forms.Button btnNoticeSearch;
    }
}