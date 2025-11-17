namespace QLPhieuNhap_BUS
{
    using ex4DAO;
    using QLPhieuNhap_DAO;

    public class ChiTietPhieuNhap_BUS
    {
        private ChiTietPhieuNhap_DAO ctDAO = new ChiTietPhieuNhap_DAO();

        // (Trong file ChiTietPhieuNhap_BUS.cs)

        public object LayDanhSachChiTiet() // Xóa string maPN
        {
            // Gọi hàm DAO không có tham số
            return ctDAO.LayDanhSachChiTiet();
        }

        public string ThemHoacCapNhat(string maPN, string maSP, int soLuong, decimal donGia, bool isUpdate = false)
        {
            // 1. Validation
            if (soLuong <= 0)
                return "Số lượng phải lớn hơn 0.";

            var ct = ctDAO.LayChiTiet(maPN, maSP);

            if (ct != null && !isUpdate) // Đã tồn tại VÀ đang ở chế độ "Thêm"
            {
                // Cộng dồn số lượng
                int soLuongMoi = ct.SoLuong.Value + soLuong;
                ct.SoLuong = soLuongMoi;
                // Có thể cập nhật đơn giá mới
                ct.DonGia = donGia;

                if (ctDAO.CapNhat(ct))
                    return null; // Thành công
                else
                    return "Lỗi khi cập nhật số lượng.";
            }
            else if (isUpdate) // Chế độ "Sửa"
            {
                ct.SoLuong = soLuong;
                ct.DonGia = donGia;
                if (ctDAO.CapNhat(ct))
                    return null; // Thành công
                else
                    return "Lỗi khi cập nhật sản phẩm.";
            }
            else // Thêm mới hoàn toàn
            {
                ChiTietPhieuNhap ctMoi = new ChiTietPhieuNhap
                {
                    MaPN = maPN,
                    MaSP = maSP,
                    SoLuong = soLuong,
                    DonGia = donGia
                };
                if (ctDAO.Them(ctMoi))
                    return null; // Thành công
                else
                    return "Lỗi khi thêm sản phẩm mới.";
            }
        }

        public string XoaChiTiet(string maPN, string maSP)
        {
            if (ctDAO.Xoa(maPN, maSP))
                return null;
            else
                return "Lỗi khi xóa sản phẩm.";
        }

        public decimal TinhTongTien(string maPN)
        {
            return ctDAO.TinhTongTien(maPN);
        }
    }
}