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
    public partial class Main : Form
    {
         
        Angajati ag = new Angajati();
        Clienti cl = new Clienti();
        Lucrari l = new Lucrari();
        Masini m = new Masini();
        Piese p = new Piese();
        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ag.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cl.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            l.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            m.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            p.Show();
        }
    }
}
