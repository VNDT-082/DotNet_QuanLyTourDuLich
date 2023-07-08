using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDotNet_TourDuLich
{
    class account
    {
        public string maTk { get; set; }
        public string maLoaiTk { get; set; }
        public string tenTK{ get; set; }
        public string tenDn { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string Mk { get; set; }

        public account()
        {
            maTk = maLoaiTk = tenTK = tenDn = SDT = Email = Mk = "";
        }
        public account(string mtk,string ml,string ten,string tenN,string dd,string mail,string pass)
        {
            maTk = mtk;
            maLoaiTk = ml;
            tenTK = ten;
            tenDn = tenN;
            SDT = dd;
            Email = mail;
            Mk = pass;
        }
    }
}
