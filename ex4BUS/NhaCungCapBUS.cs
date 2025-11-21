using ex4LINQDAO;
using ex4LINQDTO; 
using System.Collections.Generic;

namespace ex4LINQBUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO dao = new NhaCungCapDAO();

        public List<NhaCungCapDTO> LayDanhSach()
        {
            return dao.LayDanhSach();
        }
    }
}