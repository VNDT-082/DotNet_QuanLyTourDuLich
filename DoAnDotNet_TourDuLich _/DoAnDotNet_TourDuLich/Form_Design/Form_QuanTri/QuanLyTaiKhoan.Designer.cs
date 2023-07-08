
namespace DoAnDotNet_TourDuLich.Form_Design.Form_QuanTri
{
    partial class QuanLyTaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_QuayVe = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.cbb_LoaiAccounts = new System.Windows.Forms.ComboBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtTenTk = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblLoaiHDV = new System.Windows.Forms.Label();
            this.lblTenHDV = new System.Windows.Forms.Label();
            this.lblMaHDV = new System.Windows.Forms.Label();
            this.dgv_Accounts = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnDotNet_TourDuLich.Properties.Resources.background1;
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 57);
            this.panel1.TabIndex = 10;
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
            this.panel2.Size = new System.Drawing.Size(1352, 100);
            this.panel2.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(1172, 28);
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
            this.btnSua.Location = new System.Drawing.Point(995, 28);
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
            this.btnLuu.Location = new System.Drawing.Point(641, 28);
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
            this.btnThem.Location = new System.Drawing.Point(818, 28);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pn_Main
            // 
            this.pn_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pn_Main.Controls.Add(this.cbb_LoaiAccounts);
            this.pn_Main.Controls.Add(this.txtMK);
            this.pn_Main.Controls.Add(this.txtEmail);
            this.pn_Main.Controls.Add(this.txtMaTK);
            this.pn_Main.Controls.Add(this.txtTenDN);
            this.pn_Main.Controls.Add(this.txtTenTk);
            this.pn_Main.Controls.Add(this.txtSDT);
            this.pn_Main.Controls.Add(this.lblMaTK);
            this.pn_Main.Controls.Add(this.label1);
            this.pn_Main.Controls.Add(this.lblCCCD);
            this.pn_Main.Controls.Add(this.lblSDT);
            this.pn_Main.Controls.Add(this.lblLoaiHDV);
            this.pn_Main.Controls.Add(this.lblTenHDV);
            this.pn_Main.Controls.Add(this.lblMaHDV);
            this.pn_Main.Location = new System.Drawing.Point(0, 57);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(1352, 158);
            this.pn_Main.TabIndex = 13;
            // 
            // cbb_LoaiAccounts
            // 
            this.cbb_LoaiAccounts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbb_LoaiAccounts.FormattingEnabled = true;
            this.cbb_LoaiAccounts.Location = new System.Drawing.Point(235, 46);
            this.cbb_LoaiAccounts.Name = "cbb_LoaiAccounts";
            this.cbb_LoaiAccounts.Size = new System.Drawing.Size(384, 31);
            this.cbb_LoaiAccounts.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMK.Location = new System.Drawing.Point(1001, 47);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(251, 30);
            this.txtMK.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(235, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(251, 30);
            this.txtEmail.TabIndex = 1;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaTK.Location = new System.Drawing.Point(39, 47);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(161, 30);
            this.txtMaTK.TabIndex = 1;
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenDN.Location = new System.Drawing.Point(670, 118);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(240, 30);
            this.txtTenDN.TabIndex = 1;
            // 
            // txtTenTk
            // 
            this.txtTenTk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenTk.Location = new System.Drawing.Point(670, 47);
            this.txtTenTk.Name = "txtTenTk";
            this.txtTenTk.Size = new System.Drawing.Size(240, 30);
            this.txtTenTk.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtSDT.Location = new System.Drawing.Point(39, 118);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(161, 30);
            this.txtSDT.TabIndex = 1;
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaTK.Location = new System.Drawing.Point(39, 15);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(121, 23);
            this.lblMaTK.TabIndex = 0;
            this.lblMaTK.Text = "Mã tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(997, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCCCD.Location = new System.Drawing.Point(235, 85);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(58, 23);
            this.lblCCCD.TabIndex = 0;
            this.lblCCCD.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.Location = new System.Drawing.Point(670, 86);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(132, 23);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Tên đăng nhập";
            // 
            // lblLoaiHDV
            // 
            this.lblLoaiHDV.AutoSize = true;
            this.lblLoaiHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiHDV.Location = new System.Drawing.Point(235, 15);
            this.lblLoaiHDV.Name = "lblLoaiHDV";
            this.lblLoaiHDV.Size = new System.Drawing.Size(131, 23);
            this.lblLoaiHDV.TabIndex = 0;
            this.lblLoaiHDV.Text = "Loại tài khoản";
            // 
            // lblTenHDV
            // 
            this.lblTenHDV.AutoSize = true;
            this.lblTenHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenHDV.Location = new System.Drawing.Point(670, 15);
            this.lblTenHDV.Name = "lblTenHDV";
            this.lblTenHDV.Size = new System.Drawing.Size(125, 23);
            this.lblTenHDV.TabIndex = 0;
            this.lblTenHDV.Text = "Tên tài khoản";
            // 
            // lblMaHDV
            // 
            this.lblMaHDV.AutoSize = true;
            this.lblMaHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHDV.Location = new System.Drawing.Point(39, 86);
            this.lblMaHDV.Name = "lblMaHDV";
            this.lblMaHDV.Size = new System.Drawing.Size(118, 23);
            this.lblMaHDV.TabIndex = 0;
            this.lblMaHDV.Text = "Số điện thoại";
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
            this.dgv_Accounts.Location = new System.Drawing.Point(21, 220);
            this.dgv_Accounts.Name = "dgv_Accounts";
            this.dgv_Accounts.RowHeadersWidth = 100;
            this.dgv_Accounts.RowTemplate.Height = 24;
            this.dgv_Accounts.Size = new System.Drawing.Size(1316, 402);
            this.dgv_Accounts.TabIndex = 14;
            this.dgv_Accounts.SelectionChanged += new System.EventHandler(this.dgv_Accounts_SelectionChanged);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1352, 722);
            this.Controls.Add(this.dgv_Accounts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_Main);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pn_Main.ResumeLayout(false);
            this.pn_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Accounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_QuayVe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.ComboBox cbb_LoaiAccounts;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtTenTk;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblLoaiHDV;
        private System.Windows.Forms.Label lblTenHDV;
        private System.Windows.Forms.Label lblMaHDV;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Accounts;
    }
}