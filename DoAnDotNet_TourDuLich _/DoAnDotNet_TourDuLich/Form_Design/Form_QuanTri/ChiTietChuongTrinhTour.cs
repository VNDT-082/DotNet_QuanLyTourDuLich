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

using DoAnDotNet_TourDuLich.Form_Design;
using DoAnDotNet_TourDuLich.Form_Design.FormKhachs;
using DoAnDotNet_TourDuLich.Form_Design.Form_QuanTri;
using DoAnDotNet_TourDuLich.ThuMuc_Class;

namespace DoAnDotNet_TourDuLich.Form_Design.Form_QuanTri
{
    public partial class ChiTietChuongTrinhTour : Form
    {
        DuLieu_QuanTri dl = new DuLieu_QuanTri();
        _ChiTietChuongTrinhTour ct = new _ChiTietChuongTrinhTour();
        public ChiTietChuongTrinhTour()
        {
            InitializeComponent();
        }
        private void Load_CbbCCTour()
        {
            cbbChuongTrinhTour.Items.Clear();
            DataSet cbb_Tour = dl.Load_CbbTour();
            if(cbbChuongTrinhTour!=null)
            {
                cbbChuongTrinhTour.DataSource = cbb_Tour.Tables["Tour"];
                cbbChuongTrinhTour.DisplayMember = "TenTour";
                cbbChuongTrinhTour.ValueMember = "MaTour";
            }
            else
            {
                return;
            }
        }
        private void Load_ChiTietChuongTrinhThuN(int id)
        {
            
            DataTable chiTiet = dl.Load_ChiTietChuongTrinh(id);
            if(chiTiet!=null)
            {
                foreach(DataRow dr in chiTiet.Rows)
                {
                    ct.Id = int.Parse(dr["id"].ToString());
                    ct.MaCTTour = dr["MaCTTour"].ToString();
                    ct.Ngay = int.Parse(dr["Ngay"].ToString());
                    ct.GioDi = dr["GioDi"].ToString();
                    ct.GioDen = dr["GioDen"].ToString();
                    ct.DiemKhoiHanh = dr["DiemKhoiHanh"].ToString();
                    ct.DiemDen = dr["DiemDen"].ToString();
                    ct.MoTa = dr["MoTa"].ToString();
                    ct.HinhAnh = dr["HinhAnh"].ToString();

                }
            }
            else
            {
                return;
            }
        }
        private void Show_ChiTietChuongTrinhThuN()
        {
            txtTenAnh.Text = "";
            txtGioiDi.Text = "";
            txtGioDen.Text = "";
            txtNoiDi.Text = "";
            txtNoiDen.Text = "";
            txtMoTa.Text = "";
            picture_Adm.Image = new Bitmap(Application.StartupPath + "\\HinhAnh\\" + "info.png");

            txtGioiDi.Text = ct.GioDi;
            txtGioDen.Text = ct.GioDen;
            txtNoiDi.Text = ct.DiemKhoiHanh;
            txtNoiDen.Text = ct.DiemDen;
            txtMoTa.Text = ct.MoTa;
            if (ct.HinhAnh != null && ct.HinhAnh!="")
            {
                picture_Adm.Image = new Bitmap(Application.StartupPath + "\\HinhAnh\\" + ct.HinhAnh);
            }
            
            txtTenAnh.Text = ct.HinhAnh;
        }
        private void Load_CbbIdChiTiet(string MaTour,int Ngay)
        {
            cbb_ChiTiet.Items.Clear();
            DataTable dsNgay = dl.Load_idNgayDi(MaTour,Ngay);
            if (dsNgay != null)
            {
                foreach(DataRow dr in dsNgay.Rows)
                {
                    cbb_ChiTiet.Items.Add(dr[0].ToString());
                }
            }
        }
        private void Load_CbbNgayThu(string MaTour)
        {
            //cbbNgayThu.Items.Clear();
            DataSet dsNgay = dl.Load_SoNgayDi(MaTour);
            if(dsNgay!=null)
            {
                cbbNgayThu.DataSource = dsNgay.Tables["Ngay"];
                cbbNgayThu.DisplayMember = "Ngay";
                cbbNgayThu.ValueMember = "Ngay";
            }
            else
            {
                return;
            }
        }
        private void DemTongNgay(string MaTour)
        {
            DataTable dt = dl.DemSoNgayDi(MaTour);
            if(dt!=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    txtTongNgay.Text = dr[0].ToString();
                }
            }
        }
        private void ChiTietChuongTrinhTour_Load(object sender, EventArgs e)
        {
            Load_CbbCCTour();
        }

