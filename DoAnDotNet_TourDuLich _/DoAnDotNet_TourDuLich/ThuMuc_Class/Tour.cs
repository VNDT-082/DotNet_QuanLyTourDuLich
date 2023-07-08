using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDotNet_TourDuLich.ThuMuc_Class
{
    class Tour
    {
        public string MaTour { get; set; }
        public string MaHDV { get; set; }
        public string TenTour { get; set; }
        public string DiaDiem { get; set; }

        public string ChiPhi { get; set; }
        public string AnhBia { get; set; }
        public string LoaiTour { get; set; }
        public Tour()
        {
            MaTour = MaHDV = TenTour = DiaDiem = ChiPhi = AnhBia =LoaiTour= "";
        }
        public Tour(string matour,string mahdv,string tentour,string diadiem,string chiphi,string anhbia,string loaitour)
        {
            MaTour = matour;
            MaHDV = mahdv;
            TenTour = tentour;
            DiaDiem = diadiem;
            ChiPhi = chiphi;
            AnhBia = anhbia;
            LoaiTour = loaitour;
        }
    }
}
