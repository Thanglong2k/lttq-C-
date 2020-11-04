using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALNhanVien
    {
        static DALGeneric dalGeneric = new DALGeneric();
        
        //Hiển thị tất cả sinh viên
        public DataTable showAll(string nameTB)
        {
            return dalGeneric.selectAll(nameTB);
        }
        //Thêm sinh viên
        public bool Add(DTONhanVien nv)
        {
            string insert = string.Format("insert into NhanVien (MaNV,TenNV,GioiTinh,NgaySinh,DienThoai,DiaChi,MaCa,MaCV) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                    nv.MaNV, nv.TenNV, nv.GioiTinh, nv.NgaySinh, nv.DienThoai, nv.DiaChi, nv.MaCa, nv.MaCV);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTONhanVien nv)
        {
            
            string update = string.Format("update  NhanVien set  TenNV = '{0}', GioiTinh = '{1}', NgaySinh = '{2}', DienThoai = '{3}', DiaChi = '{4}', MaCa = {5}, MaCV = '{6}' where MaNV = '{7}'",
                   nv.TenNV, nv.GioiTinh, nv.NgaySinh, nv.DienThoai, nv.DiaChi, nv.MaCa, nv.MaCV, nv.MaNV);
               
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string maNV)
        {             
            string delete = string.Format("delete from  NhanVien where MaNV = '{0}'", maNV);                
            return dalGeneric.ExecuteNonQuery(delete);
        }

        public DataSet NVBanItNhat(string maNV)
        {
            SqlParameter[] sql = new SqlParameter[1];
            sql[0] = new SqlParameter("@MaNV",maNV);
            return dalGeneric.rpDataset("SP_NV",sql);
        }
    }
}
