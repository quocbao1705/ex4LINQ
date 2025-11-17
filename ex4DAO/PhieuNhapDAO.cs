using ex4DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QLPhieuNhap_DAO
{
    public class PhieuNhap_DAO
    {
        // Bạn nên 'new' DataContext trong từng hàm 'using'
        // để đảm bảo kết nối được đóng đúng cách.
        // Tôi sẽ sửa lại theo cách này cho chuẩn.

        public bool KiemTraTonTai(string maPN)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                return db.PhieuNhaps.Any(pn => pn.MaPN == maPN);
            }
        }

        public bool Them(PhieuNhap pn)
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.PhieuNhaps.InsertOnSubmit(pn);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<PhieuNhap> LayDanhSach()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                return db.PhieuNhaps.OrderByDescending(pn => pn.NgayNhap).ToList();
            }
        }
    }
}