        private void cbbChuongTrinhTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbChuongTrinhTour.SelectedIndex>=0)
            {
                string MaTour = (string)cbbChuongTrinhTour.SelectedValue.ToString();
                Load_CbbNgayThu(MaTour);
               
                DemTongNgay(MaTour);
            }
        }

        private void cbbNgayThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNgayThu.Items.Count > 1)
            {
                if (cbbNgayThu.SelectedIndex >= 0)
                {
                    string MaTour = (string)cbbChuongTrinhTour.SelectedValue.ToString();
                    int Ngay = int.Parse(cbbNgayThu.SelectedValue.ToString());
                    cbb_ChiTiet.Items.Clear();
                    Load_CbbIdChiTiet(MaTour, Ngay);
                }
            }
            else
                return;
        }

        private void cbbidChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_ChiTiet.SelectedIndex >= 0)
            {
                string ma = (string)cbb_ChiTiet.SelectedItem.ToString();
                Load_ChiTietChuongTrinhThuN(int.Parse(ma));
                Show_ChiTietChuongTrinhThuN();
            }
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            openFile_ = new OpenFileDialog();
            if (openFile_.ShowDialog() == DialogResult.OK)
            {
                picture_Adm.Image = new Bitmap(openFile_.FileName);
                string fileName = openFile_.FileName;
                txtTenAnh.Text = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            }
        }

        private bool UpLoadFile(OpenFileDialog Upload)
        {
            try
            {
                string path = Application.StartupPath + "\\HinhAnh\\";
                string path_ = "..\\....\\..\\HinhAnh\\";
                path = path + txtTenAnh.Text;
                path_ = path_ + txtTenAnh.Text;
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
                path = path + txtTenAnh.Text;
                path_ = path_ + txtTenAnh.Text;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            _ChiTietChuongTrinhTour ct_add = new _ChiTietChuongTrinhTour();
            ct_add.MaCTTour= (string)cbbChuongTrinhTour.SelectedValue;
            ct_add.GioDi = txtGioiDi.Text;
            ct_add.GioDen = txtGioDen.Text;
            ct_add.Ngay = int.Parse(cbbNgayThu.Text);
            ct_add.DiemKhoiHanh = txtNoiDi.Text;
            ct_add.DiemDen = txtNoiDen.Text;
            ct_add.MoTa = txtMoTa.Text;
            ct_add.HinhAnh = txtTenAnh.Text;
            int kq = dl.ThemChiTietChuongTrinhTour(ct_add);
            if(kq==1)
            {
                if (txtTenAnh.Text != null || txtTenAnh.Text != "" && picture_Adm.Image != null)
                {
                    if (UpLoadFile(openFile_))
                    {
                        MessageBox.Show("Upload:" + ct_add.HinhAnh + "Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Upload:" + ct_add.HinhAnh + " That bai");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _ChiTietChuongTrinhTour ct_add = new _ChiTietChuongTrinhTour();
            ct_add.MaCTTour = (string)cbbChuongTrinhTour.SelectedValue;
            ct_add.GioDi = txtGioiDi.Text;
            ct_add.GioDen = txtGioDen.Text;
            ct_add.Ngay = int.Parse(cbbNgayThu.Text);
            ct_add.DiemKhoiHanh = txtNoiDi.Text;
            ct_add.DiemDen = txtNoiDen.Text;
            ct_add.MoTa = txtMoTa.Text;
            ct_add.HinhAnh = txtTenAnh.Text;
            ct_add.Id = int.Parse(cbb_ChiTiet.Text);
            int kq = dl.SuaChiTietChuongTrinhTour(ct_add);
            if (kq == 1)
            {
                if (txtTenAnh.Text != null || txtTenAnh.Text != "" && picture_Adm.Image != null)
                {
                    if (UpLoadFile(openFile_))
                    {
                        MessageBox.Show("Upload:" + ct_add.HinhAnh + "Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Upload:" + ct_add.HinhAnh + " That bai");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(cbb_ChiTiet.Text);
            int kq = dl.XoaChiTietChuongTrinhTour(Id);
            if(kq==1)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
