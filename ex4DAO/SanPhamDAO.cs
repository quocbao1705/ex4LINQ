using System.Collections.Generic;
using System.Linq;
using ex4LINQDAO;
using ex4LINQDTO;

namespace ex4LINQDAO
{
    public class SanPhamDAO
    {
        // Lấy danh sách sản phẩm
        public List<SanPhamDTO> LayDanhSach()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var query = from sp in db.SanPhams
                            select new SanPhamDTO
                            {
                                MaSP = sp.MaSP,
                                TenSP = sp.TenSP,
                                DonGia = (decimal)sp.DonGia // LINQ tự xử lý nullable
                            };
                return query.ToList();
            }
        }

        // Lấy 1 sản phẩm (để lấy đơn giá)
        public SanPhamDTO LayTheoMa(string maSP)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var sp = db.SanPhams.SingleOrDefault(s => s.MaSP == maSP);

                if (sp != null)
                {
                    return new SanPhamDTO
                    {
                        MaSP = sp.MaSP,
                        TenSP = sp.TenSP,
                        DonGia = (decimal)sp.DonGia
                    };
                }
                return null;
            }
        }
    }
}