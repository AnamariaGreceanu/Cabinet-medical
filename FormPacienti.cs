using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class FormPacienti : Form
    {
        Pacient p;
        List<Pacient> listaPacienti = new List<Pacient>();
        public FormPacienti()
        {
            InitializeComponent();
        }

        private void btnIntroducere_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string dataNastere = tbDataNastere.Text;
            string dataInregistrare;
            if( tbDataInregistrare.Text!=null)dataInregistrare=tbDataInregistrare.Text;
            else { dataInregistrare = dateTimePicker1.Value.ToString("dd.MMMM.yyyy"); }
            bool internat = rbDa.Checked ? true : false;
            string diagnostic = tbDiagnostic.Text;

            p = new Pacient(nume, dataNastere, dataInregistrare, internat, diagnostic);
            /*p.calculeazaVarsta();
            */
            MessageBox.Show(p.ToString());
            listaPacienti.Add(p);
        }
        private void CalculeazaVarsta_Click(object sender, EventArgs e)
        {
            /*  p.calculeazaVarsta();
              VarstaTextBox.Text =p.varsta.ToString();*/
        }

        private void btnAfiseazaPacientii_Click(object sender, EventArgs e)
        {
            foreach (Pacient p in listaPacienti)
            {
                listBoxTotiPacientii.Items.Add(p);
            }
            
        }

        private void listBoxTotiPacientii_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxTotiPacientii.SelectedIndex;
            p = listaPacienti[index];
            tbNumeSelectat.Text = p.Nume;
        }
        private void btnAfiseazaUnPacient_Click(object sender, EventArgs e)
        {
            int i = 0, gasit = 0;
            if (tbNumeSelectat.Text != "")
            {
                while (i < listaPacienti.Count && gasit == 0)
                {
                    if (listaPacienti[i].Nume == tbNumeSelectat.Text)
                    {
                        int varsta=listaPacienti[i].calculeazaVarsta();
                        gasit = 1;
                        tbUnStudent.Text = listaPacienti[i].ToString()+ " si este in varsta de "+varsta;
                    }
                    i++;
                }
            }
            else MessageBox.Show("nu s a selectat niciun pacient");
        }
        private void salvareTxtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.txt | (*.txt)";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Pacient p in listaPacienti)
                {
                    sw.WriteLine(p.ToString());
                }
                listBoxTotiPacientii.Items.Clear();
                sw.Close();
            }
        }

        private void salvareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listaPacienti);
            fs.Close();
            listBoxTotiPacientii.Items.Clear();
            MessageBox.Show("s a salvat fisierul serializat");
        }

        private void deschideretxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxTotiPacientii.Items.Clear();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBoxTotiPacientii.Items.Add(line);
                }
                sr.Close();
            }
        }

        private void deschidereBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Pacient> listaPacientiDeserializati = (List<Pacient>)bf.Deserialize(fs);
            listBoxTotiPacientii.Items.Clear();
            foreach (Pacient p in listaPacientiDeserializati)
            {
                listBoxTotiPacientii.Items.Add(p);
            }
            fs.Close();
        }


        private void tbDataInregistrare_Validated(object sender, EventArgs e)
        {
            errDataInregistrare.Clear();
        }

        private void tbDataInregistrare_Validating(object sender, CancelEventArgs e)
        {
            if (tbDataInregistrare == null)
            {
                errDataInregistrare.SetError(tbDataInregistrare, "Informatie lipsa");
                e.Cancel = true;
            }
        }

   
    }
}
