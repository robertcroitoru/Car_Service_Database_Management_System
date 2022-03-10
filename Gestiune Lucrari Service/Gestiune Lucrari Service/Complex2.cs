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
    public partial class Complex2 : Form
    {
        string path = "Data Source=DESKTOP-HUEGF7L;Initial Catalog=Lucrari_Service_Auto;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;

        public Complex2()
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
                adpt = new SqlDataAdapter("SELECT Distinct A.Nume, A.Prenume from Angajati A, (select L.Stare, L.AngajatID from Lucrari L where L.Stare = 'final') as St where A.AngajatID = St.AngajatID", con);

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
//"SELECT Distinct A.Nume, A.Prenume from Angajati A, (select L.Stare, L.AngajatID from Lucrari L where L.Stare = @Stare) as St where A.AngajatID = St.AngajatID", con);