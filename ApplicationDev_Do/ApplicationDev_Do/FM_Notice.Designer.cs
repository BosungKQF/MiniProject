
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
            this.cboSNoticeMaker = new System.Windows.Forms.ComboBox();
            this.btnNoticeSearch = new System.Windows.Forms.Button();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.cboSNoticeClass = new System.Windows.Forms.ComboBox();
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cboSNoticeMaker);
            this.groupBox1.Controls.Add(this.btnNoticeSearch);
            this.groupBox1.Controls.Add(this.dgvNotice);
            this.groupBox1.Controls.Add(this.cboSNoticeClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpNoticeEnd);
            this.groupBox1.Controls.Add(this.dtpNoticStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(1028, 732);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "알림장 조회";
            // 
            // cboSNoticeMaker
            // 
            this.cboSNoticeMaker.FormattingEnabled = true;
            this.cboSNoticeMaker.Items.AddRange(new object[] {
            "전체",
            "김현희",
            "양기식",
            "이시경",
            "양경민",
            "이상권"});
            this.cboSNoticeMaker.Location = new System.Drawing.Point(326, 47);
            this.cboSNoticeMaker.Name = "cboSNoticeMaker";
            this.cboSNoticeMaker.Size = new System.Drawing.Size(159, 29);
            this.cboSNoticeMaker.TabIndex = 12;
            this.cboSNoticeMaker.Text = "전체";
            // 
            // btnNoticeSearch
            // 
            this.btnNoticeSearch.Location = new System.Drawing.Point(488, 96);
            this.btnNoticeSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNoticeSearch.Name = "btnNoticeSearch";
            this.btnNoticeSearch.Size = new System.Drawing.Size(125, 47);
            this.btnNoticeSearch.TabIndex = 11;
            this.btnNoticeSearch.Text = "조회";
            this.btnNoticeSearch.UseVisualStyleBackColor = true;
            this.btnNoticeSearch.Click += new System.EventHandler(this.btnNoticeSearch_Click);
            // 
            // dgvNotice
            // 
            this.dgvNotice.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNotice.Location = new System.Drawing.Point(3, 158);
            this.dgvNotice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.RowHeadersWidth = 51;
            this.dgvNotice.RowTemplate.Height = 23;
            this.dgvNotice.Size = new System.Drawing.Size(1022, 569);
            this.dgvNotice.TabIndex = 10;
            this.dgvNotice.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNotice_CellMouseClick);
            // 
            // cboSNoticeClass
            // 
            this.cboSNoticeClass.FormattingEnabled = true;
            this.cboSNoticeClass.Items.AddRange(new object[] {
            "전체",
            "스마트팩토리",
            "빅데이터"});
            this.cboSNoticeClass.Location = new System.Drawing.Point(73, 48);
            this.cboSNoticeClass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cboSNoticeClass.Name = "cboSNoticeClass";
            this.cboSNoticeClass.Size = new System.Drawing.Size(159, 29);
            this.cboSNoticeClass.TabIndex = 8;
            this.cboSNoticeClass.Text = "전체";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "보낸날짜";
            // 
            // dtpNoticeEnd
            // 
            this.dtpNoticeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNoticeEnd.Location = new System.Drawing.Point(310, 104);
            this.dtpNoticeEnd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpNoticeEnd.Name = "dtpNoticeEnd";
            this.dtpNoticeEnd.Size = new System.Drawing.Size(147, 28);
            this.dtpNoticeEnd.TabIndex = 5;
            this.dtpNoticeEnd.Value = new System.DateTime(2021, 6, 4, 9, 3, 35, 0);
            // 
            // dtpNoticStart
            // 
            this.dtpNoticStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNoticStart.Location = new System.Drawing.Point(123, 104);
            this.dtpNoticStart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpNoticStart.Name = "dtpNoticStart";
            this.dtpNoticStart.Size = new System.Drawing.Size(142, 28);
            this.dtpNoticStart.TabIndex = 4;
            this.dtpNoticStart.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(266, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "작성자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "반";
            // 
            // FM_Notice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
        private System.Windows.Forms.ComboBox cboSNoticeClass;
        private System.Windows.Forms.Button btnNoticeSearch;
        private System.Windows.Forms.ComboBox cboSNoticeMaker;
    }
}