using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DoAnDotNet_TourDuLich.ThuMuc_Class;

namespace DoAnDotNet_TourDuLich.Form_Design
{
    public partial class QuanLyTour : Form
    {
        DuLieu_QuanTri dl = new DuLieu_QuanTri();
        List<Tour> ds_Tour = new List<Tour>();
        List<Tour> ds_Tour_Add = new List<Tour>();
        List<Tour> ds_Tour_Update = new List<Tour>();
        List<string> ds_Tour_delete = new List<string>();
        List<string> ds_MaTour = new List<string>();

        public QuanLyTour()
        {
            InitializeComponent();
        }

        private void Load_HuongDanVien()
        {
            DataSet ds_HDV = dl.Load_HuongDanVien_Name_id();
            cbb_TenHuongdanVien.DataSource = ds_HDV.Tables["HuongDanVien"];
            cbb_TenHuongdanVien.DisplayMember = "TenHDV";
            cbb_TenHuongdanVien.ValueMember = "MaHDV";
        }
        private void Load_LoaiTour()
        {
            DataSet ds_LoaiTour = dl.Load_LoaiTour();
            cbb_LoaiTour.DataSource = ds_LoaiTour.Tables["LoaiTour"];
            cbb_LoaiTour.DisplayMember = "TenLoaiTour";
            cbb_LoaiTour.ValueMember = "MaLoaiTour";
        }
        private void KhoiTaoImagesList()
        {
            image_list.Images.Clear();
            image_list = new ImageList() { ImageSize = new Size(180, 120) };
        }
        private void Load_Tour()
        {
            DataTable tb_Tour = dl.Load_Tour();

            if (tb_Tour.Rows.Count > 0)
            {
                foreach (DataRow dr in tb_Tour.Rows)
                {
                    Tour t = new Tour();
                    t.MaTour = dr["MaTour"].ToString();
                    t.MaHDV = dr["Huo_MaHDV"].ToString();
                    t.TenTour = dr["TenTour"].ToString();
                    t.DiaDiem = dr["DiaDiem"].ToString();
                    t.ChiPhi = dr["ChiPhi"].ToString();
                    t.AnhBia = dr["AnhBia"].ToString();
                    t.LoaiTour = dr["MaLoaiTour"].ToString();
                    ds_Tour.Add(t);
                    ds_MaTour.Add(t.MaTour);
                }
                foreach (Tour t in ds_Tour)
                {
                    image_list.Images.Add(new Bitmap(Application.StartupPath + "\\HinhAnh\\" + t.AnhBia));
                }

            }
        }
        private void Load_ListView()
        {
            lv_Tour.Items.Clear();
            int dem = 0;
            lv_Tour.SmallImageList = image_list;

            foreach (Tour t in ds_Tour)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = dem;
                item.SubItems.Add(t.MaTour);
                item.SubItems.Add(t.MaHDV);
                item.SubItems.Add(t.TenTour);
                item.SubItems.Add(t.DiaDiem);
                item.SubItems.Add(t.ChiPhi);
                item.SubItems.Add(t.AnhBia);
                item.SubItems.Add(t.LoaiTour);
                lv_Tour.Items.Add(item);
                dem++;
            }
        }
        private void QuanLyTour_Load(object sender, EventArgs e)
        {
            KhoiTaoImagesList();
            Load_LoaiTour();
            Load_HuongDanVien();
            Load_Tour();
            Load_ListView();
        }

