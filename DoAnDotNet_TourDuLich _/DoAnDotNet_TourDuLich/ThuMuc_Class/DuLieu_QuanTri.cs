using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnDotNet_TourDuLich.ThuMuc_Class
{
    class DuLieu_QuanTri
    {
        public string strCon { get; set; }
        SqlConnection con;
        public DuLieu_QuanTri()
        {
            strCon = "Data Source= LAPTOP-QTRBNIQ4 ; Initial Catalog = QuanLyTour ;  Integrated Security = True ;";
            con = new SqlConnection(strCon);
        }
        public DataSet Load_LoaiAccounts(string strSelect,string TenBang)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                //string strSelect = "select *from LoaiAccounts";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataSet ds = new DataSet();
                da.Fill(ds,TenBang);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet Load_DataGridView(string strSelect,string TenBang)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                //string strSelect = "select *from Accounts";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataSet ds = new DataSet();
                da.Fill(ds, TenBang);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void LuuDataGridView( string strSelect, DataSet ds, string TenBang)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, TenBang);
                con.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("loi");
            }

        }
        public void XoaDuLieu_Dgv(DataSet ds,string TenBang,string KhoaChinh, string strSelect)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                DataRow dr = ds.Tables[TenBang].Rows.Find(KhoaChinh);
                if(dr!=null)
                {
                    dr.Delete();
                }
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, TenBang);
                con.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("loi");
            }
        }
        //QuanLyTour
        public DataSet Load_HuongDanVien_Name_id()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select MaHDV, TenHDV from HuongDanVien";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "HuongDanVien");
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet Load_LoaiTour()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select*from LoaiTour";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "LoaiTour");
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Load_Tour()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select * from Tour";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public int AddTour(Tour t)
        {

            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "insert into Tour values('"+t.MaTour+"', '"+t.MaHDV+"', N'"+t.TenTour+"',"+
                    " N'"+t.DiaDiem+"', "+t.ChiPhi+", '"+t.AnhBia+"', '"+t.LoaiTour+"')";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                cmd.ExecuteNonQuery();
                string strInsertChuongTrinhTour = "insert into ChuongTrinhTour values('" + t.MaTour + "', N'" + t.TenTour + "')";
                SqlCommand cmd1 = new SqlCommand(strInsertChuongTrinhTour, con);
                cmd1.ExecuteNonQuery();
                string strInsertChiTietChuongTrinhTour = "insert into ChiTietChuongTrinh(MaCTTour, Ngay) values('" + t.MaTour + "',1)";
                SqlCommand cmd2 = new SqlCommand(strInsertChiTietChuongTrinhTour,con);
                cmd2.ExecuteNonQuery();
                con.Close();
                kq = 1;
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }
        public int RemoveTour(string matour)
        {

            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strDeleteCTCT = "delete ChiTietChuongTrinh where MaCTTour='"+matour+"'";
                SqlCommand cmd1 = new SqlCommand(strDeleteCTCT, con);
                cmd1.ExecuteNonQuery();
                string strDeleteCT = "delete ChuongTrinhTour where MaCTTour = '"+matour+"'";
                SqlCommand cmd2 = new SqlCommand(strDeleteCT, con);
                cmd2.ExecuteNonQuery();
                string strInsert = "delete Tour where MaTour = '"+matour+"'; ";
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
        public int UpDateTour(Tour t)
        {

            int kq = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "update Tour set Huo_MaHDV = '"+t.MaHDV+"', TenTour = N'"+t.TenTour+"', DiaDiem = N'"+t.DiaDiem+"'"+
                    ", ChiPhi = '"+t.ChiPhi+"', AnhBia = '"+t.AnhBia+"', MaLoaiTour = '"+t.LoaiTour+"' where MaTour = '"+t.MaTour+"'; ";
                SqlCommand cmd = new SqlCommand(strInsert, con);
                kq=cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception)
            {
                kq = 0;
            }
            return kq;
        }

        //ChiTietChuongTrinhTour
        public DataSet Load_CbbTour()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select MaTour, TenTour from Tour";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Tour");
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet Load_SoNgayDi(string MaTour)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select Ngay, count(Ngay) as 'SoLuong' from ChiTietChuongTrinh where MaCTTour='"+MaTour+"'group by Ngay";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Ngay");
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Load_idNgayDi(string MaTour, int ngay)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select id from ChiTietChuongTrinh where MaCTTour = '" + MaTour+"' and Ngay = "+ngay+";";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable DemSoNgayDi(string MaTour)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select Max(Ngay) from ChiTietChuongTrinh where MaCTTour='"+MaTour+"'";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable Load_ChiTietChuongTrinh(int id)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string strSelect = "select*from ChiTietChuongTrinh where id="+id+";";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int ThemChiTietChuongTrinhTour(_ChiTietChuongTrinhTour ct)
        {
            try
            {
                if(con.State== ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "insert into ChiTietChuongTrinh values ('" + ct.MaCTTour + "'," + ct.Ngay + ",'" + ct.GioDi +
                    "','" + ct.GioDen + "',N'" + ct.DiemKhoiHanh + "',N'" + ct.DiemDen + "',N'" + ct.MoTa + "','" + ct.HinhAnh + "')";

                SqlCommand cmd = new SqlCommand(strInsert,con);
                int kq = cmd.ExecuteNonQuery();
                con.Close();
                return kq;
            }
            catch(Exception)
            {
                return -1;
            }
        }
        public int SuaChiTietChuongTrinhTour(_ChiTietChuongTrinhTour ct)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "update ChiTietChuongTrinh set Ngay = "+ct.Ngay+", GioDi = '"+ct.GioDi+"', GioDen = '"+ct.GioDen+
                    "', DiemKhoiHanh = N'"+ct.DiemKhoiHanh+"', DiemDen = N'"+ct.DiemDen+"', MoTa = N'"+ct.MoTa+"', HinhAnh = '"+ct.HinhAnh+
                    "'where id = "+ct.Id+"; ";

                SqlCommand cmd = new SqlCommand(strInsert, con);
                int kq = cmd.ExecuteNonQuery();
                con.Close();
                return kq;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int XoaChiTietChuongTrinhTour(int id)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string strInsert = "delete ChiTietChuongTrinh where id="+id+";";

                SqlCommand cmd = new SqlCommand(strInsert, con);
                int kq = cmd.ExecuteNonQuery();
                con.Close();
                return kq;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
