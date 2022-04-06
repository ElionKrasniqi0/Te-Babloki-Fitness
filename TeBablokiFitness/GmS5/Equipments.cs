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
    public partial class Equipments : Form
    {
        public Equipments()
        {
            InitializeComponent();
        }

       // private void btnSave_CheckedChanged(object sender, EventArgs e)
        //{
         //   String EquipName = txtEquipName.Text;
           // String Description = txtDescription.Text;
          //  String MUsed = txtMusclesUsed.Text;
           // String DDate = dateTimePickerDeliveryDate.Text;
            //Int64 Cost = Int64.Parse(txtCost.Text);

           // SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = DESKTOP-LLHBFGL\\SQLEXPRESS01; database = Gym1; integrated security = True"; 
              //  SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;

          //  cmd.CommandText = "insert into Equipment ( EquipName,EDescription,MUsed,DDate,Cost) values ('" + EquipName + "','" + Description + "','" + MUsed + "','" + DDate + "','" + Cost +  "')";
           // SqlDataAdapter DA = new SqlDataAdapter(cmd);
            //DataSet DS = new DataSet();
             //DA.Fill(DS);
            //MessageBox.Show("Data Saved. ", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void btnReset_CheckedChanged(object sender, EventArgs e)
        //{
          //  txtEquipName.Clear();
            //txtDescription.Clear();
            //txtMusclesUsed.Clear();
            //txtCost.Clear();
            //dateTimePickerDeliveryDate.Value = DateTime.Now;
        //}

        //private void ViewEquipments_CheckedChanged(object sender, EventArgs e)
        //{
         //   ViewEquipment ve = new ViewEquipment();
          //  ve.Show();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            String EquipName = txtEquipName.Text;
            String Description = txtDescription.Text;
            String MUsed = txtMusclesUsed.Text;
            String DDate = dateTimePickerDeliveryDate.Text;
            Int64 Cost = Int64.Parse(txtCost.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-LLHBFGL\\SQLEXPRESS01; database = Gym1; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Equipment ( EquipName,EDescription,MUsed,DDate,Cost) values ('" + EquipName + "','" + Description + "','" + MUsed + "','" + DDate + "','" + Cost + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            
            MessageBox.Show("Data Saved. ", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEquipName.Clear();
            txtDescription.Clear();
            txtMusclesUsed.Clear();
            txtCost.Clear();
            dateTimePickerDeliveryDate.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewEquipment ve = new ViewEquipment();
            ve.Show();
        }
    }
 }

