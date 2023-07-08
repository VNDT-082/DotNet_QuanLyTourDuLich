using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDotNet_TourDuLich.ThuMuc_Class
{
    class GioiTinh
    {
        string display;
        int value;
        public string Display { get => display; set => display = value; }
        public int Value { get => value; set => this.value = value; }
        public GioiTinh()
        {
            Display = "Nam";
            Value = 1;
        }
        public GioiTinh(string Display,int Value)
        {
            this.Display = Display;
            this.Value = Value;
        }
    }
}
