using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUSBinhGa
    {
        static DALBinhGa dalBinhGa = new DALBinhGa();

        public static DataTable showAll(string nameTB)
        {
            return dalBinhGa.showAll(nameTB);
        }

       
        public static bool Add(DTOBinhGa bg)
        {
            return dalBinhGa.Add(bg);
        }
        public static bool Edit(DTOBinhGa bg)
        {
            return dalBinhGa.Edit(bg);
        }
        public static bool Delete(string ma)
        {
            return dalBinhGa.Delete(ma);
        }
        
    }
}
