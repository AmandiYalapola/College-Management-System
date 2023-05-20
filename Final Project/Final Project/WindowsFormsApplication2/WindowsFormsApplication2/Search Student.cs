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
    public partial class Search_Student : Form
    {
        public Search_Student()
        {
            InitializeComponent();
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet.Fees' table. You can move, or remove it, as needed.
            this.feesTableAdapter.Fill(this.collegeDataSet.Fees);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-ULT25NKH; database = college;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAdmission1.NAID as Student_ID, NewAdmission1.fname as Full_Name,NewAdmission1.mname as Mother_Name,NewAdmission1.gender as Gender,NewAdmission1.dob as Date_of_Birth,NewAdmission1.mobile as Mobile,NewAdmission1.email as Email_ID,NewAdmission1.semester,NewAdmission1.prog as Programming_Language,NewAdmission1.sname as School_Name,NewAdmission1.duration as Course_Duration,NewAdmission1.addres as Address,fees.fees as Fees from NewAdmission1 inner join fees on NewAdmission1.NAID=fees.NAID";
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-ULT25NKH; database = college;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission1 where NAID= "+textBox1.Text+"";
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
