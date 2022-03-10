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
   
    public partial class Lucrari : Form
    {

       

        string path = "Data Source=DESKTOP-HUEGF7L;Initial Catalog=Lucrari_Service_Auto;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;

        int ID;
        public Lucrari()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void Lucrari_Load(object sender, EventArgs e)
        {

        }

        public void display()
        {

            try
            {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Lucrari", con);

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
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Lucrari (AngajatID, ClientID, MasinaID, Nume_lucrare, Piese_necesare, Stare) values ('" + textAngajat.Text + "', '" + textClient.Text + "', '" + textMasina.Text + "', '" + textNume.Text + "', '" + textPiese.Text + "', '" + textStare.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Refresh();
                MessageBox.Show("O noua lucrare a fost adaugata!");
                display();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Lucrari set AngajatID='" + textAngajat.Text + "', ClientID='" + textClient.Text + "', MasinaID='" + textMasina.Text + "', Nume_lucrare='" + textNume.Text + "', Piese_Necesare='" + textPiese.Text + "', Stare='" + textStare.Text + "' where LucrareID='" + ID + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Refresh();
                MessageBox.Show("Datele au fost schimbate!");
                display();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Lucrari where LucrareID='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lucrarea a fost stearsa!");

                con.Close();
                Refresh();
                display();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textAngajat.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textClient.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textMasina.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textNume.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textPiese.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textStare.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complex2 c2 = new Complex2();
            c2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Simple2 s2 = new Simple2();
            s2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Simple3 s3 = new Simple3();
            s3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Simple4 s4 = new Simple4();
            s4.Show();
        }
    }
}
