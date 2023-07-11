using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class Reteta:ICloneable
    {
        private string numeMedic;
        private string dataEmitere;
        private string[] medicamente;
        private int nrZileTratament;

        public Reteta(string numeMedic,string dataEmitere,string[]medicamente,int nrZileTratament)
        {
            this.numeMedic = numeMedic;
            this.dataEmitere = dataEmitere;
            this.medicamente = medicamente;
            this.nrZileTratament = nrZileTratament;
        } 
        public string DataEmitere
        {
            get { return dataEmitere; }
            set { dataEmitere = value; }
        }
        public string[] Medicamente
        {
            get { return medicamente; }
            set { medicamente = value; }
        }
        public string MedicamenteFormatted
        {
            get { return string.Join(", ", Medicamente); }
        }
        public int NrZileTratament
        {
            get { return nrZileTratament; }
            set { nrZileTratament = value; }
        }

        public string NumeMedic { get => numeMedic; set => numeMedic = value; }

        public object Clone()
        {
            Reteta r = (Reteta)this.MemberwiseClone();
            string[] medicamenteClonate = (string[])medicamente.Clone();
            r.medicamente = medicamenteClonate;
            return r;
        }

        public static Reteta operator +(Reteta r, string medicamentNou)
        {
            string[] medicamenteNoi = new string[r.medicamente.Length + 1];
            for (int i = 0; i < r.medicamente.Length; i++)
            {
                medicamenteNoi[i] = r.medicamente[i];
            }
            medicamenteNoi[medicamenteNoi.Length - 1] = medicamentNou;
            r.medicamente = medicamenteNoi;
            return r;
        }

        public string this[int index]
        {
            get {
                if (index >= 0 && index < medicamente.Length) {
                    return this.medicamente[index];
                }
                else {
                   return "index gresit";
                }
            }
            set  {  this.medicamente[index] = value;  }
        }

        public string dataFinalaTratament()
        {
           return Convert.ToDateTime(dataEmitere).AddDays(nrZileTratament).ToString();
        }

        public override string ToString()
        {
            string mesajAfisare = "Reteta emisa de " + numeMedic + " contine urmatoarele ";
            foreach (string i in this.medicamente)
            {
                mesajAfisare += i + " ";
            }
            return mesajAfisare;
        }
    }
}
