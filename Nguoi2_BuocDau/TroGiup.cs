using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguoi2_BuocDau
{
    public static class TroGiup
    {
        // Lấy chuỗi kết nối từ App.config
        private static string ChuoiKetNoi => ConfigurationManager.ConnectionStrings["MetroConn"].ConnectionString;

        // Hàm lấy dữ liệu SELECT trả về DataTable
        public static DataTable LayBang(string sql, params SqlParameter[] thamSo)
        {
            using (var ketNoi = new SqlConnection(ChuoiKetNoi))
            using (var lenh = new SqlCommand(sql, ketNoi))
            using (var boDoc = new SqlDataAdapter(lenh))
            {
                if (thamSo != null && thamSo.Length > 0) lenh.Parameters.AddRange(thamSo);
                var dt = new DataTable();
                boDoc.Fill(dt);
                return dt;
            }
        }

        // Hàm INSERT/UPDATE/DELETE
        public static int ThucThi(string sql, params SqlParameter[] thamSo)
        {
            var result = 0;
            using (var ketNoi = new SqlConnection(ChuoiKetNoi))
            using (var lenh = new SqlCommand(sql, ketNoi))
            {
                if (thamSo != null && thamSo.Length > 0) lenh.Parameters.AddRange(thamSo);
                ketNoi.Open();
                result = lenh.ExecuteNonQuery();
            }
            // Sau khi thêm dữ liệu, trả về 0 và để code phía ngoài xử lý việc làm trống textbox
            return result;
        }

        // Hàm trả về 1 giá trị (ví dụ COUNT)
        public static object LayGiaTri(string sql, params SqlParameter[] thamSo)
        {
            using (var conn = new SqlConnection(ChuoiKetNoi))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (thamSo != null && thamSo.Length > 0)
                    cmd.Parameters.AddRange(thamSo);
                conn.Open();
                return cmd.ExecuteScalar();  // trả ra COUNT(*)
            }
        }

    }
}
