using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class FormMedici : Form
    {
        List<Medic> listaMedici = new List<Medic>();
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Cabinet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter adapter;
        public FormMedici()
        {
            InitializeComponent();
            incarcaDate();
        }
        private void incarcaDate()
        {
            conexiune.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Medici", conexiune);
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) {
                string nume=dt.Rows[i]["Nume"].ToString();
                string specializare = dt.Rows[i]["Specializare"].ToString();
                int aniVechime = Convert.ToInt32(dt.Rows[i]["AniVechime"]);
                int nrOre = Convert.ToInt32(dt.Rows[i]["NrOre"]);
                Medic medic = new Medic(nume, specializare, aniVechime, nrOre);
                listaMedici.Add(medic);
            }
            conexiune.Close();
        }
        private void graficMediciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series["Medici"].Points.Clear();
            chart1.Titles.Clear();
            chart1.Visible = true;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            Dictionary<string, int> specializareCount = new Dictionary<string, int>();

            for (int i = 0; i < listaMedici.Count; i++)
            {
                string specializare = listaMedici[i].Specializare;

                if (specializareCount.ContainsKey(specializare))
                {
                    specializareCount[specializare]++; 
                }
                else
                {
                    specializareCount[specializare] = 1; 
                }
            }
            foreach (var kvp in specializareCount)
            {
                string specializare = kvp.Key;
                int count = kvp.Value;

                chart1.Series["Medici"].Points.AddXY(specializare, count);
            }
            chart1.Titles.Add("Medici specializari");
   
        }
        

        private void salvareBmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvare_bmp(panel1, "Grafic_" + DateTime.Now.ToString("dd-MM-yyyy") + ".bmp");
            MessageBox.Show("s a salvat imaginea");
        }
        private void salvare_bmp(Control c, string nume_fisier)
        {
            Bitmap img = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(img, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            img.Save(nume_fisier);
            img.Dispose();
        }
        private void printareListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Century Gothic", 11);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);
            PageSettings settings = printDocument.DefaultPageSettings;
            var totalW = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalH = settings.PaperSize.Height - settings.Margins.Top - settings.Margins.Bottom;

            if (settings.Landscape)
            {
                var temp = totalH;
                totalH = totalW;
                totalW = temp;
            }

            var cellW = totalW / 5;
            var cellH = 40;

            int x = settings.Margins.Left;
            int y = 70;

            graphics.DrawRectangle(pen, x, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);
            graphics.DrawRectangle(pen, x + cellW * 4, y, cellW, cellH);


            graphics.DrawString("Nume medic", font, brush, x, y);
            graphics.DrawString("Specializare", font, brush, x + cellW * 3, y);
            graphics.DrawString("Ani vechime", font, brush, x + cellW * 2, y);
            graphics.DrawString("Numar de ore", font, brush, x + cellW, y);

            y += cellH;

            foreach (Medic medic in listaMedici)
            {
                graphics.DrawRectangle(pen, x, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 2, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 3, y, cellW, cellH);
                graphics.DrawRectangle(pen, x + cellW * 4, y, cellW, cellH);


                graphics.DrawString(medic.Nume, font, brush, x, y);
                graphics.DrawString(medic.Specializare, font, brush, x + cellW, y);
                graphics.DrawString(medic.AniVechime.ToString(), font, brush, x + cellW * 2, y);
                graphics.DrawString(medic.NrOre.ToString(), font, brush, x + cellW * 3, y);

                y += cellH;
            }
        }

        private void adaugareMedicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdaugMedic form2 = new FormAdaugMedic(listaMedici);
            form2.Show();
            this.Close();
        }
    }
}
