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
    public partial class SanPhamTour : Form
    {
        public delegate void TruyenTour(string matour, string mahdv, string tentour, string diadiem, string chiphi, string anhbia, string loaitour);
        public TruyenTour GuiThongTinTour;
        public delegate void TruyenKhach_DSTour(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass);
        public TruyenKhach_DSTour Gui_TaiKHoan_DST;
        ThuMuc_Class.Tour t = new ThuMuc_Class.Tour();
        DuLieu dl = new DuLieu();
        public SanPhamTour()
        {
            InitializeComponent();
            GuiThongTinTour = new TruyenTour(NhanThongTinTour);
            Gui_TaiKHoan_DST = new TruyenKhach_DSTour(loadDuLieu);
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
        }
        private void NhanThongTinTour(string matour, string mahdv, string tentour, string diadiem, string chiphi, string anhbia, string loaitour)
        {
            t.MaTour = matour;
            t.MaHDV = mahdv;
            t.TenTour = tentour;
            t.DiaDiem = diadiem;
            t.ChiPhi = chiphi;
            t.AnhBia = anhbia;
            t.LoaiTour = loaitour;
            picture_item.Image = new Bitmap(Application.StartupPath + "\\HinhAnh\\" + anhbia);
            picture_item.SizeMode = PictureBoxSizeMode.Zoom;
            lblMaTour.Text =matour;
            lblTenTour.Text = tentour;
            lblGia.Text = chiphi + "VNĐ";

        }

        private void btnDatMua_Click(object sender, EventArgs e)
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

            int Excu = dl.LickMua(k.MaKhach, t,mtxtNgayDi.Text);
            if (Excu == 1)
            {
                DialogResult ThongBao = new DialogResult();
                ThongBao = MessageBox.Show("Đã Mua thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult ThongBao = new DialogResult();
                ThongBao = MessageBox.Show("Đã Mua thất bại!!!Kiểm tra lại thông tin ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lblmtour.Visible = true;
            lblttour.Visible = true;
            lblMaTour.Visible = true;
            lblTenTour.Visible = true;
            lblgia1.Visible = true;
            lblGia.Visible = true;
            btn_Dat.Visible = true;
            btnDatMua.Visible = false;
            lblNgayDi.Visible = false;
            mtxtNgayDi.Visible = false;
        }

        private void btn_Dat_Click(object sender, EventArgs e)
        {
            lblmtour.Visible = false;
            lblttour.Visible = false;
            lblMaTour.Visible = false;
            lblTenTour.Visible = false;
            lblgia1.Visible = false;
            lblGia.Visible = false;
            btn_Dat.Visible = false;


            btnDatMua.Visible = true;
            lblNgayDi.Visible = true;
            mtxtNgayDi.Visible = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {  
            ChuongTrinhTour f = new ChuongTrinhTour();
            f.GuiThongTinTour(t.MaTour, t.MaHDV, t.TenTour, t.DiaDiem, t.ChiPhi, t.AnhBia, t.LoaiTour);
            f.Gui_TaiKHoan_DST(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
            f.ShowDialog();
        }
    }
}
