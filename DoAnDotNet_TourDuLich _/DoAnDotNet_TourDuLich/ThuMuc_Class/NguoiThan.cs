using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDotNet_TourDuLich.ThuMuc_Class
{
    class NguoiThan
    {
        int maThanhVien;
        string tenThanhVien, gioiTinh, cCCD, maKhach, maTour;
        string ngaySinh;

        public string MaTour
        {
            get { return maTour; }
            set { maTour = value; }
        }
        public int MaThanhVien
        {
            get { return maThanhVien; }
            set { maThanhVien = value; }
        }
        public string TenThanhVien
        {
            get { return tenThanhVien; }
            set { tenThanhVien = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set
            {
                if(value=="0")
                {
                    gioiTinh = "Nữ";
                }
                else if(value=="1")
                {
                    gioiTinh = "Nam";
                }
            }
        }
        public string CCCD
        {
            get { return cCCD; }
            set { cCCD = value; }
        }
        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string MaKhach
        {
            get { return maKhach; }
            set { maKhach = value; }
        }
        public NguoiThan()
        {
            MaThanhVien = 0;
            TenThanhVien = CCCD = MaKhach= MaTour= "";
            NgaySinh = "";
            GioiTinh = "0";
        }
        public NguoiThan(int MaThanhVien,string TenThanhVien, string MaKhach, string GioiTinh, string NgaySinh, string CCCD, string MaTour)
        {
            this.MaThanhVien = MaThanhVien;
            this.TenThanhVien = TenThanhVien;
            this.MaKhach = MaKhach;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.CCCD = CCCD;
            this.MaTour = MaTour;
        }
    }
}
