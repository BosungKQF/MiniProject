
namespace ApplicationDev_Do
{
    partial class NoticeDetail
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
            this.rtxtNoticeDetail = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtNoticeDetail
            // 
            this.rtxtNoticeDetail.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtNoticeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtNoticeDetail.Location = new System.Drawing.Point(0, 0);
            this.rtxtNoticeDetail.Name = "rtxtNoticeDetail";
            this.rtxtNoticeDetail.Size = new System.Drawing.Size(800, 450);
            this.rtxtNoticeDetail.TabIndex = 0;
            this.rtxtNoticeDetail.Text = "";
            this.rtxtNoticeDetail.Click += new System.EventHandler(this.rtxtNoticeDetail_Click);
            // 
            // NoticeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxtNoticeDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NoticeDetail";
            this.Text = "알림장";
            this.Load += new System.EventHandler(this.NoticeDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtNoticeDetail;
    }
}