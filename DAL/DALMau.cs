using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALMau
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("Mau");
        }
        //Thêm sinh viên
        public bool Add(DTOMau m)
        {
            string insert = string.Format("insert into Mau (MaMau,TenMau) values ('{0}','{1}')", m.MaMau, m.TenMau);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTOMau m)
        {
            string update = string.Format("update  Mau set  TenMau = '{0}' where MaMau = '{1}'", m.TenMau, m.MaMau);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string maMau)
        {
            string delete = string.Format("delete from  Mau where MaMau = '{0}'", maMau);
            return dalGeneric.ExecuteNonQuery(delete);
        }
    }
}
