using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKhachHang
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("KhachHang");
        }
        //Thêm sinh viên
        public bool Add(DTOKhachHang kh)
        {
            string insert = string.Format("insert into KhachHang (MaKH,TenKH,DiaChi,DienThoai) values ('{0}','{1}','{2}','{3}')",
                kh.MaKH, kh.TenKH,kh.DiaChi,kh.DienThoai);
            return dalGeneric.ExecuteNonQuery(insert);
        }
        public bool Edit(DTOKhachHang kh)
        {
            string update = string.Format("update  KhachHang set  TenKH = '{0}', DiaChi = '{1}', DienThoai = '{2}' where MaKH = '{3}'", 
                kh.TenKH,kh.DiaChi,kh.DienThoai,kh.MaKH);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string kh)
        {
            string delete = string.Format("delete from  KhachHang where MaKH = '{0}'", kh);
            return dalGeneric.ExecuteNonQuery(delete);
        }

    }
}
