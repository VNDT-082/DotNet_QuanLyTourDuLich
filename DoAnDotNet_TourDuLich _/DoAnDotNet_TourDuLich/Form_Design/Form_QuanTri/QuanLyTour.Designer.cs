
namespace DoAnDotNet_TourDuLich.Form_Design
{
    partial class QuanLyTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.cbb_TenHuongdanVien = new System.Windows.Forms.ComboBox();
            this.cbb_LoaiTour = new System.Windows.Forms.ComboBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblLoaiHDV = new System.Windows.Forms.Label();
            this.lblMaHDV = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTenHDV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.col_picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_loaiTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_hinhAnh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ChiPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_DiaDiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MaHDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_maTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Tour = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.picture_item = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.image_list = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_item)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(1447, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.BackColor = System.Drawing.Color.Red;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSua.Location = new System.Drawing.Point(1270, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 43);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.BackColor = System.Drawing.Color.Blue;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLuu.Location = new System.Drawing.Point(916, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(154, 43);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_QuayVe
            // 
            this.btn_QuayVe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_QuayVe.BackColor = System.Drawing.Color.Blue;
            this.btn_QuayVe.CausesValidation = false;
            this.btn_QuayVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_QuayVe.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_QuayVe.Location = new System.Drawing.Point(12, 10);
            this.btn_QuayVe.Name = "btn_QuayVe";
            this.btn_QuayVe.Size = new System.Drawing.Size(154, 43);
            this.btn_QuayVe.TabIndex = 0;
            this.btn_QuayVe.Text = "Quay lại";
            this.btn_QuayVe.UseVisualStyleBackColor = false;
            this.btn_QuayVe.Click += new System.EventHandler(this.btn_QuayVe_Click);
            // 
            // cbb_TenHuongdanVien
            // 
            this.cbb_TenHuongdanVien.BackColor = System.Drawing.Color.White;
            this.cbb_TenHuongdanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbb_TenHuongdanVien.ForeColor = System.Drawing.Color.Black;
            this.cbb_TenHuongdanVien.FormattingEnabled = true;
            this.cbb_TenHuongdanVien.Location = new System.Drawing.Point(402, 62);
            this.cbb_TenHuongdanVien.Name = "cbb_TenHuongdanVien";
            this.cbb_TenHuongdanVien.Size = new System.Drawing.Size(360, 31);
            this.cbb_TenHuongdanVien.TabIndex = 2;
            // 
            // cbb_LoaiTour
            // 
            this.cbb_LoaiTour.BackColor = System.Drawing.Color.White;
            this.cbb_LoaiTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbb_LoaiTour.ForeColor = System.Drawing.Color.Black;
            this.cbb_LoaiTour.FormattingEnabled = true;
            this.cbb_LoaiTour.Location = new System.Drawing.Point(768, 62);
            this.cbb_LoaiTour.Name = "cbb_LoaiTour";
            this.cbb_LoaiTour.Size = new System.Drawing.Size(339, 31);
            this.cbb_LoaiTour.TabIndex = 2;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.BackColor = System.Drawing.Color.White;
            this.txtHinhAnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtHinhAnh.ForeColor = System.Drawing.Color.Black;
            this.txtHinhAnh.Location = new System.Drawing.Point(1267, 213);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(300, 30);
            this.txtHinhAnh.TabIndex = 1;
            // 
            // txtTenTour
            // 
            this.txtTenTour.BackColor = System.Drawing.Color.White;
            this.txtTenTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenTour.ForeColor = System.Drawing.Color.Black;
            this.txtTenTour.Location = new System.Drawing.Point(158, 210);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(957, 30);
            this.txtTenTour.TabIndex = 1;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.BackColor = System.Drawing.Color.White;
            this.txtDiaDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtDiaDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiaDiem.Location = new System.Drawing.Point(57, 154);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(322, 30);
            this.txtDiaDiem.TabIndex = 1;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.BackColor = System.Drawing.Color.White;
            this.txtChiPhi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtChiPhi.ForeColor = System.Drawing.Color.Black;
            this.txtChiPhi.Location = new System.Drawing.Point(402, 154);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(360, 30);
            this.txtChiPhi.TabIndex = 1;
            // 
            // txtMaTour
            // 
            this.txtMaTour.BackColor = System.Drawing.Color.White;
            this.txtMaTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaTour.ForeColor = System.Drawing.Color.Black;
            this.txtMaTour.Location = new System.Drawing.Point(57, 62);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(322, 30);
            this.txtMaTour.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(1920, 46);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(92, 23);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Loại Tour";
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaTK.ForeColor = System.Drawing.Color.Black;
            this.lblMaTK.Location = new System.Drawing.Point(60, 215);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(93, 23);
            this.lblMaTK.TabIndex = 0;
            this.lblMaTK.Text = "Tên Tour:";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayVaoLam.ForeColor = System.Drawing.Color.Black;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(398, 128);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(70, 23);
            this.lblNgayVaoLam.TabIndex = 0;
            this.lblNgayVaoLam.Text = "Chi phí";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.Location = new System.Drawing.Point(53, 128);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(84, 23);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Địa điểm";
            // 
            // lblLoaiHDV
            // 
            this.lblLoaiHDV.AutoSize = true;
            this.lblLoaiHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiHDV.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiHDV.Location = new System.Drawing.Point(1169, 216);
            this.lblLoaiHDV.Name = "lblLoaiHDV";
            this.lblLoaiHDV.Size = new System.Drawing.Size(93, 23);
            this.lblLoaiHDV.TabIndex = 0;
            this.lblLoaiHDV.Text = "Hình ảnh:";
            // 
            // lblMaHDV
            // 
            this.lblMaHDV.AutoSize = true;
            this.lblMaHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaHDV.Location = new System.Drawing.Point(2012, 46);
            this.lblMaHDV.Name = "lblMaHDV";
            this.lblMaHDV.Size = new System.Drawing.Size(82, 23);
            this.lblMaHDV.TabIndex = 0;
            this.lblMaHDV.Text = "Mã Tour";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnThem.Location = new System.Drawing.Point(1093, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTenHDV
            // 
            this.lblTenHDV.AutoSize = true;
            this.lblTenHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenHDV.ForeColor = System.Drawing.Color.Black;
            this.lblTenHDV.Location = new System.Drawing.Point(398, 36);
            this.lblTenHDV.Name = "lblTenHDV";
            this.lblTenHDV.Size = new System.Drawing.Size(174, 23);
            this.lblTenHDV.TabIndex = 0;
            this.lblTenHDV.Text = "Tên hướng dẫn viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btn_QuayVe);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 678);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1627, 64);
            this.panel2.TabIndex = 8;
            // 
            // col_picture
            // 
            this.col_picture.Text = "Picture";
            this.col_picture.Width = 140;
            // 
            // col_loaiTour
            // 
            this.col_loaiTour.Text = "Mã loại Tour";
            this.col_loaiTour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_loaiTour.Width = 173;
            // 
            // col_hinhAnh
            // 
            this.col_hinhAnh.Text = "Hình ảnh";
            this.col_hinhAnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_hinhAnh.Width = 163;
            // 
            // col_ChiPhi
            // 
            this.col_ChiPhi.Text = "Chi phí";
            this.col_ChiPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_ChiPhi.Width = 144;
            // 
            // col_DiaDiem
            // 
            this.col_DiaDiem.Text = "Địa điểm";
            this.col_DiaDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_DiaDiem.Width = 171;
            // 
            // col_TenTour
            // 
            this.col_TenTour.Text = "Tên Tour";
            this.col_TenTour.Width = 214;
            // 
            // col_MaHDV
            // 
            this.col_MaHDV.Text = "Mã hưỡng dẫn viên";
            this.col_MaHDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_MaHDV.Width = 98;
            // 
            // col_maTour
            // 
            this.col_maTour.Text = "Mã Tour";
            this.col_maTour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_maTour.Width = 145;
            // 
            // lv_Tour
            // 
            this.lv_Tour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Tour.BackColor = System.Drawing.Color.White;
            this.lv_Tour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_picture,
            this.col_maTour,
            this.col_MaHDV,
            this.col_TenTour,
            this.col_DiaDiem,
            this.col_ChiPhi,
            this.col_hinhAnh,
            this.col_loaiTour});
            this.lv_Tour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lv_Tour.ForeColor = System.Drawing.Color.Black;
            this.lv_Tour.FullRowSelect = true;
            this.lv_Tour.GridLines = true;
            this.lv_Tour.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Tour.HideSelection = false;
            this.lv_Tour.LabelWrap = false;
            this.lv_Tour.Location = new System.Drawing.Point(0, 311);
            this.lv_Tour.MaximumSize = new System.Drawing.Size(1800, 800);
            this.lv_Tour.Name = "lv_Tour";
            this.lv_Tour.Size = new System.Drawing.Size(1609, 260);
            this.lv_Tour.TabIndex = 7;
            this.lv_Tour.UseCompatibleStateImageBehavior = false;
            this.lv_Tour.View = System.Windows.Forms.View.Details;
            this.lv_Tour.SelectedIndexChanged += new System.EventHandler(this.lv_Tour_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnOpenFile);
            this.panel3.Controls.Add(this.picture_item);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cbb_TenHuongdanVien);
            this.panel3.Controls.Add(this.cbb_LoaiTour);
            this.panel3.Controls.Add(this.txtHinhAnh);
            this.panel3.Controls.Add(this.txtTenTour);
            this.panel3.Controls.Add(this.txtDiaDiem);
            this.panel3.Controls.Add(this.txtChiPhi);
            this.panel3.Controls.Add(this.txtMaTour);
            this.panel3.Controls.Add(this.lblGioiTinh);
            this.panel3.Controls.Add(this.lblMaTK);
            this.panel3.Controls.Add(this.lblNgayVaoLam);
            this.panel3.Controls.Add(this.lblSDT);
            this.panel3.Controls.Add(this.lblLoaiHDV);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblTenHDV);
            this.panel3.Controls.Add(this.lblMaHDV);
            this.panel3.Location = new System.Drawing.Point(2, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1607, 257);
            this.panel3.TabIndex = 9;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::DoAnDotNet_TourDuLich.Properties.Resources.icon_file;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpenFile.Location = new System.Drawing.Point(1207, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(56, 47);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // picture_item
            // 
            this.picture_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_item.Location = new System.Drawing.Point(1267, 3);
            this.picture_item.Name = "picture_item";
            this.picture_item.Size = new System.Drawing.Size(300, 210);
            this.picture_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_item.TabIndex = 4;
            this.picture_item.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(1150, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 254);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(764, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Tour";
            // 
            // image_list
            // 
            this.image_list.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_list.ImageSize = new System.Drawing.Size(16, 16);
            this.image_list.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnDotNet_TourDuLich.Properties.Resources.background1;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1627, 57);
            this.panel1.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.Location = new System.Drawing.Point(274, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(136, 32);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(43, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(220, 30);
            this.txtTimKiem.TabIndex = 0;
            // 
            // QuanLyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1627, 742);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lv_Tour);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyTour";
            this.Text = "QuanLyTour";
            this.Load += new System.EventHandler(this.QuanLyTour_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_item)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.ComboBox cbb_TenHuongdanVien;
        private System.Windows.Forms.ComboBox cbb_LoaiTour;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtChiPhi;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblLoaiHDV;
        private System.Windows.Forms.Label lblMaHDV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTenHDV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader col_picture;
        private System.Windows.Forms.ColumnHeader col_loaiTour;
        private System.Windows.Forms.ColumnHeader col_hinhAnh;
        private System.Windows.Forms.ColumnHeader col_ChiPhi;
        private System.Windows.Forms.ColumnHeader col_DiaDiem;
        private System.Windows.Forms.ColumnHeader col_TenTour;
        private System.Windows.Forms.ColumnHeader col_MaHDV;
        private System.Windows.Forms.ColumnHeader col_maTour;
        private System.Windows.Forms.ListView lv_Tour;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picture_item;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList image_list;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}