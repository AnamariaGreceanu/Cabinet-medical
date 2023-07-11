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

namespace proiect
{
    public partial class FormAdaugMedic : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cabinet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        public FormAdaugMedic(List<Medic>listaMedici)
        {
            InitializeComponent();            
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string specializare = tbSpecializare.Text;
            int aniVechime = Convert.ToInt32(tbAniVechime.Text);
            int nrOre = Convert.ToInt32(tbNrOre.Text);


            Medic m = new Medic(nume, specializare, aniVechime, nrOre);

            conexiune.Open();
            cmd = new SqlCommand("INSERT INTO Medici(Nume,Specializare,aniVechime,nrOre)VALUES(@nume,@specializare,@aniVechime,@nrOre)", conexiune);
            cmd.Parameters.AddWithValue("@nume",tbNume.Text);
            cmd.Parameters.AddWithValue("@specializare", tbSpecializare.Text);
            cmd.Parameters.AddWithValue("@aniVechime", Convert.ToInt32(tbAniVechime.Text));
            cmd.Parameters.AddWithValue("@nrOre", Convert.ToInt32(tbNrOre.Text));
            cmd.ExecuteNonQuery();
            conexiune.Close();
            MessageBox.Show("medic inserat cu succes!");
        }


        private void paginaAnterioaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedici form = new FormMedici();
            form.Show();
            this.Close();
        }
    }
}
