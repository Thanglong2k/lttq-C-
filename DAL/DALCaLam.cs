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
    public class DALCaLam
    {
        static DALGeneric dalGeneric = new DALGeneric();
        static DBConnect dBConnect = new DBConnect();

        static SqlConnection Conn = dBConnect.Connection();
        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("CaLam");
        }
        //Thêm sinh viên
        public bool Add(DTOCaLam cl)
        {
            string insert = string.Format("insert into CaLam (MaCa,TenCa) values ('{0}','{1}')",cl.MaCa, cl.TenCa);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTOCaLam cl)
        {
            string update = string.Format("update  CaLam set  TenCa = '{0}' where MaCa = '{1}'",cl.TenCa, cl.MaCa);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string maCL)
        {
            string delete = string.Format("delete from  CaLam where MaCa = '{0}'", maCL);
            return dalGeneric.ExecuteNonQuery(delete);
        }

       
    }
}
