namespace DSA5Chargen
{
    using System.Windows.Forms;

    using MetroFramework.Forms;

    public partial class Spielwerte : MetroForm
    {
        #region Constructors and Destructors

        public Spielwerte()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void Spielwerte_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.OnCloseCleanup();
        }

        #endregion

        private void Spielwerte_VisibleChanged(object sender, System.EventArgs e)
        {
            nud_mut.Text = Charakter.Mut.ToString();
            nud_klugheit.Text = Charakter.Klugheit.ToString();
            nud_intuiton.Text = Charakter.Intuition.ToString();
            nud_charisma.Text = Charakter.Charisma.ToString();
            nud_fingerfertigkeit.Text = Charakter.Fingerfertigkeit.ToString();
            nud_geschicklichkeit.Text = Charakter.Geschicklichkeit.ToString();
            nud_konstitution.Text = Charakter.Konstitution.ToString();
            nud_körperkraft.Text = Charakter.Körperkraft.ToString();
            txtBox_ap.Text = Charakter.VerfügbareAbenteurpunkte.ToString();
        }

        private void nud_mut_ValueChanged(object sender, System.EventArgs e)
        {
            Charakter.Mut = int.Parse(nud_mut.Text);
        }

        private void nud_klugheit_ValueChanged(object sender, System.EventArgs e)
        {
            Charakter.Klugheit = int.Parse(nud_klugheit.Text);

        }

        private void nud_intuiton_ValueChanged(object sender, System.EventArgs e)
        {
            Charakter.Intuition = int.Parse(nud_intuiton.Text);

        }

        private void nud_charisma_ValueChanged(object sender, System.EventArgs e)
        {
            Charakter.Charisma = int.Parse(nud_charisma.Text);

        }

        private void nud_fingerfertigkeit_ValueChanged(object sender, System.EventArgs e)
        {
            Charakter.Fingerfertigkeit = int.Parse(nud_fingerfertigkeit.Text);

        }

        private void nud_geschicklichkeit_ValueChanged(object sender, System.EventArgs e)
        {
            Charakter.Geschicklichkeit = int.Parse(nud_geschicklichkeit.Text);

        }

        private void nud_konstitution_ValueChanged(object sender, System.EventArgs e)
        {
            Charakter.Konstitution = int.Parse(nud_konstitution.Text);

        }

        private void nud_körperkraft_ValueChanged(object sender, System.EventArgs e)
        {
            Charakter.Körperkraft = int.Parse(nud_körperkraft.Text);

        }
    }
}