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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ULT25NKH;Initial Catalog=college;Integrated Security=True");
        SqlCommand com;
        private void txtregnumber_TextChanged(object sender, EventArgs e)
        {



            if(txtregnumber.Text != "")
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname,mname,duration from NewAdmission1 where NAID ='" + txtregnumber.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if(ds.Tables[0].Rows.Count !=0)
                {
                    fnamelbl.Text = ds.Tables[0].Rows[0][0].ToString();
                    mnamelbl.Text = ds.Tables[0].Rows[0][1].ToString();
                    durationlbl.Text = ds.Tables[0].Rows[0][2].ToString();
                } 
                else
                {
                    fnamelbl.Text = "________";
                    mnamelbl.Text = "________";
                    durationlbl.Text = "________";
                }
            } 
            else
            {
                txtregnumber.Text = "";
                txtregnumber.Text = "";
                fnamelbl.Text = "________";
                mnamelbl.Text = "________";
                durationlbl.Text = "________";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //upgrade semester
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fees where NAID = " + txtregnumber.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count == 0)
            {

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = LAPTOP-ULT25NKH;database = college;integrated security = True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                cmd1.CommandText = "insert into fees (NAID,fees) values (" + txtregnumber.Text + "," + txtfees.Text + ")";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                if (MessageBox.Show("Fees Submission Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtregnumber.Text = "";
                    txtfees.Text = "";
                    fnamelbl.Text = "________";
                    mnamelbl.Text = "________";
                    durationlbl.Text = "________";
                }
            }
            else
            {
                MessageBox.Show("Fees is AllReady Submitted.");
                txtregnumber.Text = "";
                txtfees.Text = "";
                fnamelbl.Text = "________";
                mnamelbl.Text = "________";
                durationlbl.Text = "________";
            }



        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }
    }
}
