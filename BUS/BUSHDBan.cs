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
    public class BUSHDBan
    {
        static DALHDBan dalHDBan = new DALHDBan();

        public static DataTable showAll(string nameTB)
        {
            return dalHDBan.showAll(nameTB);
        }

        public static bool Add(DTOHDBan hdb)
        {
            return dalHDBan.Add(hdb);
        }
        
    }
}
