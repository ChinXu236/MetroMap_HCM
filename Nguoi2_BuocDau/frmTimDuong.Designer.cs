namespace Nguoi2_BuocDau
{
    partial class frmTimDuong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblGaĐi;
        private System.Windows.Forms.Label lblGaĐến;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Button btnTimDuong;
        private System.Windows.Forms.Button btnDoiChieu;
        private System.Windows.Forms.DataGridView dgvLoTrinh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblGaĐi = new System.Windows.Forms.Label();
            this.lblGaĐến = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.btnTimDuong = new System.Windows.Forms.Button();
            this.btnDoiChieu = new System.Windows.Forms.Button();
            this.dgvLoTrinh = new System.Windows.Forms.DataGridView();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoTrinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGaĐi
            // 
            this.lblGaĐi.AutoSize = true;
            this.lblGaĐi.Location = new System.Drawing.Point(50, 20);
            this.lblGaĐi.Name = "lblGaĐi";
            this.lblGaĐi.Size = new System.Drawing.Size(39, 16);
            this.lblGaĐi.TabIndex = 0;
            this.lblGaĐi.Text = "Ga đi";
            // 
            // lblGaĐến
            // 
            this.lblGaĐến.AutoSize = true;
            this.lblGaĐến.Location = new System.Drawing.Point(50, 60);
            this.lblGaĐến.Name = "lblGaĐến";
            this.lblGaĐến.Size = new System.Drawing.Size(51, 16);
            this.lblGaĐến.TabIndex = 1;
            this.lblGaĐến.Text = "Ga đến";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(120, 17);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(200, 22);
            this.txtTu.TabIndex = 2;
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(120, 57);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(200, 22);
            this.txtDen.TabIndex = 3;
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.Location = new System.Drawing.Point(420, 30);
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.Size = new System.Drawing.Size(105, 32);
            this.btnTimDuong.TabIndex = 4;
            this.btnTimDuong.Text = "Tìm đường";
            this.btnTimDuong.UseVisualStyleBackColor = true;
            // 
            // btnDoiChieu
            // 
            this.btnDoiChieu.Location = new System.Drawing.Point(340, 37);
            this.btnDoiChieu.Name = "btnDoiChieu";
            this.btnDoiChieu.Size = new System.Drawing.Size(60, 23);
            this.btnDoiChieu.TabIndex = 5;
            this.btnDoiChieu.Text = "⇄";
            this.btnDoiChieu.UseVisualStyleBackColor = true;
            // 
            // dgvLoTrinh
            // 
            this.dgvLoTrinh.AllowUserToAddRows = false;
            this.dgvLoTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoTrinh.Location = new System.Drawing.Point(12, 98);
            this.dgvLoTrinh.Name = "dgvLoTrinh";
            this.dgvLoTrinh.ReadOnly = true;
            this.dgvLoTrinh.RowHeadersVisible = false;
            this.dgvLoTrinh.RowHeadersWidth = 51;
            this.dgvLoTrinh.RowTemplate.Height = 24;
            this.dgvLoTrinh.Size = new System.Drawing.Size(776, 309);
            this.dgvLoTrinh.TabIndex = 6;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(542, 29);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(89, 33);
            this.btnChiTiet.TabIndex = 7;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.Location = new System.Drawing.Point(661, 28);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(90, 32);
            this.BtnQuayLai.TabIndex = 8;
            this.BtnQuayLai.Text = "Quay Lại";
            this.BtnQuayLai.UseVisualStyleBackColor = true;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // frmTimDuong
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnQuayLai);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.lblGaĐi);
            this.Controls.Add(this.lblGaĐến);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.btnTimDuong);
            this.Controls.Add(this.btnDoiChieu);
            this.Controls.Add(this.dgvLoTrinh);
            this.Name = "frmTimDuong";
            this.Text = "MetroMap HCM - Tìm đường";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoTrinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button BtnQuayLai;
    }
}
