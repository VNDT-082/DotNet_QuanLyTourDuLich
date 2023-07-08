
namespace DoAnDotNet_TourDuLich.Form_Design.FormKhachs
{
    partial class XemLich
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
            this.lv_Lich = new System.Windows.Forms.ListView();
            this.cloMaTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayDi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gr_loc = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.gr_loc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::DoAnDotNet_TourDuLich.Properties.Resources.bg3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lv_Lich);
            this.panel2.Controls.Add(this.gr_loc);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1450, 736);
            this.panel2.TabIndex = 2;
            // 
            // lv_Lich
            // 
            this.lv_Lich.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Lich.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cloMaTour,
            this.colTenTour,
            this.colNgayDi});
            this.lv_Lich.Enabled = false;
            this.lv_Lich.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lv_Lich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lv_Lich.GridLines = true;
            this.lv_Lich.HideSelection = false;
            this.lv_Lich.Location = new System.Drawing.Point(223, 169);
            this.lv_Lich.Name = "lv_Lich";
            this.lv_Lich.Size = new System.Drawing.Size(1143, 425);
            this.lv_Lich.TabIndex = 4;
            this.lv_Lich.UseCompatibleStateImageBehavior = false;
            this.lv_Lich.View = System.Windows.Forms.View.Details;
            // 
            // cloMaTour
            // 
            this.cloMaTour.Text = "Mã Tour";
            this.cloMaTour.Width = 116;
            // 
            // colTenTour
            // 
            this.colTenTour.Text = "Tên Tour";
            this.colTenTour.Width = 793;
            // 
            // colNgayDi
            // 
            this.colNgayDi.Text = "Ngày Đi";
            this.colNgayDi.Width = 220;
            // 
            // gr_loc
            // 
            this.gr_loc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gr_loc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gr_loc.Controls.Add(this.label3);
            this.gr_loc.Controls.Add(this.lblTenKhach);
            this.gr_loc.Controls.Add(this.lblTong);
            this.gr_loc.Controls.Add(this.label2);
            this.gr_loc.Controls.Add(this.label1);
            this.gr_loc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gr_loc.Location = new System.Drawing.Point(223, 27);
            this.gr_loc.Name = "gr_loc";
            this.gr_loc.Size = new System.Drawing.Size(1143, 115);
            this.gr_loc.TabIndex = 3;
            this.gr_loc.TabStop = false;
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
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenKhach.ForeColor = System.Drawing.Color.Red;
            this.lblTenKhach.Location = new System.Drawing.Point(164, 30);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(52, 32);
            this.lblTenKhach.TabIndex = 4;
            this.lblTenKhach.Text = "ten";
            // 
            // lblTong
            // 
            this.lblTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTong.Location = new System.Drawing.Point(1057, 73);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(20, 22);
            this.lblTong.TabIndex = 2;
            this.lblTong.Text = "0";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(972, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lời nhắc:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hãy kiểm tra lịch thường xuyên bạn nhé!!!:";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Blue;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // XemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 737);
            this.Controls.Add(this.panel2);
            this.Name = "XemLich";
            this.Text = "XemLich";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.XemLich_Load);
            this.panel2.ResumeLayout(false);
            this.gr_loc.ResumeLayout(false);
            this.gr_loc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gr_loc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListView lv_Lich;
        private System.Windows.Forms.ColumnHeader cloMaTour;
        private System.Windows.Forms.ColumnHeader colTenTour;
        private System.Windows.Forms.ColumnHeader colNgayDi;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label2;
    }
}