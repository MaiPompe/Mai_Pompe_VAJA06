using System.IO;

namespace vaja6 {

    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id {
            //Omogoča, da dobimo vrednost shranjeno v id
            get
            {
                return id;
            }
        }

        public string U_ime {
            //Omoogča, da nastavimo in dobimo vrednost shranjeno v u_ime
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

        public string U_geslo
        {
            //Omoogča, da nastavimo in dobimo vrednost shranjeno v u_geslo
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

        public static int StIg
        {
            //Omogoča, da dobimo vrednost shranjeno v stIg
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
