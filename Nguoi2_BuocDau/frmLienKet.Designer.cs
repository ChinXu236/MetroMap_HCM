namespace Nguoi2_BuocDau
{
    partial class frmLienKet
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
            this.lblGa1 = new System.Windows.Forms.Label();
            this.lblGa2 = new System.Windows.Forms.Label();
            this.cmbGa1 = new System.Windows.Forms.ComboBox();
            this.cmbGa2 = new System.Windows.Forms.ComboBox();
            this.lblKhoangCach = new System.Windows.Forms.Label();
            this.numKhoangCach = new System.Windows.Forms.NumericUpDown();
            this.chkVoHuong = new System.Windows.Forms.CheckBox();
            this.btnSuaKhoangCach = new System.Windows.Forms.Button();
            this.btnThemLienKet = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoaLienKet = new System.Windows.Forms.Button();
            this.dgvLienKet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numKhoangCach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLienKet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGa1
            // 
            this.lblGa1.AutoSize = true;
            this.lblGa1.Location = new System.Drawing.Point(26, 110);
            this.lblGa1.Name = "lblGa1";
            this.lblGa1.Size = new System.Drawing.Size(35, 16);
            this.lblGa1.TabIndex = 0;
            this.lblGa1.Text = "Ga 1";
            // 
            // lblGa2
            // 
            this.lblGa2.AutoSize = true;
            this.lblGa2.Location = new System.Drawing.Point(294, 110);
            this.lblGa2.Name = "lblGa2";
            this.lblGa2.Size = new System.Drawing.Size(35, 16);
            this.lblGa2.TabIndex = 0;
            this.lblGa2.Text = "Ga 2";
            // 
            // cmbGa1
            // 
            this.cmbGa1.FormattingEnabled = true;
            this.cmbGa1.Location = new System.Drawing.Point(84, 102);
            this.cmbGa1.Name = "cmbGa1";
            this.cmbGa1.Size = new System.Drawing.Size(121, 24);
            this.cmbGa1.TabIndex = 1;
            // 
            // cmbGa2
            // 
            this.cmbGa2.FormattingEnabled = true;
            this.cmbGa2.Location = new System.Drawing.Point(356, 102);
            this.cmbGa2.Name = "cmbGa2";
            this.cmbGa2.Size = new System.Drawing.Size(121, 24);
            this.cmbGa2.TabIndex = 1;
            // 
            // lblKhoangCach
            // 
            this.lblKhoangCach.AutoSize = true;
            this.lblKhoangCach.Location = new System.Drawing.Point(29, 160);
            this.lblKhoangCach.Name = "lblKhoangCach";
            this.lblKhoangCach.Size = new System.Drawing.Size(163, 16);
            this.lblKhoangCach.TabIndex = 2;
            this.lblKhoangCach.Text = "Khoảng Cách (phút/đơn vị)";
            // 
            // numKhoangCach
            // 
            this.numKhoangCach.Location = new System.Drawing.Point(209, 154);
            this.numKhoangCach.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numKhoangCach.Name = "numKhoangCach";
            this.numKhoangCach.Size = new System.Drawing.Size(120, 22);
            this.numKhoangCach.TabIndex = 3;
            // 
            // chkVoHuong
            // 
            this.chkVoHuong.Location = new System.Drawing.Point(32, 214);
            this.chkVoHuong.Name = "chkVoHuong";
            this.chkVoHuong.Size = new System.Drawing.Size(445, 20);
            this.chkVoHuong.TabIndex = 4;
            this.chkVoHuong.Text = "Vô hướng (tự động chèn 2 chiều) _ Đánh dấu nếu muốn graph vô hướng";
            this.chkVoHuong.UseVisualStyleBackColor = true;
            // 
            // btnSuaKhoangCach
            // 
            this.btnSuaKhoangCach.Location = new System.Drawing.Point(179, 260);
            this.btnSuaKhoangCach.Name = "btnSuaKhoangCach";
            this.btnSuaKhoangCach.Size = new System.Drawing.Size(126, 23);
            this.btnSuaKhoangCach.TabIndex = 5;
            this.btnSuaKhoangCach.Text = "Sửa Khoảng Cách";
            this.btnSuaKhoangCach.UseVisualStyleBackColor = true;
            // 
            // btnThemLienKet
            // 
            this.btnThemLienKet.Location = new System.Drawing.Point(29, 260);
            this.btnThemLienKet.Name = "btnThemLienKet";
            this.btnThemLienKet.Size = new System.Drawing.Size(126, 23);
            this.btnThemLienKet.TabIndex = 5;
            this.btnThemLienKet.Text = "Thêm Liên Kết";
            this.btnThemLienKet.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(179, 309);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(126, 23);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoaLienKet
            // 
            this.btnXoaLienKet.Location = new System.Drawing.Point(29, 309);
            this.btnXoaLienKet.Name = "btnXoaLienKet";
            this.btnXoaLienKet.Size = new System.Drawing.Size(126, 23);
            this.btnXoaLienKet.TabIndex = 5;
            this.btnXoaLienKet.Text = "Xóa Liên Kết";
            this.btnXoaLienKet.UseVisualStyleBackColor = true;
            // 
            // dgvLienKet
            // 
            this.dgvLienKet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLienKet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLienKet.Location = new System.Drawing.Point(499, 52);
            this.dgvLienKet.Name = "dgvLienKet";
            this.dgvLienKet.ReadOnly = true;
            this.dgvLienKet.RowHeadersWidth = 51;
            this.dgvLienKet.RowTemplate.Height = 24;
            this.dgvLienKet.Size = new System.Drawing.Size(289, 310);
            this.dgvLienKet.TabIndex = 6;
            // 
            // frmLienKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLienKet);
            this.Controls.Add(this.btnXoaLienKet);
            this.Controls.Add(this.btnThemLienKet);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSuaKhoangCach);
            this.Controls.Add(this.chkVoHuong);
            this.Controls.Add(this.numKhoangCach);
            this.Controls.Add(this.lblKhoangCach);
            this.Controls.Add(this.cmbGa2);
            this.Controls.Add(this.cmbGa1);
            this.Controls.Add(this.lblGa2);
            this.Controls.Add(this.lblGa1);
            this.Name = "frmLienKet";
            this.Text = "frmLienKet";
            ((System.ComponentModel.ISupportInitialize)(this.numKhoangCach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLienKet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGa1;
        private System.Windows.Forms.Label lblGa2;
        private System.Windows.Forms.ComboBox cmbGa1;
        private System.Windows.Forms.ComboBox cmbGa2;
        private System.Windows.Forms.Label lblKhoangCach;
        private System.Windows.Forms.NumericUpDown numKhoangCach;
        private System.Windows.Forms.CheckBox chkVoHuong;
        private System.Windows.Forms.Button btnSuaKhoangCach;
        private System.Windows.Forms.Button btnThemLienKet;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoaLienKet;
        private System.Windows.Forms.DataGridView dgvLienKet;
    }
}