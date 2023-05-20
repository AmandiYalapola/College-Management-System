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
    public partial class Remove_Student : Form
    {
        public Remove_Student()
        {
            InitializeComponent();
        }

        private void Remove_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet2.NewAdmission1' table. You can move, or remove it, as needed.
            this.newAdmission1TableAdapter.Fill(this.collegeDataSet2.NewAdmission1);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-ULT25NKH;database = college;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission1 ";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("This will DELETE Your Data.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-ULT25NKH;database = college;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewAdmission1 where NAID=" + textBox1.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Deletion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }







        }
    }
}
