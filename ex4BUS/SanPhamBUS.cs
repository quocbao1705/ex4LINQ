using System.Collections.Generic;
using ex4LINQDAO;
using ex4LINQDTO;

namespace ex4LINQBUS 
{
    public class SanPhamBUS
    {
        private SanPhamDAO dao = new SanPhamDAO();

        public List<SanPhamDTO> LayDanhSach()
        {
            return dao.LayDanhSach();
        }

        public SanPhamDTO LayTheoMa(string maSP)
        {
            return dao.LayTheoMa(maSP);
        }
    }
}