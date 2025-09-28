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
    public partial class frmGa : Form
    {
        public frmGa()
        {
            InitializeComponent();
        }

        private void FormGa_Load(object sender, EventArgs e)
        {
            hienThiGa();
        }

        private void hienThiGa()
        {
            dgvGa.DataSource = TroGiup.LayBang("SELECT MaGa, TenGa FROM Ga ORDER BY MaGa");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaGa.Text.Trim();
            string ten = txtTenGa.Text.Trim();

            if (string.IsNullOrEmpty(ma) || string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Nhap day du Ma ga va Ten ga");
                return;
            }

            TroGiup.ThucThi("INSERT INTO Ga VALUES(@ma,@ten)",
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten", ten));

            hienThiGa();
            // Xóa nội dung textbox sau khi thêm thành công
            txtMaGa.Text = string.Empty;
            txtTenGa.Text = string.Empty;
            txtMaGa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaGa.Text.Trim();
            string ten = txtTenGa.Text.Trim();

            TroGiup.ThucThi("UPDATE Ga SET TenGa=@ten WHERE MaGa=@ma",
                new SqlParameter("@ten", ten),
                new SqlParameter("@ma", ma));

            hienThiGa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaGa.Text.Trim();

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui long chon mot ga de xoa");
                return;
            }

            // Kiểm tra lại giá trị MaGa có tồn tại trong DataGridView không
            bool maGaTonTai = false;
            foreach (DataGridViewRow row in dgvGa.Rows)
            {
                if (row.Cells["MaGa"].Value != null && row.Cells["MaGa"].Value.ToString() == ma)
                {
                    maGaTonTai = true;
                    break;
                }
            }
            if (!maGaTonTai)
            {
                MessageBox.Show($"Không tìm thấy mã ga '{ma}' trong danh sách.");
                return;
            }

            // Kiểm tra ga có trong bảng LienKet không
            var soLienKet = TroGiup.LayGiaTri(
                "SELECT COUNT(*) FROM LienKet WHERE Ga1=@ma OR Ga2=@ma",
                new SqlParameter("@ma", ma)
            );

            if (Convert.ToInt32(soLienKet) > 0)
            {
                DialogResult dr = MessageBox.Show(
                    "Ga nay dang co lien ket. Ban co muon xoa ca cac lien ket khong?",
                    "Xac nhan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dr == DialogResult.Yes)
                {
                    TroGiup.ThucThi("DELETE FROM LienKet WHERE Ga1=@ma OR Ga2=@ma",
                        new SqlParameter("@ma", ma));
                    int soDongXoa = TroGiup.ThucThi("DELETE FROM Ga WHERE MaGa=@ma",
                        new SqlParameter("@ma", ma));
                    if (soDongXoa > 0)
                        MessageBox.Show("Da xoa ga va cac lien ket lien quan.");
                    else
                        MessageBox.Show("Không xóa được ga. Có thể mã ga không tồn tại hoặc bị lỗi ràng buộc dữ liệu.");
                }
                else
                {
                    MessageBox.Show("Da huy thao tac xoa.");
                    return;
                }
            }
            else
            {
                int soDongXoa = TroGiup.ThucThi("DELETE FROM Ga WHERE MaGa=@ma",
                    new SqlParameter("@ma", ma));
                if (soDongXoa > 0)
                    MessageBox.Show("Da xoa ga.");
                else
                    MessageBox.Show("Không xóa được ga. Có thể mã ga không tồn tại hoặc bị lỗi ràng buộc dữ liệu.");
            }

            hienThiGa();
            txtMaGa.Text = string.Empty;
            txtTenGa.Text = string.Empty;
            txtMaGa.Focus();
        }



        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hienThiGa();
        }

        private void btnTestKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                TroGiup.LayBang("SELECT TOP 1 * FROM Ga");
                MessageBox.Show("Ket noi DB OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi: " + ex.Message);
            }
        }

        private void dgvGa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGa.CurrentRow != null && dgvGa.CurrentRow.Index >= 0)
            {
                // Lấy giá trị MaGa, TenGa từ dòng hiện tại
                object maGa = dgvGa.CurrentRow.Cells["MaGa"].Value;
                object tenGa = dgvGa.CurrentRow.Cells["TenGa"].Value;

                if (maGa != null) txtMaGa.Text = maGa.ToString().Trim();
                if (tenGa != null) txtTenGa.Text = tenGa.ToString().Trim();

                // Highlight dòng đang chọn (màu vàng)
                dgvGa.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                dgvGa.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }



    }
}
