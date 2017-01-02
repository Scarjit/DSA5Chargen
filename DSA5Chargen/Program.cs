using System;
using System.Windows.Forms;

namespace DSA5Chargen
{
    using MetroFramework.Forms;

    internal static class Program
    {

        public static MetroForm form_besitz;
        public static MetroForm form_kampf;
        public static MetroForm form_liturgien_und_zermonien;
        public static MetroForm form_persönliche_daten;
        public static MetroForm form_spielwerte;
        public static MetroForm form_zauber_und_rituale;
        public static MetroForm form_main;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            form_persönliche_daten = new persönliche_daten();
            form_spielwerte = new Spielwerte();
            form_main = new Main();
            Application.Run(form_main);
        }

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
        
        public static void CycleTo(Pages page)
        {
            //form_besitz.Hide();
            //form_kampf.Hide();
            //form_liturgien_und_zermonien.Hide();
            form_persönliche_daten.Hide();
            form_spielwerte.Hide();
            //form_zauber_und_rituale.Hide();
            form_main.Hide();

            switch (page)
            {
                case Pages.Besitz:
                    form_besitz.Show();
                    form_besitz.BringToFront();
                    break;
                case Pages.Kampf:
                    form_kampf.Show();
                    form_kampf.BringToFront();
                    break;
                case Pages.Geweiht:
                    form_liturgien_und_zermonien.Show();
                    form_liturgien_und_zermonien.BringToFront();
                    break;
                case Pages.Persona:
                    form_persönliche_daten.Show();
                    form_persönliche_daten.BringToFront();
                    break;
                case Pages.Spielwerte:
                    form_spielwerte.Show();
                    form_spielwerte.BringToFront();
                    break;
                case Pages.Magie:
                    form_zauber_und_rituale.Show();
                    form_zauber_und_rituale.BringToFront();
                    break;
                case Pages.Main:
                    form_main.Show();
                    form_main.BringToFront();
                    break;
                default:
                    form_main.Show();
                    form_main.BringToFront();
                    break;
            }

        }
    }
}