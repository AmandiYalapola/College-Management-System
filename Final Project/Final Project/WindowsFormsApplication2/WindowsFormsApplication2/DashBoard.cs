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

namespace WindowsFormsApplication2
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ULT25NKH;Initial Catalog=college;Integrated Security=True");//connection string
        
        private void DashBoard_Load(object sender, EventArgs e)
        {// count students
            SqlCommand com = new SqlCommand();
            com.Connection = con;

            com.CommandText = "select count(*) from NewAdmission1";
            SqlDataAdapter DA = new SqlDataAdapter(com);
           DataTable dt = new DataTable();
            DA.Fill(dt);

            lblstudent.Text = dt.Rows[0][0].ToString();
            //count sum  fees
            SumFees();

            SqlCommand com2 = new SqlCommand();
            com2.Connection = con;

            com2.CommandText = "select count(*) from teacher";
            SqlDataAdapter DA2 = new SqlDataAdapter(com2);
            DataTable dt2 = new DataTable();
            DA2.Fill(dt2);

            lblteacher.Text = dt2.Rows[0][0].ToString();
            //count events
            SqlCommand com3 = new SqlCommand();
            com3.Connection = con;

            com3.CommandText = "select count(*) from Events";
            SqlDataAdapter DA3 = new SqlDataAdapter(com3);
            DataTable dt3 = new DataTable();
            DA3.Fill(dt3);

            lblevents.Text = dt3.Rows[0][0].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void SumFees()
        {
            SqlCommand com1 = new SqlCommand();
            com1.Connection = con;

            com1.CommandText = "select Sum(fees) from Fees";
            
            SqlDataAdapter DA1 = new SqlDataAdapter(com1);
            DataTable dt1 = new DataTable();
            DA1.Fill(dt1);

            lblfees.Text = "RS." + dt1.Rows[0][0].ToString() ;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
