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
    public partial class Student_Individual_Detail : Form
    {
        public Student_Individual_Detail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-ULT25NKH;database = college;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText ="select * from NewAdmission1 where NAID = "+textBox1.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count !=0)
            {
                label14.Text = ds.Tables[0].Rows[0][1].ToString();
                label15.Text = ds.Tables[0].Rows[0][2].ToString();
                label16.Text = ds.Tables[0].Rows[0][3].ToString();
                label17.Text = ds.Tables[0].Rows[0][4].ToString();
                label18.Text = ds.Tables[0].Rows[0][5].ToString();
                label19.Text = ds.Tables[0].Rows[0][6].ToString();
                label20.Text = ds.Tables[0].Rows[0][7].ToString();
                label21.Text = ds.Tables[0].Rows[0][8].ToString();
                label22.Text = ds.Tables[0].Rows[0][9].ToString();
                label23.Text = ds.Tables[0].Rows[0][10].ToString();
                label24.Text = ds.Tables[0].Rows[0][11].ToString();
            }   
            else
            {
                MessageBox.Show("No Read Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label14.Text = "__________";
                label15.Text = "__________";
                label15.Text = "__________";
                label16.Text = "__________";
                label17.Text = "__________";
                label18.Text = "__________";
                label19.Text = "__________";
                label20.Text = "__________";
                label21.Text = "__________";
                label22.Text = "__________";
                label23.Text = "__________";
                label24.Text = "__________";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            label14.Text = "__________";
            label15.Text = "__________";
            label15.Text = "__________";
            label16.Text =  "__________";
            label17.Text =  "__________";
            label18.Text =  "__________";
            label19.Text = "__________";
            label20.Text = "__________";
            label21.Text = "__________";
            label22.Text =  "__________";
            label23.Text =  "__________";
            label24.Text = "__________";

            textBox1.Text = "";
        }
    }
}
