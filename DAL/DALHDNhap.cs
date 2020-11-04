using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHDNhap
    {
        static DALGeneric dalGeneric = new DALGeneric();
        

        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("HoaDonNhap");
        }
        public DataTable showAllHDN_CTHDN()
        {
            return dalGeneric.selectAllHDN_CTHDN("ShowAllHDN_CTHDN");
        }
        //Thêm sinh viên
        public bool Add(DTOHDNhap hdn)
        {
            string insert = string.Format("insert into HoaDonNhap (SoHDN,MaNV,NgayNhap,MaNCC,TongTien) values ('{0}','{1}','{2}','{3}',{4})",
                hdn.SoHDN, hdn.MaNV, hdn.NgayNhap, hdn.MaNCC, hdn.TongTien);
            return dalGeneric.ExecuteNonQuery(insert);
        }

    }
}
