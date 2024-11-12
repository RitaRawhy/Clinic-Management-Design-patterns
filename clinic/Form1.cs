using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clinic
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           cn = new SqlConnection(@"Data Source=DESKTOP-PU165U4;Initial Catalog=clinic;Integrated Security=True");
        }
        private void koginbutton_Click(object sender, EventArgs e)
        {
            if (idtextbox.Text == "1" && passtextBox.Text == "1907" || idtextbox.Text == "2" && passtextBox.Text == "1911")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
          
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select id,password from login WHERE id ='" + idtextbox.Text + "' AND passwrod ='" + passtextBox + "' ", cn);
                cmd.Parameters.AddWithValue("id", idtextbox.Text);
                cmd.Parameters.AddWithValue("password", passtextBox.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                cn.Close();
            }




        }



        private void idtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
