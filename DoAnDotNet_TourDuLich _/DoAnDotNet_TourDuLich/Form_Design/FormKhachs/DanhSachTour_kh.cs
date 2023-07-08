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
    public partial class DanhSachTour_kh : Form
    {
        public delegate void TruyenKhach(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass);
        public TruyenKhach Gui_TaiKHoan;

        DuLieu dl = new DuLieu();
        public DanhSachTour_kh()
        {
            InitializeComponent();
            Gui_TaiKHoan = new TruyenKhach(loadDuLieu);
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
            a.Mk= pass;
        }
        //public void GuiDuLieu(string matour, string macttour, string mahdv, string tentour, string diadiem, string chiphi, string anhbia)
        //{
        //    Form_Design.FormKhachs.SanPhamTour f = new Form_Design.FormKhachs.SanPhamTour();
        //    f.GuiThongTinTour(matour, macttour, mahdv, tentour, diadiem, chiphi, anhbia);
        //}
        private void Load_DsTour()
        {
            DataTable ds_tour = dl.Ds_Tour();
            foreach (DataRow dr in ds_tour.Rows)
            {
                string matour = dr["MaTour"].ToString();
                //string macttour = dr["MaCTTour"].ToString();
                string mahdv = dr["Huo_MaHDV"].ToString();
                string tentour = dr["TenTour"].ToString();
                string diadiem = dr["DiaDiem"].ToString();
                string chiphi = dr["ChiPhi"].ToString();
                string anhbia = dr["AnhBia"].ToString();
                string loaitour = dr["MaLoaiTour"].ToString();
                Form_Design.FormKhachs.SanPhamTour form_item = new Form_Design.FormKhachs.SanPhamTour();
                form_item.GuiThongTinTour(matour, mahdv, tentour, diadiem, chiphi, anhbia,loaitour);
                form_item.Gui_TaiKHoan_DST(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
                Panel pn = new Panel();
                pn.Width = 400;
                pn.Height = 450;
                openForm1(form_item, pn);
                //openForm1(new Form_Design.FormKhachs.SanPhamTour(),pn);
                tb_dsTour.Controls.Add(pn);
            }
        }
        private void Load_DsTour(string strSelect)
        {
            tb_dsTour.Controls.Clear();
            DataTable ds_tour = dl.Ds_Tour(strSelect);
            foreach (DataRow dr in ds_tour.Rows)
            {
                string matour = dr["MaTour"].ToString();
                //string macttour = dr["MaCTTour"].ToString();
                string mahdv = dr["Huo_MaHDV"].ToString();
                string tentour = dr["TenTour"].ToString();
                string diadiem = dr["DiaDiem"].ToString();
                string chiphi = dr["ChiPhi"].ToString();
                string anhbia = dr["AnhBia"].ToString();
                string loaitour = dr["MaLoaiTour"].ToString();
                Form_Design.FormKhachs.SanPhamTour form_item = new Form_Design.FormKhachs.SanPhamTour();
                form_item.GuiThongTinTour(matour, mahdv, tentour, diadiem, chiphi, anhbia, loaitour);
                form_item.Gui_TaiKHoan_DST(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
                Panel pn = new Panel();
                pn.Width = 400;
                pn.Height = 450;
                openForm1(form_item, pn);
                //openForm1(new Form_Design.FormKhachs.SanPhamTour(),pn);
                tb_dsTour.Controls.Add(pn);
            }
        }
        private void openForm1(Form f_Opsion , Panel pn)
        {
            f_Opsion.TopLevel = false;
            f_Opsion.FormBorderStyle = FormBorderStyle.None;
            f_Opsion.Dock = DockStyle.Fill;

            pn.Controls.Add(f_Opsion);
            pn.Tag = f_Opsion;
            f_Opsion.BringToFront();
            f_Opsion.Show();
        }

        private void DanhSachTour_kh_Load(object sender, EventArgs e)
        {
            lblTenKhach.Text = a.tenTK;
            Load_DsTour();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_TrangChu_KhachHang f = new Form_TrangChu_KhachHang();
            f.Gui_DuLieu(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
            f.Show();
        }

        private void LoadCBBLoaiTour()
        {
            DataSet ds = dl.LoaiTour();
            if (ds != null)
            {
                cbb_LoaiTour.DataSource = ds.Tables["LoaiTour"];
                cbb_LoaiTour.DisplayMember="TenLoaiTour";
                cbb_LoaiTour.ValueMember = "MaLoaiTour";

            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string strSelect = "select*from Tour where MaLoaiTour = " + cbb_LoaiTour.SelectedValue;
            Load_DsTour(strSelect);

        }

        private void gr_loc_Enter(object sender, EventArgs e)
        {
            LoadCBBLoaiTour();
        }
    }
}
