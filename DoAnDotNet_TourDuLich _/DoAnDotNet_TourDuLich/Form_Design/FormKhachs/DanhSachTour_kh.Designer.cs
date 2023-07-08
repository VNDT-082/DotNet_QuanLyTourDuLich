
namespace DoAnDotNet_TourDuLich.Form_Design.FormKhachs
{
    partial class DanhSachTour_kh
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.gr_loc = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_LoaiTour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_dsTour = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.gr_loc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DoAnDotNet_TourDuLich.Properties.Resources.bg3;
            this.panel2.Controls.Add(this.gr_loc);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.tb_dsTour);
            this.panel2.Location = new System.Drawing.Point(1, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1531, 907);
            this.panel2.TabIndex = 1;
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhach.ForeColor = System.Drawing.Color.Red;
            this.lblTenKhach.Location = new System.Drawing.Point(25, 62);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(52, 32);
            this.lblTenKhach.TabIndex = 4;
            this.lblTenKhach.Text = "ten";
            // 
            // gr_loc
            // 
            this.gr_loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gr_loc.Controls.Add(this.label3);
            this.gr_loc.Controls.Add(this.lblTenKhach);
            this.gr_loc.Controls.Add(this.comboBox1);
            this.gr_loc.Controls.Add(this.btnLoc);
            this.gr_loc.Controls.Add(this.label2);
            this.gr_loc.Controls.Add(this.cbb_LoaiTour);
            this.gr_loc.Controls.Add(this.label1);
            this.gr_loc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr_loc.Location = new System.Drawing.Point(14, 107);
            this.gr_loc.Name = "gr_loc";
            this.gr_loc.Size = new System.Drawing.Size(265, 353);
            this.gr_loc.TabIndex = 3;
            this.gr_loc.TabStop = false;
            this.gr_loc.Text = "Bộ lọc";
            this.gr_loc.Enter += new System.EventHandler(this.gr_loc_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 34);
            this.comboBox1.TabIndex = 3;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.Red;
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoc.Location = new System.Drawing.Point(64, 273);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(137, 43);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(6, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá:";
            // 
            // cbb_LoaiTour
            // 
            this.cbb_LoaiTour.FormattingEnabled = true;
            this.cbb_LoaiTour.Location = new System.Drawing.Point(6, 136);
            this.cbb_LoaiTour.Name = "cbb_LoaiTour";
            this.cbb_LoaiTour.Size = new System.Drawing.Size(236, 34);
            this.cbb_LoaiTour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại Tour:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Blue;
            this.btn_back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(29, 27);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(137, 43);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_dsTour
            // 
            this.tb_dsTour.AutoScroll = true;
            this.tb_dsTour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tb_dsTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb_dsTour.ColumnCount = 3;
            this.tb_dsTour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tb_dsTour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tb_dsTour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tb_dsTour.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb_dsTour.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_dsTour.Location = new System.Drawing.Point(301, 27);
            this.tb_dsTour.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.tb_dsTour.Name = "tb_dsTour";
            this.tb_dsTour.RowCount = 2;
            this.tb_dsTour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tb_dsTour.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tb_dsTour.Size = new System.Drawing.Size(1205, 736);
            this.tb_dsTour.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(25, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hello!!!";
            // 
            // DanhSachTour_kh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1530, 791);
            this.Controls.Add(this.panel2);
            this.Name = "DanhSachTour_kh";
            this.Text = "DanhSachTour_kh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachTour_kh_Load);
            this.panel2.ResumeLayout(false);
            this.gr_loc.ResumeLayout(false);
            this.gr_loc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TableLayoutPanel tb_dsTour;
        private System.Windows.Forms.GroupBox gr_loc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_LoaiTour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label label3;
    }
}