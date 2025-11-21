using System.Collections.Generic;
using System.Linq;
using ex4LINQDTO;
using ex4LINQDAO;

namespace ex4LINQDAO
{
    public class NhaCungCapDAO
    {
        public List<NhaCungCapDTO> LayDanhSach()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                // Map từ Entity (db) sang DTO
                var query = from ncc in db.NhaCungCaps
                            select new NhaCungCapDTO
                            {
                                MaNCC = ncc.MaNCC,
                                TenNCC = ncc.TenNCC
                            };

                return query.ToList();
            }
        }
    }
}