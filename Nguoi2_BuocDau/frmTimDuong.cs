using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguoi2_BuocDau
{
    public partial class frmTimDuong : Form
    {
        public frmTimDuong()
        {
            InitializeComponent();
        }

        private void FormTimDuong_Load(object sender, EventArgs e)
        {
            DataTable dt = TroGiup.LayBang("SELECT MaGa, TenGa FROM Ga ORDER BY TenGa");
            cmbGaBatDau.DataSource = dt;
            cmbGaBatDau.DisplayMember = "TenGa";
            cmbGaBatDau.ValueMember = "MaGa";

            cmbGaKetThuc.DataSource = dt.Copy();
            cmbGaKetThuc.DisplayMember = "TenGa";
            cmbGaKetThuc.ValueMember = "MaGa";
        }

        private void btnTimDuong_Click(object sender, EventArgs e)
        {
            string start = cmbGaBatDau.SelectedValue.ToString();
            string end = cmbGaKetThuc.SelectedValue.ToString();

            var duong = Dijkstra.TimDuongNganNhat(start, end);
            txtKetQua.Text = string.Join(" -> ", duong);
        }

    }
}
