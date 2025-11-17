using ex4DAO;
using QLPhieuNhap_DAO; // Using project DAO
using System.Collections.Generic;

namespace QLPhieuNhap_BUS
{
    public class NhaCungCap_BUS
    {
        private NhaCungCap_DAO dao = new NhaCungCap_DAO();

        public List<NhaCungCap> LayDanhSach()
        {
            // Chỉ gọi qua DAO, không xử lý gì thêm
            return dao.LayDanhSach();
        }
    }
}