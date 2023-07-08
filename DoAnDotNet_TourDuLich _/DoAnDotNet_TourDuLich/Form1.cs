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
    public partial class Form1 : Form
    {
        DuLieu dl = new DuLieu();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            txtTenDN.Focus();
        }
        private void cb_HienMK_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_HienMK.Checked==true)
            {
                txtMatKhau.PasswordChar='\0';
            }
            else{
                txtMatKhau.PasswordChar='*';
            }
        }
        private bool kiemTraDuLieu(string str1 ,string str2)
        {
            if (str1 == str2)
                return true;
            else
                return false;
        }
        int flag = 0;
        string mtk;
        string maLoai;
        string tenTk;
        string tenDn;
        string sdt;
        string email;
        string mk;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DataTable tb_account = dl.AcCounts();
            foreach(DataRow dr in tb_account.Rows)
            {
                if(kiemTraDuLieu(txtTenDN.Text,dr["TenDangNhap"].ToString())==true)
                {
                    if(kiemTraDuLieu(txtMatKhau.Text , dr["MatKhau"].ToString())==true)
                    {
                        flag = 1;
                        mtk = dr["MaTK"].ToString();
                        maLoai = dr["MaLoaiAcc"].ToString();
                        tenTk = dr["TenTK"].ToString();
                        tenDn = dr["TenDangNhap"].ToString();
                        sdt = dr["SDT"].ToString();
                        email = dr["Email"].ToString();
                        mk = dr["MatKhau"].ToString();
                    }
                }
            }
            if (flag == 1)
            {
                if(maLoai=="1")
                {
                    Form_TrangChu_QTV f = new Form_TrangChu_QTV();
                    f.Gui_DuLieu(mtk, maLoai, tenTk, tenDn, sdt, email, mk);
                    this.Hide();
                    f.Show();
                }
                else if(maLoai=="2")
                {
                    Form_TrangChu_KhachHang f_kh = new Form_TrangChu_KhachHang();
                    f_kh.Gui_DuLieu(mtk, maLoai, tenTk, tenDn, sdt, email, mk);
                    this.Hide();
                    f_kh.Show();
                }
               
            }
            else
            {
                lblTenDangNhapErr.Text = "Tên đăng nhập hoặc mật khẩu sai!!!";
                lblMatKhauErr.Text = "Tên đăng nhập hoặc mật khẩu sai!!!";
            }
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy f = new frmDangKy();
            f.Show();
        }
    }
}
