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

namespace clinic
{
    public partial class doctor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=desktop-pu165u4;Initial Catalog=clinic2;Integrated Security=True");
        public doctor()
        {
            InitializeComponent();
          
        }

        private void doctor_Load(object sender, EventArgs e)
        {
            label1.Text = userlogin.uname;
            display();
        }

        private void display()
        {

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from appointments where drname ='" +label1.Text+ "'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogin ff = new userlogin();
            ff.Show();
        }
    }
}
