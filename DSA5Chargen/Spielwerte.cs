namespace DSA5Chargen
{
    using System.Windows.Forms;

    using MetroFramework.Forms;

    public partial class Spielwerte : MetroForm
    {
        #region Constructors and Destructors

        public Spielwerte()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        private void Spielwerte_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.OnCloseCleanup();
        }

        #endregion
    }
}