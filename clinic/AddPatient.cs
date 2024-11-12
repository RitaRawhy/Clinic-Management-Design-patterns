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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }
       
        private void clear()
        {
            PnametextBox.Text = "";
            datetextBox.Text = "";
            timetextBox.Text = "";
            phonetextBox.Text = "";
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

        }

    
    }
}
