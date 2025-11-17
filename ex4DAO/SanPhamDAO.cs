using ex4DAO;
using System.Collections.Generic;
using System.Linq;

namespace QLPhieuNhap_DAO
{
    public class SanPham_DAO
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public List<SanPham> LayDanhSach()
        {
            return db.SanPhams.ToList();
        }

        public SanPham LayTheoMa(string maSP)
        {
            // SingleOrDefault trả về null nếu không tìm thấy
            return db.SanPhams.SingleOrDefault(sp => sp.MaSP == maSP);
        }
    }
}