using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLoaiGa
    {
        static DALGeneric dalGeneric = new DALGeneric();

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("LoaiGa");
        }
        //Thêm sinh viên
        public bool Add(DTOLoaiGa lg)
        {
            string insert = string.Format("insert into LoaiGa (MaLoai,TenLoai) values ('{0}','{1}')", lg.MaLoai, lg.TenLoai);
            return dalGeneric.ExecuteNonQuery(insert);
        }

        public bool Edit(DTOLoaiGa lg)
        {
            string update = string.Format("update  LoaiGa set  TenLoai = '{0}' where MaLoai = '{1}'", lg.TenLoai, lg.MaLoai);
            return dalGeneric.ExecuteNonQuery(update);
        }

        public bool Delete(string maLoai)
        {
            string delete = string.Format("delete from  LoaiGa where MaLoai = '{0}'", maLoai);
            return dalGeneric.ExecuteNonQuery(delete);
        }
    }
}
