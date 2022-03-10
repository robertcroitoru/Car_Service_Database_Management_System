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
    public partial class Angajati : Form
    {
        string path = "Data Source=DESKTOP-HUEGF7L;Initial Catalog=Lucrari_Service_Auto;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;

        int ID;

        public Angajati()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void Angajati_Load(object sender, EventArgs e)
        {

        }

        public void display()
        {

            try
            {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Angajati", con);

                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Angajati (Nume, Prenume, Data_Nasterii, Gen, Functie, Telefon) values ('" + textNume.Text + "', '" + textPrenume.Text + "', '" + textData.Text + "', '" + textGen.Text + "', '" + textFunctie.Text + "', '" + textTelefon.Text + "') ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Refresh();
                MessageBox.Show("Un nou angajat a fost adaugat!");
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
            textNume.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textPrenume.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textData.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textGen.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textFunctie.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textTelefon.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update Angajati set Nume='" + textNume.Text + "', Prenume='" + textPrenume.Text + "', Data_Nasterii='" + textData.Text + "', Gen='" + textGen.Text + "', Functie='" + textFunctie.Text + "', Telefon='" + textTelefon.Text+"' where AngajatID='" + ID + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Refresh();
                MessageBox.Show("Datele au fost schimbate!");
                display();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Angajati where AngajatID='"+ID+"'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Angajatul a fost sters!");
                
                con.Close();
                Refresh();
                display();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complex1 c1 = new Complex1();
            c1.Show();

        }
    }
}
