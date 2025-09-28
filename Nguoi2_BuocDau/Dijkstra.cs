using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nguoi2_BuocDau
{
    public static class Dijkstra
    {
        // Hàm lấy danh sách liên kết từ DB dưới dạng graph
        private static Dictionary<string, List<(string, int)>> XayDungDoThi()
        {
            var graph = new Dictionary<string, List<(string, int)>>();

            var dt = TroGiup.LayBang("SELECT Ga1, Ga2, KhoangCach FROM LienKet");

            foreach (System.Data.DataRow row in dt.Rows)
            {
                string g1 = row["Ga1"].ToString();
                string g2 = row["Ga2"].ToString();
                int kc = Convert.ToInt32(row["KhoangCach"]);

                if (!graph.ContainsKey(g1)) graph[g1] = new List<(string, int)>();
                graph[g1].Add((g2, kc));
            }

            return graph;
        }

        // Hàm tìm đường ngắn nhất từ gaStart đến gaEnd
        public static List<string> TimDuongNganNhat(string gaStart, string gaEnd)
        {
            var graph = XayDungDoThi();
            var kc = new Dictionary<string, int>();
            var truoc = new Dictionary<string, string>();
            var Q = new List<string>();

            foreach (var nut in graph.Keys)
            {
                kc[nut] = int.MaxValue;
                Q.Add(nut);
            }
            kc[gaStart] = 0;

            while (Q.Count > 0)
            {
                // chọn nút có kc nhỏ nhất
                string u = null;
                int min = int.MaxValue;
                foreach (var nut in Q)
                {
                    if (kc[nut] < min)
                    {
                        min = kc[nut];
                        u = nut;
                    }
                }

                if (u == null) break;
                Q.Remove(u);

                if (!graph.ContainsKey(u)) continue;

                foreach (var (v, w) in graph[u])
                {
                    int alt = kc[u] + w;
                    if (alt < kc[v])
                    {
                        kc[v] = alt;
                        truoc[v] = u;
                    }
                }
            }

            // dựng lại đường đi
            var duong = new List<string>();
            string hienTai = gaEnd;
            while (truoc.ContainsKey(hienTai))
            {
                duong.Insert(0, hienTai);
                hienTai = truoc[hienTai];
            }
            duong.Insert(0, gaStart);

            return duong;
        }
    }
}
