using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDotNet_TourDuLich.ThuMuc_Class
{
    class _ChiTietChuongTrinhTour
    {
        private int id;
        private string maCTTour;
        private int ngay;
        private string gioDi;
        private string gioDen;
        private string diemKhoiHanh;
        private string diemDen;
        private string moTa;
        private string hinhAnh;

        

        public string MaCTTour { get => maCTTour; set => maCTTour = value; }
        public int Ngay { get => ngay; set => ngay = value; }
        public string GioDi { get => gioDi; set => gioDi = value; }
        public string GioDen { get => gioDen; set => gioDen = value; }
        public string DiemKhoiHanh { get => diemKhoiHanh; set => diemKhoiHanh = value; }
        public string DiemDen { get => diemDen; set => diemDen = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int Id { get => id; set => id = value; }

        public _ChiTietChuongTrinhTour()
        {
            MaCTTour = "";
            Ngay = 0;
            GioDi = "";
            GioDen = "";
            DiemKhoiHanh = "";
            DiemDen = "";
            MoTa = "";
            HinhAnh = "";
            Id = 0;
        }
        public _ChiTietChuongTrinhTour(int id, string maCTTour, int ngay, string gioDi, string gioDen,
            string diemKhoiHanh, string diemDen, string moTa, string hinhAnh)
        {
            Id = id;
            MaCTTour = maCTTour;
            Ngay = ngay;
            GioDi = gioDi;
            GioDen = gioDen;
            DiemKhoiHanh = diemKhoiHanh;
            DiemDen = diemDen;
            MoTa = moTa;
            HinhAnh = hinhAnh;
        }
    }
}
