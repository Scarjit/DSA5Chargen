namespace DSA5Chargen
{
    using System;
    using System.Windows.Forms;

    using MetroFramework.Forms;

    public partial class persönliche_daten : MetroForm
    {
        #region Constructors and Destructors

        public persönliche_daten()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        private void cb_Erfahrungsgrad_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Program.CycleTo(Program.Pages.Spielwerte);
        }

        private void persönliche_daten_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.OnCloseCleanup();
        }

        #endregion

        private void txtBox_name_TextChanged(object sender, EventArgs e)
        {
            Charakter.Name = this.txtBox_name.Text;
        }

        private void txtBox_familie_TextChanged(object sender, EventArgs e)
        {
            Charakter.Familie = this.txtBox_familie.Text;
        }

        private void txtBox_gebdatum_TextChanged(object sender, EventArgs e)
        {
            Charakter.Geburstdatum = this.txtBox_gebdatum.Text;
        }

        private void cb_Spezies_TextChanged(object sender, EventArgs e)
        {
            Charakter.Spezies = this.cb_Spezies.Text;
        }

        private void txtBox_Haarfarbe_TextChanged(object sender, EventArgs e)
        {
            Charakter.Haarfarbe = this.txtBox_Haarfarbe.Text;
        }

        private void txtBox_Kultur_TextChanged(object sender, EventArgs e)
        {
            Charakter.Kultur = this.txtBox_Kultur.Text;
        }

        private void txtBox_Titel_TextChanged(object sender, EventArgs e)
        {
            Charakter.Titel = this.txtBox_Titel.Text;
        }

        private void txtBox_Geschlecht_TextChanged(object sender, EventArgs e)
        {
            Charakter.Geschlecht = this.txtBox_Geschlecht.Text;
        }

        private void txtBox_Gebort_TextChanged(object sender, EventArgs e)
        {
            Charakter.Geburstort = txtBox_Gebort.Text;
        }
        private void txtBox_Alter_TextChanged(object sender, EventArgs e)
        {
            Charakter.Alter = txtBox_Alter.Text;
        }
        private void txtBox_Größe_TextChanged(object sender, EventArgs e)
        {
            Charakter.Größe = txtBox_Größe.Text;
        }
        private void txtBox_Augenfarbe_TextChanged(object sender, EventArgs e)
        {
            Charakter.Augenfarbe = txtBox_Augenfarbe.Text;
        }
        private void txtBox_Profession_TextChanged(object sender, EventArgs e)
        {
            Charakter.Profession = txtBox_Profession.Text;
        }
        private void txtBox_Sozialstatus_TextChanged(object sender, EventArgs e)
        {
            Charakter.Sozialstatus = txtBox_Sozialstatus.Text;
        }
        private void txtBox_Gewicht_TextChanged(object sender, EventArgs e)
        {
            Charakter.Gewicht = txtBox_Gewicht.Text;
        }

    }
}