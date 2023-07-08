
namespace DoAnDotNet_TourDuLich.Form_Design.Form_QuanTri
{
    partial class QuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.txtngaySinh = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblTenHDV = new System.Windows.Forms.Label();
            this.lblMaHDV = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.pn_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Accounts
            // 
            this.dgv_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Accounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Accounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Accounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Accounts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_Accounts.Location = new System.Drawing.Point(8, 220);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_Accounts.RowHeadersWidth = 100;
            this.dgv_Accounts.RowTemplate.Height = 24;
            this.dgv_Accounts.Size = new System.Drawing.Size(1316, 402);
            this.dgv_Accounts.TabIndex = 18;
            // 
            // txtngaySinh
            // 
            this.txtngaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtngaySinh.Location = new System.Drawing.Point(787, 63);
            this.txtngaySinh.Name = "txtngaySinh";
            this.txtngaySinh.Size = new System.Drawing.Size(251, 30);
            this.txtngaySinh.TabIndex = 1;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaKhach.Location = new System.Drawing.Point(227, 62);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(251, 30);
            this.txtMaKhach.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.BackColor = System.Drawing.Color.Blue;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLuu.Location = new System.Drawing.Point(624, 28);
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
            this.btnThem.Location = new System.Drawing.Point(801, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaTK
            // 
            this.txtMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaTK.Location = new System.Drawing.Point(39, 63);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(161, 30);
            this.txtMaTK.TabIndex = 1;
            // 
            // pn_Main
            // 
            this.pn_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_Main.Controls.Add(this.txtngaySinh);
            this.pn_Main.Controls.Add(this.txtMaKhach);
            this.pn_Main.Controls.Add(this.txtMaTK);
            this.pn_Main.Controls.Add(this.txtTenKhach);
            this.pn_Main.Controls.Add(this.txtSDT);
            this.pn_Main.Controls.Add(this.lblMaTK);
            this.pn_Main.Controls.Add(this.label1);
            this.pn_Main.Controls.Add(this.lblCCCD);
            this.pn_Main.Controls.Add(this.lblTenHDV);
            this.pn_Main.Controls.Add(this.lblMaHDV);
            this.pn_Main.Location = new System.Drawing.Point(0, 57);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(1337, 158);
            this.pn_Main.TabIndex = 17;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenKhach.Location = new System.Drawing.Point(511, 63);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(240, 30);
            this.txtTenKhach.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtSDT.Location = new System.Drawing.Point(1085, 63);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(214, 30);
            this.txtSDT.TabIndex = 1;
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaTK.Location = new System.Drawing.Point(39, 31);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(121, 23);
            this.lblMaTK.TabIndex = 0;
            this.lblMaTK.Text = "Mã tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(783, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày sinh";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCCCD.Location = new System.Drawing.Point(227, 31);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(93, 23);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "Mã khách";
            // 
            // lblTenHDV
            // 
            this.lblTenHDV.AutoSize = true;
            this.lblTenHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenHDV.Location = new System.Drawing.Point(511, 31);
            this.lblTenHDV.Name = "lblTenHDV";
            this.lblTenHDV.Size = new System.Drawing.Size(97, 23);
            this.lblTenHDV.TabIndex = 0;
            this.lblTenHDV.Text = "Tên khách";
            // 
            // lblMaHDV
            // 
            this.lblMaHDV.AutoSize = true;
            this.lblMaHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHDV.Location = new System.Drawing.Point(1085, 31);
            this.lblMaHDV.Name = "lblMaHDV";
            this.lblMaHDV.Size = new System.Drawing.Size(118, 23);
            this.lblMaHDV.TabIndex = 0;
            this.lblMaHDV.Text = "Số điện thoại";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.BackColor = System.Drawing.Color.Red;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSua.Location = new System.Drawing.Point(978, 28);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 43);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btn_QuayVe);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 622);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1335, 100);
            this.panel2.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(1155, 28);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnDotNet_TourDuLich.Properties.Resources.background1;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 57);
            this.panel1.TabIndex = 15;
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
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1335, 722);
            this.Controls.Add(this.dgv_Accounts);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.pn_Main.ResumeLayout(false);
            this.pn_Main.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Accounts;
        private System.Windows.Forms.TextBox txtngaySinh;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblTenHDV;
        private System.Windows.Forms.Label lblMaHDV;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel1;
    }
}