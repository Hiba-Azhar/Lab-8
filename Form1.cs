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

namespace Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string con_string = @"Data Source=(localdb)\ProjectsV12;Initial Catalog=SpaceX;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(con_string);
            string query = $@"Select * from Record";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            sda.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];
        }
    }
}
