using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDotNet_TourDuLich.Form_Design.FormKhachs
{
    public partial class XemLich : Form
    {
        public delegate void TruyenKhach_XemLich(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass);
        public TruyenKhach_XemLich Gui_TaiKHoan;
        DuLieu dl = new DuLieu();
        public XemLich()
        {
            InitializeComponent();
            Gui_TaiKHoan = new TruyenKhach_XemLich(loadDuLieu);
        }
        account a = new account();
        private void loadDuLieu(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass)
        {
            a.maTk = mtk;
            a.maLoaiTk = ml;
            a.tenTK = ten;
            a.tenDn = tenN;
            a.SDT = dd;
            a.Email = mail;
            a.Mk = pass;
            lblTenKhach.Text = ten;
        }
        private void LoadLich()
        {
            DataTable layMaKhach = dl.LayMaKhach(a.maTk);
            ThuMuc_Class.KhachHang k = new ThuMuc_Class.KhachHang();
            foreach (DataRow dr in layMaKhach.Rows)
            {
                k.MaKhach = dr["MaKhach"].ToString();
                k.MaTK = dr["MaTK"].ToString();
                k.TenKhach = dr["TenKhach"].ToString();
                k.NgaySinh = dr["NgaySinh"].ToString();
                k.SDT = dr["SDT"].ToString();
            }

            DataTable dt = dl.LoadLichTourDaDat(k.MaKhach);
            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                lv_Lich.Items.Add(item);
            }

            lblTong.Text = dt.Rows.Count.ToString();
        }

        private void XemLich_Load(object sender, EventArgs e)
        {
            LoadLich();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TrangChu_KhachHang f = new Form_TrangChu_KhachHang();
            f.Gui_DuLieu(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
            f.Show();
        }
    }
}
