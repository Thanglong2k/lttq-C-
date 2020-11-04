using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSChiTietHDN
    {
        static DALChiTietHDN dalChiTietHDN = new DALChiTietHDN();

        public static DataTable showAll()
        {
            return dalChiTietHDN.showAll();
        }

        public static bool Add(DTOChiTietHDN cthdn)
        {
            return dalChiTietHDN.Add(cthdn);
        }
    }
}
