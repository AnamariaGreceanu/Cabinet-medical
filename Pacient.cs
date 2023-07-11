using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    [Serializable]

    class Pacient
    {
        private string nume;
        private string dataNastere;
        private string dataInregistrare;
        private bool internat;
        private string diagnostic;

        public Pacient(string nume, string dataNastere, string dataInregistrare, bool internat, string diagnostic)
        {
            this.nume = nume;
            this.dataNastere = dataNastere;//mm.dd.yyyy
            this.dataInregistrare = dataInregistrare;
            this.internat = internat;
            this.diagnostic = diagnostic;
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string DataNastere
        {
            get { return dataNastere; }
            set { dataNastere = value; }
        }
        public string DataInregistrare
        {
            get { return DataInregistrare; }
            set { DataInregistrare = value; }
        }
        public bool Internat
        {
            get { return internat; }
            set { internat = value; }
        }
        public string Diagnostic
        {
            get { return diagnostic; }
            set { diagnostic = value; }
        }

        public int calculeazaVarsta()
        {
                return (DateTime.Now.Subtract(Convert.ToDateTime(dataNastere)).Days) / 365;
        }

        public string zileInternare()
        {
            if (!internat) return "pacientul nu este internat";
            else return (DateTime.Today - Convert.ToDateTime(dataInregistrare)).Days.ToString();

        }
        public override string ToString()
        {
            return "Pacientul " + nume + " este diagnosticat cu " + diagnostic;
        }
    }
}
