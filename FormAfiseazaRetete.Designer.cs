
namespace proiect
{
    partial class FormAfiseazaRetete
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
            this.tbZile = new System.Windows.Forms.TextBox();
            this.tbMedicamente = new System.Windows.Forms.TextBox();
            this.tbDataEmitere = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaAnterioaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(166, 81);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(166, 22);
            this.tbNume.TabIndex = 2;
            // 
            // tbZile
            // 
            this.tbZile.Location = new System.Drawing.Point(166, 255);
            this.tbZile.Name = "tbZile";
            this.tbZile.Size = new System.Drawing.Size(166, 22);
            this.tbZile.TabIndex = 3;
            // 
            // tbMedicamente
            // 
            this.tbMedicamente.Location = new System.Drawing.Point(166, 182);
            this.tbMedicamente.Multiline = true;
            this.tbMedicamente.Name = "tbMedicamente";
            this.tbMedicamente.Size = new System.Drawing.Size(166, 55);
            this.tbMedicamente.TabIndex = 4;
            // 
            // tbDataEmitere
            // 
            this.tbDataEmitere.Location = new System.Drawing.Point(166, 130);
            this.tbDataEmitere.Name = "tbDataEmitere";
            this.tbDataEmitere.Size = new System.Drawing.Size(166, 22);
            this.tbDataEmitere.TabIndex = 5;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(166, 310);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(71, 53);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Tag = "Prev";
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnSchimba_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(261, 310);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 53);
            this.btnNext.TabIndex = 7;
            this.btnNext.Tag = "Next";
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnSchimba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume medic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data emitere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Medicamente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nr zile tratament";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaAnterioaraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaAnterioaraToolStripMenuItem
            // 
            this.paginaAnterioaraToolStripMenuItem.Name = "paginaAnterioaraToolStripMenuItem";
            this.paginaAnterioaraToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.paginaAnterioaraToolStripMenuItem.Text = "Pagina anterioara";
            this.paginaAnterioaraToolStripMenuItem.Click += new System.EventHandler(this.paginaAnterioaraToolStripMenuItem_Click);
            // 
            // FormAfiseazaRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tbDataEmitere);
            this.Controls.Add(this.tbMedicamente);
            this.Controls.Add(this.tbZile);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAfiseazaRetete";
            this.Text = "FormAfiseazaRetete";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbZile;
        private System.Windows.Forms.TextBox tbMedicamente;
        private System.Windows.Forms.TextBox tbDataEmitere;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaAnterioaraToolStripMenuItem;
    }
}