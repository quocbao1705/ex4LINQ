using ex4DAO;
using QLPhieuNhap_DAO;
using System;
using System.Collections.Generic;

namespace QLPhieuNhap_BUS
{
    public class PhieuNhap_BUS
    {
        private PhieuNhap_DAO pnDAO = new PhieuNhap_DAO();
        private ChiTietPhieuNhap_DAO ctDAO = new ChiTietPhieuNhap_DAO();

        public string ThemPhieuNhap(string maPN, string maNCC, DateTime ngayNhap)
        {
            // 1. Validation
            if (string.IsNullOrWhiteSpace(maPN))
                return "Mã phiếu nhập không được trống.";

            // 2. Logic nghiệp vụ
            if (pnDAO.KiemTraTonTai(maPN))
                return "Mã phiếu nhập đã tồn tại.";

            // 3. Gọi DAO
            PhieuNhap pn = new PhieuNhap
            {
                MaPN = maPN,
                MaNCC = maNCC,
                NgayNhap = ngayNhap
            };

            if (pnDAO.Them(pn))
                return null; // Thành công
            else
                return "Đã xảy ra lỗi khi lưu phiếu nhập.";
        }

        public string XoaPhieuNhap(string maPN)
        {
            // Logic: Không cho xóa nếu đã có chi tiết
            if (ctDAO.KiemTraChiTietTonTai(maPN))
            {
                return "Không thể xóa, phiếu đã có chi tiết sản phẩm.";
            }

            // (Chưa code hàm Delete trong DAO, nếu cần bạn tự thêm)
            // if (pnDAO.Delete(maPN)) ...

            return null;
        }
        // (Bên trong lớp PhieuNhap_BUS)

        public List<PhieuNhap> LayDanhSach()
        {
            return pnDAO.LayDanhSach();
        }
    }
}