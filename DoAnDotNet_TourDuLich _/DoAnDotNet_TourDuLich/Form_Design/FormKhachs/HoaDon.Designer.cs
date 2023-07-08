
namespace DoAnDotNet_TourDuLich.Form_Design.FormKhachs
{
    partial class HoaDon
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
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.col_maTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_soLuongVe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_GiaVe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NgayDat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_ngayDi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_tong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_trangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMatour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtngaydat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_maTour,
            this.col_TenTour,
            this.col_soLuongVe,
            this.col_GiaVe,
            this.col_NgayDat,
            this.col_ngayDi,
            this.col_tong,
            this.col_trangThai});
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.GridLines = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(46, 202);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(1291, 518);
            this.lvHoaDon.TabIndex = 0;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            this.lvHoaDon.SelectedIndexChanged += new System.EventHandler(this.lvHoaDon_SelectedIndexChanged);
            // 
            // col_maTour
            // 
            this.col_maTour.Text = "Mã Tour";
            this.col_maTour.Width = 104;
            // 
            // col_TenTour
            // 
            this.col_TenTour.Text = "Tên Tour";
            this.col_TenTour.Width = 249;
            // 
            // col_soLuongVe
            // 
            this.col_soLuongVe.Text = "Số lượng ";
            this.col_soLuongVe.Width = 115;
            // 
            // col_GiaVe
            // 
            this.col_GiaVe.Text = "Giá vé";
            this.col_GiaVe.Width = 148;
            // 
            // col_NgayDat
            // 
            this.col_NgayDat.Text = "Ngày đặt";
            this.col_NgayDat.Width = 176;
            // 
            // col_ngayDi
            // 
            this.col_ngayDi.Text = "Ngày ";
            this.col_ngayDi.Width = 123;
            // 
            // col_tong
            // 
            this.col_tong.Text = "Tổng tiền";
            this.col_tong.Width = 88;
            // 
            // col_trangThai
            // 
            this.col_trangThai.Text = "TrangThai";
            this.col_trangThai.Width = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(401, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào:";
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTenKhach.Location = new System.Drawing.Point(537, 49);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(137, 35);
            this.lblTenKhach.TabIndex = 1;
            this.lblTenKhach.Text = "Xin chào:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi tiết thông tin đặt tour:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Blue;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 14);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(137, 43);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Blue;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(1106, 125);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 43);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMatour
            // 
            this.txtMatour.Location = new System.Drawing.Point(389, 133);
            this.txtMatour.Name = "txtMatour";
            this.txtMatour.Size = new System.Drawing.Size(193, 30);
            this.txtMatour.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(289, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Tour";
            // 
            // txtngaydat
            // 
            this.txtngaydat.Location = new System.Drawing.Point(862, 133);
            this.txtngaydat.Name = "txtngaydat";
            this.txtngaydat.Size = new System.Drawing.Size(193, 30);
            this.txtngaydat.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(757, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày đặt";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DoAnDotNet_TourDuLich.Properties.Resources.bg3;
            this.ClientSize = new System.Drawing.Size(1391, 801);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtngaydat);
            this.Controls.Add(this.txtMatour);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenKhach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvHoaDon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader col_maTour;
        private System.Windows.Forms.ColumnHeader col_TenTour;
        private System.Windows.Forms.ColumnHeader col_soLuongVe;
        private System.Windows.Forms.ColumnHeader col_GiaVe;
        private System.Windows.Forms.ColumnHeader col_NgayDat;
        private System.Windows.Forms.ColumnHeader col_ngayDi;
        private System.Windows.Forms.ColumnHeader col_tong;
        private System.Windows.Forms.ColumnHeader col_trangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMatour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtngaydat;
        private System.Windows.Forms.Label label4;
    }
}