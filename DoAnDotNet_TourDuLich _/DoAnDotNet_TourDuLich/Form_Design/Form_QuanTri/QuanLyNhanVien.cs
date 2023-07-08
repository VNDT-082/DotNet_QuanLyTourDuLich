using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDotNet_TourDuLich
{
    public partial class QuanLyNhanVien : Form
    {
        DuLieu dl = new DuLieu();
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_ListView_HDV()
        {
            lv_HDV.Items.Clear();
            DataTable dt = dl.HuongDanVien();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["MaHDV"].ToString();
                item.SubItems.Add(dr["TenHDV"].ToString());
                item.SubItems.Add(dr["MaTK"].ToString());
                item.SubItems.Add(dr["MaLoai"].ToString());
                item.SubItems.Add(dr["GioiTinh"].ToString());
                item.SubItems.Add(dr["SDT"].ToString());
                item.SubItems.Add(dr["NgayVaoLam"].ToString());
                item.SubItems.Add(dr["CCCD"].ToString());
                lv_HDV.Items.Add(item);
            }
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            Load_ListView_HDV();
        }
        private void SetCombobox_GioiTinh()
        {
            cbb_GioiTinh.Items.Clear();
            cbb_GioiTinh.Items.Add("Nam");
            cbb_GioiTinh.Items.Add("Nữ");
        }
        private void SetCombobox_LoaiHDV()
        {
            cbb_LoaiHuongDanVien.Items.Clear();
            DataTable dt = dl.LoaiHuongDanVien();
            foreach(DataRow dr in dt.Rows)
            {
                cbb_LoaiHuongDanVien.Items.Add(dr["TenLoai"].ToString());
            }
        }
        private void lv_HDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            HuongDanVien hdv = new HuongDanVien();
            if (lv_HDV.SelectedItems.Count > 0)
            {
                hdv.MaHDV = lv_HDV.SelectedItems[0].SubItems[0].Text;
                hdv.TenHDV = lv_HDV.SelectedItems[0].SubItems[1].Text;
                hdv.MaTK = lv_HDV.SelectedItems[0].SubItems[2].Text;
                hdv.MaLoai = lv_HDV.SelectedItems[0].SubItems[3].Text;
                hdv.GioiTinh = lv_HDV.SelectedItems[0].SubItems[4].Text;
                hdv.SDT = lv_HDV.SelectedItems[0].SubItems[5].Text; 
                hdv.NgayVaoLam = lv_HDV.SelectedItems[0].SubItems[6].Text;
                hdv.CCCD = lv_HDV.SelectedItems[0].SubItems[7].Text;
            }
            txtMaHDV.Text= hdv.MaHDV ;
            txtTenHDV.Text= hdv.TenHDV;
            txtMaTK.Text= hdv.MaTK ;           
            DataTable dt = dl.LoaiHuongDanVien();
            foreach(DataRow dr in dt.Rows)
            {
                if(hdv.MaLoai==dr["MaLoai"].ToString())
                {
                    cbb_LoaiHuongDanVien.Text = dr["TenLoai"].ToString();
                }
            }
            cbb_GioiTinh.Text = hdv.GioiTinh;
            txtSDT.Text= hdv.SDT ;
            txtNgayVaoLam.Text= hdv.NgayVaoLam ;
            txtCCCD.Text= hdv.CCCD;
        }

        private void cbb_GioiTinh_Click(object sender, EventArgs e)
        {
            SetCombobox_GioiTinh();
        }

        private void cbb_LoaiHuongDanVien_Click(object sender, EventArgs e)
        {
            SetCombobox_LoaiHDV();
        }
        private string maLoai;
        private string LayMaLoaiHDV(string index)
        {
            DataTable dt = dl.LoaiHuongDanVien();
            foreach (DataRow dr in dt.Rows)
            {
               if(index==dr["TenLoai"].ToString())
                {
                    maLoai = dr["MaLoai"].ToString();
                }
            }
            return maLoai;
        }

        //doi tuong su dung de luu du lieu sau khi them sua xoa
        string TenSuKien="";
        HuongDanVien hdv_ThemSuaXoa;
        private void btnThem_Click(object sender, EventArgs e)
        {
            hdv_ThemSuaXoa = new HuongDanVien();
            hdv_ThemSuaXoa.TenHDV = txtTenHDV.Text;
            hdv_ThemSuaXoa.MaTK = txtMaTK.Text;
            hdv_ThemSuaXoa.MaHDV = txtMaHDV.Text;
            hdv_ThemSuaXoa.MaLoai = LayMaLoaiHDV(cbb_LoaiHuongDanVien.Text);
            hdv_ThemSuaXoa.GioiTinh = cbb_GioiTinh.Text;
            hdv_ThemSuaXoa.SDT = txtSDT.Text;
            hdv_ThemSuaXoa.NgayVaoLam = txtNgayVaoLam.Text;
            hdv_ThemSuaXoa.CCCD = txtCCCD.Text;
            ListViewItem item = new ListViewItem();
            item.Text= hdv_ThemSuaXoa.MaHDV;
            item.SubItems.Add(hdv_ThemSuaXoa.TenHDV);
            item.SubItems.Add(hdv_ThemSuaXoa.MaTK);
            item.SubItems.Add(hdv_ThemSuaXoa.MaLoai);
            item.SubItems.Add(hdv_ThemSuaXoa.GioiTinh);
            item.SubItems.Add(hdv_ThemSuaXoa.SDT);
            item.SubItems.Add(hdv_ThemSuaXoa.NgayVaoLam);
            item.SubItems.Add(hdv_ThemSuaXoa.CCCD);
            lv_HDV.Items.Add(item);
            TenSuKien = "Them";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            hdv_ThemSuaXoa = new HuongDanVien();
            hdv_ThemSuaXoa.TenHDV = txtTenHDV.Text;
            hdv_ThemSuaXoa.MaTK = txtMaTK.Text;
            hdv_ThemSuaXoa.MaHDV = txtMaHDV.Text;
            hdv_ThemSuaXoa.MaLoai = LayMaLoaiHDV(cbb_LoaiHuongDanVien.Text);
            hdv_ThemSuaXoa.GioiTinh = cbb_GioiTinh.Text;
            hdv_ThemSuaXoa.SDT = txtSDT.Text;
            hdv_ThemSuaXoa.NgayVaoLam = txtNgayVaoLam.Text;
            hdv_ThemSuaXoa.CCCD = txtCCCD.Text;

            if (lv_HDV.FocusedItem!=null && lv_HDV.FocusedItem.Index >= 0)
            {
                ListViewItem item = lv_HDV.FocusedItem;
                item.Text = hdv_ThemSuaXoa.MaHDV;
                item.SubItems[1].Text=hdv_ThemSuaXoa.TenHDV;
                item.SubItems[2].Text=hdv_ThemSuaXoa.MaTK;
                item.SubItems[3].Text=hdv_ThemSuaXoa.MaLoai;
                item.SubItems[4].Text=hdv_ThemSuaXoa.GioiTinh;
                item.SubItems[5].Text=hdv_ThemSuaXoa.SDT;
                item.SubItems[6].Text=hdv_ThemSuaXoa.NgayVaoLam;
                item.SubItems[7].Text= hdv_ThemSuaXoa.CCCD;
            }
            TenSuKien = "Sua";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            hdv_ThemSuaXoa = new HuongDanVien();
            hdv_ThemSuaXoa.TenHDV = txtTenHDV.Text;
            hdv_ThemSuaXoa.MaTK = txtMaTK.Text;
            hdv_ThemSuaXoa.MaHDV = txtMaHDV.Text;
            hdv_ThemSuaXoa.MaLoai = LayMaLoaiHDV(cbb_LoaiHuongDanVien.Text);
            hdv_ThemSuaXoa.GioiTinh = cbb_GioiTinh.Text;
            hdv_ThemSuaXoa.SDT = txtSDT.Text;
            hdv_ThemSuaXoa.NgayVaoLam = txtNgayVaoLam.Text;
            hdv_ThemSuaXoa.CCCD = txtCCCD.Text;
            foreach (ListViewItem l in lv_HDV.SelectedItems)
            {
                l.Remove();
            }
            TenSuKien = "Xoa";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             if(TenSuKien=="Them")
            {
                int Excu = 0;
                Excu = dl.ThemHuongDanVien(hdv_ThemSuaXoa);
                if(Excu==1)
                {
                    DialogResult ThongBao = new DialogResult();
                    ThongBao = MessageBox.Show("Đã Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult ThongBao = new DialogResult();
                    ThongBao = MessageBox.Show("Đã Thêm thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TenSuKien = "";
                hdv_ThemSuaXoa = new HuongDanVien();
            }
             else if(TenSuKien=="Sua")
            {
                int Excu = 0;
                Excu = dl.SuaHuongDanVien(hdv_ThemSuaXoa);
                if (Excu == 1)
                {
                    DialogResult ThongBao = new DialogResult();
                    ThongBao = MessageBox.Show("Đã sữa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult ThongBao = new DialogResult();
                    ThongBao = MessageBox.Show("Đã sữa thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TenSuKien = "";
                hdv_ThemSuaXoa = new HuongDanVien();
            }
            else if(TenSuKien=="Xoa")
            {
                int Excu = 0;
                Excu = dl.XoaHuongDanVien(hdv_ThemSuaXoa);
                if (Excu == 1)
                {
                    DialogResult ThongBao = new DialogResult();
                    ThongBao = MessageBox.Show("Đã xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult ThongBao = new DialogResult();
                    ThongBao = MessageBox.Show("Đã xóa thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TenSuKien = "";
                hdv_ThemSuaXoa = new HuongDanVien();
            }
            else
            {
                DialogResult ThongBao =new DialogResult();
                ThongBao = MessageBox.Show("Lưu thất bại!!!", "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Load_ListView_HDV();
        }
    }
}
