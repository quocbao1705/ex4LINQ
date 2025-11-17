using ex4DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLPhieuNhap_DAO
{
    public class ChiTietPhieuNhap_DAO
    {
        public object LayDanhSachChiTiet() 
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var query = from ct in db.ChiTietPhieuNhaps
                            orderby ct.MaPN // Sắp xếp theo MaPN cho dễ nhìn
                            select new
                            {
                                MaPN = ct.MaPN,
                                MaSP = ct.MaSP,
                                SoLuong = ct.SoLuong,
                                DonGia = ct.DonGia
                            };

                return query.ToList();
            }
        }

        public ChiTietPhieuNhap LayChiTiet(string maPN, string maSP)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                return db.ChiTietPhieuNhaps
                         .SingleOrDefault(ct => ct.MaPN == maPN && ct.MaSP == maSP);
            }
        }

        public bool KiemTraChiTietTonTai(string maPN)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                return db.ChiTietPhieuNhaps.Any(ct => ct.MaPN == maPN);
            }
        }

        public bool Them(ChiTietPhieuNhap ct)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.ChiTietPhieuNhaps.InsertOnSubmit(ct);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception) { return false; }
        }

        public bool CapNhat(ChiTietPhieuNhap ctCapNhat)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var ct = db.ChiTietPhieuNhaps.SingleOrDefault(
                        c => c.MaPN == ctCapNhat.MaPN && c.MaSP == ctCapNhat.MaSP);

                    if (ct == null) return false;

                    ct.SoLuong = ctCapNhat.SoLuong;
                    ct.DonGia = ctCapNhat.DonGia; // Cập nhật luôn đơn giá

                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception) { return false; }
        }

        public bool Xoa(string maPN, string maSP)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    var ct = db.ChiTietPhieuNhaps.SingleOrDefault(
                        c => c.MaPN == maPN && c.MaSP == maSP);

                    if (ct == null) return false;

                    db.ChiTietPhieuNhaps.DeleteOnSubmit(ct);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception) { return false; }
        }

        public decimal TinhTongTien(string maPN)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                decimal? tong = db.ChiTietPhieuNhaps
                                  .Where(ct => ct.MaPN == maPN)
                                  .Sum(ct => (decimal?)(ct.SoLuong * ct.DonGia));
                return tong ?? 0;
            }
        }
    }
}