using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4BUS
{
    public class NhaCungCapDTO
    {
        public NhaCungCapDTO(string MaNCC, string TenNCC)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
        }
        public NhaCungCapDTO()
        {
        }
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
    }
}
