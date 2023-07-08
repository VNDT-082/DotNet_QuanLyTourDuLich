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
    public partial class ChuongTrinhTour : Form
    {
        public delegate void TruyenTour(string matour, string mahdv, string tentour, string diadiem, string chiphi, string anhbia, string loaitour);
        public TruyenTour GuiThongTinTour;
        public delegate void TruyenKhach_DSTour(string mtk, string ml, string ten, string tenN, string dd, string mail, string pass);
        public TruyenKhach_DSTour Gui_TaiKHoan_DST;
        public ChuongTrinhTour()
        {
            InitializeComponent();
            GuiThongTinTour = new TruyenTour(NhanThongTinTour);
            Gui_TaiKHoan_DST = new TruyenKhach_DSTour(loadDuLieu);
        }
        //khai bao//
        DuLieu dl = new DuLieu();
        account a = new account();
        ThuMuc_Class.Tour t = new ThuMuc_Class.Tour();

        private void btnDatMua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dat_Click(object sender, EventArgs e)
        {

        }

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
            lblMaTour.Text = matour;
            lblTenTour.Text = tentour;
            lblGia.Text = chiphi + "VNĐ";

        }
        private void LoadThongTinCaNhan(string matk)
        {
            DataTable tk = dl.LayMaKhach(matk);
            ThuMuc_Class.KhachHang k = new ThuMuc_Class.KhachHang();
            foreach (DataRow dr in tk.Rows)
            {
                k.MaKhach = dr["MaKhach"].ToString();
                k.MaTK = dr["MaTK"].ToString();
                k.TenKhach = dr["TenKhach"].ToString();
                //k.NgaySinh = dr["NgaySinh"].ToString();
                DateTime ngaysinh = DateTime.Parse(dr["NgaySinh"].ToString());
                string ns=ngaysinh.ToString("{MM/dd/yyyy}");
                k.NgaySinh = ns;
                k.NgaySinh = ns.ToString();
                k.SDT = dr["SDT"].ToString();
            }
            txtMaKhach.Text = k.MaKhach;
            txtTenKhach.Text = k.TenKhach;
            mtxtNgaySinh.Text = k.NgaySinh;
            txtSDT.Text = k.SDT;
            txtMaTour.Text = t.MaTour;
        }
        private void KiemTraTrangThai()
        {
            if(mtxtNgayDi.Text== "  /  /")
            {
                btnDatTour.Enabled = false;
            }
            else
            {
                if(numericUpDown1.Value==1)
                {
                    btnDatTour.Enabled = true;
                    lblMoiNhapTN.Visible = false;
                }
                else
                {
                    lblMoiNhapTN.Visible = true;
                    btnDatTour.Enabled = false;
                    LoadCCB_GioiTinh();
                }
            }
        }
        private void ChuongTrinhTour_Load(object sender, EventArgs e)
        {
            LoadThongTinCaNhan(a.maTk);
            KiemTraTrangThai();
            LoadTabPage();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            KiemTraTrangThai();
        }

        private void mtxtNgayDi_Click(object sender, EventArgs e)
        {
            KiemTraTrangThai();
        }
        private void LoadTabPage()
        {
            tabControl1.Controls.Clear();
            DataTable dt_Ngay = dl.LoadSoNgayDiCuaChuongTrinh(t.MaTour);
            int dem = 1;
            if(dt_Ngay!=null && dt_Ngay.Rows.Count>0)
            {
                foreach (DataRow dr in dt_Ngay.Rows)
                {
                    Panel tbl_item = new TableLayoutPanel();
                    tbl_item.AutoScroll = true;
                    tbl_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
                    tbl_item.BackColor = Color.White;
                    tbl_item.Width = 1000;
                    tbl_item.Height = 730;
                    DataTable dt = dl.LoadChiTietChuongTrinhTour(t.MaTour, dr[1].ToString());
                    if(dt!=null && dt.Rows.Count>0)
                    {
                        foreach (DataRow dr_ctt in dt.Rows)
                        {
                            Label ngay = new Label();
                            ngay.AutoSize = true;
                            ngay.Text = "Lịch trình của ngày:";
                            ngay.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                            tbl_item.Controls.Add(ngay);

                            Label GioDi = new Label();
                            GioDi.AutoSize = true;
                            GioDi.Text = "Giờ đi:" + dr_ctt[3].ToString();
                            GioDi.ForeColor = Color.Red;
                            GioDi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                            tbl_item.Controls.Add(GioDi);

                            Label GioDen = new Label();
                            GioDen.AutoSize = true;
                            GioDen.Text = "Giờ đến:" + dr_ctt[4].ToString();
                            GioDen.ForeColor = Color.Blue;
                            GioDen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                            tbl_item.Controls.Add(GioDen);

                            Label DiemKhoiHanh = new Label();
                            DiemKhoiHanh.AutoSize = true;
                            DiemKhoiHanh.ForeColor = Color.Red;
                            DiemKhoiHanh.Text = "Khởi hành từ:" + dr_ctt[5].ToString();
                            DiemKhoiHanh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                            tbl_item.Controls.Add(DiemKhoiHanh);

                            Label DiemDen = new Label();
                            DiemDen.AutoSize = true;
                            DiemDen.Text = "Đến:" + dr_ctt[6].ToString();
                            DiemDen.ForeColor = Color.Blue;
                            DiemDen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                            tbl_item.Controls.Add(DiemDen);

                            if(dr_ctt[8].ToString()!=null || dr_ctt[8].ToString()!="")
                            {
                                PictureBox pt = new PictureBox();
                                pt.Location = new System.Drawing.Point(33, 20);
                                pt.Size = new System.Drawing.Size(500, 350);
                                pt.SizeMode = PictureBoxSizeMode.StretchImage;
                                pt.Image = new Bitmap(Application.StartupPath + "\\HinhAnh\\" + dr_ctt[8].ToString());
                                tbl_item.Controls.Add(pt);
                            }
                            


                            Label MoTa = new Label();
                            MoTa.AutoSize = true;
                            MoTa.Text = "Mô tả:" + dr_ctt[7].ToString();
                            MoTa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                            tbl_item.Controls.Add(MoTa);

                            Label footer = new Label();
                            footer.AutoSize = true;
                            footer.Text = "::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::" +
                                ":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::";
                            footer.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular,
                                System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                            tbl_item.Controls.Add(footer);



                        }
                    }
                    
                    TabPage tp = new TabPage();
                    tp.Anchor = System.Windows.Forms.AnchorStyles.None;
                    tp.AutoSize = false;
                    tp.AutoScroll = false;
                    tp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    tp.Controls.Add(tbl_item);
                    tp.Location = new System.Drawing.Point(4, 32);
                    tp.Name = dr[0].ToString();
                    tp.Padding = new System.Windows.Forms.Padding(3);
                    tp.Size = new System.Drawing.Size(1010, 910);
                    tp.TabIndex = 0;
                    tp.Text = "Ngày" + dr[1].ToString();
                    tp.UseVisualStyleBackColor = true;
                    tabControl1.Controls.Add(tp);
                }
            }
            
        }
        //Them thanh vien
        private void LoadCCB_GioiTinh()
        {
            DataSet ds = dl.LoadTableGioiTinh();
            cbbGioiTinh.DataSource = ds.Tables["GioiTinh"];
            cbbGioiTinh.DisplayMember = "TenGioiTinh";
            cbbGioiTinh.ValueMember = "MaGioiTinh";

            
        }
        List<ThuMuc_Class.NguoiThan> ds_nguoiThan = new List<ThuMuc_Class.NguoiThan>();

        int dem = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dem < numericUpDown1.Value)
                {
                    ThuMuc_Class.NguoiThan nt = new ThuMuc_Class.NguoiThan();
                    nt.TenThanhVien = txtTenThanhVien.Text;
                    nt.NgaySinh = mtxtNgaySinhTV.Text;
                    nt.GioiTinh = cbbGioiTinh.SelectedValue.ToString();
                    nt.CCCD = txtCCCD.Text;
                    nt.MaKhach = txtMaKhach.Text;
                    nt.MaTour = txtMaTour.Text;
                    ds_nguoiThan.Add(nt);
                    lvThanhVien.Items.Clear();
                    foreach (ThuMuc_Class.NguoiThan n in ds_nguoiThan)
                    {
                        ListViewItem item = new ListViewItem(n.TenThanhVien);
                        item.SubItems.Add(nt.NgaySinh);
                        item.SubItems.Add(n.GioiTinh);
                        item.SubItems.Add(n.CCCD);
                        lvThanhVien.Items.Add(item);
                    }
                    dem++;
                }
                else
                {
                    MessageBox.Show("Đã nhập đủ số lượng!");
                }
            }
            catch(Exception)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Lỗi THÊM thành viên vui lòng kiểm tra lại", "chú ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
        }

        private void lvThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvThanhVien.SelectedItems.Count>0)
            {
                txtTenThanhVien.Text = lvThanhVien.SelectedItems[0].SubItems[0].Text;
                mtxtNgaySinhTV.Text = lvThanhVien.SelectedItems[0].SubItems[1].Text;
                cbbGioiTinh.Text = lvThanhVien.SelectedItems[0].SubItems[2].Text;
                txtCCCD.Text = lvThanhVien.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvThanhVien.SelectedItems.Count > 0)
                {
                    foreach (ThuMuc_Class.NguoiThan nt in ds_nguoiThan)
                    {
                        if (nt.TenThanhVien == lvThanhVien.SelectedItems[0].SubItems[0].Text
                            && nt.NgaySinh == lvThanhVien.SelectedItems[0].SubItems[1].Text)
                        {
                            nt.TenThanhVien = txtTenThanhVien.Text;
                            nt.NgaySinh = mtxtNgaySinhTV.Text;
                            nt.GioiTinh = cbbGioiTinh.SelectedValue.ToString();
                            nt.CCCD = txtCCCD.Text;
                            //nt.MaKhach = txtMaKhach.Text;

                            lvThanhVien.SelectedItems[0].SubItems[0].Text = txtTenThanhVien.Text;
                            lvThanhVien.SelectedItems[0].SubItems[1].Text = mtxtNgaySinhTV.Text;
                            lvThanhVien.SelectedItems[0].SubItems[2].Text = cbbGioiTinh.Text;
                            lvThanhVien.SelectedItems[0].SubItems[3].Text = txtCCCD.Text;
                        }
                    }
                }
            }
            catch (Exception)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Lỗi SỮA thành viên vui lòng kiểm tra lại", "chú ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvThanhVien.SelectedItems.Count > 0)
                {
                    foreach (ThuMuc_Class.NguoiThan nt in ds_nguoiThan)
                    {
                        if (nt.TenThanhVien == lvThanhVien.SelectedItems[0].SubItems[0].Text
                            && nt.NgaySinh == lvThanhVien.SelectedItems[0].SubItems[1].Text)
                        {
                            ds_nguoiThan.Remove(nt);
                            lvThanhVien.Items.Remove(lvThanhVien.SelectedItems[0]);
                            dem--;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Lỗi XÓA thành viên vui lòng kiểm tra lại", "chú ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = (MessageBox.Show("Dữ liệu đã khóa!!!", "chú ý",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if(tb==DialogResult.Yes)
            {
                pn_nguoiThan.Enabled = false;
                pn_ThongTinKH.Focus();
                btnDatTour.Enabled = true;

            }

        }

        private void btnDatTour_Click(object sender, EventArgs e)
        {
            try
            {
                int kq = 0;
                int SoLuongTV = int.Parse(numericUpDown1.Value.ToString());
                string GiaTour = t.ChiPhi;
                ThuMuc_Class.DatVe v = new ThuMuc_Class.DatVe(txtMaKhach.Text,txtMaTour.Text,mtxtNgayDi.Text,SoLuongTV, GiaTour);
                kq = dl.LickMua(v);
           
                foreach (ThuMuc_Class.NguoiThan nt in ds_nguoiThan)
                {
                    kq = dl.XacNhanThanhVien(txtMaKhach.Text, nt);
                }
                if (kq == 0)
                {
                    MessageBox.Show("Lỗi!!!");
                }
                else
                {
                    //ds_nguoiThan.Clear();
                    btnHuy.Visible = true;
                    btnDatTour.Visible = false;
                    lblMoiNhapTN.Text = "Đã đặt Tour thành công!!!";
                }
            }
            catch (Exception)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Lỗi!!!", "chú ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                int kq = 0;
                kq = dl.XoaThanhVien_HuyTour(txtMaKhach.Text, txtMaTour.Text);
                kq = dl.XoaDonDatTour_HuyTour(txtMaKhach.Text, txtMaTour.Text);
                if (kq == 0)
                {
                    MessageBox.Show("Lỗi!!!");
                }
                else
                {
                    //ds_nguoiThan.Clear();
                    btnHuy.Visible = false;
                    btnDatTour.Visible = true;
                    lblMoiNhapTN.Text = "Mời thêm thông tin người thân!!";
                }
            }
            catch (Exception)
            {
                DialogResult tb;
                tb = (MessageBox.Show("Lỗi!!!", "chú ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning));
            }
        }
    }
}
