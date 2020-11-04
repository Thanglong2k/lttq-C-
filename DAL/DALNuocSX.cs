using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNuocSX
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("NuocSX");
        }
        //Thêm sinh viên
        public bool Add(DTONuocSX nsx)
        {
            string insert = string.Format("insert into NuocSX (MaNSX,TenNSX) values ('{0}','{1}')", nsx.MaNSX, nsx.TenNSX);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTONuocSX nsx)
        {
            string update = string.Format("update  NuocSX set  Tennsx = '{0}' where Mansx = '{1}'", nsx.TenNSX, nsx.MaNSX);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string maNSX)
        {
            string delete = string.Format("delete from  NuocSX where Mansx = '{0}'", maNSX);
            return dalGeneric.ExecuteNonQuery(delete);
        }
    }
}
