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
    public partial class Complex3 : Form
    {
        string path = "Data Source=DESKTOP-HUEGF7L;Initial Catalog=Lucrari_Service_Auto;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        public Complex3()
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
                adpt = new SqlDataAdapter("SELECT C.ClientID, C.Nume, C.Prenume as Nume, ( SELECT COUNT(*) FROM Masini M WHERE M.ClientID = C.ClientID) AS Numar_Masini FROM Clienti C", con);

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
//"select M.An_fabricatie, COUNT(M.MasinaID) as nr_masini from Masini M group by M.An_fabricatie having COUNT(M.MasinaID) >= ( select top 1 COUNT(M1.MasinaID) from Masini M1 group by M1.An_fabricatie order by COUNT(M1.MasinaID) DESC )"
