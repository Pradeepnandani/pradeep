using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace CALCULATOR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_ADD_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.Match(TXT_FIRSTNO.Text, "^[0-9]{1,10}[.]{0,2}").Success || !Regex.Match(TXT_SECONDNO.Text, "^[0-9]{1,10}[.]{0,2}").Success)
            { MessageBox.Show("enter alphanumeric values only", "save", MessageBoxButton.OKCancel, MessageBoxImage.Warning); }
            else
            {
                try
                {
                    double num1 = Convert.ToDouble(TXT_FIRSTNO.Text);
                    double num2 = Convert.ToDouble(TXT_SECONDNO.Text);
                    TXT_RESULT.Text = (num1 + num2).ToString();

                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NRID5437\SQLEXPRESS;Initial Catalog=Pradeep;Integrated Security=True");
                    string queery = "insert into calculator values(@First_number,@Second_number,@addition,@substraction,@multiplication,@Dividation)";
                    SqlCommand cmd = new SqlCommand(queery, con);
                    cmd.Parameters.AddWithValue("@First_number", TXT_FIRSTNO.Text);
                    cmd.Parameters.AddWithValue("@Second_number", TXT_SECONDNO.Text);
                    cmd.Parameters.AddWithValue("@addition", TXT_RESULT.Text);
                    cmd.Parameters.AddWithValue("@substraction", "-");
                    cmd.Parameters.AddWithValue("@multiplication", "-");
                    cmd.Parameters.AddWithValue("@Dividation", "-");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BTN_SUB_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.Match(TXT_FIRSTNO.Text, "^[0-9]{1,10}[.]{0,2}").Success || !Regex.Match(TXT_SECONDNO.Text, "^[0-9]{1,10}[.]{0,2}").Success)
            { MessageBox.Show("enter alphanumeric values only", "save", MessageBoxButton.OKCancel, MessageBoxImage.Warning); }
            else
            {
                try
                {
                    double num1 = Convert.ToDouble(TXT_FIRSTNO.Text);
                    double num2 = Convert.ToDouble(TXT_SECONDNO.Text);
                    TXT_RESULT.Text = (num1 - num2).ToString();
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NRID5437\SQLEXPRESS;Initial Catalog=Pradeep;Integrated Security=True");
                    string queery = "insert into calculator values(@First_number,@Second_number,@addition,@substraction,@multiplication,@Dividation)";
                    SqlCommand cmd = new SqlCommand(queery, con);
                    cmd.Parameters.AddWithValue("@First_number", TXT_FIRSTNO.Text);
                    cmd.Parameters.AddWithValue("@Second_number", TXT_SECONDNO.Text);
                    cmd.Parameters.AddWithValue("@addition", "-");
                    cmd.Parameters.AddWithValue("@substraction", TXT_RESULT.Text);
                    cmd.Parameters.AddWithValue("@multiplication", "-");
                    cmd.Parameters.AddWithValue("@Dividation", "-");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void BTN_MUL_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.Match(TXT_FIRSTNO.Text, "^[0-9]{1,10}[.]{0,2}").Success || !Regex.Match(TXT_SECONDNO.Text, "^[0-9]{1,10}[.]{0,2}").Success)
            { MessageBox.Show("enter alphanumeric values only", "save", MessageBoxButton.OKCancel, MessageBoxImage.Warning); }
            else
            {
                try
                {
                    double num1 = Convert.ToDouble(TXT_FIRSTNO.Text);
                    double num2 = Convert.ToDouble(TXT_SECONDNO.Text);
                    TXT_RESULT.Text = (num1 * num2).ToString();
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NRID5437\SQLEXPRESS;Initial Catalog=Pradeep;Integrated Security=True");
                    string queery = "insert into calculator values(@First_number,@Second_number,@addition,@substraction,@multiplication,@Dividation)";
                    SqlCommand cmd = new SqlCommand(queery, con);
                    cmd.Parameters.AddWithValue("@First_number", TXT_FIRSTNO.Text);
                    cmd.Parameters.AddWithValue("@Second_number", TXT_SECONDNO.Text);
                    cmd.Parameters.AddWithValue("@addition", "-");
                    cmd.Parameters.AddWithValue("@substraction", "-");
                    cmd.Parameters.AddWithValue("@multiplication", TXT_RESULT.Text);
                    cmd.Parameters.AddWithValue("@Dividation", "-");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch
                {
                }
            }
        }

        private void BTN_DIV_Click(object sender, RoutedEventArgs e)
        {
            if (!Regex.Match(TXT_FIRSTNO.Text, "^[0-9]{1,10}[.]{0,2}").Success || !Regex.Match(TXT_SECONDNO.Text, "^[0-9]{1,10}[.]{0,2}").Success)
            { MessageBox.Show("enter alphanumeric values only", "save", MessageBoxButton.OKCancel, MessageBoxImage.Warning); }
            else
            {
                try
                {
                    double num1 = Convert.ToDouble(TXT_FIRSTNO.Text);
                    double num2 = Convert.ToDouble(TXT_SECONDNO.Text);
                    TXT_RESULT.Text = (num1 / num2).ToString();
                    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-NRID5437\SQLEXPRESS;Initial Catalog=Pradeep;Integrated Security=True");
                    string queery = "insert into calculator values(@First_number,@Second_number,@addition,@substraction,@multiplication,@Dividation)";
                    SqlCommand cmd = new SqlCommand(queery, con);
                    cmd.Parameters.AddWithValue("@First_number", TXT_FIRSTNO.Text);
                    cmd.Parameters.AddWithValue("@Second_number", TXT_SECONDNO.Text);
                    cmd.Parameters.AddWithValue("@addition", "-");
                    cmd.Parameters.AddWithValue("@substraction", "-");
                    cmd.Parameters.AddWithValue("@multiplication", "-");
                    cmd.Parameters.AddWithValue("@Dividation", TXT_RESULT.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(DivideByZeroException EX)
                {
                    MessageBox.Show("you cant divide by zero");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TXT_FIRSTNO.Clear();
            TXT_SECONDNO.Clear();
            TXT_RESULT.Clear();
        }
    }
}
