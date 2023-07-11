
namespace proiect
{
    partial class FormMedici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedici));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficMediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printareListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareMedicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.adaugareMedicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficMediciToolStripMenuItem,
            this.salvareBmpToolStripMenuItem,
            this.printareListaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // graficMediciToolStripMenuItem
            // 
            this.graficMediciToolStripMenuItem.Name = "graficMediciToolStripMenuItem";
            this.graficMediciToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.graficMediciToolStripMenuItem.Text = "Grafic medici";
            this.graficMediciToolStripMenuItem.Click += new System.EventHandler(this.graficMediciToolStripMenuItem_Click);
            // 
            // salvareBmpToolStripMenuItem
            // 
            this.salvareBmpToolStripMenuItem.Name = "salvareBmpToolStripMenuItem";
            this.salvareBmpToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.salvareBmpToolStripMenuItem.Text = "Salvare bmp";
            this.salvareBmpToolStripMenuItem.Click += new System.EventHandler(this.salvareBmpToolStripMenuItem_Click);
            // 
            // printareListaToolStripMenuItem
            // 
            this.printareListaToolStripMenuItem.Name = "printareListaToolStripMenuItem";
            this.printareListaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.printareListaToolStripMenuItem.Text = "Printare lista";
            this.printareListaToolStripMenuItem.Click += new System.EventHandler(this.printareListaToolStripMenuItem_Click);
            // 
            // adaugareMedicToolStripMenuItem
            // 
            this.adaugareMedicToolStripMenuItem.Name = "adaugareMedicToolStripMenuItem";
            this.adaugareMedicToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.adaugareMedicToolStripMenuItem.Text = "Adaugare medic";
            this.adaugareMedicToolStripMenuItem.Click += new System.EventHandler(this.adaugareMedicToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 396);
            this.panel1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(42, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Medici";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(488, 352);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // FormMedici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMedici";
            this.Text = "Form Medici";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficMediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBmpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem printareListaToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem adaugareMedicToolStripMenuItem;
    }
}