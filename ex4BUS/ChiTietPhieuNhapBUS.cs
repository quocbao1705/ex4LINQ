using System.Collections.Generic;
using System.Linq; 
using ex4LINQDAO;
using ex4LINQDTO;

namespace ex4LINQBUS
{
    public class ChiTietPhieuNhapBUS
    {
        private ChiTietPhieuNhapDAO ctDAO = new ChiTietPhieuNhapDAO();

        public List<ChiTietDTO> LayDanhSachChiTiet()
        {
            return ctDAO.LayDanhSachChiTiet();
        }

        public string ThemHoacCapNhat(string maPN, string maSP, int soLuong, decimal donGia, bool isUpdate = false)
        {
            if (soLuong <= 0)
                return "Số lượng phải lớn hơn 0.";

            var danhSach = ctDAO.LayDanhSachChiTiet();
            var ctHienTai = danhSach.SingleOrDefault(x => x.MaPN == maPN && x.MaSP == maSP);

            ChiTietDTO dto = new ChiTietDTO
            {
                MaPN = maPN,
                MaSP = maSP,
                DonGia = donGia
            };

            if (ctHienTai != null && !isUpdate)
            {
                dto.SoLuong = ctHienTai.SoLuong + soLuong;

                if (ctDAO.CapNhat(dto))
                    return null;
                else
                    return "Lỗi khi cập nhật số lượng.";
            }
            else if (isUpdate)
            {
                dto.SoLuong = soLuong; 

                if (ctDAO.CapNhat(dto))
                    return null;
                else
                    return "Lỗi khi cập nhật sản phẩm.";
            }
            else
            {
                dto.SoLuong = soLuong;

                if (ctHienTai != null) return "Sản phẩm đã tồn tại (Lỗi Logic).";

                if (ctDAO.Them(dto))
                    return null;
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
            var danhSach = ctDAO.LayDanhSachChiTiet();

            decimal tong = danhSach.Where(x => x.MaPN == maPN)
                                   .Sum(x => x.SoLuong * x.DonGia);

            return tong;
        }
    }
}