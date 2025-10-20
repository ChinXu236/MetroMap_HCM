using System;
using System.Collections.Generic;
using System.Linq;
using Nguoi2_BuocDau.model;

namespace Nguoi2_BuocDau
{
    public class DoanDuong
    {
        public string GaDi { get; set; }
        public string GaDen { get; set; }
        public string MaTuyen { get; set; }
        public double KhoangCach { get; set; }
        public TimeSpan? GioXuatPhat { get; set; } // giờ xuất phát của đoạn
        public TimeSpan? GioDen { get; set; }      // giờ đến của đoạn
        public bool DoiTuyen { get; set; }
        public int ThoiGianDenTiepTheo { get; set; } // phút đi đoạn tiếp theo (3 phút)
    }

    public static class Dijkstra
    {
        // Xây dựng đồ thị
        private static Dictionary<string, List<Tuple<string, double>>> XayDungDoThi()
        {
            var graph = new Dictionary<string, List<Tuple<string, double>>>();

            using (var db = new Model1())
            {
                foreach (var lk in db.LienKets.ToList())
                {
                    string g1 = lk.MaGa1;
                    string g2 = lk.MaGa2;
                    double kc = lk.KhoangCach ?? 0;

                    if (!graph.ContainsKey(g1)) graph[g1] = new List<Tuple<string, double>>();
                    graph[g1].Add(Tuple.Create(g2, kc));

                    if (!graph.ContainsKey(g2)) graph[g2] = new List<Tuple<string, double>>();
                    graph[g2].Add(Tuple.Create(g1, kc));
                }
            }

            return graph;
        }

        public static List<DoanDuong> TimDuongChiTiet(string tenGaStart, string tenGaEnd)
        {
            using (var db = new Model1())
            {
                var gaStartObj = db.Gas.FirstOrDefault(g => g.TenGa.Equals(tenGaStart, StringComparison.OrdinalIgnoreCase));
                var gaEndObj = db.Gas.FirstOrDefault(g => g.TenGa.Equals(tenGaEnd, StringComparison.OrdinalIgnoreCase));

                if (gaStartObj == null || gaEndObj == null)
                    return null;

                string gaStart = gaStartObj.MaGa;
                string gaEnd = gaEndObj.MaGa;

                var graph = XayDungDoThi();

                var kc = new Dictionary<string, double>();
                var truoc = new Dictionary<string, string>();
                var Q = new HashSet<string>(graph.Keys);

                foreach (var nut in graph.Keys)
                    kc[nut] = double.PositiveInfinity;
                kc[gaStart] = 0;

                while (Q.Count > 0)
                {
                    string u = null;
                    double minKC = double.PositiveInfinity;
                    foreach (var n in Q)
                    {
                        if (kc[n] < minKC)
                        {
                            minKC = kc[n];
                            u = n;
                        }
                    }

                    if (u == null) break;
                    Q.Remove(u);
                    if (u == gaEnd) break;
                    if (!graph.ContainsKey(u)) continue;

                    foreach (var vTuple in graph[u])
                    {
                        string v = vTuple.Item1;
                        double alt = kc[u] + 1; // 1 đoạn = 1 trọng số (không dùng km)
                        if (alt < kc[v])
                        {
                            kc[v] = alt;
                            truoc[v] = u;
                        }
                    }
                }

                if (!truoc.ContainsKey(gaEnd) && gaStart != gaEnd) return null;

                // Dựng đường đi
                var duong = new List<string>();
                string hienTai = gaEnd;
                while (truoc.ContainsKey(hienTai))
                {
                    duong.Insert(0, hienTai);
                    hienTai = truoc[hienTai];
                }
                duong.Insert(0, gaStart);

                // Chi tiết từng đoạn
                var ketQua = new List<DoanDuong>();

                // Lấy giờ xuất phát đầu tiên từ LichTrinh
                var lichDau = db.LichTrinhs
                    .Where(l => l.MaGa == gaStart)
                    .OrderBy(l => l.GioXuatPhat)
                    .FirstOrDefault();

                TimeSpan gioHienTai = lichDau?.GioXuatPhat ?? DateTime.Now.TimeOfDay;

                for (int i = 0; i < duong.Count - 1; i++)
                {
                    string maGa1 = duong[i];
                    string maGa2 = duong[i + 1];

                    var g1 = db.Gas.FirstOrDefault(g => g.MaGa == maGa1);
                    var g2 = db.Gas.FirstOrDefault(g => g.MaGa == maGa2);

                    var lk = db.LienKets.FirstOrDefault(x =>
                        (x.MaGa1 == maGa1 && x.MaGa2 == maGa2) ||
                        (x.MaGa1 == maGa2 && x.MaGa2 == maGa1));

                    bool doiTuyen = g1.MaTuyen != g2.MaTuyen;
                    string maTuyen = doiTuyen ? g2.MaTuyen + " (Đổi tuyến)" : g1.MaTuyen;

                    TimeSpan gioDi = gioHienTai;
                    TimeSpan gioDen = gioDi.Add(TimeSpan.FromMinutes(3)); // mỗi đoạn 3 phút

                    ketQua.Add(new DoanDuong
                    {
                        GaDi = g1.TenGa,
                        GaDen = g2.TenGa,
                        MaTuyen = maTuyen,
                        KhoangCach = lk?.KhoangCach ?? 0,
                        GioXuatPhat = gioDi,
                        GioDen = gioDen,
                        DoiTuyen = doiTuyen,
                        ThoiGianDenTiepTheo = 3
                    });

                    // Cập nhật giờ cho đoạn tiếp theo
                    gioHienTai = gioDen;
                }

                return ketQua;
            }
        }
    }
}
