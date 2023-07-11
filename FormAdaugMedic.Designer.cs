
namespace proiect
{
    partial class FormAdaugMedic
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbAniVechime = new System.Windows.Forms.TextBox();
            this.tbSpecializare = new System.Windows.Forms.TextBox();
            this.tbNrOre = new System.Windows.Forms.TextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaAnterioaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(117, 78);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(144, 22);
            this.tbNume.TabIndex = 0;
            // 
            // tbAniVechime
            // 
            this.tbAniVechime.Location = new System.Drawing.Point(117, 188);
            this.tbAniVechime.Name = "tbAniVechime";
            this.tbAniVechime.Size = new System.Drawing.Size(144, 22);
            this.tbAniVechime.TabIndex = 2;
            // 
            // tbSpecializare
            // 
            this.tbSpecializare.Location = new System.Drawing.Point(117, 136);
            this.tbSpecializare.Name = "tbSpecializare";
            this.tbSpecializare.Size = new System.Drawing.Size(144, 22);
            this.tbSpecializare.TabIndex = 3;
            // 
            // tbNrOre
            // 
            this.tbNrOre.Location = new System.Drawing.Point(117, 245);
            this.tbNrOre.Name = "tbNrOre";
            this.tbNrOre.Size = new System.Drawing.Size(144, 22);
            this.tbNrOre.TabIndex = 4;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(74, 300);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(139, 82);
            this.btnAdaugare.TabIndex = 5;
            this.btnAdaugare.Text = "Adaugati medicul";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Specializare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ani vechime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nr Ore";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaAnterioaraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaAnterioaraToolStripMenuItem
            // 
            this.paginaAnterioaraToolStripMenuItem.Name = "paginaAnterioaraToolStripMenuItem";
            this.paginaAnterioaraToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.paginaAnterioaraToolStripMenuItem.Text = "Pagina anterioara";
            this.paginaAnterioaraToolStripMenuItem.Click += new System.EventHandler(this.paginaAnterioaraToolStripMenuItem_Click);
            // 
            // FormAdaugMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.tbNrOre);
            this.Controls.Add(this.tbSpecializare);
            this.Controls.Add(this.tbAniVechime);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdaugMedic";
            this.Text = "FormAdaugMedic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbAniVechime;
        private System.Windows.Forms.TextBox tbSpecializare;
        private System.Windows.Forms.TextBox tbNrOre;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaAnterioaraToolStripMenuItem;
    }
}