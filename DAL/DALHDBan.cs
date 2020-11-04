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
    public class DALHDBan
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll(string nameTB)
        {
            return dalGeneric.selectAll(nameTB);
        }
        //Thêm sinh viên
        public bool Add(DTOHDBan hdb)
        {
            string insert = string.Format("insert into HoaDonBan (SoHDB,MaNV,NgayBan,MaKH,TongTien) values ('{0}','{1}','{2}','{3}',{4})",
                hdb.SoHDB, hdb.MaNV, hdb.NgayBan, hdb.MaKH, hdb.TongTien);
            return dalGeneric.ExecuteNonQuery(insert);
        }

       
    }
}
