
namespace proiect
{
    partial class FormRetete
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbMedicamente = new System.Windows.Forms.ListBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbZile = new System.Windows.Forms.TextBox();
            this.tbDataEmitere = new System.Windows.Forms.TextBox();
            this.lbNumeMedic = new System.Windows.Forms.Label();
            this.lbDataEmitere = new System.Windows.Forms.Label();
            this.labelMedicamente = new System.Windows.Forms.Label();
            this.lbNrZile = new System.Windows.Forms.Label();
            this.tbMedicamente = new System.Windows.Forms.TextBox();
            this.btnAdaugaMedicament = new System.Windows.Forms.Button();
            this.btnAdaugaReteta = new System.Windows.Forms.Button();
            this.btnAfiseazaRetetele = new System.Windows.Forms.Button();
            this.tbMedSelectat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbMedicamente
            // 
            this.lbMedicamente.FormattingEnabled = true;
            this.lbMedicamente.ItemHeight = 16;
            this.lbMedicamente.Location = new System.Drawing.Point(61, 66);
            this.lbMedicamente.Name = "lbMedicamente";
            this.lbMedicamente.Size = new System.Drawing.Size(257, 308);
            this.lbMedicamente.TabIndex = 1;
            this.lbMedicamente.SelectedIndexChanged += new System.EventHandler(this.lbMedicamente_SelectedIndexChanged);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(479, 72);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(161, 22);
            this.tbNume.TabIndex = 2;
            // 
            // tbZile
            // 
            this.tbZile.Location = new System.Drawing.Point(479, 174);
            this.tbZile.Name = "tbZile";
            this.tbZile.Size = new System.Drawing.Size(161, 22);
            this.tbZile.TabIndex = 3;
            // 
            // tbDataEmitere
            // 
            this.tbDataEmitere.Location = new System.Drawing.Point(479, 126);
            this.tbDataEmitere.Name = "tbDataEmitere";
            this.tbDataEmitere.Size = new System.Drawing.Size(161, 22);
            this.tbDataEmitere.TabIndex = 4;
            // 
            // lbNumeMedic
            // 
            this.lbNumeMedic.AutoSize = true;
            this.lbNumeMedic.Location = new System.Drawing.Point(364, 77);
            this.lbNumeMedic.Name = "lbNumeMedic";
            this.lbNumeMedic.Size = new System.Drawing.Size(86, 17);
            this.lbNumeMedic.TabIndex = 5;
            this.lbNumeMedic.Text = "Nume medic";
            // 
            // lbDataEmitere
            // 
            this.lbDataEmitere.AutoSize = true;
            this.lbDataEmitere.Location = new System.Drawing.Point(367, 126);
            this.lbDataEmitere.Name = "lbDataEmitere";
            this.lbDataEmitere.Size = new System.Drawing.Size(89, 17);
            this.lbDataEmitere.TabIndex = 6;
            this.lbDataEmitere.Text = "Data emitere";
            // 
            // labelMedicamente
            // 
            this.labelMedicamente.AutoSize = true;
            this.labelMedicamente.Location = new System.Drawing.Point(367, 217);
            this.labelMedicamente.Name = "labelMedicamente";
            this.labelMedicamente.Size = new System.Drawing.Size(92, 17);
            this.labelMedicamente.TabIndex = 7;
            this.labelMedicamente.Text = "Medicamente";
            // 
            // lbNrZile
            // 
            this.lbNrZile.AutoSize = true;
            this.lbNrZile.Location = new System.Drawing.Point(367, 179);
            this.lbNrZile.Name = "lbNrZile";
            this.lbNrZile.Size = new System.Drawing.Size(100, 17);
            this.lbNrZile.TabIndex = 8;
            this.lbNrZile.Text = "Zile Tratament";
            // 
            // tbMedicamente
            // 
            this.tbMedicamente.Location = new System.Drawing.Point(479, 214);
            this.tbMedicamente.Multiline = true;
            this.tbMedicamente.Name = "tbMedicamente";
            this.tbMedicamente.ReadOnly = true;
            this.tbMedicamente.Size = new System.Drawing.Size(161, 85);
            this.tbMedicamente.TabIndex = 9;
            // 
            // btnAdaugaMedicament
            // 
            this.btnAdaugaMedicament.Location = new System.Drawing.Point(703, 162);
            this.btnAdaugaMedicament.Name = "btnAdaugaMedicament";
            this.btnAdaugaMedicament.Size = new System.Drawing.Size(118, 72);
            this.btnAdaugaMedicament.TabIndex = 10;
            this.btnAdaugaMedicament.Text = "Adauga medicamentul selectat";
            this.btnAdaugaMedicament.UseVisualStyleBackColor = true;
            this.btnAdaugaMedicament.Click += new System.EventHandler(this.btnAdaugaMedicament_Click);
            // 
            // btnAdaugaReteta
            // 
            this.btnAdaugaReteta.Location = new System.Drawing.Point(493, 312);
            this.btnAdaugaReteta.Name = "btnAdaugaReteta";
            this.btnAdaugaReteta.Size = new System.Drawing.Size(114, 60);
            this.btnAdaugaReteta.TabIndex = 11;
            this.btnAdaugaReteta.Text = "Adauga reteta";
            this.btnAdaugaReteta.UseVisualStyleBackColor = true;
            this.btnAdaugaReteta.Click += new System.EventHandler(this.btnAdaugaReteta_Click);
            // 
            // btnAfiseazaRetetele
            // 
            this.btnAfiseazaRetetele.Location = new System.Drawing.Point(391, 393);
            this.btnAfiseazaRetetele.Name = "btnAfiseazaRetetele";
            this.btnAfiseazaRetetele.Size = new System.Drawing.Size(324, 29);
            this.btnAfiseazaRetetele.TabIndex = 12;
            this.btnAfiseazaRetetele.Text = "Afiseaza retetele";
            this.btnAfiseazaRetetele.UseVisualStyleBackColor = true;
            this.btnAfiseazaRetetele.Click += new System.EventHandler(this.btnAfiseazaRetetele_Click);
            // 
            // tbMedSelectat
            // 
            this.tbMedSelectat.Location = new System.Drawing.Point(694, 256);
            this.tbMedSelectat.Name = "tbMedSelectat";
            this.tbMedSelectat.ReadOnly = true;
            this.tbMedSelectat.Size = new System.Drawing.Size(136, 22);
            this.tbMedSelectat.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista medicamente";
            // 
            // FormRetete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMedSelectat);
            this.Controls.Add(this.btnAfiseazaRetetele);
            this.Controls.Add(this.btnAdaugaReteta);
            this.Controls.Add(this.btnAdaugaMedicament);
            this.Controls.Add(this.tbMedicamente);
            this.Controls.Add(this.lbNrZile);
            this.Controls.Add(this.labelMedicamente);
            this.Controls.Add(this.lbDataEmitere);
            this.Controls.Add(this.lbNumeMedic);
            this.Controls.Add(this.tbDataEmitere);
            this.Controls.Add(this.tbZile);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lbMedicamente);
            this.Name = "FormRetete";
            this.Text = "FormRetete";
            this.Load += new System.EventHandler(this.FormRetete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lbMedicamente;
        private System.Windows.Forms.TextBox tbMedicamente;
        private System.Windows.Forms.Label lbNrZile;
        private System.Windows.Forms.Label labelMedicamente;
        private System.Windows.Forms.Label lbDataEmitere;
        private System.Windows.Forms.Label lbNumeMedic;
        private System.Windows.Forms.TextBox tbDataEmitere;
        private System.Windows.Forms.TextBox tbZile;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button btnAdaugaMedicament;
        private System.Windows.Forms.Button btnAdaugaReteta;
        private System.Windows.Forms.Button btnAfiseazaRetetele;
        private System.Windows.Forms.TextBox tbMedSelectat;
        private System.Windows.Forms.Label label1;
    }
}