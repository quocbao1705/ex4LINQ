using System;
using System.Collections.Generic;
using System.Linq;
using ex4LINQDAO;
using ex4LINQDTO;

namespace ex4LINQDAO
{
    public class PhieuNhapDAO
    {
        public List<PhieuNhapDTO> LayDanhSach()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                // Sắp xếp giảm dần theo ngày nhập
                var query = from pn in db.PhieuNhaps
                            orderby pn.NgayNhap descending
                            select new PhieuNhapDTO
                            {
                                MaPN = pn.MaPN,
                                MaNCC = pn.MaNCC,
                                NgayNhap = pn.NgayNhap.Value // .Value nếu trong DB cho phép null
                            };
                return query.ToList();
            }
        }

        public bool Them(PhieuNhapDTO pnDto)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                try
                {
                    // Chuyển từ DTO sang Entity để lưu
                    PhieuNhap pnEntity = new PhieuNhap
                    {
                        MaPN = pnDto.MaPN,
                        MaNCC = pnDto.MaNCC,
                        NgayNhap = pnDto.NgayNhap
                    };

                    db.PhieuNhaps.InsertOnSubmit(pnEntity);
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Hàm kiểm tra tồn tại (nếu cần)
        public bool KiemTraTonTai(string maPN)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                return db.PhieuNhaps.Any(p => p.MaPN == maPN);
            }
        }
    }
}