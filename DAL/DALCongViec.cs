using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAlCongViec
    {
        static DALGeneric dalGeneric = new DALGeneric();


        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("CongViec");
        }
        //Thêm sinh viên
        public bool Add(DTOCongViec cv)
        {
            string insert = string.Format("insert into CongViec (MaCV,TenCV) values ('{0}','{1}')", cv.MaCV, cv.TenCV);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTOCongViec cv)
        {
            string update = string.Format("update  CongViec set  TenCV = '{0}' where MaCV = '{1}'", cv.TenCV, cv.MaCV);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string maCV)
        {
            string delete = string.Format("delete from  CongViec where MaCV = '{0}'", maCV);
            return dalGeneric.ExecuteNonQuery(delete);
        }
    }
}
