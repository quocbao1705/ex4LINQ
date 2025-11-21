using System;
using System.Collections.Generic;
using System.Linq;
using ex4LINQDAO;
using ex4LINQDTO;

namespace ex4LINQDAO
{
    public class ChiTietPhieuNhapDAO
    {
        // Lấy toàn bộ chi tiết
        public List<ChiTietDTO> LayDanhSachChiTiet()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var query = from ct in db.ChiTietPhieuNhaps
                            select new ChiTietDTO
                            {
                                MaPN = ct.MaPN,
                                MaSP = ct.MaSP,
                                SoLuong = ct.SoLuong.HasValue ? ct.SoLuong.Value : 0,
                                DonGia = ct.DonGia.HasValue ? ct.DonGia.Value : 0
                                // Nếu muốn lấy TenSP, phải join với bảng SanPham ở đây
                            };
                return query.ToList();
            }
        }

        // Kiểm tra tồn tại
        public bool KiemTraTonTai(string maPN, string maSP)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                return db.ChiTietPhieuNhaps.Any(ct => ct.MaPN == maPN && ct.MaSP == maSP);
            }
        }

        // Thêm chi tiết
        public bool Them(ChiTietDTO ctDto)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    ChiTietPhieuNhap ctEntity = new ChiTietPhieuNhap
                    {
                        MaPN = ctDto.MaPN,
                        MaSP = ctDto.MaSP,
                        SoLuong = ctDto.SoLuong,
                        DonGia = ctDto.DonGia
                    };

                    db.ChiTietPhieuNhaps.InsertOnSubmit(ctEntity);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception) { return false; }
            }
        }

        // Cập nhật chi tiết
        public bool CapNhat(ChiTietDTO ctDto)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    // 1. Tìm entity cũ
                    var ctEntity = db.ChiTietPhieuNhaps.SingleOrDefault(c => c.MaPN == ctDto.MaPN && c.MaSP == ctDto.MaSP);

                    if (ctEntity == null) return false;

                    // 2. Cập nhật giá trị
                    ctEntity.SoLuong = ctDto.SoLuong;
                    ctEntity.DonGia = ctDto.DonGia;

                    // 3. Lưu
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception) { return false; }
            }
        }

        // Xóa chi tiết
        public bool Xoa(string maPN, string maSP)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    var ctEntity = db.ChiTietPhieuNhaps.SingleOrDefault(c => c.MaPN == maPN && c.MaSP == maSP);

                    if (ctEntity == null) return false;

                    db.ChiTietPhieuNhaps.DeleteOnSubmit(ctEntity);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception) { return false; }
            }
        }
    }
}