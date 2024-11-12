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
    public partial class userlogin : Form
    {

       

        SqlConnection cn;
       SqlDataReader dr;
        public userlogin()
            {
                InitializeComponent();
       //         cn = new SqlConnection(@"Data Source=desktop-pu165u4;Initial Catalog=clinic2;Integrated Security=True");
            }

            private void login_Load(object sender, EventArgs e)
            {

            }

        void factorymethod()
        {
            string type;
            UserHandleFactory log = new UserHandleFactory();
            if (comboBox1.Text != "")
            {
                type = comboBox1.SelectedItem.ToString();
                IuserType user = log.GetType(type);
                user.login();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Choose Your Position !!");
            }

        }



        private void passtextBox_TextChanged(object sender, EventArgs e)
        {

        }


        public static string uname;
        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=desktop-pu165u4;Initial Catalog=clinic2;Integrated Security=True");
            string query = ("select name,password,type from users WHERE name ='" + name.Text.Trim() + "' AND password ='" + passtextBox.Text.Trim() + "' AND type ='" + comboBox1.Text.Trim() + "'");
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                uname = name.Text;
                factorymethod();             
            }
            else
            {
                MessageBox.Show("INVALID INPUTS !!");
            }
        }
           
            
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
