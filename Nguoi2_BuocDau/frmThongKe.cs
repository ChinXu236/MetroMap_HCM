using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Nguoi2_BuocDau
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            string sql = @"
                SELECT t.TenTuyen, COUNT(g.MaGa) AS SoGa
                FROM Tuyen t
                JOIN Ga g ON 1=1 -- chỗ này em chỉnh theo cách em thiết kế quan hệ
                GROUP BY t.TenTuyen";

            DataTable dt = TroGiup.LayBang(sql);

            chartThongKe.Series.Clear();
            Series series = new Series("So Ga");
            series.ChartType = SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(row["TenTuyen"].ToString(), Convert.ToInt32(row["SoGa"]));
            }

            chartThongKe.Series.Add(series);
        }
    }
}
