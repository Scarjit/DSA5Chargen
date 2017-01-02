using MetroFramework.Forms;

namespace DSA5Chargen
{
    public partial class persönliche_daten : MetroForm
    {
        public persönliche_daten()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, System.EventArgs e)
        {
            Program.CycleTo(Program.Pages.Spielwerte);
        }
    }
}