        private void lv_Tour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Tour.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem item = lv_Tour.SelectedItems[0];
                txtMaTour.Text = item.SubItems[1].Text;
                cbb_TenHuongdanVien.SelectedValue = item.SubItems[2].Text;
                txtTenTour.Text = item.SubItems[3].Text;
                txtDiaDiem.Text = item.SubItems[4].Text;
                txtChiPhi.Text = item.SubItems[5].Text;
                txtHinhAnh.Text = item.SubItems[6].Text;
                cbb_LoaiTour.SelectedValue = item.SubItems[7].Text;
                picture_item.Image = new Bitmap(Application.StartupPath + "\\HinhAnh\\" + item.SubItems[6].Text);

            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture_item.Image = new Bitmap(openFileDialog1.FileName);
                string fileName = openFileDialog1.FileName;
                txtHinhAnh.Text = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            }
        }
        private bool UpLoadFile(OpenFileDialog Upload)
        {
            try
            {
                string path = Application.StartupPath + "\\HinhAnh\\";
                string path_ = "..\\....\\..\\HinhAnh\\";
                path = path + txtHinhAnh.Text;
                path_ = path_ + txtHinhAnh.Text;
                if (!File.Exists(path_))
                    File.Copy(Upload.FileName, path_);
                else
                {
                    MessageBox.Show("Tập tin đã tồn tại trong debug\n " + path, "Thông báo");
                    return false;
                }
                if (!File.Exists(path))
                    File.Copy(Upload.FileName, path);
                else
                {
                    MessageBox.Show("Tập tin đã tồn tại trong resource\n" + path, "Thông báo");
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool DeleteFile(string HinhAnh)
        {
            try
            {
                string path = Application.StartupPath + "\\HinhAnh\\";
                string path_ = "..\\....\\..\\HinhAnh\\";
                path = path + txtHinhAnh.Text;
                path_ = path_ + txtHinhAnh.Text;
                if (File.Exists(path_))
                    File.Delete(path_);
                else
                {
                    MessageBox.Show("Tập tin đã tồn tại trong debug\n " + path_, "Thông báo");
                    return false;
                }
                if (!File.Exists(path))
                    File.Delete(path);
                else
                {
                    MessageBox.Show("Tập tin đã tồn tại trong resource\n" + path, "Thông báo");
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        private void AddTour()
        {
            Tour t = new Tour();
            t.MaTour = txtMaTour.Text;
            t.DiaDiem = txtDiaDiem.Text;
            t.ChiPhi = txtChiPhi.Text;
            t.TenTour = txtTenTour.Text;
            if (cbb_TenHuongdanVien.SelectedIndex >= 0)
            {
                t.MaHDV = (string)cbb_TenHuongdanVien.SelectedValue;
            }
            if (cbb_LoaiTour.SelectedIndex >= 0)
            {
                t.LoaiTour = (string)cbb_LoaiTour.SelectedValue.ToString();
            }
            t.AnhBia = txtHinhAnh.Text;
            if (!ds_MaTour.Contains(t.MaTour))
            {
                ds_Tour_Add.Add(t);
                ds_MaTour.Add(t.MaTour);
            }
            else
            {
                MessageBox.Show("Tour đã tồn tại ");
                return;
            }
            if (txtHinhAnh.Text != null || txtHinhAnh.Text != "" && picture_item.Image != null)
            {
                if (UpLoadFile(openFileDialog1))
                {
                    MessageBox.Show("Upload:" + t.AnhBia + "Thành công");
                }
                else
                {
                    MessageBox.Show("Upload:" + t.AnhBia + " That bai");
                }
            }
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddTour();
            foreach(Tour t in ds_Tour_Add)
            {
                if(ds_Tour.Contains(t))
                {
                    ds_Tour.Add(t);
                }
            }
            Load_ListView();
            
        }

        private void UpdateTour()
        {
            Tour t = new Tour();
            t.MaTour = txtMaTour.Text;
            t.DiaDiem = txtDiaDiem.Text;
            t.ChiPhi = txtChiPhi.Text;
            t.TenTour = txtTenTour.Text;
            if (cbb_TenHuongdanVien.SelectedIndex >= 0)
            {
                t.MaHDV = (string)cbb_TenHuongdanVien.SelectedValue;
            }
            if (cbb_LoaiTour.SelectedIndex >= 0)
            {
                t.LoaiTour = (string)cbb_LoaiTour.SelectedValue.ToString();
            }
            t.AnhBia = txtHinhAnh.Text;
            if (ds_MaTour.Contains(t.MaTour))
            {
                ds_Tour_Update.Add(t);
                ds_MaTour.Add(t.MaTour);
            }
            else
            {
                MessageBox.Show("Tour chưa tồn tại, không thể sửa ");
                return;
            }
            if (txtHinhAnh.Text != null || txtHinhAnh.Text != "" && picture_item.Image != null)
            {
                if (UpLoadFile(openFileDialog1))
                {
                    MessageBox.Show("Upload Thành công");
                }
                else
                {
                    MessageBox.Show("Upload That bai");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateTour();
            foreach(Tour t_current in ds_Tour)
            {
                foreach(Tour t_apter in ds_Tour_Update)
                {
                    if(t_current.MaTour==t_apter.MaTour)
                    {
                        t_current.MaHDV = t_apter.MaHDV;
                        t_current.TenTour = t_apter.TenTour;
                        t_current.DiaDiem = t_apter.DiaDiem;
                        t_current.ChiPhi = t_apter.ChiPhi;
                        t_current.AnhBia = t_apter.AnhBia;
                        t_current.LoaiTour = t_apter.LoaiTour;
                    }
                }
            }
            Load_ListView();
        }

        private void Delete_Tour()
        {
            string MaTour = txtMaTour.Text;
            if (ds_MaTour.Contains(MaTour))
            {
                ds_Tour_delete.Add(MaTour);
            }
            else
            {
                MessageBox.Show("Tour chưa tồn tại, không thể xóa");
                return;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Delete_Tour();
            for(int i=0;i<ds_Tour.Count;i++)
            {
                foreach(string matour in ds_Tour_delete)
                {
                    if(ds_Tour[i].MaTour==matour)
                    {
                        ds_Tour.Remove(ds_Tour[i]);
                        image_list.Images.RemoveAt(i);
                        break;
                    }
                }
            }
            Load_ListView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(ds_Tour_Add.Count>0)
            {
                int kq = 0;
                foreach(Tour item in ds_Tour_Add)
                {
                    kq = dl.AddTour(item);
                    if(kq==0)
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                if (kq == 1)
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            if(ds_Tour_delete.Count>0)
            {
                int kq = 0;
                foreach(string item in ds_Tour_delete)
                {
                    kq = dl.RemoveTour(item);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                if (kq == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
            }
            if(ds_Tour_Update.Count>0)
            {
                int kq = 0;
                foreach (Tour item in ds_Tour_Update)
                {
                     kq= dl.UpDateTour(item);
                    if (kq == 0)
                    {
                        
                    }
                }
                if(kq==1)
                {
                    MessageBox.Show("Sửa thành công");
                }
            }
        }

        private void btn_QuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
