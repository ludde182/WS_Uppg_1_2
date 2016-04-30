using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Uppg_1.ServiceReference1;
using WS_Uppg_1_2;

namespace WF_Uppg_1
{
    public partial class Form1 : Form
    {
        WebServiceSoapClient client = new WebServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = txtPath.Text;
            if (client.Exists(tmp))
                txtReader.Text = client.TxtFile(tmp);
            else
                txtReader.Text = "File not found. Please check if the file exists.";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtboxup2.Text = null;
            List<string> list = client.GetReservations();
            foreach (string s in list)
            {
                string temp = "\n";
                txtboxup2.Text += s + temp;
            }
        }

        private void btn_getCust_Click(object sender, EventArgs e)
        {
            try
            {
                txtboxup2.Text = null;
                List<string> list = client.GetCustomers();
                foreach (string s in list)
                {
                    string temp = "\n";
                    txtboxup2.Text += s + temp;
                }
            }

            catch (Exceptions err)
            {
                txtboxup2.Text = err.errMsg;
            }

        }
    }
}
