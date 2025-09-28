namespace Nguoi2_BuocDau
{
    partial class frmTuyen
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
            this.dgvTuyen = new System.Windows.Forms.DataGridView();
            this.lblMaTuyen = new System.Windows.Forms.Label();
            this.lblTenTuyen = new System.Windows.Forms.Label();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTestKetNoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTuyen
            // 
            this.dgvTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyen.Location = new System.Drawing.Point(303, 73);
            this.dgvTuyen.Name = "dgvTuyen";
            this.dgvTuyen.RowHeadersWidth = 51;
            this.dgvTuyen.RowTemplate.Height = 24;
            this.dgvTuyen.Size = new System.Drawing.Size(343, 262);
            this.dgvTuyen.TabIndex = 0;
            // 
            // lblMaTuyen
            // 
            this.lblMaTuyen.AutoSize = true;
            this.lblMaTuyen.Location = new System.Drawing.Point(65, 90);
            this.lblMaTuyen.Name = "lblMaTuyen";
            this.lblMaTuyen.Size = new System.Drawing.Size(67, 16);
            this.lblMaTuyen.TabIndex = 1;
            this.lblMaTuyen.Text = "Mã Tuyến";
            // 
            // lblTenTuyen
            // 
            this.lblTenTuyen.AutoSize = true;
            this.lblTenTuyen.Location = new System.Drawing.Point(65, 149);
            this.lblTenTuyen.Name = "lblTenTuyen";
            this.lblTenTuyen.Size = new System.Drawing.Size(66, 16);
            this.lblTenTuyen.TabIndex = 1;
            this.lblTenTuyen.Text = "Tên tuyến";
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Location = new System.Drawing.Point(148, 90);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(100, 22);
            this.txtMaTuyen.TabIndex = 2;
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(148, 143);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(100, 22);
            this.txtTenTuyen.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(68, 240);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(173, 240);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(68, 201);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(173, 201);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnTestKetNoi
            // 
            this.btnTestKetNoi.Location = new System.Drawing.Point(107, 284);
            this.btnTestKetNoi.Name = "btnTestKetNoi";
            this.btnTestKetNoi.Size = new System.Drawing.Size(112, 23);
            this.btnTestKetNoi.TabIndex = 3;
            this.btnTestKetNoi.Text = "Test Kết Nối";
            this.btnTestKetNoi.UseVisualStyleBackColor = true;
            // 
            // frmTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTestKetNoi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTenTuyen);
            this.Controls.Add(this.txtMaTuyen);
            this.Controls.Add(this.lblTenTuyen);
            this.Controls.Add(this.lblMaTuyen);
            this.Controls.Add(this.dgvTuyen);
            this.Name = "frmTuyen";
            this.Text = "frmTuyen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTuyen;
        private System.Windows.Forms.Label lblMaTuyen;
        private System.Windows.Forms.Label lblTenTuyen;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTestKetNoi;
    }
}