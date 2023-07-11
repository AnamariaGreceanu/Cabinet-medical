using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{

    public class Medic:IComparable,ICalculVenit
    {
        private string nume;
        private string specializare;
        private int aniVechime;
        private int nrOre;

        public Medic(string nume,string specializare,int aniVechime,int nrOre)
        {
            this.nume = nume;
            this.specializare = specializare;
            this.aniVechime = aniVechime;
            this.nrOre = nrOre;
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Specializare
        {
            get { return specializare; }
            set { specializare = value; }
        }
        public int AniVechime
        {
            get { return aniVechime; }
            set { aniVechime = value; }

        }
        public int NrOre
        {
            get { return nrOre; }
            set { nrOre = value; }

        }
        public int CompareTo(object obj)
        {
           Medic m = (Medic)obj;
            if (this.aniVechime < m.aniVechime) { return -1; }
            else if (this.aniVechime == m.aniVechime) { return 0; }
            else return 1;
        }
        public static Medic operator++(Medic m)
        {
            m.aniVechime++;
            return m;
        }

        public float CalculVenit()
        {
            return nrOre * 28 - ((nrOre * 28)  *(aniVechime>20?15:7)/ 100);
        }

        public override string ToString()
        {
            return "Medicul " + nume + " are specializarea in " + specializare + " si are " + aniVechime+" ani vechime";
        }
    }
}
