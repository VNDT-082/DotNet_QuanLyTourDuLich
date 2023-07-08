using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDotNet_TourDuLich
{
    class HuongDanVien
    {
        public string MaHDV { get; set; }
        public string MaTK { get; set; }
        public string MaLoai { get; set; }
        public string TenHDV { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string NgayVaoLam { get; set; }
        public string CCCD { get; set; }
        public HuongDanVien()
        {
            MaHDV = MaTK = MaLoai = TenHDV = SDT = NgayVaoLam = CCCD =GioiTinh= "";
        }
        public HuongDanVien(string mahdv,string matk,string maloai,string tenhdv,string gioitinh,string sdt,string ngayvaolam,string cccd)
        {
            MaHDV = mahdv;
            MaTK = matk;
            MaLoai = maloai;
            TenHDV = tenhdv;
            GioiTinh = gioitinh;
            SDT = sdt;
            NgayVaoLam = ngayvaolam;
            CCCD = cccd;
        }
    }
}
