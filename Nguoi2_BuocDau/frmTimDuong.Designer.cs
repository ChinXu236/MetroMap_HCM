namespace Nguoi2_BuocDau
{
    partial class frmTimDuong
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
            this.cmbGaBatDau = new System.Windows.Forms.ComboBox();
            this.cmbGaKetThuc = new System.Windows.Forms.ComboBox();
            this.lblGaBatDau = new System.Windows.Forms.Label();
            this.lblGaKetThuc = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnTimDuong = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbGaBatDau
            // 
            this.cmbGaBatDau.FormattingEnabled = true;
            this.cmbGaBatDau.Location = new System.Drawing.Point(234, 77);
            this.cmbGaBatDau.Name = "cmbGaBatDau";
            this.cmbGaBatDau.Size = new System.Drawing.Size(121, 24);
            this.cmbGaBatDau.TabIndex = 0;
            // 
            // cmbGaKetThuc
            // 
            this.cmbGaKetThuc.FormattingEnabled = true;
            this.cmbGaKetThuc.Location = new System.Drawing.Point(234, 142);
            this.cmbGaKetThuc.Name = "cmbGaKetThuc";
            this.cmbGaKetThuc.Size = new System.Drawing.Size(121, 24);
            this.cmbGaKetThuc.TabIndex = 0;
            // 
            // lblGaBatDau
            // 
            this.lblGaBatDau.AutoSize = true;
            this.lblGaBatDau.Location = new System.Drawing.Point(125, 77);
            this.lblGaBatDau.Name = "lblGaBatDau";
            this.lblGaBatDau.Size = new System.Drawing.Size(75, 16);
            this.lblGaBatDau.TabIndex = 1;
            this.lblGaBatDau.Text = "Ga Bắt Đầu";
            // 
            // lblGaKetThuc
            // 
            this.lblGaKetThuc.AutoSize = true;
            this.lblGaKetThuc.Location = new System.Drawing.Point(125, 150);
            this.lblGaKetThuc.Name = "lblGaKetThuc";
            this.lblGaKetThuc.Size = new System.Drawing.Size(80, 16);
            this.lblGaKetThuc.TabIndex = 1;
            this.lblGaKetThuc.Text = "Ga Kết Thúc";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(125, 297);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(54, 16);
            this.lblKetQua.TabIndex = 1;
            this.lblKetQua.Text = "Kết Quả";
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.Location = new System.Drawing.Point(192, 210);
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.Size = new System.Drawing.Size(114, 41);
            this.btnTimDuong.TabIndex = 2;
            this.btnTimDuong.Text = "Tìm Đường";
            this.btnTimDuong.UseVisualStyleBackColor = true;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(234, 290);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(121, 22);
            this.txtKetQua.TabIndex = 3;
            // 
            // frmTimDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.btnTimDuong);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblGaKetThuc);
            this.Controls.Add(this.lblGaBatDau);
            this.Controls.Add(this.cmbGaKetThuc);
            this.Controls.Add(this.cmbGaBatDau);
            this.Name = "frmTimDuong";
            this.Text = "frmTimDuong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGaBatDau;
        private System.Windows.Forms.ComboBox cmbGaKetThuc;
        private System.Windows.Forms.Label lblGaBatDau;
        private System.Windows.Forms.Label lblGaKetThuc;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnTimDuong;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}