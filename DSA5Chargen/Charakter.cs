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

        #region persönliche Daten

        /// <summary>
        /// Der Charaktername (Vorname) als String
        /// </summary>
        public static string Name;

        /// <summary>
        /// Der Familienname des Charakters (Nachname) als String
        /// </summary>
        public static string Familie;

        /// <summary>
        /// Das Geburtsdatum des Charakters als String
        /// </summary>
        public static string Geburstdatum;

        /// <summary>
        /// Die Spezies des Charakters als String
        /// </summary>
        public static string Spezies;

        /// <summary>
        /// Die Hautfarbe des Charakters als String
        /// </summary>
        public static string Haarfarbe;

        /// <summary>
        /// Die Kultur des Charakters als String
        /// </summary>
        public static string Kultur;

        /// <summary>
        /// Der Titel des Charakters als String
        /// </summary>
        public static string Titel;

        /// <summary>
        /// Das Geschlecht des Charakters (Apache) als String
        /// </summary>
        public static string Geschlecht;

        /// <summary>
        /// Die Charakteristika des Charakters als String
        /// </summary>
        public static string Charaktersitika;

        /// <summary>
        /// Sonstiges als String
        /// </summary>
        public static string Sonstiges;

        /// <summary>
        /// Der Geburtsort des Charakters als String
        /// </summary>
        public static string Geburstort;

        //Todo: Warum kein Integer?
        /// <summary>
        /// Das Alter des Charakters als String
        /// </summary>
        public static string Alter;

        //Todo: Warum kein Integer?
        /// <summary>
        /// Die Größe des Charakters als String
        /// </summary>
        public static string Größe;

        /// <summary>
        /// Die Augenfarbe des Charakters als String
        /// </summary>
        public static string Augenfarbe;

        /// <summary>
        /// Die Profession des Charakters als String
        /// </summary>
        public static string Profession;

        /// <summary>
        /// Der Sozialstatus des Charakters als String
        /// </summary>
        public static string Sozialstatus;

        //Todo: Warum kein Integer?
        /// <summary>
        /// Das Gewicht des Charakters als String
        /// </summary>
        public static string Gewicht;

        /// <summary>
        /// Der Erfahrungsgrad des Charakters als String
        /// </summary>
        public static string Erfahrungsgrad;
        #endregion

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