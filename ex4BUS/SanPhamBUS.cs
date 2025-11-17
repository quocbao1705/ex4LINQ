using ex4DAO;
using QLPhieuNhap_DAO;
using System.Collections.Generic;

namespace QLPhieuNhap_BUS
{
    public class SanPham_BUS
    {
        private SanPham_DAO dao = new SanPham_DAO();

        public List<SanPham> LayDanhSach()
        {
            return dao.LayDanhSach();
        }

        public SanPham LayTheoMa(string maSP)
        {
            return dao.LayTheoMa(maSP);
        }
    }
}