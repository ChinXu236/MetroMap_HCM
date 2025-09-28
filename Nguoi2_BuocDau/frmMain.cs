using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Nguoi2_BuocDau
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void mnuQuanLyGa_Click(object sender, EventArgs e)
        {
            frmGa f = new frmGa();
            f.ShowDialog();   // mở FormGa
        }

        private void mnuQuanLyTuyen_Click(object sender, EventArgs e)
        {
            frmTuyen f = new frmTuyen();
            f.ShowDialog();
        }

        private void mnuQuanLyLienKet_Click(object sender, EventArgs e)
        {
            frmLienKet f = new frmLienKet();
            f.ShowDialog();
        }

        private void mnuTimDuong_Click(object sender, EventArgs e)
        {
            frmTimDuong f = new frmTimDuong();
            f.ShowDialog();
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe f = new frmThongKe();
            f.ShowDialog();
        }


    }
}
