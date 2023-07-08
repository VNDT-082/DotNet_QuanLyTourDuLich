using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDotNet_TourDuLich.ThuMuc_Class
{
    class KhachHang
    {
        public string MaKhach { get; set; }
        public string MaTK { get; set; }
        public string TenKhach { get; set; }
        public string NgaySinh { get; set; }
        public string SDT { get; set; }
        public KhachHang()
        {
            MaKhach = TenKhach = MaTK = NgaySinh = SDT = "";
        }
        public KhachHang(string makhach,string matk,string tenkhach,string ngaysinh,string sdt)
        {
            MaKhach = makhach;
            MaTK = matk;
            TenKhach = tenkhach;
            NgaySinh = ngaysinh;
            SDT = sdt;
        }

    }
}
