using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDotNet_TourDuLich
{
    public partial class frmDangKy : Form
    {
        DuLieu dl = new DuLieu();
        public frmDangKy()
        {
            InitializeComponent();
        }
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }


        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                Form1 f = new Form1();
                f.Show();

            }
        }

     

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            string tenDn = txt_tk.Text.ToString().Trim();
            string mk = txt_mk.Text.ToString().Trim();
            string remk = txt_remk.Text.ToString().Trim();
            string fullname = txt_fullname.Text.ToString().Trim();
            string mail = txt_Mail.Text.ToString().Trim();
            string sdt = txt_sdt.Text;
            string ngaysinh = String.Format("{0:dd/MM/yyyy}", dateTimePicker1.Value);

            if (tenDn == "" || mk == "" || remk == "" || mail == "" || fullname == ""|| sdt  == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {

                if (isEmail(mail) == false)
                {
                    MessageBox.Show("Mail không hợp lệ ! vui lòng kiểm tra lại. ", "Error", MessageBoxButtons.OK);
                    txt_Mail.Text = "";
                    txt_Mail.Focus();
                }
                else
                {
                    //string sql = "Select count(*) from Accounts where TenTK ='" + tk + ;
                    if (mk == remk)
                    {
                        int kq=dl.DangKy(fullname, tenDn, sdt, mail, mk);
                        if(kq==1)
                        {
                            int max_id = 0;
                            DataTable tb_taiKhoan = dl.TimMaxAccount();
                            foreach (DataRow dr in tb_taiKhoan.Rows)
                            {
                                int id = int.Parse(dr[0].ToString());
                                if (max_id < id)
                                {
                                    max_id = id;
                                }
                            }
                            DataTable tb_khachHang = dl.TimMaxKhachHang();
                            int max_kh = 0;
                            foreach (DataRow dr in tb_khachHang.Rows)
                            {
                                string makh = dr[0].ToString();
                                string sotk = "";
                                for (int i = 2; i < makh.Length; i++)
                                {
                                    sotk += makh[i];
                                }
                                int max_temp = int.Parse(sotk);
                                if (max_kh < max_temp)
                                {
                                    max_kh = max_temp;
                                }
                            }
                            string Ma_khachHang = "";
                            max_kh += 1;
                            if (max_kh<10)
                            {
                                Ma_khachHang="KH0" + max_kh.ToString();
                            }
                            else
                            {
                                Ma_khachHang = "KH" + max_kh.ToString();
                            }
                            int kq1 = dl.DangKyKhachHang(Ma_khachHang, max_id, fullname, ngaysinh ,sdt) ;
                            if(kq1==1)
                            {
                                this.Hide();
                                Form1 f = new Form1();
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Phần Nhập lại và phần mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Phần Nhập lại và phần mật khẩu không trùng khớp", "Thông báo", MessageBoxButtons.OK);
                    }

                }
            }
        }

        private void cb_HienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_HienMK.Checked == true)
            {
                txt_mk.PasswordChar = '\0';
            }
            else
            {
                txt_mk.PasswordChar = '*';
            }
        }

        private void cb_hienmk1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_hienmk1.Checked == true)
            {
                txt_remk.PasswordChar = '\0';
            }
            else
            {
                txt_remk.PasswordChar = '*';
            }
        }
    }
}
