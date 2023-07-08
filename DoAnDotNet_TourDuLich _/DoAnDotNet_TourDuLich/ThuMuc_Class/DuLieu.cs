using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnDotNet_TourDuLich
{
    class DuLieu
    {
        public string strCon { get; set; }
        SqlConnection con;
        public DuLieu()
        {
            strCon = "Data Source= LAPTOP-QTRBNIQ4 ; Initial Catalog = QuanLyTour ;  Integrated Security = True ;";
            con = new SqlConnection(strCon);
        }
        public DataTable AcCounts()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            string strSelect="select*from Accounts";
            SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
            DataTable dt=new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable HuongDanVien()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            string strSelect = "Select * from HuongDanVien";
            SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable LoaiHuongDanVien()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            string strSelect = "select * from LoaiHDV";
            SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public int ThemHuongDanVien(HuongDanVien a)
        {
            
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "set dateformat dmy "
                    + "insert into HuongDanVien values ('" + a.MaHDV + "'," + a.MaTK + "," + a.MaLoai
                    + ", N'" + a.TenHDV + "', N'" + a.GioiTinh + "', '" + a.SDT + "', '" + a.NgayVaoLam
                    + "', '" + a.CCCD + "')";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                con.Close();
                kq = 1;
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }
        public int XoaHuongDanVien(HuongDanVien a)
        {
            int kq = 0;
            try
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                string strDelete = "delete from HuongDanVien where MaHDV = '" + a.MaHDV + "'";
                SqlCommand cmd = new SqlCommand(strDelete, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch(Exception)
            {
                kq = 0;
            }
            return kq;
        }
        public int SuaHuongDanVien( HuongDanVien a)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strUpDate = "set dateformat dmy "+
                    "update HuongDanVien set MaHDV = '" +a.MaHDV+"', MaTK = "+a.MaTK
                    +", MaLoai = "+a.MaLoai+", TenHDV = N'"+a.TenHDV+"',GioiTinh = N'"+a.GioiTinh+"',NgayVaoLam = '"+
                    a.NgayVaoLam+"',CCCD = '"+a.CCCD+"' where MaHDV = '"+a.MaHDV+"'; ";
                SqlCommand cmd = new SqlCommand(strUpDate, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }
        //public string XuLy_YYYYMMDD(string date)
        //{
        //    string ngay, thang, nam;
        //    string year_month_day;
        //    ngay = date[0].ToString() + date[1].ToString();
        //    thang = date[3].ToString() + date[4].ToString();
        //    nam = date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString();
        //    year_month_day = nam + "-" + thang + "-" + ngay;
        //    return year_month_day;
        //}




        //code khach hang;
        public DataTable Ds_Tour()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "Select *from Tour";
                SqlDataAdapter da = new SqlDataAdapter(strSelect,con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(Exception)
            {
                return null;
            }
            
        }
        public DataTable Ds_Tour(string strSelect)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet LoaiTour()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string select = "select*from LoaiTour";
                SqlDataAdapter da = new SqlDataAdapter(select, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "LoaiTour");
                return ds;
            }
            catch(Exception)
            {
                return null;
            }
        }

        //dat tour
        public int LickMua(string MaKhach,ThuMuc_Class.Tour t,string ngaydi)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "set dateformat dmy " +
                " insert into DatVe values ('"+MaKhach+"', '"+t.MaTour+"', 1,"+t.ChiPhi+", GETDATE(),'"+ngaydi+"',"+t.ChiPhi+",0)";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }

        //dat tour
        public int LickMua(ThuMuc_Class.DatVe t)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string strInsert = "set dateformat mdy " +
                " insert into DatVe(MaKhach,MaTour,SoLuongVe,Tong,NgayDat,NgayDi,GiaVe)" +
                " values ('" + t.MaKhach + "', '" + t.MaTour + "', "+t.SoLuong+"," + t.TongTien.ToString() + ", GETDATE(),'" + t.NgayDi + "',"+t.GiaVe+")";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }

        //huy tour
        public int LickHuy(ThuMuc_Class.DatVe t)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "set dateformat mdy " +
                " insert into DatVe values ('" + t.MaKhach + "', '" + t.MaTour + "', " + t.SoLuong + "," + t.TongTien + ", GETDATE(),'" + t.NgayDi + "'," + t.GiaVe + ")";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }


        //load thong tin khach hang
        public DataTable LayMaKhach(string matk)
        {
            string strselect = "select* from KhachHang where MaTK = " + matk +";";
            SqlDataAdapter da = new SqlDataAdapter(strselect, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable LoadLichTourDaDat(string makhach)
        {
            

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select dv.MaTour,t.TenTour, dv.NgayDat from DatVe dv, Tour t where dv.MaKhach = '" + makhach + "'" +
                "and t.MaTour = dv.MaTour";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable LoadThongTinKhachHang(string makh)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select*from KhachHang where MaKhach='"+makh+"';";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Load ChiTietchuong trinh
        public DataTable LoadChiTietChuongTrinhTour(string matour, string ngay)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select ctt.id, ctt.MaCTTour, ctt.Ngay, ctt.GioDi, ctt.GioDen, " +
                    " ctt.DiemKhoiHanh, ctt.DiemDen, ctt.MoTa, ctt.HinhAnh" +
                     " from ChiTietChuongTrinh ctt, Tour t" +
                    " where t.MaTour = ctt.MaCTTour and t.MaTour = '" + matour + "' and ctt.Ngay=" + ngay + ";";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable LoadSoNgayDiCuaChuongTrinh(string matour)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select ctt.MaCTTour,ctt.Ngay, count(ctt.Ngay) as'SoLuong'" +
                                   "from ChiTietChuongTrinh ctt,Tour t "+
                                   "where ctt.MaCTTour = t.MaTour and t.MaTour = '"+matour+ "' group by ctt.Ngay, ctt.MaCTTour  order by ctt.Ngay";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet LoadTableGioiTinh()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select *from GioiTinh";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataSet ds = new DataSet();
                da.Fill(ds,"GioiTinh");
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private int KiemTraGioiTinh(string gioitinh)
        {
            if (gioitinh == "Nam")
            {
                return 1;
            }
            else
                return 0;
        }
        public int XacNhanThanhVien(string MaKhach, ThuMuc_Class.NguoiThan nt)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "SET DATEFORMAT mdy insert into ThanhVien values "+
                "('"+MaKhach+"',N'"+nt.TenThanhVien+"',"+KiemTraGioiTinh(nt.GioiTinh)+",'"+nt.NgaySinh+"','"+nt.CCCD+"','"+nt.MaTour+"')";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }


        //Xoa du lieu khu khac hang huy tour
        public int XoaThanhVien_HuyTour(string MaKhach, string MaTour)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "delete from ThanhVien where MaKhach = '"+MaKhach+"' and MaTour = '"+MaTour+"'";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }

        public int XoaDonDatTour_HuyTour(string MaKhach, string MaTour)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "delete from DatVe where MaKhach = '"+MaKhach+"' and MaTour = '"+MaTour+"' "+
                    " and NgayDat = (select MAX(NgayDat) from DatVe where MaKhach = '" + MaKhach + "' and MaTour = '" + MaTour + "')";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }
        //hoa don
        public DataTable HoaHon(string MaKhach)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select dv.MaTour, TenTour, SoLuongVe, GiaVe, NgayDat, NgayDi, Tong, TrangThai " +
                    "from DatVe dv, Tour t where dv.MaTour=t.MaTour and dv.MaKhach='" + MaKhach + "';";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable TimMaxAccount()
        {
            try
            {
                string strSelect = "select *from Accounts";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public DataTable TimMaxKhachHang()
        {
            try
            {
                string strSelect = "select *from KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int DangKy(string fullname, string tenDn, string sdt, string mail, string mk)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "Insert into Accounts values(" + 2 + ",N'" + fullname + "','" + tenDn + "','" + sdt + "','" + mail 
                    + "','" + mk + "')";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                kq=cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                kq = -1;
            }
            return kq;
        }

        public int DangKyKhachHang(string makhach, int matk,string tenKhach,string ngaysinh, string sdt)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "set dateformat dmy" +
                    " insert into KhachHang values ('"+makhach+"', "+matk+", N'"+tenKhach+"','"+ngaysinh+"' ,'"+sdt+"')";

                SqlCommand cmd = new SqlCommand(strInsert, con);
                kq = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                kq = -1;
            }
            return kq;
        }

        public int HuyDatTour(string MaKhach, string MaTour, string NgayDat)
        {
            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "set dateformat dmy delete DatVe where MaKhach = '"+MaKhach+"' and MaTour = '"+MaTour+
                    " ' and NgayDat = '"+NgayDat+"'";
                    
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                kq = 1;
                con.Close();
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }

    }



}
