namespace Nguoi2_BuocDau
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuQLGa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLTuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLLienKet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimDuong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLGa,
            this.mnuQLTuyen,
            this.mnuQLLienKet,
            this.mnuTimDuong,
            this.toolStripMenuItem1,
            this.mnuThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 113);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuQLGa
            // 
            this.mnuQLGa.Name = "mnuQLGa";
            this.mnuQLGa.Size = new System.Drawing.Size(97, 24);
            this.mnuQLGa.Text = "Quản Lý Ga";
            this.mnuQLGa.Click += new System.EventHandler(this.mnuQuanLyGa_Click);
            // 
            // mnuQLTuyen
            // 
            this.mnuQLTuyen.Name = "mnuQLTuyen";
            this.mnuQLTuyen.Size = new System.Drawing.Size(118, 24);
            this.mnuQLTuyen.Text = "Quản Lý Tuyến";
            this.mnuQLTuyen.Click += new System.EventHandler(this.mnuQuanLyTuyen_Click);
            // 
            // mnuQLLienKet
            // 
            this.mnuQLLienKet.Name = "mnuQLLienKet";
            this.mnuQLLienKet.Size = new System.Drawing.Size(132, 24);
            this.mnuQLLienKet.Text = "Quản Lý Liên Kết";
            this.mnuQLLienKet.Click += new System.EventHandler(this.mnuQuanLyLienKet_Click);
            // 
            // mnuTimDuong
            // 
            this.mnuTimDuong.Name = "mnuTimDuong";
            this.mnuTimDuong.Size = new System.Drawing.Size(174, 24);
            this.mnuTimDuong.Text = "Tìm Đường Ngắn Nhất";
            this.mnuTimDuong.Click += new System.EventHandler(this.mnuTimDuong_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(86, 24);
            this.mnuThongKe.Text = "Thống Kê";
            this.mnuThongKe.Click += new System.EventHandler(this.mnuThongKe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 587);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "MetroMap HCM";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuQLGa;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTuyen;
        private System.Windows.Forms.ToolStripMenuItem mnuQLLienKet;
        private System.Windows.Forms.ToolStripMenuItem mnuTimDuong;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
    }
}

