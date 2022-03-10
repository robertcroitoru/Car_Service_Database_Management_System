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
    public partial class Simple4 : Form
    {
        string path = "Data Source=DESKTOP-HUEGF7L;Initial Catalog=Lucrari_Service_Auto;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        public Simple4()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        public void display()
        {

            try
            {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select L.LucrareID, L.Nume_Lucrare, A.Functie, A.Nume, A.Prenume from Lucrari L inner join Angajati A on A.AngajatID = L.AngajatID where A.Functie = 'mecanic' group by L.LucrareID, L.Nume_lucrare, A.Functie, A.Nume, A.Prenume", con);

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
