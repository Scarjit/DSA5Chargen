namespace DSA5Chargen
{
    using System;
    using System.Windows.Forms;

    using MetroFramework.Forms;

    public partial class PersönlicheDaten : MetroForm
    {
        #region Constructors and Destructors

        public PersönlicheDaten()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        private void btn_spielwerte_Click(object sender, EventArgs e)
        {
            Program.CycleTo(Program.Pages.Spielwerte);
        }

        /// <summary>
        ///     Lässt den richtigen AP Stand berechnen und setzt Charakter.Erfahrungsgrad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_Erfahrungsgrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cb_erfahrungsgrad.Text)
            {
                case "Unerfahren (900)":
                    this.set_ap_via_erfahrungsgrad(900);
                    Charakter.Erfahrungsgrad = "Unerfahren";
                    break;
                case "Durschnittlich (1.000)":
                    this.set_ap_via_erfahrungsgrad(1000);
                    Charakter.Erfahrungsgrad = "Durschnittlich";
                    break;
                case "Erfahren (1.100)":
                    this.set_ap_via_erfahrungsgrad(1100);
                    Charakter.Erfahrungsgrad = "Erfahren";
                    break;
                case "Kompetent (1.200)":
                    this.set_ap_via_erfahrungsgrad(1200);
                    Charakter.Erfahrungsgrad = "Kompetent";
                    break;
                case "Meisterlich (1.400)":
                    this.set_ap_via_erfahrungsgrad(1400);
                    Charakter.Erfahrungsgrad = "Meisterlich";
                    break;
                case "Brilliant (1.700)":
                    this.set_ap_via_erfahrungsgrad(1700);
                    Charakter.Erfahrungsgrad = "Brilliant";
                    break;
                case "Legendär (2.000)":
                    this.set_ap_via_erfahrungsgrad(2000);
                    Charakter.Erfahrungsgrad = "Legendär";
                    break;
            }
        }

        private void cb_Spezies_TextChanged(object sender, EventArgs e)
        {
            Charakter.Spezies = this.cb_Spezies.Text;
        }

        private void persönliche_daten_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.OnCloseCleanup();
        }

        /// <summary>
        ///     Verändert die AP des Charakters um den Unterschied zwischen altem und neuem Erfahrungsgrad
        ///     Des Weiteren wird dann die Textbox der verfügbaren AP angepasst.
        /// </summary>
        /// <param name="ap"></param>
        private void set_ap_via_erfahrungsgrad(int ap)
        {
            switch (Charakter.Erfahrungsgrad)
            {
                case "Unerfahren":
                    Charakter.VerfügbareAbenteurpunkte += ap - 900;
                    break;
                case "Durschnittlich":
                    Charakter.VerfügbareAbenteurpunkte += ap - 1000;
                    break;
                case "Erfahren":
                    Charakter.VerfügbareAbenteurpunkte += ap - 1100;
                    break;
                case "Kompetent":
                    Charakter.VerfügbareAbenteurpunkte += ap - 1200;
                    break;
                case "Meisterlich":
                    Charakter.VerfügbareAbenteurpunkte += ap - 1400;
                    break;
                case "Brilliant":
                    Charakter.VerfügbareAbenteurpunkte += ap - 1700;
                    break;
                case "Legendär":
                    Charakter.VerfügbareAbenteurpunkte += ap - 2000;
                    break;
                default:
                    Charakter.VerfügbareAbenteurpunkte += ap;
                    break;
            }
            this.txtBox_ap.Text = Charakter.VerfügbareAbenteurpunkte.ToString();
        }

        private void txtBox_Alter_TextChanged(object sender, EventArgs e)
        {
            Charakter.Alter = this.txtBox_alter.Text;
        }

        private void txtBox_Augenfarbe_TextChanged(object sender, EventArgs e)
        {
            Charakter.Augenfarbe = this.txtBox_augenfarbe.Text;
        }

        private void txtBox_familie_TextChanged(object sender, EventArgs e)
        {
            Charakter.Familie = this.txtBox_familie.Text;
        }

        private void txtBox_gebdatum_TextChanged(object sender, EventArgs e)
        {
            Charakter.Geburstdatum = this.txtBox_gebdatum.Text;
        }

        private void txtBox_Gebort_TextChanged(object sender, EventArgs e)
        {
            Charakter.Geburstort = this.txtBox_geburtsort.Text;
        }

        private void txtBox_Geschlecht_TextChanged(object sender, EventArgs e)
        {
            Charakter.Geschlecht = this.txtBox_geschlecht.Text;
        }

        private void txtBox_Gewicht_TextChanged(object sender, EventArgs e)
        {
            Charakter.Gewicht = this.txtBox_gewicht.Text;
        }

        private void txtBox_Größe_TextChanged(object sender, EventArgs e)
        {
            Charakter.Größe = this.txtBox_größe.Text;
        }

        private void txtBox_Haarfarbe_TextChanged(object sender, EventArgs e)
        {
            Charakter.Haarfarbe = this.txtBox_haarfarbe.Text;
        }

        private void txtBox_Kultur_TextChanged(object sender, EventArgs e)
        {
            Charakter.Kultur = this.txtBox_kultur.Text;
        }

        private void txtBox_name_TextChanged(object sender, EventArgs e)
        {
            Charakter.Name = this.txtBox_name.Text;
        }

        private void txtBox_Profession_TextChanged(object sender, EventArgs e)
        {
            Charakter.Profession = this.txtBox_profession.Text;
        }

        private void txtBox_Sozialstatus_TextChanged(object sender, EventArgs e)
        {
            Charakter.Sozialstatus = this.txtBox_sozialstatus.Text;
        }

        private void txtBox_Titel_TextChanged(object sender, EventArgs e)
        {
            Charakter.Titel = this.txtBox_titel.Text;
        }

        #endregion
    }
}