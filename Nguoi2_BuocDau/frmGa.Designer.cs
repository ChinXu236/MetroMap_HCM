namespace Nguoi2_BuocDau
{
    partial class frmGa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGa = new System.Windows.Forms.DataGridView();
            this.colMaGa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaGa = new System.Windows.Forms.Label();
            this.lblTenGa = new System.Windows.Forms.Label();
            this.txtMaGa = new System.Windows.Forms.TextBox();
            this.txtTenGa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTestKetNoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGa
            // 
            this.dgvGa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvGa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaGa,
            this.colTenGa});
            this.dgvGa.Location = new System.Drawing.Point(322, 54);
            this.dgvGa.Name = "dgvGa";
            this.dgvGa.ReadOnly = true;
            this.dgvGa.RowHeadersVisible = false;
            this.dgvGa.RowHeadersWidth = 51;
            this.dgvGa.RowTemplate.Height = 24;
            this.dgvGa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGa.Size = new System.Drawing.Size(415, 266);
            this.dgvGa.TabIndex = 0;
            // 
            // colMaGa
            // 
            this.colMaGa.DataPropertyName = "MaGa";
            this.colMaGa.HeaderText = "Mã Ga";
            this.colMaGa.MinimumWidth = 6;
            this.colMaGa.Name = "colMaGa";
            this.colMaGa.ReadOnly = true;
            // 
            // colTenGa
            // 
            this.colTenGa.DataPropertyName = "TenGa";
            this.colTenGa.HeaderText = "Tên Ga";
            this.colTenGa.MinimumWidth = 6;
            this.colTenGa.Name = "colTenGa";
            this.colTenGa.ReadOnly = true;
            // 
            // lblMaGa
            // 
            this.lblMaGa.AutoSize = true;
            this.lblMaGa.Location = new System.Drawing.Point(57, 67);
            this.lblMaGa.Name = "lblMaGa";
            this.lblMaGa.Size = new System.Drawing.Size(47, 16);
            this.lblMaGa.TabIndex = 1;
            this.lblMaGa.Text = "Mã Ga";
            // 
            // lblTenGa
            // 
            this.lblTenGa.AutoSize = true;
            this.lblTenGa.Location = new System.Drawing.Point(60, 136);
            this.lblTenGa.Name = "lblTenGa";
            this.lblTenGa.Size = new System.Drawing.Size(52, 16);
            this.lblTenGa.TabIndex = 2;
            this.lblTenGa.Text = "Tên Ga";
            // 
            // txtMaGa
            // 
            this.txtMaGa.Location = new System.Drawing.Point(138, 60);
            this.txtMaGa.Name = "txtMaGa";
            this.txtMaGa.Size = new System.Drawing.Size(100, 22);
            this.txtMaGa.TabIndex = 3;
            // 
            // txtTenGa
            // 
            this.txtTenGa.Location = new System.Drawing.Point(138, 130);
            this.txtTenGa.Name = "txtTenGa";
            this.txtTenGa.Size = new System.Drawing.Size(100, 22);
            this.txtTenGa.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(60, 212);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(163, 212);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(60, 259);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(163, 259);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTestKetNoi
            // 
            this.btnTestKetNoi.Location = new System.Drawing.Point(82, 297);
            this.btnTestKetNoi.Name = "btnTestKetNoi";
            this.btnTestKetNoi.Size = new System.Drawing.Size(124, 23);
            this.btnTestKetNoi.TabIndex = 4;
            this.btnTestKetNoi.Text = "Test Kết Nối";
            this.btnTestKetNoi.UseVisualStyleBackColor = true;
            this.btnTestKetNoi.Click += new System.EventHandler(this.btnTestKetNoi_Click);
            // 
            // frmGa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestKetNoi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenGa);
            this.Controls.Add(this.txtMaGa);
            this.Controls.Add(this.lblTenGa);
            this.Controls.Add(this.lblMaGa);
            this.Controls.Add(this.dgvGa);
            this.Name = "frmGa";
            this.Text = "frmGa";
            this.Load += new System.EventHandler(this.FormGa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGa;
        private System.Windows.Forms.Label lblMaGa;
        private System.Windows.Forms.Label lblTenGa;
        private System.Windows.Forms.TextBox txtMaGa;
        private System.Windows.Forms.TextBox txtTenGa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTestKetNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGa;
    }
}