using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gestiune_Lucrari_Service
{
    public partial class Masini : Form
    {
        string path = "Data Source=DESKTOP-HUEGF7L;Initial Catalog=Lucrari_Service_Auto;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        public Masini()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void Masini_Load(object sender, EventArgs e)
        {

        }

        public void display()
        {

            try
            {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Masini", con);

                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complex4 c4 = new Complex4();
            c4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simple1 s1 = new Simple1();
            s1.Show();
        }
    }
}
