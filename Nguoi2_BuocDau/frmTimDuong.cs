using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Nguoi2_BuocDau.model;

namespace Nguoi2_BuocDau
{
    public partial class frmTimDuong : Form
    {
        private List<DoanDuong> selectedChiTiet;

        public frmTimDuong()
        {
            InitializeComponent();
            SetupDataGridView();
            RegisterEvents();
        }

        private void SetupDataGridView()
        {
            dgvLoTrinh.Columns.Clear();
            dgvLoTrinh.Columns.Add("STT", "STT");
            dgvLoTrinh.Columns.Add("GaDi", "Ga đi");
            dgvLoTrinh.Columns.Add("GaDen", "Ga đến");
            dgvLoTrinh.Columns.Add("Tuyen", "Tuyến");
            dgvLoTrinh.Columns.Add("KhoangCach", "Khoảng cách (km)");
            dgvLoTrinh.Columns.Add("GioXuatPhat", "Giờ xuất phát / Thông tin");

            dgvLoTrinh.ReadOnly = true;
            dgvLoTrinh.AllowUserToAddRows = false;
            dgvLoTrinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoTrinh.RowHeadersVisible = false;

            // Cột giờ xuất phát rộng hơn
            dgvLoTrinh.Columns["GioXuatPhat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLoTrinh.Columns["GioXuatPhat"].MinimumWidth = 150;
            dgvLoTrinh.Columns["GioXuatPhat"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvLoTrinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void RegisterEvents()
        {
            btnTimDuong.Click += BtnTimDuong_Click;
            btnDoiChieu.Click += BtnDoiChieu_Click;
            btnChiTiet.Click += BtnChiTiet_Click;
        }

        private void BtnDoiChieu_Click(object sender, EventArgs e)
        {
            (txtTu.Text, txtDen.Text) = (txtDen.Text, txtTu.Text);
        }

        // Biến toàn cục để lưu giờ xuất phát 5 chuyến tổng quan
        private List<TimeSpan> gioXuatPhatChuyen;

        private void BtnTimDuong_Click(object sender, EventArgs e)
        {
            string gaDi = txtTu.Text.Trim();
            string gaDen = txtDen.Text.Trim();

            if (string.IsNullOrEmpty(gaDi) || string.IsNullOrEmpty(gaDen))
            {
                MessageBox.Show("Nhập ga đi và ga đến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ketQuaChiTiet = Dijkstra.TimDuongChiTiet(gaDi, gaDen);

            if (ketQuaChiTiet == null || ketQuaChiTiet.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đường đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selectedChiTiet = ketQuaChiTiet;
            dgvLoTrinh.Rows.Clear();
            int stt = 1;
            gioXuatPhatChuyen = new List<TimeSpan>();

            double tongKm = ketQuaChiTiet.Sum(d => d.KhoangCach);
            int tongPhut = ketQuaChiTiet.Sum(d => d.ThoiGianDenTiepTheo);
            string cacTuyen = string.Join(", ", ketQuaChiTiet.Select(d => d.MaTuyen).Distinct());

            // Lấy giờ xuất phát đầu tiên
            var firstSegment = ketQuaChiTiet
                .Where(d => d.GaDi.Equals(gaDi, StringComparison.OrdinalIgnoreCase) && d.GioXuatPhat.HasValue)
                .OrderBy(d => d.GioXuatPhat.Value)
                .FirstOrDefault();

            if (firstSegment == null)
            {
                MessageBox.Show("Không tìm thấy giờ xuất phát cho ga đi này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TimeSpan gioBatDauChuyen = firstSegment.GioXuatPhat.Value;

            // Hiển thị 5 chuyến, cách nhau 10 phút
            for (int i = 0; i < 5; i++)
            {
                string thongTin = $"Tổng thời gian: {tongPhut / 60} giờ {tongPhut % 60} phút\n" +
                                  $"Chuyến bắt đầu: {gioBatDauChuyen:hh\\:mm}";

                dgvLoTrinh.Rows.Add(
                    stt++,
                    gaDi,
                    gaDen,
                    cacTuyen,
                    tongKm.ToString("0.00"),
                    thongTin
                );

                gioXuatPhatChuyen.Add(gioBatDauChuyen); // Lưu giờ xuất phát của chuyến
                gioBatDauChuyen = gioBatDauChuyen.Add(TimeSpan.FromMinutes(10));
            }
        }

        private void BtnChiTiet_Click(object sender, EventArgs e)
        {
            if (selectedChiTiet == null || selectedChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa có kết quả tổng quan để hiển thị chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvLoTrinh.CurrentRow == null)
            {
                MessageBox.Show("Chọn một chuyến để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dgvLoTrinh.CurrentRow.Index;
            if (index < 0 || index >= gioXuatPhatChuyen.Count) return;

            TimeSpan gioBatDauChuyen = gioXuatPhatChuyen[index];

            dgvLoTrinh.Rows.Clear();
            int stt = 1;

            // Hiển thị tất cả các đoạn của tuyến, tính giờ xuất phát từng đoạn
            foreach (var d in selectedChiTiet)
            {
                dgvLoTrinh.Rows.Add(
                    stt++,
                    d.GaDi,
                    d.GaDen,
                    d.MaTuyen,
                    d.KhoangCach.ToString("0.00"),
                    gioBatDauChuyen.ToString(@"hh\:mm")
                );

                // Mỗi đoạn giả lập 3 phút
                gioBatDauChuyen = gioBatDauChuyen.Add(TimeSpan.FromMinutes(3));
            }
        }


        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            if (gioXuatPhatChuyen == null || gioXuatPhatChuyen.Count == 0) return;

            dgvLoTrinh.Rows.Clear();
            int stt = 1;

            double tongKm = selectedChiTiet.Sum(d => d.KhoangCach);
            int tongPhut = selectedChiTiet.Sum(d => d.ThoiGianDenTiepTheo);
            string cacTuyen = string.Join(", ", selectedChiTiet.Select(d => d.MaTuyen).Distinct());

            string gaDi = txtTu.Text.Trim();
            string gaDen = txtDen.Text.Trim();

            foreach (var gioBatDau in gioXuatPhatChuyen)
            {
                string thongTin = $"Tổng thời gian: {tongPhut / 60} giờ {tongPhut % 60} phút\n" +
                                  $"Chuyến bắt đầu: {gioBatDau:hh\\:mm}";

                dgvLoTrinh.Rows.Add(
                    stt++,
                    gaDi,
                    gaDen,
                    cacTuyen,
                    tongKm.ToString("0.00"),
                    thongTin
                );
            }
        }
    }
}