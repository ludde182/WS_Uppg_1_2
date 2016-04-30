using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WS_Uppg_1_2;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace WF_Uppg_1
{
    class DAL
    {
        SqlConnection con = new SqlConnection();

        // DAL Constructor - connection string
        public DAL()
        {
            con.ConnectionString = 
                "user id=root;" +                            
                "password=root;server=DESKTOP-LAMR8JS;" +                         
                "Trusted_Connection=yes;" +
                "database=database; " +              
                "connection timeout=30";
        }



        //Read a file method
        public string TxtFile(string s)
        {
            string filepath = "C:\\Users\\Ludde\\Desktop\\";
            StreamReader sr = File.OpenText(filepath + s + ".txt");
           string line = sr.ReadToEnd();

            return line;
        }


        //Get Reservations method
        public List<string> GetReservations()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Reservation", con);
            DataSet ds = new DataSet();
      //      adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(ds, "Reservation");
            List<string> customerList = new List<string>();
            foreach (DataRow dataRow in ds.Tables["Reservation"].Rows)
            {
                customerList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
            }

            return customerList;
        }


        //Get Customers method
        public List<string> GetCustomers()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", con);
            DataSet ds = new DataSet();
       //     adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(ds, "Customer");
            List<string> customerList = new List<string>();
            foreach (DataRow dataRow in ds.Tables["Customer"].Rows)
            {
                customerList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            return customerList;
        }

        public bool Exists(string path)
        {
            string tmp = "C:\\Users\\Ludde\\Desktop\\" + path + ".txt";
            return File.Exists(tmp);
        }

    }
}
