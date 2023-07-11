using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class FormAfiseazaRetete : Form
    {
        List<Reteta> listaRetete = new List<Reteta>(); 
        BindingSource bs = new BindingSource();
        public FormAfiseazaRetete(List<Reteta>lista)
        {
            InitializeComponent();
            listaRetete = lista; ;
            
            bs.DataSource = listaRetete;
            tbNume.DataBindings.Add(new Binding("Text", bs, "NumeMedic", true));
            tbDataEmitere.DataBindings.Add(new Binding("Text", bs, "DataEmitere", true));
            tbMedicamente.DataBindings.Add(new Binding("Text", bs, "MedicamenteFormatted", true));
            tbZile.DataBindings.Add(new Binding("Text", bs, "NrZileTratament", true));
        }

        private void btnSchimba_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Tag as String == "Prev")
            {
                BindingContext[bs].Position -= 1;
            }
            else
            {
                BindingContext[bs].Position += 1;
            }
        }

        private void paginaAnterioaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRetete form = new FormRetete();
            form.Show();
            this.Close();
        }
    }
}
