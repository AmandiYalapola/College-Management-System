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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
            DisplayEvents();
        }

        private void DisplayEvents()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-ULT25NKH;database = college;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Events";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Reset()
        {
            txtDuration.Text ="";
            txtEvent.Text ="";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {//Add events
            if(txtEvent.Text==""||txtDuration.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = LAPTOP-ULT25NKH;database = college;integrated security = True";
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = "insert into Events values ('" + txtEvent.Text + "','" +dateTimePicker1.Text + "','" + txtDuration.Text + "')";
                    SqlDataAdapter DA = new SqlDataAdapter(com);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    MessageBox.Show("Event Added");
                    DisplayEvents();
                    Reset();
                }
                catch(Exception )
                {

                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //delete events
            if (MessageBox.Show("This will DELETE Your Data.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-ULT25NKH;database = college;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Events where EId=" + textBox1.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Reset();
                DisplayEvents();
                MessageBox.Show("Deletion Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
           }

        public object Key { get; set; }

        private void Events_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet3.Events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.collegeDataSet3.Events);

        }
    }
    }

