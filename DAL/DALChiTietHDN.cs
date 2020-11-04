using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALChiTietHDN
    {
        static DALGeneric dalGeneric = new DALGeneric();


        //Hiển thị tất cả sinh viên
        public DataTable showAll()
        {
            return dalGeneric.selectAll("ChiTietHDN");
        }
        //Thêm sinh viên
        public bool Add(DTOChiTietHDN cthdn)
        {
            string insert = string.Format("insert into ChiTietHDN (SoHDN,MaBinh,SoLuong,DonGia,GiamGia,ThanhTien) values ('{0}','{1}',{2},{3},{4},{5})",
                cthdn.SoHDN, cthdn.MaBinh, cthdn.SoLuong, cthdn.DonGia, cthdn.GiamGia, cthdn.ThanhTien);
            return dalGeneric.ExecuteNonQuery(insert);
        }
    }
}
