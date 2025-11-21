using System;
using System.Collections.Generic;
using System.Linq; 
using ex4LINQDAO;
using ex4LINQDTO;

namespace ex4LINQBUS
{
    public class PhieuNhapBUS
    {
        private PhieuNhapDAO pnDAO = new PhieuNhapDAO();
        private ChiTietPhieuNhapDAO ctDAO = new ChiTietPhieuNhapDAO();

        public string ThemPhieuNhap(string maPN, string maNCC, DateTime ngayNhap)
        {
            if (string.IsNullOrWhiteSpace(maPN))
                return "Mã phiếu nhập không được trống.";

            if (pnDAO.KiemTraTonTai(maPN))
                return "Mã phiếu nhập đã tồn tại.";

            PhieuNhapDTO pn = new PhieuNhapDTO
            {
                MaPN = maPN,
                MaNCC = maNCC,
                NgayNhap = ngayNhap
            };

            if (pnDAO.Them(pn))
                return null; 
            else
                return "Đã xảy ra lỗi khi lưu phiếu nhập.";
        }

        public string XoaPhieuNhap(string maPN)
        {

            var danhSachChiTiet = ctDAO.LayDanhSachChiTiet();

            bool coChiTiet = danhSachChiTiet.Any(ct => ct.MaPN == maPN);

            if (coChiTiet)
            {
                return "Không thể xóa, phiếu đã có chi tiết sản phẩm.";
            }
            return null;
        }

        public List<PhieuNhapDTO> LayDanhSach()
        {
            return pnDAO.LayDanhSach();
        }
    }
}