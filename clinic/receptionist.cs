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

namespace clinic
{
    public partial class receptionist : Form
    {
        public receptionist()
        {
            InitializeComponent();
            
            DateTime date = Convert.ToDateTime(dateTimePicker1.Value);
        }
/*
        void bridgeusage()
        {
            string drname;
            string pname;
            string time;
            pname = pnametextBox.Text;
            drname = drnametextBox.Text;
            time = timetextBox.Text;
            if (comboBox1.SelectedItem== "examination")
            {
                doctors rev = new doctors(new examination());
                MessageBox.Show(rev.reservations(drname, pname, time));
            }
            else if(comboBox1.SelectedItem == "consultation")
            {
                doctors cons = new doctors(new consultations());
                MessageBox.Show(cons.reservations(drname, pname, time));
            }          
        }
*/
        /*
        void proxyimplement()
        {
           
            string drname;
            string pname;
            string time;
            pname = pnametextBox.Text;
            drname = drnametextBox.Text;
            time = timetextBox.Text;
            proxy pp = new proxy();
            listBox1.Items.Add( pp.schedule_appointment(pname,time,drname));

        }
        */
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatepbutton_Click(object sender, EventArgs e)
        {
            update();
            display();
            clear();
        }

        private void addpbutton_Click(object sender, EventArgs e)
        {
            insert();
            display();
            clear();
        }

        private void clear()
        {
            drnametextBox.Text = "";
            pnametextBox.Text = "";
            timetextBox.Text = "";
            comboBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogin ff = new userlogin();
            ff.Show();
        }
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
    
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        SqlConnection con = new SqlConnection(@"Data Source=desktop-pu165u4;Initial Catalog=clinic2;Integrated Security=True");
        private void insert()
        {
            if (pnametextBox.Text != "" && timetextBox.Text != "" && drnametextBox.Text != "" && comboBox1.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("insert into appointments(drname,pname,time,type,date) values(@drname,@pname,@time,@type,@date)", con);
                cmd.Parameters.AddWithValue("@drname", drnametextBox.Text);
                cmd.Parameters.AddWithValue("@pname", pnametextBox.Text);
                cmd.Parameters.AddWithValue("@time", timetextBox.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("please provide details");
            }
        }
        private void delete()
        {
            if (pnametextBox.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete from appointments where pname=@pname", con);
                cmd.Parameters.AddWithValue("@pname", pnametextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted Successfully");
            }
            else
            {
                MessageBox.Show("please enter id to delete");
            }
        }
        private void update()
        {
            if (pnametextBox.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("update appointments set drname=@drname, time=@time where pname=@pname", con);
               
                cmd.Parameters.AddWithValue("@drname", drnametextBox.Text);
                cmd.Parameters.AddWithValue("@pname", pnametextBox.Text);
                cmd.Parameters.AddWithValue("@time", timetextBox.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated Successfully");
            }
            else
            {
                MessageBox.Show("please enter details to update");
            }
        }

        private void display()
        {

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from appointments", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void deletepbutton_Click(object sender, EventArgs e)
        {
            delete();
            clear();
            display();
        }

        private void receptionist_Load(object sender, EventArgs e)
        {
            display();  
        }
    }
}
