using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDotNet_TourDuLich.Form_Design.Form_QuanTri
{
    public partial class QuanLyKhachHang : Form
    {
        ThuMuc_Class.DuLieu_QuanTri dl = new ThuMuc_Class.DuLieu_QuanTri();
        DataSet ds;
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        private void DataBingding(DataTable dt)
        {
            txtMaKhach.DataBindings.Clear();
            txtMaTK.DataBindings.Clear();
            txtngaySinh.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtTenKhach.DataBindings.Clear();

            txtMaTK.DataBindings.Add("Text", dt, "MaTK");
            txtTenKhach.DataBindings.Add("Text", dt, "TenKhach");
            txtSDT.DataBindings.Add("Text", dt, "SDT");
            txtMaKhach.DataBindings.Add("Text", dt, "MaKhach");
            txtngaySinh.DataBindings.Add("Text", dt, "NgaySinh");
        }

        private void LoadLv_KhachHang()
        {
            string strSelect = "select *from KhachHang";
            ds = dl.Load_DataGridView(strSelect,"KhachHang");
            dgv_Accounts.DataSource = ds.Tables["KhachHang"];
            DataBingding(ds.Tables["KhachHang"]);
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["KhachHang"].Columns[0];
            ds.Tables["KhachHang"].PrimaryKey = key;

        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadLv_KhachHang();
            dgv_Accounts.AllowUserToAddRows = false;
            dgv_Accounts.ReadOnly = true;
            foreach (Control item in pn_Main.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(MaskedTextBox) || item.GetType() == typeof(ComboBox))
                {
                    item.Enabled = false;
                }
            }
            btnLuu.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dgv_Accounts.AllowUserToAddRows = true;
            dgv_Accounts.ReadOnly = false;
            for (int i = 0; i < dgv_Accounts.Rows.Count - 1; i++)
            {
                dgv_Accounts.Rows[i].ReadOnly = true;
            }
            dgv_Accounts.FirstDisplayedScrollingRowIndex = dgv_Accounts.Rows.Count - 1;
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dgv_Accounts.ReadOnly = false;
            for (int i = 0; i < dgv_Accounts.Rows.Count - 1; i++)
            {
                dgv_Accounts.Rows[i].ReadOnly = false;
            }
            dgv_Accounts.Columns[0].ReadOnly = true;
            dgv_Accounts.AllowUserToAddRows = false;
            txtSDT.Enabled = txtMaKhach.Enabled = txtTenKhach.Enabled = txtngaySinh.Enabled = txtMaTK.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Xác nhận muốn xóa!", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
            {
                DataTable ds_acc = new DataTable();
                string strSelect = "select *from KhachHang";
                dl.XoaDuLieu_Dgv(ds, "KhachHang", txtMaKhach.Text, strSelect);

            }
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strSelect = "select *from KhachHang";
                dl.LuuDataGridView(strSelect, ds, "KhachHang");
                DataBingding(ds.Tables["KhachHang"]);
                MessageBox.Show("Xử lý thành công!!!");
                btnThem.Enabled = btnXoa.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Xử lý thất bại!!!");
            }
        }
    }
}
