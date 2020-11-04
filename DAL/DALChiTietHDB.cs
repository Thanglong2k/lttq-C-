using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALChiTietHDB
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("ChiTietHDB");
        }
        //Thêm sinh viên
        public bool Add(DTOChiTietHDB cthdb)
        {
            string insert = string.Format("insert into ChiTietHDB (SoHDB,MaBinh,SoLuong,GiamGia,ThanhTien) values ('{0}','{1}',{2},{3},{4})",
                cthdb.SoHDB, cthdb.MaBinh, cthdb.SoLuong, cthdb.GiamGia, cthdb.ThanhTien);
            return dalGeneric.ExecuteNonQuery(insert);
        }
    }
}
