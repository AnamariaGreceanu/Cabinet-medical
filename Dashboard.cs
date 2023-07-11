using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnMedici_Click(object sender, EventArgs e)
        {
            FormMedici form = new FormMedici();
            form.Show();
        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            FormPacienti form = new FormPacienti();
            form.Show();
        }

        private void btnRetete_Click(object sender, EventArgs e)
        {
            FormRetete form = new FormRetete();
            form.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
