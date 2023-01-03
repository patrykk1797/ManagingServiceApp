using System;
using System.Windows.Forms;

namespace Warsztat
{
    public partial class AddRepair : Form
    {
        public AddRepair()
        {
            InitializeComponent();
        }

        private void AddRepair_Load(object sender, EventArgs e)
        {
            foreach (Mechanic mechanic in Mechanic.listOfMechanics)
                cmbMechanic.Items.Add(mechanic);
        }

        private void btnAddNewRepair_Click(object sender, EventArgs e)
        {
            if (check()) return;

            string registry = tbxRegistry.Text;

            DateTime repairDate = dtpDate.Value;

            Mechanic mechanic = (Mechanic)cmbMechanic.SelectedItem;

            decimal costsOfParts = numCosts.Value;

            int workTime = (int)numWorktime.Value;

            Repair repair = new Repair(registry, repairDate, mechanic, costsOfParts, workTime);

            DialogResult confirm = MessageBox.Show("Potwierdź dodanie naprawy", "Dodawanie nowej naprawy", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                Repair.listOfRepairs.Add(repair);
                formClear();
            }
            else return;
        }

        private bool check() {

            if (String.IsNullOrEmpty(tbxRegistry.Text) || String.IsNullOrEmpty(cmbMechanic.Text) || numWorktime.Value <= 0)
            { 
                MessageBox.Show("Brak wszystkich niezbędnych danych.", "Błąd");
                return true;
            }

            Mechanic mechanic = (Mechanic)cmbMechanic.SelectedItem;

          
            
            return false;
        }

        private void formClear() {

            tbxRegistry.Text = "";

            dtpDate.Value = DateTime.Now;

            cmbMechanic.SelectedItem = null;

            numCosts.Value = 0;

            numWorktime.Value = 0;

        }
    }
}
