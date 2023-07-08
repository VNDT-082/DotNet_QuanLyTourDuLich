using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnDotNet_TourDuLich.ThuMuc_Class;

namespace DoAnDotNet_TourDuLich.Form_Design.FormKhachs
{
    public partial class HoaDon : Form
    {
        public delegate void TruyenKhach_XemLich(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass);
        public TruyenKhach_XemLich Gui_TaiKHoan;
        DuLieu dl = new DuLieu();
        public HoaDon()
        {
            InitializeComponent();
            Gui_TaiKHoan = new TruyenKhach_XemLich(loadDuLieu);
        }
        account a = new account();
        KhachHang k = new KhachHang();
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
        void LoadHoadDon()
        {
            DataTable layMaKhach = dl.LayMaKhach(a.maTk);
           
            foreach (DataRow dr in layMaKhach.Rows)
            {
                k.MaKhach = dr["MaKhach"].ToString();
                k.MaTK = dr["MaTK"].ToString();
                k.TenKhach = dr["TenKhach"].ToString();
                k.NgaySinh = dr["NgaySinh"].ToString();
                k.SDT = dr["SDT"].ToString();
            }
            DataTable tb = dl.HoaHon(k.MaKhach);
            lvHoaDon.Items.Clear();
            if(tb.Rows.Count>0 &&tb!=null)
            {
                foreach (DataRow dr in tb.Rows)
                {
                    ListViewItem item = new ListViewItem(dr[0].ToString());
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());
                    item.SubItems.Add(dr[4].ToString());
                    item.SubItems.Add(dr[5].ToString());
                    item.SubItems.Add(dr[6].ToString());
                    int x = int.Parse(dr[7].ToString());
                    if (x == 0)
                    {
                        item.SubItems.Add("Chưa thanh toán");
                    }
                    else
                    {
                        item.SubItems.Add("Đã thanh toán");
                    }
                    lvHoaDon.Items.Add(item);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TrangChu_KhachHang f = new Form_TrangChu_KhachHang();
            f.Gui_DuLieu(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
            f.Show();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadHoadDon();
        }

        private void lvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvHoaDon.SelectedItems.Count>0)
            {
               
                txtMatour.Text = lvHoaDon.SelectedItems[0].SubItems[0].Text;
                DateTime d=DateTime.Parse(lvHoaDon.SelectedItems[0].SubItems[4].Text);
                string ngaydat = string.Format("{0:dd/MM/yyyy HH:mm:ss}",d) ;
                txtngaydat.Text = ngaydat;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string ngaydat = txtngaydat.Text;
            string matour = txtMatour.Text;
            string makhach = k.MaKhach;
            DialogResult tb = new DialogResult();
            tb = MessageBox.Show("bạn muốn hủy tour?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tb == DialogResult.Yes)
            {
                int kq = dl.HuyDatTour(makhach, matour, ngaydat);
                if (kq==1)
                {
                    LoadHoadDon();
                    MessageBox.Show("Hủy thành công");
                }
                else
                {
                    MessageBox.Show("Hủy thất bại");
                }
            }
            
        }
    }
}
