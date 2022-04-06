using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GmS5
{
    public partial class ViewEquipment : Form
    {
        public ViewEquipment()
        {
            InitializeComponent();
        }

        private void ViewEquipment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = DESKTOP-LLHBFGL\\SQLEXPRESS01; database = Gym1; integrated security = True";
            con.ConnectionString = "data source = DESKTOP-LLHBFGL\\SQLEXPRESS01; database = Gym1; integrated security = True";
           // SqlCommand eshte komanda per te insertuar te dhenat
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Equipment";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
           

          
        }
    }
}
