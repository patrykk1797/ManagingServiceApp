using System;
using System.Drawing;
using System.Windows.Forms;

namespace Warsztat
{
    public partial class MechanicsList : Form
    {
        public MechanicsList()
        {
            InitializeComponent();
        }

        private void Mechanicy_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Mechanic.listOfMechanics;
        }
    }
}
