using ex4DAO;
using System.Collections.Generic;
using System.Linq;

namespace QLPhieuNhap_DAO
{
    public class NhaCungCap_DAO
    {
        // Sử dụng DataContext đã tạo
        DataClasses1DataContext db = new DataClasses1DataContext();

        public List<NhaCungCap> LayDanhSach()
        {
            // Lấy tất cả và trả về 1 List
            return db.NhaCungCaps.ToList();
        }
    }
}