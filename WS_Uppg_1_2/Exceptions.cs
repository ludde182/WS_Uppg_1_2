using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Uppg_1_2
{
   public class Exceptions : Exception
    {

        public string errMsg { get; set; }

        public Exceptions(string s)
        {
            errMsg = s;
        }
    }
}