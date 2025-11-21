using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4LINQDTO
{
    public class ChiTietDTO
    {
      
        public string MaPN { get; set; }
        public string MaSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string TenSP { get; set; }

        public decimal ThanhTien => SoLuong * DonGia;
        public ChiTietDTO()
        {

        }
        public ChiTietDTO(string maPN, string maSP, int soLuong, decimal donGia, string tenSP)
        {
            MaPN = maPN;
            MaSP = maSP;
            SoLuong = soLuong;
            DonGia = donGia;
            TenSP = tenSP;
        }
    }
}