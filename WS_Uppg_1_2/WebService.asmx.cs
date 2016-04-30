using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_Uppg_1_2
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://www.bff.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        Controller ctrl = new Controller();

        [WebMethod]
        public bool Exists(string s)
        {
            return ctrl.Exists(s);
        }

        [WebMethod]
        public string TxtFile(string s)
        {
            return ctrl.TxtFile(s);
        }

        [WebMethod]
        public List<String> GetCustomers()
        {
            return ctrl.GetCustomers();
        }


        [WebMethod]
        public List<string> GetReservations()
        {
            return ctrl.GetReservations();
        }


    }
}
