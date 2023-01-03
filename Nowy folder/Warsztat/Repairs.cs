using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Warsztat
{
    public partial class Repairs : Form
    {
        public Repairs()
        {
            InitializeComponent();
        }

        private void PokażNaprawy_Load(object sender, EventArgs e)

        {
            for (int i = 0; i < Repair.listOfRepairs.Count; i++)
            {
                dgvRepairList.Rows.Add();
                dgvRepairList.Rows[i].Cells[0].Value = Repair.listOfRepairs[i].vehicleRegisterNr;
                dgvRepairList.Rows[i].Cells[1].Value = Repair.listOfRepairs[i].repairDate.ToShortDateString();
                dgvRepairList.Rows[i].Cells[2].Value = Repair.listOfRepairs[i].mechanic;
                dgvRepairList.Rows[i].Cells[3].Value = Repair.listOfRepairs[i].costsOfParts;
                dgvRepairList.Rows[i].Cells[4].Value = Repair.listOfRepairs[i].workTime;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal cena = Repair.listOfRepairs[0].workTime*Repair.listOfRepairs[0].mechanic.wage;
            for (int i = 0; i < Repair.listOfRepairs.Count; i++)
            {

                if (Repair.listOfRepairs[i].workTime*Repair.listOfRepairs[i].mechanic.wage < cena)

                {

                   cena = Repair.listOfRepairs[i].workTime * Repair.listOfRepairs[i].mechanic.wage;

                    

                }

                numericUpDown1.Value = cena;

            }




        }
       
    }
}

