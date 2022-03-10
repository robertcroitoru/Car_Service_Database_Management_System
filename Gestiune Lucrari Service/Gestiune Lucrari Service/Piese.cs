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
    public partial class Piese : Form
    {
        string path = "Data Source=DESKTOP-HUEGF7L;Initial Catalog=Lucrari_Service_Auto;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        public Piese()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void Piese_Load(object sender, EventArgs e)
        {

        }

        public void display()
        {

            try
            {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Piese", con);

                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
