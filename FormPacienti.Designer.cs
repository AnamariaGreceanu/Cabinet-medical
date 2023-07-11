
namespace proiect
{
    partial class FormPacienti
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
            this.btnIntroducere = new System.Windows.Forms.Button();
            this.btnAfiseazaPacientii = new System.Windows.Forms.Button();
            this.btnAfiseazaUnPacient = new System.Windows.Forms.Button();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbDiagnostic = new System.Windows.Forms.TextBox();
            this.tbDataInregistrare = new System.Windows.Forms.TextBox();
            this.tbDataNastere = new System.Windows.Forms.TextBox();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniSalvarePacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareTxtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideretxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschidereBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbNumeSelectat = new System.Windows.Forms.TextBox();
            this.listBoxTotiPacientii = new System.Windows.Forms.ListBox();
            this.tbUnStudent = new System.Windows.Forms.TextBox();
            this.errDataInregistrare = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errDataInregistrare)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIntroducere
            // 
            this.btnIntroducere.Location = new System.Drawing.Point(44, 325);
            this.btnIntroducere.Name = "btnIntroducere";
            this.btnIntroducere.Size = new System.Drawing.Size(233, 39);
            this.btnIntroducere.TabIndex = 0;
            this.btnIntroducere.Text = "Introdu pacientul";
            this.btnIntroducere.UseVisualStyleBackColor = true;
            this.btnIntroducere.Click += new System.EventHandler(this.btnIntroducere_Click);
            // 
            // btnAfiseazaPacientii
            // 
            this.btnAfiseazaPacientii.Location = new System.Drawing.Point(433, 50);
            this.btnAfiseazaPacientii.Name = "btnAfiseazaPacientii";
            this.btnAfiseazaPacientii.Size = new System.Drawing.Size(141, 66);
            this.btnAfiseazaPacientii.TabIndex = 1;
            this.btnAfiseazaPacientii.Text = "Afiseaza pacientii";
            this.btnAfiseazaPacientii.UseVisualStyleBackColor = true;
            this.btnAfiseazaPacientii.Click += new System.EventHandler(this.btnAfiseazaPacientii_Click);
            // 
            // btnAfiseazaUnPacient
            // 
            this.btnAfiseazaUnPacient.Location = new System.Drawing.Point(696, 50);
            this.btnAfiseazaUnPacient.Name = "btnAfiseazaUnPacient";
            this.btnAfiseazaUnPacient.Size = new System.Drawing.Size(135, 69);
            this.btnAfiseazaUnPacient.TabIndex = 2;
            this.btnAfiseazaUnPacient.Text = "Afiseaza pacientul cu numele selectat";
            this.btnAfiseazaUnPacient.UseVisualStyleBackColor = true;
            this.btnAfiseazaUnPacient.Click += new System.EventHandler(this.btnAfiseazaUnPacient_Click);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(163, 47);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(133, 22);
            this.tbNume.TabIndex = 4;
            // 
            // tbDiagnostic
            // 
            this.tbDiagnostic.Location = new System.Drawing.Point(163, 204);
            this.tbDiagnostic.Name = "tbDiagnostic";
            this.tbDiagnostic.Size = new System.Drawing.Size(133, 22);
            this.tbDiagnostic.TabIndex = 5;
            // 
            // tbDataInregistrare
            // 
            this.tbDataInregistrare.Location = new System.Drawing.Point(163, 149);
            this.tbDataInregistrare.Name = "tbDataInregistrare";
            this.tbDataInregistrare.Size = new System.Drawing.Size(133, 22);
            this.tbDataInregistrare.TabIndex = 6;
            this.tbDataInregistrare.Validating += new System.ComponentModel.CancelEventHandler(this.tbDataInregistrare_Validating);
            this.tbDataInregistrare.Validated += new System.EventHandler(this.tbDataInregistrare_Validated);
            // 
            // tbDataNastere
            // 
            this.tbDataNastere.Location = new System.Drawing.Point(163, 97);
            this.tbDataNastere.Name = "tbDataNastere";
            this.tbDataNastere.Size = new System.Drawing.Size(133, 22);
            this.tbDataNastere.TabIndex = 7;
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(175, 258);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(47, 21);
            this.rbDa.TabIndex = 8;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "Da";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(175, 285);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 9;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nu";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data nastere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data inregistrare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Diagnostic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Internat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optiuniSalvarePacientiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optiuniSalvarePacientiToolStripMenuItem
            // 
            this.optiuniSalvarePacientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareTxtToolStripMenuItem1,
            this.salvareBinarToolStripMenuItem,
            this.deschideretxtToolStripMenuItem,
            this.deschidereBinarToolStripMenuItem});
            this.optiuniSalvarePacientiToolStripMenuItem.Name = "optiuniSalvarePacientiToolStripMenuItem";
            this.optiuniSalvarePacientiToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.optiuniSalvarePacientiToolStripMenuItem.Text = "Optiuni fisiere pacienti";
            // 
            // salvareTxtToolStripMenuItem1
            // 
            this.salvareTxtToolStripMenuItem1.Name = "salvareTxtToolStripMenuItem1";
            this.salvareTxtToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.salvareTxtToolStripMenuItem1.Text = "Salvare fisier txt";
            this.salvareTxtToolStripMenuItem1.Click += new System.EventHandler(this.salvareTxtToolStripMenuItem1_Click);
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.salvareBinarToolStripMenuItem.Text = "Salvare fisier binar";
            this.salvareBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareBinarToolStripMenuItem_Click);
            // 
            // deschideretxtToolStripMenuItem
            // 
            this.deschideretxtToolStripMenuItem.Name = "deschideretxtToolStripMenuItem";
            this.deschideretxtToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.deschideretxtToolStripMenuItem.Text = "Deschidere .txt";
            this.deschideretxtToolStripMenuItem.Click += new System.EventHandler(this.deschideretxtToolStripMenuItem_Click);
            // 
            // deschidereBinarToolStripMenuItem
            // 
            this.deschidereBinarToolStripMenuItem.Name = "deschidereBinarToolStripMenuItem";
            this.deschidereBinarToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.deschidereBinarToolStripMenuItem.Text = "Deschidere binar";
            this.deschidereBinarToolStripMenuItem.Click += new System.EventHandler(this.deschidereBinarToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbNumeSelectat
            // 
            this.tbNumeSelectat.Location = new System.Drawing.Point(696, 125);
            this.tbNumeSelectat.Name = "tbNumeSelectat";
            this.tbNumeSelectat.ReadOnly = true;
            this.tbNumeSelectat.Size = new System.Drawing.Size(135, 22);
            this.tbNumeSelectat.TabIndex = 17;
            // 
            // listBoxTotiPacientii
            // 
            this.listBoxTotiPacientii.FormattingEnabled = true;
            this.listBoxTotiPacientii.ItemHeight = 16;
            this.listBoxTotiPacientii.Location = new System.Drawing.Point(371, 149);
            this.listBoxTotiPacientii.Name = "listBoxTotiPacientii";
            this.listBoxTotiPacientii.Size = new System.Drawing.Size(262, 260);
            this.listBoxTotiPacientii.TabIndex = 1;
            this.listBoxTotiPacientii.SelectedIndexChanged += new System.EventHandler(this.listBoxTotiPacientii_SelectedIndexChanged);
            // 
            // tbUnStudent
            // 
            this.tbUnStudent.Location = new System.Drawing.Point(666, 164);
            this.tbUnStudent.Multiline = true;
            this.tbUnStudent.Name = "tbUnStudent";
            this.tbUnStudent.Size = new System.Drawing.Size(198, 84);
            this.tbUnStudent.TabIndex = 18;
            // 
            // errDataInregistrare
            // 
            this.errDataInregistrare.ContainerControl = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(630, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // FormPacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbUnStudent);
            this.Controls.Add(this.tbNumeSelectat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbDa);
            this.Controls.Add(this.tbDataNastere);
            this.Controls.Add(this.tbDataInregistrare);
            this.Controls.Add(this.tbDiagnostic);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.listBoxTotiPacientii);
            this.Controls.Add(this.btnAfiseazaUnPacient);
            this.Controls.Add(this.btnAfiseazaPacientii);
            this.Controls.Add(this.btnIntroducere);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPacienti";
            this.Text = "FormPacienti";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errDataInregistrare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIntroducere;
        private System.Windows.Forms.Button btnAfiseazaPacientii;
        private System.Windows.Forms.Button btnAfiseazaUnPacient;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbDiagnostic;
        private System.Windows.Forms.TextBox tbDataInregistrare;
        private System.Windows.Forms.TextBox tbDataNastere;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniSalvarePacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareTxtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideretxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschidereBinarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbNumeSelectat;
        private System.Windows.Forms.ListBox listBoxTotiPacientii;
        private System.Windows.Forms.TextBox tbUnStudent;
        private System.Windows.Forms.ErrorProvider errDataInregistrare;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}