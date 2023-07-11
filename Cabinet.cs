using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    class Cabinet
    {
        private string nume;
        private List<Medic> listaMedici;
        public Cabinet(string nume)
        {
            this.nume = nume;
            listaMedici = new List<Medic>();
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public List<Medic> ListaMedici
        {
            get { return listaMedici; }
            set { listaMedici = value; }
        }
        public void adaugaMedic(Medic m)
        {
            ListaMedici.Add(m);
        }
        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare += "Cabinetul medical " + nume + " are urmatorii medici: \n";
            foreach (Medic m in listaMedici)
            {
                mesajAfisare += m.ToString() + "\n";
            }
            return mesajAfisare;
        }
    }
}
