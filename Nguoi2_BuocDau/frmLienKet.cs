using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguoi2_BuocDau
{
    public partial class frmLienKet : Form
    {
        public frmLienKet()
        {
            InitializeComponent();
        }
        // Khi form load -> nạp dữ liệu cho 2 combobox và datagridview
        private void FormLienKet_Load(object sender, EventArgs e)
        {
            NapComboGa();
            NapDanhSachLienKet();
        }

        // 1) Nạp danh sách Ga vào 2 ComboBox
        private void NapComboGa()
        {
            // Lay danh sach ga tu CSDL
            DataTable dtGa = TroGiup.LayBang("SELECT MaGa, TenGa FROM Ga ORDER BY TenGa");

            // Gan DataSource cho cboGa1 va cboGa2
            cmbGa1.DataSource = dtGa;
            cmbGa1.DisplayMember = "TenGa"; // hien thi ten ga
            cmbGa1.ValueMember = "MaGa";    // gia tri la MaGa

            // Dung dtGa.Copy() de 2 combobox khong bi link chung
            cmbGa2.DataSource = dtGa.Copy();
            cmbGa2.DisplayMember = "TenGa";
            cmbGa2.ValueMember = "MaGa";
        }

        // 2) Nạp danh sách LienKet lên DataGridView
        private void NapDanhSachLienKet()
        {
            // Join voi bang Ga de hien thi ten ga thay vi ma ga (tuong minh)
            string sql = @"
                SELECT lk.Ga1, g1.TenGa AS TenGa1, lk.Ga2, g2.TenGa AS TenGa2, lk.KhoangCach
                FROM LienKet lk
                LEFT JOIN Ga g1 ON lk.Ga1 = g1.MaGa
                LEFT JOIN Ga g2 ON lk.Ga2 = g2.MaGa
                ORDER BY lk.Ga1, lk.Ga2";
            dgvLienKet.DataSource = TroGiup.LayBang(sql);
            dgvLienKet.AutoResizeColumns();
        }

        // 3) Ham kiem tra lien ket da ton tai chua
        private bool KiemTraLienKetTonTai(string ga1, string ga2)
        {
            var kq = TroGiup.LayGiaTri("SELECT COUNT(*) FROM LienKet WHERE Ga1=@g1 AND Ga2=@g2",
                new SqlParameter("@g1", ga1), new SqlParameter("@g2", ga2));
            return Convert.ToInt32(kq) > 0;
        }

        // 4) Su kien nut Them lien ket
        private void btnThemLienKet_Click(object sender, EventArgs e)
        {
            // Lay gia tri tu UI
            string maGa1 = cmbGa1.SelectedValue?.ToString();
            string maGa2 = cmbGa2.SelectedValue?.ToString();
            int khoangCach = (int)numKhoangCach.Value;
            bool voHuong = chkVoHuong.Checked;

            // Validation: khong cho noi 2 ga giong nhau
            if (string.IsNullOrEmpty(maGa1) || string.IsNullOrEmpty(maGa2))
            {
                MessageBox.Show("Vui long chon ca 2 ga.");
                return;
            }
            if (maGa1 == maGa2)
            {
                MessageBox.Show("Khong the noi 1 ga voi chinh no.");
                return;
            }

            try
            {
                // Chen 1 chieu neu chua ton tai
                if (!KiemTraLienKetTonTai(maGa1, maGa2))
                {
                    TroGiup.ThucThi("INSERT INTO LienKet(Ga1,Ga2,KhoangCach) VALUES(@g1,@g2,@kc)",
                        new SqlParameter("@g1", maGa1),
                        new SqlParameter("@g2", maGa2),
                        new SqlParameter("@kc", khoangCach));
                }
                else
                {
                    MessageBox.Show("Lien ket da ton tai: " + maGa1 + " -> " + maGa2);
                }

                // Neu muon vo huong (them nguoc lai) thi chen nguoc neu chua ton tai
                if (voHuong)
                {
                    if (!KiemTraLienKetTonTai(maGa2, maGa1))
                    {
                        TroGiup.ThucThi("INSERT INTO LienKet(Ga1,Ga2,KhoangCach) VALUES(@g1,@g2,@kc)",
                            new SqlParameter("@g1", maGa2),
                            new SqlParameter("@g2", maGa1),
                            new SqlParameter("@kc", khoangCach));
                    }
                }

                NapDanhSachLienKet(); // refresh danh sach tren grid
                MessageBox.Show("Them lien ket thanh cong.");
            }
            catch (SqlException ex)
            {
                // Xu ly loi SQL (VD: constraint, du lieu sai)
                MessageBox.Show("Loi khi them lien ket: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Co loi: " + ex.Message);
            }
        }

        // 5) Su kien nut Xoa lien ket (xoa dong dang chon tren DataGridView)
        private void btnXoaLienKet_Click(object sender, EventArgs e)
        {
            if (dgvLienKet.CurrentRow == null)
            {
                MessageBox.Show("Chon mot lien ket de xoa.");
                return;
            }

            string maGa1 = dgvLienKet.CurrentRow.Cells["Ga1"].Value?.ToString();
            string maGa2 = dgvLienKet.CurrentRow.Cells["Ga2"].Value?.ToString();

            if (string.IsNullOrEmpty(maGa1) || string.IsNullOrEmpty(maGa2))
            {
                MessageBox.Show("Du lieu lien ket khong hop le.");
                return;
            }

            var hoi = MessageBox.Show($"Ban muon xoa lien ket {maGa1} -> {maGa2} ?", "Xac nhan", MessageBoxButtons.YesNo);
            if (hoi != DialogResult.Yes) return;

            try
            {
                TroGiup.ThucThi("DELETE FROM LienKet WHERE Ga1=@g1 AND Ga2=@g2",
                    new SqlParameter("@g1", maGa1), new SqlParameter("@g2", maGa2));
                NapDanhSachLienKet();
                MessageBox.Show("Xoa lien ket thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi xoa: " + ex.Message);
            }
        }

        // 6) Su kien nut Sua khoang cach (cap nhat khoang cach cho cap Ga1->Ga2)
        private void btnSuaLienKet_Click(object sender, EventArgs e)
        {
            if (dgvLienKet.CurrentRow == null)
            {
                MessageBox.Show("Chon mot lien ket de sua.");
                return;
            }

            string maGa1 = dgvLienKet.CurrentRow.Cells["Ga1"].Value?.ToString();
            string maGa2 = dgvLienKet.CurrentRow.Cells["Ga2"].Value?.ToString();
            int khoangCachMoi = (int)numKhoangCach.Value;

            try
            {
                TroGiup.ThucThi("UPDATE LienKet SET KhoangCach=@kc WHERE Ga1=@g1 AND Ga2=@g2",
                    new SqlParameter("@kc", khoangCachMoi),
                    new SqlParameter("@g1", maGa1),
                    new SqlParameter("@g2", maGa2));
                NapDanhSachLienKet();
                MessageBox.Show("Cap nhat khoang cach thanh cong.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi khi cap nhat: " + ex.Message);
            }
        }

        // 7) Khi chon mot dong tren DataGridView -> dua thong tin len ComboBox va NumericUpDown
        private void dgvLienKet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLienKet.CurrentRow == null) return;
            cmbGa1.SelectedValue = dgvLienKet.CurrentRow.Cells["Ga1"].Value?.ToString();
            cmbGa2.SelectedValue = dgvLienKet.CurrentRow.Cells["Ga2"].Value?.ToString();
            int kc = 0;
            int.TryParse(dgvLienKet.CurrentRow.Cells["KhoangCach"].Value?.ToString(), out kc);
            numKhoangCach.Value = kc;
        }

        // 8) Nut Lam moi: nap lai du lieu
        private void btnLamMoiLienKet_Click(object sender, EventArgs e)
        {
            NapComboGa();
            NapDanhSachLienKet();
        }

        //// 9) (Tu dong) Tim kiem neu co textbox tim kiem (khong bat buoc)
        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    string tuKhoa = txtTimKiem.Text.Trim();
        //    if (string.IsNullOrEmpty(tuKhoa))
        //    {
        //        NapDanhSachLienKet();
        //        return;
        //    }

            // Tim theo ten ga 1 hoac ten ga 2
        //    string sql = @"
        //        SELECT lk.Ga1, g1.TenGa AS TenGa1, lk.Ga2, g2.TenGa AS TenGa2, lk.KhoangCach
        //        FROM LienKet lk
        //        LEFT JOIN Ga g1 ON lk.Ga1 = g1.MaGa
        //        LEFT JOIN Ga g2 ON lk.Ga2 = g2.MaGa
        //        WHERE g1.TenGa LIKE @kw OR g2.TenGa LIKE @kw
        //        ORDER BY lk.Ga1, lk.Ga2";
        //    dgvLienKet.DataSource = TroGiup.LayBang(sql, new SqlParameter("@kw", "%" + tuKhoa + "%"));
        //}


    }
}
