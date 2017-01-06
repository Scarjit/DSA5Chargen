namespace DSA5Chargen
{
    using System;

    internal static class Charakter
    {
        #region Static Fields

        //Todo: Warum kein Integer?
        /// <summary>
        ///     Das Alter des Charakters als String
        /// </summary>
        public static string Alter;

        /// <summary>
        ///     Die Augenfarbe des Charakters als String
        /// </summary>
        public static string Augenfarbe;

        /// <summary>
        ///     Die Charakteristika des Charakters als String
        /// </summary>
        public static string Charaktersitika;

        public static int Charisma;

        /// <summary>
        ///     Der Erfahrungsgrad des Charakters als String
        /// </summary>
        public static string Erfahrungsgrad;

        /// <summary>
        ///     Der Familienname des Charakters (Nachname) als String
        /// </summary>
        public static string Familie;

        public static int Fingerfertigkeit;

        /// <summary>
        ///     Das Geburtsdatum des Charakters als String
        /// </summary>
        public static string Geburstdatum;

        /// <summary>
        ///     Der Geburtsort des Charakters als String
        /// </summary>
        public static string Geburstort;

        public static int Geschicklichkeit;

        /// <summary>
        ///     Das Geschlecht des Charakters (Apache) als String
        /// </summary>
        public static string Geschlecht;

        //Todo: Warum kein Integer?
        /// <summary>
        ///     Das Gewicht des Charakters als String
        /// </summary>
        public static string Gewicht;

        //Todo: Warum kein Integer?
        /// <summary>
        ///     Die Größe des Charakters als String
        /// </summary>
        public static string Größe;

        /// <summary>
        ///     Die Hautfarbe des Charakters als String
        /// </summary>
        public static string Haarfarbe;

        public static int Intuition;

        public static int Klugheit;

        public static int Konstitution;

        public static int Körperkraft;

        /// <summary>
        ///     Die Kultur des Charakters als String
        /// </summary>
        public static string Kultur;

        public static int Mut;

        /// <summary>
        ///     Der Charaktername (Vorname) als String
        /// </summary>
        public static string Name;

        /// <summary>
        ///     Die Profession des Charakters als String
        /// </summary>
        public static string Profession;

        /// <summary>
        ///     Sonstiges als String
        /// </summary>
        public static string Sonstiges;

        /// <summary>
        ///     Der Sozialstatus des Charakters als String
        /// </summary>
        public static string Sozialstatus;

        /// <summary>
        ///     Die Spezies des Charakters als String
        /// </summary>
        public static string Spezies;

        /// <summary>
        ///     Der Titel des Charakters als String
        /// </summary>
        public static string Titel;

        public static int VerfügbareAbenteurpunkte;

        #endregion

        #region Public Methods and Operators

        public static int CalculateSkillCost(string stg, int from, int to)
        {
            var s = stg.ToUpper().ToCharArray()[0];
            if (from == to) return 0;

            var t = to;
            var f = from;
            var mult = 1;
            if (to > from)
            {
                mult = -1;
                t = from;
                f = to;
            }

            switch (s)
            {
                case 'A':
                    return CalculateA(f, t) * mult;
                case 'B':
                    return CalculateB(f, t) * mult;
                case 'C':
                    return CalculateC(f, t) * mult;
                case 'D':
                    return CalculateD(f, t) * mult;
                case 'E':
                    return CalculateE(f, t) * mult;
                default:
                    throw new Exception("Incorrect stg");
            }

            return 0;
        }

        #endregion

        #region Methods

        private static int CalculateA(int from, int to)
        {
            if (from <= 12 && to <= 12) return to - from;
            if (from <= 12 && to > 12)
            {
                var till_12 = 12 - from;
                var from_12 = to - 12;
                var m = 1;
                var ret = 0;
                for (var i = 0; i < from_12; i++)
                {
                    ret += m;
                    m++;
                }
                ret += till_12;
                return ret;
            }
            if (from > 12 && to > 12)
            {
                var diff = to - from;
                var m = 1;
                var ret = 0;
                for (var i = 0; i < diff; i++)
                {
                    ret += m;
                    m++;
                }
                return ret;
            }
            return 0;
        }

        private static int CalculateB(int from, int to)
        {
            if (from <= 12 && to <= 12) return (to - from) * 2;
            if (from <= 12 && to > 12)
            {
                var till_12 = 12 - from;
                var from_12 = to - 12;
                var m = 2;
                var ret = 0;
                for (var i = 0; i < from_12; i++)
                {
                    ret += m;
                    m += 2;
                }
                ret += till_12 * 2;
                return ret;
            }
            if (from > 12 && to > 12)
            {
                var diff = to - from;
                var m = 2;
                var ret = 0;
                for (var i = 0; i < diff; i++)
                {
                    ret += m;
                    m += 2;
                }
                return ret;
            }
            return 0;
        }

        private static int CalculateC(int from, int to)
        {
            if (from <= 12 && to <= 12) return (to - from) * 3;
            if (from <= 12 && to > 12)
            {
                var till_12 = 12 - from;
                var from_12 = to - 12;
                var m = 3;
                var ret = 0;
                for (var i = 0; i < from_12; i++)
                {
                    ret += m;
                    m += 3;
                }
                ret += till_12 * 3;
                return ret;
            }
            if (from > 12 && to > 12)
            {
                var diff = to - from;
                var m = 3;
                var ret = 0;
                for (var i = 0; i < diff; i++)
                {
                    ret += m;
                    m += 3;
                }
                return ret;
            }
            return 0;
        }

        private static int CalculateD(int from, int to)
        {
            if (from <= 12 && to <= 12) return (to - from) * 4;
            if (from <= 12 && to > 12)
            {
                var till_12 = 12 - from;
                var from_12 = to - 12;
                var m = 4;
                var ret = 0;
                for (var i = 0; i < from_12; i++)
                {
                    ret += m;
                    m += 4;
                }
                ret += till_12 * 4;
                return ret;
            }
            if (from > 12 && to > 12)
            {
                var diff = to - from;
                var m = 4;
                var ret = 0;
                for (var i = 0; i < diff; i++)
                {
                    ret += m;
                    m += 4;
                }
                return ret;
            }
            return 0;
        }

        private static int CalculateE(int from, int to)
        {
            if (from <= 14 && to <= 14) return (to - from) * 15;
            if (from <= 14 && to > 14)
            {
                var till_12 = 14 - from;
                var from_12 = to - 14;
                var m = 15;
                var ret = 0;
                for (var i = 0; i < from_12; i++)
                {
                    ret += m;
                    m += 15;
                }
                ret += till_12 * 15;
                return ret;
            }
            if (from > 14 && to > 14)
            {
                var diff = to - from;
                var m = 15;
                var ret = 0;
                for (var i = 0; i < diff; i++)
                {
                    ret += m;
                    m += 15;
                }
                return ret;
            }
            return 0;
        }

        #endregion
    }
}