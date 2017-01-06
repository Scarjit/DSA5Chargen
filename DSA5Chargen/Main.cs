namespace DSA5Chargen
{
    using System;
    using System.Windows.Forms;

    using MetroFramework.Forms;

    public partial class Main : MetroForm
    {
        #region Constructors and Destructors

        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btn_new_char_Click(object sender, EventArgs e)
        {
            Program.CycleTo(Program.Pages.Persona);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.OnCloseCleanup();
        }

        #endregion
    }
}