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
    public partial class frmTuyen : Form
    {
        public frmTuyen()
        {
            InitializeComponent();
        }

        private void FormTuyen_Load(object sender, EventArgs e)
        {
            hienThiTuyen();
        }

        private void hienThiTuyen()
        {
            dgvTuyen.DataSource = TroGiup.LayBang("SELECT MaTuyen, TenTuyen FROM Tuyen ORDER BY MaTuyen");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaTuyen.Text.Trim();
            string ten = txtTenTuyen.Text.Trim();

            TroGiup.ThucThi("INSERT INTO Tuyen VALUES(@ma,@ten)",
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten", ten));
            hienThiTuyen();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaTuyen.Text.Trim();
            string ten = txtTenTuyen.Text.Trim();

            TroGiup.ThucThi("UPDATE Tuyen SET TenTuyen=@ten WHERE MaTuyen=@ma",
                new SqlParameter("@ten", ten),
                new SqlParameter("@ma", ma));
            hienThiTuyen();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaTuyen.Text.Trim();

            TroGiup.ThucThi("DELETE FROM Tuyen WHERE MaTuyen=@ma",
                new SqlParameter("@ma", ma));
            hienThiTuyen();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hienThiTuyen();
        }
    }
}
