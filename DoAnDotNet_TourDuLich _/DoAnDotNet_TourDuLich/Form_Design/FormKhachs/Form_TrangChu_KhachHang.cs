using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DoAnDotNet_TourDuLich.Form_Design.FormKhachs;

namespace DoAnDotNet_TourDuLich
{
    public partial class Form_TrangChu_KhachHang : Form
    {
        public delegate void Truyen_Form_KhachHang(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass);
        public Truyen_Form_KhachHang Gui_DuLieu;

        public Form_TrangChu_KhachHang()
        {
            InitializeComponent();
            Gui_DuLieu = new Truyen_Form_KhachHang(loadDuLieu);
        }
        account a = new account();
        private void loadDuLieu(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass)
        {
            txtTenTK.Text = ten;
            txtTenDN.Text = tenN;
            txtSDT.Text = dd;
            txtEamil.Text = mail;
            txtMatKhau.Text = pass;
            a.maTk = mtk;
            a.maLoaiTk = ml;
            a.tenTK = ten;
            a.tenDn = tenN;
            a.SDT = dd;
            a.Email = mail;
            a.Mk = pass;
        }

        private void cb_hienMK_Click(object sender, EventArgs e)
        {
            if (cb_hienMK.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            if(panel_Toi.Visible==false)
            {
                panel_Toi.Visible = true;
            }
            else
            {
                panel_Toi.Visible = false;
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            panel_doiMatKhau.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            panel_doiMatKhau.Visible = false;
        }

        private void btn_xemTour_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Design.FormKhachs.DanhSachTour_kh f = new Form_Design.FormKhachs.DanhSachTour_kh();
            f.Gui_TaiKHoan(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
            f.ShowDialog();
        }

        private void btn_lich_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Design.FormKhachs.XemLich f = new Form_Design.FormKhachs.XemLich();
            f.Gui_TaiKHoan(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Design.FormKhachs.XemLich f = new Form_Design.FormKhachs.XemLich();
            f.Gui_TaiKHoan(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
            f.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon f = new HoaDon();
            f.Gui_TaiKHoan(a.maTk, a.maLoaiTk, a.tenTK, a.tenDn, a.SDT, a.Email, a.Mk);
            f.Show();
        }
    }
}
