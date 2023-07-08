
namespace DoAnDotNet_TourDuLich
{
    partial class QuanLyNhanVien
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lv_HDV = new System.Windows.Forms.ListView();
            this.col_maHdv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenHDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_maTk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_maLoaiNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_GioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_sdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NgayVaoLam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_CCCD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_LoaiHuongDanVien = new System.Windows.Forms.ComboBox();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenHDV = new System.Windows.Forms.TextBox();
            this.txtMaHDV = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblLoaiHDV = new System.Windows.Forms.Label();
            this.lblTenHDV = new System.Windows.Forms.Label();
            this.lblMaHDV = new System.Windows.Forms.Label();
            this.txtNgayVaoLam = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(43, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(220, 30);
            this.txtTimKiem.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnDotNet_TourDuLich.Properties.Resources.background1;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 57);
            this.panel1.TabIndex = 2;
            // 
            // lv_HDV
            // 
            this.lv_HDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_HDV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_maHdv,
            this.col_TenHDV,
            this.col_maTk,
            this.col_maLoaiNV,
            this.col_GioiTinh,
            this.col_sdt,
            this.col_NgayVaoLam,
            this.col_CCCD});
            this.lv_HDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lv_HDV.FullRowSelect = true;
            this.lv_HDV.GridLines = true;
            this.lv_HDV.HideSelection = false;
            this.lv_HDV.Location = new System.Drawing.Point(12, 221);
            this.lv_HDV.Name = "lv_HDV";
            this.lv_HDV.Size = new System.Drawing.Size(1238, 321);
            this.lv_HDV.TabIndex = 3;
            this.lv_HDV.UseCompatibleStateImageBehavior = false;
            this.lv_HDV.View = System.Windows.Forms.View.Details;
            this.lv_HDV.SelectedIndexChanged += new System.EventHandler(this.lv_HDV_SelectedIndexChanged);
            // 
            // col_maHdv
            // 
            this.col_maHdv.Text = "Mã hướng dẫn viên";
            this.col_maHdv.Width = 145;
            // 
            // col_TenHDV
            // 
            this.col_TenHDV.Text = "Tên hướng dẫn viên";
            this.col_TenHDV.Width = 157;
            // 
            // col_maTk
            // 
            this.col_maTk.Text = "Mã tài khoan";
            this.col_maTk.Width = 104;
            // 
            // col_maLoaiNV
            // 
            this.col_maLoaiNV.Text = "Loại hướng dẫn viên";
            this.col_maLoaiNV.Width = 171;
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.Text = "Giới tính";
            this.col_GioiTinh.Width = 144;
            // 
            // col_sdt
            // 
            this.col_sdt.Text = "Số điện thoại";
            this.col_sdt.Width = 163;
            // 
            // col_NgayVaoLam
            // 
            this.col_NgayVaoLam.Text = "Ngày vào làm";
            this.col_NgayVaoLam.Width = 173;
            // 
            // col_CCCD
            // 
            this.col_CCCD.Text = "Căn cước công dân";
            this.col_CCCD.Width = 173;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btn_QuayVe);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(1082, 28);
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
            this.btnSua.Location = new System.Drawing.Point(905, 28);
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
            this.btnLuu.Location = new System.Drawing.Point(551, 28);
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
            this.btn_QuayVe.Location = new System.Drawing.Point(12, 28);
            this.btn_QuayVe.Name = "btn_QuayVe";
            this.btn_QuayVe.Size = new System.Drawing.Size(154, 43);
            this.btn_QuayVe.TabIndex = 0;
            this.btn_QuayVe.Text = "Quay lại";
            this.btn_QuayVe.UseVisualStyleBackColor = false;
            this.btn_QuayVe.Click += new System.EventHandler(this.btn_QuayVe_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnThem.Location = new System.Drawing.Point(728, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNgayVaoLam);
            this.panel3.Controls.Add(this.cbb_LoaiHuongDanVien);
            this.panel3.Controls.Add(this.cbb_GioiTinh);
            this.panel3.Controls.Add(this.txtCCCD);
            this.panel3.Controls.Add(this.txtMaTK);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.txtTenHDV);
            this.panel3.Controls.Add(this.txtMaHDV);
            this.panel3.Controls.Add(this.lblGioiTinh);
            this.panel3.Controls.Add(this.lblMaTK);
            this.panel3.Controls.Add(this.lblCCCD);
            this.panel3.Controls.Add(this.lblNgayVaoLam);
            this.panel3.Controls.Add(this.lblSDT);
            this.panel3.Controls.Add(this.lblLoaiHDV);
            this.panel3.Controls.Add(this.lblTenHDV);
            this.panel3.Controls.Add(this.lblMaHDV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1262, 158);
            this.panel3.TabIndex = 5;
            // 
            // cbb_LoaiHuongDanVien
            // 
            this.cbb_LoaiHuongDanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbb_LoaiHuongDanVien.FormattingEnabled = true;
            this.cbb_LoaiHuongDanVien.Location = new System.Drawing.Point(877, 46);
            this.cbb_LoaiHuongDanVien.Name = "cbb_LoaiHuongDanVien";
            this.cbb_LoaiHuongDanVien.Size = new System.Drawing.Size(384, 31);
            this.cbb_LoaiHuongDanVien.TabIndex = 2;
            this.cbb_LoaiHuongDanVien.Click += new System.EventHandler(this.cbb_LoaiHuongDanVien_Click);
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Location = new System.Drawing.Point(611, 46);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(144, 31);
            this.cbb_GioiTinh.TabIndex = 2;
            this.cbb_GioiTinh.Click += new System.EventHandler(this.cbb_GioiTinh_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtCCCD.Location = new System.Drawing.Point(877, 116);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(251, 30);
            this.txtCCCD.TabIndex = 1;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaTK.Location = new System.Drawing.Point(32, 116);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(161, 30);
            this.txtMaTK.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtSDT.Location = new System.Drawing.Point(282, 116);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(240, 30);
            this.txtSDT.TabIndex = 1;
            // 
            // txtTenHDV
            // 
            this.txtTenHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenHDV.Location = new System.Drawing.Point(282, 47);
            this.txtTenHDV.Name = "txtTenHDV";
            this.txtTenHDV.Size = new System.Drawing.Size(240, 30);
            this.txtTenHDV.TabIndex = 1;
            // 
            // txtMaHDV
            // 
            this.txtMaHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaHDV.Location = new System.Drawing.Point(32, 47);
            this.txtMaHDV.Name = "txtMaHDV";
            this.txtMaHDV.Size = new System.Drawing.Size(161, 30);
            this.txtMaHDV.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.Location = new System.Drawing.Point(611, 15);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(85, 23);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaTK.Location = new System.Drawing.Point(32, 86);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(121, 23);
            this.lblMaTK.TabIndex = 0;
            this.lblMaTK.Text = "Mã tài khoản";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCCCD.Location = new System.Drawing.Point(877, 85);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(90, 23);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "Căn cước";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayVaoLam.Location = new System.Drawing.Point(611, 85);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(124, 23);
            this.lblNgayVaoLam.TabIndex = 0;
            this.lblNgayVaoLam.Text = "Ngày vào làm";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.Location = new System.Drawing.Point(282, 86);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(118, 23);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblLoaiHDV
            // 
            this.lblLoaiHDV.AutoSize = true;
            this.lblLoaiHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiHDV.Location = new System.Drawing.Point(877, 15);
            this.lblLoaiHDV.Name = "lblLoaiHDV";
            this.lblLoaiHDV.Size = new System.Drawing.Size(180, 23);
            this.lblLoaiHDV.TabIndex = 0;
            this.lblLoaiHDV.Text = "Loại hướng dẫn viên";
            // 
            // lblTenHDV
            // 
            this.lblTenHDV.AutoSize = true;
            this.lblTenHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenHDV.Location = new System.Drawing.Point(282, 15);
            this.lblTenHDV.Name = "lblTenHDV";
            this.lblTenHDV.Size = new System.Drawing.Size(174, 23);
            this.lblTenHDV.TabIndex = 0;
            this.lblTenHDV.Text = "Tên hướng dẫn viên";
            // 
            // lblMaHDV
            // 
            this.lblMaHDV.AutoSize = true;
            this.lblMaHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHDV.Location = new System.Drawing.Point(32, 15);
            this.lblMaHDV.Name = "lblMaHDV";
            this.lblMaHDV.Size = new System.Drawing.Size(170, 23);
            this.lblMaHDV.TabIndex = 0;
            this.lblMaHDV.Text = "Mã hướng dẫn viên";
            // 
            // txtNgayVaoLam
            // 
            this.txtNgayVaoLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtNgayVaoLam.Location = new System.Drawing.Point(611, 116);
            this.txtNgayVaoLam.Mask = "00/00/0000";
            this.txtNgayVaoLam.Name = "txtNgayVaoLam";
            this.txtNgayVaoLam.Size = new System.Drawing.Size(198, 30);
            this.txtNgayVaoLam.TabIndex = 4;
            this.txtNgayVaoLam.ValidatingType = typeof(System.DateTime);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1262, 656);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lv_HDV);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv_HDV;
        private System.Windows.Forms.ColumnHeader col_maHdv;
        private System.Windows.Forms.ColumnHeader col_maTk;
        private System.Windows.Forms.ColumnHeader col_maLoaiNV;
        private System.Windows.Forms.ColumnHeader col_GioiTinh;
        private System.Windows.Forms.ColumnHeader col_sdt;
        private System.Windows.Forms.ColumnHeader col_NgayVaoLam;
        private System.Windows.Forms.ColumnHeader col_CCCD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_LoaiHuongDanVien;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenHDV;
        private System.Windows.Forms.TextBox txtMaHDV;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblLoaiHDV;
        private System.Windows.Forms.Label lblTenHDV;
        private System.Windows.Forms.Label lblMaHDV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.ColumnHeader col_TenHDV;
        private System.Windows.Forms.MaskedTextBox txtNgayVaoLam;
    }
}