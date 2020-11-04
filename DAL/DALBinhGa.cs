using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBinhGa
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll(string nameTB)
        {
            
            return dalGeneric.selectAll(nameTB);
        }
        //Thêm sinh viên
        
        public bool Add(DTOBinhGa bg)
        {

            string insert = "insert into BinhGa values('"+bg.MaBinh+"','"+bg.TenBinh + "','" + bg.MaLoai+"','" + bg.MaMau + "'," + bg.MaKL+",'"+bg.MaNSX+"',"+
                            bg.SoLuong + "," + bg.DonGiaNhap + "," + bg.DonGiaBan + "," + bg.ThoiGianBH + ",@Anh,'" + bg.GhiChu + "')";

            /*string insert = "insert into BinhGa values(@MaBinh,@TenBinh,@MaLoai,@MaMau," +
                    "@MaKL,@MaNSX,@SoLuong,@DonGiaNhap,@DonGiaBan,@ThoiGianBaoHanh,@Anh,@GhiChu)";

            SqlConnection con = dBConnect.Connection();
            SqlCommand cmd = new SqlCommand(insert, con);
            con.Open();
            cmd.Parameters.AddWithValue("@MaBinh", bg.MaBinh);
            cmd.Parameters.AddWithValue("@TenBinh", bg.TenBinh);
            cmd.Parameters.AddWithValue("@MaLoai", bg.MaLoai);
            cmd.Parameters.AddWithValue("@MaMau", bg.MaMau);
            cmd.Parameters.AddWithValue("@MaKL", bg.MaKL);
            cmd.Parameters.AddWithValue("@MaNSX", bg.MaNSX);
            cmd.Parameters.AddWithValue("@SoLuong", bg.SoLuong);
            cmd.Parameters.AddWithValue("@DonGiaNhap", bg.DonGiaNhap);
            cmd.Parameters.AddWithValue("@DonGiaBan", bg.DonGiaBan);
            cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", bg.ThoiGianBH);
            cmd.Parameters.AddWithValue("@Anh", bg.Anh);
            cmd.Parameters.AddWithValue("@GhiChu", bg.GhiChu);*/
            return dalGeneric.ExecuteNonQueryIMG(insert,bg.Anh);
        }

        public bool Edit(DTOBinhGa bg)
        {
            string update = "update BinhGa set TenBinh='"+bg.TenBinh+"',MaLoai='"+bg.MaLoai+ "',MaMau ='"+bg.MaMau +
                    "',MaKL="+bg.MaKL+",MaNSX='"+bg.MaNSX+"',SoLuong="+bg.SoLuong+",DonGiaNhap="+bg.DonGiaNhap+",DonGiaBan="+bg.DonGiaBan +
                    ",ThoiGianBaoHanh="+bg.ThoiGianBH+",Anh=@Anh,GhiChu='"+bg.GhiChu+"' where  MaBinh='"+bg.MaBinh+"'";

            /*SqlConnection con = dBConnect.Connection();
            SqlCommand cmd = new SqlCommand(update, con);
            con.Open();
            cmd.Parameters.AddWithValue("@MaBinh", bg.MaBinh);
            cmd.Parameters.AddWithValue("@TenBinh", bg.TenBinh);
            cmd.Parameters.AddWithValue("@MaLoai", bg.MaLoai);
            cmd.Parameters.AddWithValue("@MaMau", bg.MaMau);
            cmd.Parameters.AddWithValue("@MaKL", bg.MaKL);
            cmd.Parameters.AddWithValue("@MaNSX", bg.MaNSX);
            cmd.Parameters.AddWithValue("@SoLuong", bg.SoLuong);
            cmd.Parameters.AddWithValue("@DonGiaNhap", bg.DonGiaNhap);
            cmd.Parameters.AddWithValue("@DonGiaBan", bg.DonGiaBan);
            cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", bg.ThoiGianBH);
            cmd.Parameters.AddWithValue("@Anh", bg.Anh);
            cmd.Parameters.AddWithValue("@GhiChu", bg.GhiChu);
            string a="";*/
            return dalGeneric.ExecuteNonQueryIMG(update,bg.Anh);
        }

        public bool Delete(string maBinh)
        {           
            string delete = string.Format("delete from  BinhGa where maBinh = '{0}'", maBinh);
            return dalGeneric.ExecuteNonQuery(delete);
        }
        
    }
}
