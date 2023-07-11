
namespace proiect
{
    partial class Dashboard
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
            this.btnMedici = new System.Windows.Forms.Button();
            this.btnPacienti = new System.Windows.Forms.Button();
            this.btnRetete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedici
            // 
            this.btnMedici.Location = new System.Drawing.Point(46, 155);
            this.btnMedici.Name = "btnMedici";
            this.btnMedici.Size = new System.Drawing.Size(108, 60);
            this.btnMedici.TabIndex = 0;
            this.btnMedici.Text = "Medici";
            this.btnMedici.UseVisualStyleBackColor = true;
            this.btnMedici.Click += new System.EventHandler(this.btnMedici_Click);
            // 
            // btnPacienti
            // 
            this.btnPacienti.Location = new System.Drawing.Point(255, 158);
            this.btnPacienti.Name = "btnPacienti";
            this.btnPacienti.Size = new System.Drawing.Size(128, 55);
            this.btnPacienti.TabIndex = 1;
            this.btnPacienti.Text = "Pacienti";
            this.btnPacienti.UseVisualStyleBackColor = true;
            this.btnPacienti.Click += new System.EventHandler(this.btnPacienti_Click);
            // 
            // btnRetete
            // 
            this.btnRetete.Location = new System.Drawing.Point(471, 157);
            this.btnRetete.Name = "btnRetete";
            this.btnRetete.Size = new System.Drawing.Size(136, 57);
            this.btnRetete.TabIndex = 2;
            this.btnRetete.Text = "Retete";
            this.btnRetete.UseVisualStyleBackColor = true;
            this.btnRetete.Click += new System.EventHandler(this.btnRetete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(460, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selectati in functie de ce informatii va trebuie:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 36);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 352);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRetete);
            this.Controls.Add(this.btnPacienti);
            this.Controls.Add(this.btnMedici);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedici;
        private System.Windows.Forms.Button btnPacienti;
        private System.Windows.Forms.Button btnRetete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
    }
}