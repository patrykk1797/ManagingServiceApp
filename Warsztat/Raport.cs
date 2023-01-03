using System;
using System.Windows.Forms;

namespace Warsztat
{
    public partial class Raport : Form
    {
        public Raport()
        {
            InitializeComponent();
        }

        private void Raport_Load(object sender, EventArgs e)
        {
            foreach (Mechanic mechanic in Mechanic.listOfMechanics)
                cmbMechanic.Items.Add(mechanic);
        }

        private void cmbMechanic_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvRaport.Rows.Clear();

            Mechanic mechanic = (Mechanic)cmbMechanic.SelectedItem;

            decimal sum = 0;

            for (int i = 0; i < Repair.listOfRepairs.Count; i++)
            {
                if (Repair.listOfRepairs[i].mechanic.ToString() == mechanic.ToString())
                {
                    sum += Repair.listOfRepairs[i].costsOfParts + Repair.listOfRepairs[i].workTime * mechanic.wage;

                    int index = dgvRaport.Rows.Add();

                    dgvRaport.Rows[index].Cells[0].Value = Repair.listOfRepairs[i].vehicleRegisterNr;
                    dgvRaport.Rows[index].Cells[1].Value = Repair.listOfRepairs[i].repairDate.ToShortDateString();
                    dgvRaport.Rows[index].Cells[2].Value = Repair.listOfRepairs[i].mechanic;
                    dgvRaport.Rows[index].Cells[3].Value = Repair.listOfRepairs[i].costsOfParts;
                    dgvRaport.Rows[index].Cells[4].Value = Repair.listOfRepairs[i].workTime;
                }
            }

            lblSum.Text = sum.ToString();
        }
    }
}
 