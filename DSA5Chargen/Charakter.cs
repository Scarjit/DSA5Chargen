using System;

namespace DSA5Chargen
{
    internal static class Charakter
    {
        public static int VerfügbareAbenteurpunkte;

        public static int Mut;

        public static int Klugheit;

        public static int Intuition;

        public static int Charisma;

        public static int Fingerfertigkeit;

        public static int Geschicklichkeit;

        public static int Konstitution;

        public static int Körperkraft;

        //Persönliche Daten
        public static string Name;

        public static string Familie;

        public static string Geburstdatum;

        public static string Spezies;

        public static string Haarfarbe;

        public static string Kultur;

        public static string Titel;

        public static string Geschlecht;

        public static string Charaktersitika;

        public static string Sonstiges;

        public static string Geburstort;

        public static string Alter;

        public static string Größe;

        public static string Augenfarbe;

        public static string Profession;

        public static string Sozialstatus;

        public static string Gewicht;

        public static string Erfahrungsgrad;


        public static int CalculateSkillCost(string stg, int from, int to)
        {
            var s = stg.ToUpper().ToCharArray()[0];
            if (from == to)
            {
                return 0;
            }

            int t = to;
            int f = from;
            int mult = 1;
            if (to > from)
            {
                mult = -1;
                t = from;
                f = to;
            }

            switch (s)
            {
                case 'A':
                    return CalculateA(f, t)*mult;
                case 'B':
                    return CalculateB(f, t) * mult;
                case 'C':
                    return CalculateC(f, t) * mult;
                case 'D':
                    return CalculateD(f, t) * mult;
                case 'E':
                    return CalculateE(f, t) * mult;
            }

            return 0;
        }

        private static int CalculateE(int i, int i1)
        {
            throw new NotImplementedException();
        }

        private static int CalculateD(int i, int i1)
        {
            throw new NotImplementedException();
        }

        private static int CalculateC(int i, int i1)
        {
            throw new NotImplementedException();
        }

        private static int CalculateB(int f, int t)
        {
            throw new NotImplementedException();
        }

        private static int CalculateA(int from, int to)
        {
            if (from <= 12 && to <= 12)
            {
                return to - from;
            }
            if (from <= 12 && to > 12)
            {
                int till_12 = 12 - from;
                int from_12 = to - 12;
                int m = 1;
                int ret = 0;
                for (int i = 0; i < from_12; i++)
                {
                    ret += m;
                    m++;
                }
                ret += till_12;
                return ret;
            }
            if (from > 12 && to > 12)
            {
                int diff = to - from;
                int m = 1;
                int ret = 0;
                for (int i = 0; i < diff; i++)
                {
                    ret += m;
                    m++;
                }
                return ret;
            }
            return 0;
        }
    }
}