using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WF_Uppg_1;
using WS_Uppg_1_2;

namespace WS_Uppg_1_2
{
    public class Controller
    {
        private DAL dal = new DAL();

        public List<string> GetReservations()
        {
            return dal.GetReservations();
        }

        public List<string> GetCustomers()
        {
            return dal.GetCustomers();
        }

        public string TxtFile(string s)
        {
            return dal.TxtFile(s);
        }

        public bool Exists(string s)
        {
            return dal.Exists(s);
        }

    }
}

