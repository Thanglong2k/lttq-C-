using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKhoiLuong
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("KhoiLuong");
        }
        //Thêm sinh viên
        public bool Add(DTOKhoiLuong kl)
        {
            string insert = string.Format("insert into KhoiLuong (MaKL) values ({0})", kl.MaKL);
            return dalGeneric.ExecuteNonQuery(insert);
        }


        public bool Delete(int maKL)
        {
            string delete = string.Format("delete from  KhoiLuong where MaKL = {0}", maKL);
            return dalGeneric.ExecuteNonQuery(delete);
        }
    }
}
