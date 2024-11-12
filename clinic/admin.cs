using System;
using System.IO;
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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (o.ShowDialog(this) == DialogResult.OK)
            {
                   
                if ((mystream = o.OpenFile()) != null)
                    {
                    string FileName = o.FileName;
                    pictureBox1.Load(FileName);
                       
                    }
                
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
           

        }


        SqlConnection con = new SqlConnection(@"Data Source=desktop-pu165u4;Initial Catalog=clinic2;Integrated Security=True");
        private void display()
        {
           
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from users", con);
            adapt.Fill(dt);
            admindataGridView.DataSource = dt;
            con.Close();
        }
       
        private void insert()
        {
            

            if (nametextBox.Text != "" && idtextBox.Text != "" && passtextBox.Text != "" && comboBox1.Text != "")
            {
              
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into users(id,name,password,type,image) values(@id,@name,@password,@type,@image)", con);
                cmd.Parameters.AddWithValue("@name", nametextBox.Text);
                cmd.Parameters.AddWithValue("@id", idtextBox.Text);
                cmd.Parameters.AddWithValue("@password", passtextBox.Text);
                cmd.Parameters.AddWithValue("@type", comboBox1.Text);
                MemoryStream stream = new MemoryStream();
                pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] image = stream.ToArray();
                cmd.Parameters.AddWithValue("@image",image);
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
            if (idtextBox.Text != "")
            {
              
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from users where id=@id", con);
                cmd.Parameters.AddWithValue("@id", idtextBox.Text);
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
            if (idtextBox.Text != "")
            {
               
                con.Open();
                SqlCommand cmd = new SqlCommand("update users set name=@name, password=@password where id=@id", con);
                cmd.Parameters.AddWithValue("@id", idtextBox.Text);
                cmd.Parameters.AddWithValue("@name", nametextBox.Text);
                cmd.Parameters.AddWithValue("@password", passtextBox.Text);
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
        private void clear()
        {
            idtextBox.Text = "";
            nametextBox.Text = "";
            passtextBox.Text = "";
            comboBox1.Text = "";
        }

        private void adminaddbutton_Click(object sender, EventArgs e)
        {
            insert();
            display();
            clear();
        }

        private void adminupdatebutton_Click(object sender, EventArgs e)
        {
            update();
            display();
            clear();
        }

        private void admindeletebutton_Click(object sender, EventArgs e)
        {
            delete();
            clear();
            display();
           
        }

        private void admin_Load(object sender, EventArgs e)
        {
            display();


            con.Open();
            SqlCommand cmd = new SqlCommand("select name from users",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
        }
        
   
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userlogin ff = new userlogin();
            ff.Show();
        }

        void search()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           // SqlCommand cmd = new SqlCommand("Select * from users where name ='"+comboBox2.Text+"'", con);

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from users where name ='" + comboBox2.Text + "'", con);
            adapt.Fill(dt);
            admindataGridView.DataSource = dt;
            con.Close();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            display();
        }
    }
    
}
