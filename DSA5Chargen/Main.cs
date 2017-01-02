using System;
using MetroFramework.Forms;

namespace DSA5Chargen
{
    public partial class Main : MetroForm
    {


        public Main()
        {
            InitializeComponent();
        }

        private void btn_new_char_Click(object sender, EventArgs e)
        {
            Program.CycleTo(Program.Pages.Persona);
        }
    }
}