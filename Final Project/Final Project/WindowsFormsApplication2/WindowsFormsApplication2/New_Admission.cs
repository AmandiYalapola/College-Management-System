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
    public partial class New_Admission : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ULT25NKH;Initial Catalog=college;Integrated Security=True");
        SqlCommand com;
        public New_Admission()
        {
            InitializeComponent();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void New_Admission_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;

            com.CommandText = "select max(NAID) from NewAdmission1";
            SqlDataAdapter DA = new SqlDataAdapter(com);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            L14.Text = (abc + 1).ToString();
          
         
           
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            string name = txtfullname.Text;
            string mname = txtmothername.Text;
            string gender = "";
            bool isChecked = radioButtonmale.Checked;
            if (isChecked)
            {
                gender = radioButtonmale.Text;
            }
            else
            {
                gender = radioButtonfemale.Text;
            }
            string dob = dateTimePickerDOB.Text;
            string mobile = textmobile.Text;
            string email = textBoxemail.Text;
            string semester = txtsemester.Text;
            string program = txtprogramming.Text;
            string sname = textschoolname.Text;
            string duration = txtduration.Text;
            string add = txtaddress.Text;

            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "insert into NewAdmission1 values ('" + txtfullname.Text + "','" + txtmothername.Text + "','" + gender + "','" + dateTimePickerDOB.Text + "','" + textmobile.Text + "','" + textBoxemail.Text + "','" + txtsemester.Text + "','" + txtprogramming.Text + "','" + textschoolname.Text + "','" + txtduration.Text + "','" + txtaddress.Text + "')";
            SqlDataAdapter DA = new SqlDataAdapter(com);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved. Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            



        }  
        private void buttonreset_Click(object sender, EventArgs e)
        {
            txtfullname.Clear();
            txtaddress.Clear();
            txtmothername.Clear();
            radioButtonfemale.Checked = false;
            radioButtonmale.Checked = false;
            textmobile.Clear();
            textBoxemail.Clear();
            txtprogramming.ResetText();
            txtsemester.ResetText();
            textschoolname.Clear();
            txtduration.ResetText();
        }

        public int Tables { get; set; }

        private void L14_Click(object sender, EventArgs e)
        {
           
        }
    }
}
