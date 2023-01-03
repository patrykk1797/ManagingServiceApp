using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Warsztat
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }
        private void Menu_Load(object sender, EventArgs e)
        {
            Mechanic one = new Mechanic("Tomasz", "Jabłoński", DateTime.Parse("2004-03-12"), 80);
            Mechanic two = new Mechanic("Grzegorz", "Stefaniak", DateTime.Parse("2013-02-01"), 65);
            Mechanic three = new Mechanic("Paweł", "Grzesiak", DateTime.Parse("2019-03-20"), 50);
            Mechanic four = new Mechanic("Arek", "Wnuk", DateTime.Parse("2014-05-05"), 50);

            Mechanic.listOfMechanics.Add(one);
            Mechanic.listOfMechanics.Add(two);
            Mechanic.listOfMechanics.Add(three);
            Mechanic.listOfMechanics.Add(four);

            try
            {
                FileStream fs = new FileStream("repairList.txt", FileMode.Open, FileAccess.Read);

                BinaryFormatter bf = new BinaryFormatter();

                Repair.listOfRepairs = (List<Repair>)bf.Deserialize(fs);

                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Brak pliku repairList.txt - lista napraw będzie pusta.");
            }
        }

        private void btnMechanics_Click(object sender, EventArgs e)
        {
            MechanicsList mechanicsList = new MechanicsList();
            mechanicsList.Show();
        }

        private void btnRepairs_Click(object sender, EventArgs e)
        {
            Repairs repairs = new Repairs();
            repairs.Show();
        }

        private void btnAddRepair_Click(object sender, EventArgs e)
        {
            AddRepair naprawa = new AddRepair();
            naprawa.Show();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            Raport raport = new Raport();
            raport.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();

            if (Repair.listOfRepairs.Count > 0)
            {
                FileStream fs = new FileStream("repairList.txt", FileMode.Create, FileAccess.Write);

                bf.Serialize(fs, Repair.listOfRepairs);

                fs.Close();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
} 