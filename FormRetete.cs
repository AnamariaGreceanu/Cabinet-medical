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
using System.Xml;

namespace proiect
{
    public partial class FormRetete : Form
    {
        List<Reteta> listaRetete = new List<Reteta>();
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cabinet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        SqlCommand cmd;
        string[] medicamente;
        string med;
        public FormRetete()
        {
            InitializeComponent();
            incarcaDate();
        }
        private void incarcaDate()
        {
            conexiune.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Retete", conexiune);
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string numeMedic = dt.Rows[i]["NumeMedic"].ToString();
                string dataEmitere = dt.Rows[i]["DataEmitere"].ToString();
                string medicamente_string = dt.Rows[i]["Medicamente"].ToString();
                string[] medicamente = medicamente_string.Split(',');
                int nrOre = Convert.ToInt32(dt.Rows[i]["NrZile"]);
                Reteta reteta = new Reteta(numeMedic, dataEmitere, medicamente, nrOre);
                listaRetete.Add(reteta);
            }
            conexiune.Close();
        }
        private void FormRetete_Load(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(@"Medicamente.xml");
            XmlNodeList xnList = xmlDocument.SelectNodes("/catalog");
            foreach (XmlNode xn in xnList)
            {
                XmlNodeList xmlNodeList = xn.ChildNodes;
                medicamente = new string[xmlNodeList.Count];
                int i=0;
                foreach (XmlNode node in xmlNodeList)
                {
                    string medicament = node["medicamente"].InnerText;
                    medicamente[i] = medicament;
                    lbMedicamente.Items.Add(medicament);
                    i++;
                }
                   
            }
            
        }

        private void lbMedicamente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbMedicamente.SelectedIndex;
            med = medicamente[index];
            tbMedSelectat.Text = med;
        }

        private void btnAdaugaMedicament_Click(object sender, EventArgs e)
        {
            tbMedicamente.Text += tbMedSelectat.Text+", ";
        }

        private void btnAdaugaReteta_Click(object sender, EventArgs e)
        {
            string numeMedic = tbNume.Text;
            string dataEmitere = tbDataEmitere.Text;
            int nrZileTratament = Convert.ToInt32(tbZile.Text);
            string[] medicamente_string = tbMedicamente.Text.Split(',');
            string[] medicamente=new string[medicamente_string.Length];
            for(int i = 0; i < medicamente.Length; i++)
            {
                medicamente[i] =medicamente_string[i];
            }
            
                if (numeMedic == "")
                {
                    errorProvider1.SetError(tbNume, "Introduceti denumirea: ");
                }
                else if (dataEmitere == "")
                {
                    errorProvider1.SetError(tbDataEmitere, "Introduceti pretul: ");
                }
                else if (nrZileTratament == 0)
                {
                    errorProvider1.SetError(tbZile, "Introduceti cantitatea: ");
                }
                else if (medicamente==null)
                {
                    errorProvider1.SetError(tbMedicamente, "Introduceti cantitatea: ");
                }
                else
                {
                    Reteta r = new Reteta(numeMedic, dataEmitere, medicamente, nrZileTratament);
                    listaRetete.Add(r);
                    MessageBox.Show("A fost adaugata reteta\n"+r.ToString());
                    tbNume.Clear(); tbMedicamente.Clear(); tbDataEmitere.Clear();
                    tbZile.Clear(); tbMedSelectat.Clear();
                }


                conexiune.Open();
                cmd = new SqlCommand("INSERT INTO Retete(NumeMedic,DataEmitere,Medicamente,NrZile)VALUES(@nume,@dataEmitere,@medicamente,@nrZile)", conexiune);
                cmd.Parameters.AddWithValue("@nume", numeMedic);
                cmd.Parameters.AddWithValue("@dataEmitere", dataEmitere);
                cmd.Parameters.AddWithValue("@nrZile", nrZileTratament);
                cmd.Parameters.AddWithValue("@medicamente", medicamente.ToString());
                cmd.ExecuteNonQuery();
                conexiune.Close();
                MessageBox.Show("reteta inserata cu succes!");
            

    }

        private void btnAfiseazaRetetele_Click(object sender, EventArgs e)
        {
            FormAfiseazaRetete form = new FormAfiseazaRetete(listaRetete);
            form.Show();
            this.Close();
        }
    }
}
