using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDotNet_TourDuLich.ThuMuc_Class
{
    class DatVe
    {
        string maKhach, maTour, ngayDat, ngayDi, giaVe;
        int soLuong;
        double tongTien;
        public string MaKhach
        {
            get { return maKhach; }
            set { maKhach = value; }
        }
        public string MaTour
        {
            get { return maTour; }
            set { maTour = value; }
        }
        public string NgayDat
        {
            get { return ngayDat; }
            set { ngayDat = value; }
        }
        public string NgayDi
        {
            get { return ngayDi; }
            set { ngayDi = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string GiaVe
        {
            get { return giaVe; }
            set { giaVe = value; }
        }
        public double TongTien
        {
            get { return (double)SoLuong * double.Parse(GiaVe); }
        }
        public DatVe()
        {
            MaKhach = MaTour = NgayDat = NgayDi = "";
            SoLuong = 0;
            GiaVe = "";
        }
        public DatVe(string MaKhach,string MaTour,  string NgayDi, int SoLuong, string GiaVe)
        {
            this.MaKhach = MaKhach;
            this.MaTour = MaTour;
            this.NgayDat = "01/01/1900";
            this.NgayDi = NgayDi;
            this.SoLuong = SoLuong;
            this.GiaVe = GiaVe;
        }
    }
}
