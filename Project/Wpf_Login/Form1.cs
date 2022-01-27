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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text =="")
            {
                MessageBox.Show("Username password must recquired for login");
            }
            else{
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NRID5437\SQLEXPRESS;Initial Catalog=Pradeep;Integrated Security=True");
           // string queery="select count (*) from LOGINN where USERNAME='"+textBox1.Text+ "'and PASS='"+textBox2.Text+"'";
            SqlCommand cmd = new SqlCommand("proc_login1", con);
            cmd.CommandType = CommandType.StoredProcedure;
           
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
           // cmd.Parameters.AddWithValue("flag","select");
            ////if(dt.Rows[0][0].ToString()=="1")
            //{
            //    MessageBox.Show("LOGIN SUCESSFULLY", "sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Hide();
            //    Form2 FM = new Form2();
                
            //    FM.Show();
            //}
            //else
            //{
            //     MessageBox.Show("invalid creditionals", "sucessful", MessageBoxButtons.OK,MessageBoxIcon.Information); 
            //}


            SqlParameter p1 = new SqlParameter("@username",textBox1.Text);
            SqlParameter p2 = new SqlParameter("@password", textBox2.Text);
            SqlParameter p3 = new SqlParameter("@flag", "select");
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
          
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {


                rd.Read();
                MessageBox.Show("LOG IN Sucessful", "sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 FM = new Form2();

                FM.Show();
            }
            else 
            {
                MessageBox.Show("invalid creditionals", "sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            
            }
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            register_page rp = new register_page();
            rp.Show();
            this.Hide(); ;
        }

        
    }
}
