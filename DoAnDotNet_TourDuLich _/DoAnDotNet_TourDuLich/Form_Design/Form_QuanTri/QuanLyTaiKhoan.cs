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
    public partial class QuanLyTaiKhoan : Form
    {
        ThuMuc_Class.DuLieu_QuanTri dl = new ThuMuc_Class.DuLieu_QuanTri();
        DataSet ds;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        private void LoadCbb_LoaiAccounts()
        {
            string strSelect = "select *from LoaiAccounts";
            DataSet ds1 = dl.Load_LoaiAccounts(strSelect, "LoaiAccounts");
            cbb_LoaiAccounts.DataSource = ds1.Tables["LoaiAccounts"];
            cbb_LoaiAccounts.ValueMember = "MaLoaiAcc";
            cbb_LoaiAccounts.DisplayMember = "TenLoaiAcc";
        }
        private void LoadLv_Account()
        {
            string strSelect = "select *from Accounts";
            ds = dl.Load_DataGridView(strSelect, "Accounts");
            dgv_Accounts.DataSource = ds.Tables["Accounts"];
            DataBingding(ds.Tables["Accounts"]);
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["Accounts"].Columns[0];
            ds.Tables["Accounts"].PrimaryKey = key;

        }
        private void lv_HDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadCbb_LoaiAccounts();
            LoadLv_Account();
            dgv_Accounts.AllowUserToAddRows = false;
            dgv_Accounts.ReadOnly = true;
            foreach (Control item in pn_Main.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(MaskedTextBox) || item.GetType() == typeof(ComboBox))
                {
                    item.Enabled = false;
                }
            }
            btnLuu.Enabled = btnSua.Enabled= btnXoa.Enabled = false;

            
        }
        private void DataBingding(DataTable dt)
        {
            txtEmail.DataBindings.Clear();
            txtMaTK.DataBindings.Clear();
            cbb_LoaiAccounts.DataBindings.Clear();
            txtMK.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtTenDN.DataBindings.Clear();
            txtTenTk.DataBindings.Clear();

            cbb_LoaiAccounts.DataBindings.Add("Text", dt, "MaLoaiAcc");
            txtMaTK.DataBindings.Add("Text", dt, "MaTK");
            txtTenTk.DataBindings.Add("Text", dt, "TenTK");
            txtTenDN.DataBindings.Add("Text", dt, "TenDangNhap");
            txtSDT.DataBindings.Add("Text", dt, "SDT");
            txtEmail.DataBindings.Add("Text", dt, "Email");
            txtMK.DataBindings.Add("Text", dt, "MatKhau");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            dgv_Accounts.AllowUserToAddRows = true;
            dgv_Accounts.ReadOnly = false;
            for (int i= 0;i < dgv_Accounts.Rows.Count-1;i++)
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
            for(int i=0; i<dgv_Accounts.Rows.Count-1;i++)
            {
                dgv_Accounts.Rows[i].ReadOnly = false;
            }
            dgv_Accounts.Columns[0].ReadOnly = true;
            dgv_Accounts.AllowUserToAddRows = false;
            txtMK.Enabled = txtSDT.Enabled = txtTenDN.Enabled = txtTenTk.Enabled = txtEmail.Enabled = cbb_LoaiAccounts.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strSelect = "select *from Accounts";
                dl.LuuDataGridView(strSelect, ds, "Accounts");
                DataBingding(ds.Tables["Accounts"]);
                MessageBox.Show("Xử lý thành công!!!");
                btnThem.Enabled = btnXoa.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Xử lý thất bại!!!");
            }
        }

        private void dgv_Accounts_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Xác nhận muốn xóa!", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(tb==DialogResult.Yes)
            {
                DataTable ds_acc = new DataTable();
                string strSelect = "select * from Accounts";
                dl.XoaDuLieu_Dgv(ds, "Accounts",txtMaTK.Text, strSelect);

            }
            btnLuu.Enabled = true;
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
