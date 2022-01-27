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
namespace LOGIN
{
    public partial class register_page : Form
    {
        public register_page()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {   
        if(txtpassword.Text!=txtconfirmpass.Text || txtusername.Text=="" || txtpassword.Text=="" || txtconfirmpass.Text=="")
        {
            MessageBox.Show("Password should be same /all Fields are mandotory ", "sucessful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            Form1 f = new Form1();
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NRID5437\SQLEXPRESS;Initial Catalog=Pradeep;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("proc_login1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtconfirmpass.Text);
            cmd.Parameters.AddWithValue("@flag", "submit");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registration sucessful", "sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            f.Show();


        }
        }
        
    }
}
