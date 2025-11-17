using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4BUS
{
    public class PhieuNhapDTO
    {
        public PhieuNhapDTO()
        {

        }
        public string MaPN { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public decimal ThanhTien { get; set; }



        public PhieuNhapDTO(string maPN, string maNCC, DateTime ngayNhap, string tenNCC, decimal thanhTien)
        {
            MaPN = maPN;
            MaNCC = maNCC;
            NgayNhap = ngayNhap;
            TenNCC = tenNCC;
            ThanhTien = thanhTien;
        }
    }
}
