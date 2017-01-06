namespace DSA5Chargen
{
    using System;
    using System.Windows.Forms;

    using MetroFramework.Forms;

    internal static class Program
    {
        #region Static Fields

        public static MetroForm FormBesitz;

        public static MetroForm FormKampf;

        public static MetroForm FormLiturgienUndZermonien;

        public static MetroForm FormMain;

        public static MetroForm FormPersönlicheDaten;

        public static MetroForm FormSpielwerte;

        public static MetroForm FormZauberUndRituale;

        #endregion

        #region Enums

        public enum Pages
        {
            Besitz,

            Kampf,

            Geweiht,

            Persona,

            Spielwerte,

            Magie,

            Main
        }

        #endregion

        #region Public Methods and Operators

        public static void CycleTo(Pages page)
        {
            //form_besitz.Hide();
            //form_kampf.Hide();
            //form_liturgien_und_zermonien.Hide();
            FormPersönlicheDaten.Hide();
            FormSpielwerte.Hide();
            //form_zauber_und_rituale.Hide();
            FormMain.Hide();

            switch (page)
            {
                case Pages.Besitz:
                    FormBesitz.Show();
                    FormBesitz.BringToFront();
                    break;
                case Pages.Kampf:
                    FormKampf.Show();
                    FormKampf.BringToFront();
                    break;
                case Pages.Geweiht:
                    FormLiturgienUndZermonien.Show();
                    FormLiturgienUndZermonien.BringToFront();
                    break;
                case Pages.Persona:
                    FormPersönlicheDaten.Show();
                    FormPersönlicheDaten.BringToFront();
                    break;
                case Pages.Spielwerte:
                    FormSpielwerte.Show();
                    FormSpielwerte.BringToFront();
                    break;
                case Pages.Magie:
                    FormZauberUndRituale.Show();
                    FormZauberUndRituale.BringToFront();
                    break;
                case Pages.Main:
                    FormMain.Show();
                    FormMain.BringToFront();
                    break;
                default:
                    FormMain.Show();
                    FormMain.BringToFront();
                    break;
            }
        }

        public static void OnCloseCleanup()
        {
            MessageBox.Show("Cleanup");
            Application.Exit();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormPersönlicheDaten = new persönliche_daten();
            FormSpielwerte = new Spielwerte();
            FormMain = new Main();
            Application.Run(FormMain);
        }

        #endregion
    }
}