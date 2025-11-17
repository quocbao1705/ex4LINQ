using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4BUS
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public SanPhamDTO(String MaSP, String TenSP, decimal DonGia)
        {
            this.MaSP = MaSP;
            this.TenSP = TenSP;
            this.DonGia = DonGia;
        }
        public SanPhamDTO()
        {
            
        }
    }
}
