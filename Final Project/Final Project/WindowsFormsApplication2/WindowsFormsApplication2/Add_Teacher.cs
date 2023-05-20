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
    public partial class Add_Teacher : Form
    {
        public Add_Teacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save details
            string name = txtfname.Text;
            string gender = "";
            bool isChecked = radioButtonMale.Checked;

            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            string dob = dateTimePickerDOB.Text;
            string mobile = txtmobile.Text;
            string email = txtEmail.Text;
            string semester = txtsemester.Text;
            string program = txtprogramming.Text;
            string yer = txtDuration.Text;
            string adr = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-ULT25NKH;database = college;integrated security = True";
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "insert into teacher values ('" + txtfname.Text + "','" + gender + "','" + dateTimePickerDOB.Text + "','" + txtmobile.Text + "','" + txtEmail.Text + "','" + txtsemester.Text + "','" + txtprogramming.Text + "','" + txtDuration.Text + "','" + txtAddress.Text + "')";
            SqlDataAdapter DA = new SqlDataAdapter(com);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();

            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Add_Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
