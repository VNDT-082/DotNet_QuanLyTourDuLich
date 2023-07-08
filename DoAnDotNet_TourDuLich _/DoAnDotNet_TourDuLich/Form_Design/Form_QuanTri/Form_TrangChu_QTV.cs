using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnDotNet_TourDuLich.Form_Design.Form_QuanTri;
using DoAnDotNet_TourDuLich.Form_Design.FormKhachs;

namespace DoAnDotNet_TourDuLich
{
    public partial class Form_TrangChu_QTV : Form
    {
        private account adm = new account();

        public delegate void Truyen_Form_TrangChu(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass);
        public Truyen_Form_TrangChu Gui_DuLieu;

        public Form_TrangChu_QTV()
        {
            InitializeComponent();
            Gui_DuLieu = new Truyen_Form_TrangChu(loadDuLieu);
        }

        private void  loadDuLieu(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass)
        {
            lblTenTk.Text = ten;
            lblTenDN.Text = tenN;
            lblSDT.Text = dd;
            lblmail.Text = mail;
        }
        private void SetButtonDefault()
        {
            foreach (Control item in pn_button.Controls)
            {
                if (item is Button)
                {
                    item.ForeColor = System.Drawing.Color.White;
                    item.BackColor = System.Drawing.Color.Navy;
                }
            }
        }
        private void Form_TrangChu_QTV_Load(object sender, EventArgs e)
        {
            this.Width=1320;
        }

        private Form FormOpsion;
        private void openForm(Form f_Opsion)
        {
            if (FormOpsion != null)
            {
                FormOpsion.Close();
            }
            FormOpsion = f_Opsion;
            f_Opsion.TopLevel = false;
            f_Opsion.FormBorderStyle = FormBorderStyle.None;
            f_Opsion.Dock = DockStyle.Fill;
            panel_body.Controls.Add(f_Opsion);
            panel_body.Tag = f_Opsion;
            f_Opsion.BringToFront();
            f_Opsion.Show();
        }

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnQuanLyNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnQuanLyNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            openForm(new QuanLyNhanVien());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnQLTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnQLTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            openForm(new Form_Design.Form_QuanTri.QuanLyTaiKhoan());
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnQLKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnQLKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            openForm(new Form_Design.Form_QuanTri.QuanLyKhachHang());
        }

        private void btnQuaLyTour_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnQuaLyTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnQuaLyTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            openForm(new Form_Design.QuanLyTour());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pn_button.Visible = false;
            pnThongTin.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pn_button.Visible = true;
            pnThongTin.Visible = false;
        }

        private void btnQLVeMayBay_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnQLVeMayBay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnQLVeMayBay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            openForm(new ChiTietChuongTrinhTour());

        }

        private void btnQLDatTour_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnQLDatTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnQLDatTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            openForm(new Report());
        }
    }
}
