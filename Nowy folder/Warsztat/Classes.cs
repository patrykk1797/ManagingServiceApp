using System;
using System.Collections.Generic;

namespace Warsztat
{
    [Serializable]
    class Mechanic
    {
        public string firstName;

        public string lastName;

        public DateTime beginDate;

        public decimal wage;

        public static List<Mechanic> listOfMechanics = new List<Mechanic>();

        public Mechanic(string _firstName, string _lastName, DateTime _beginDate, decimal _wage)
        {
            firstName = _firstName;
            lastName = _lastName;
            beginDate = _beginDate;
            wage = _wage;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName},  {beginDate} - stawka ({wage}zł/h)";
        }

    }
    [Serializable]
    class Repair
    {
        public string vehicleRegisterNr;

        public DateTime repairDate;

        public Mechanic mechanic;

        public decimal costsOfParts;

        public int workTime;

        public static List<Repair> listOfRepairs = new List<Repair>();

        public Repair(string _registry, DateTime _repairDate, Mechanic _mechanic, decimal _costsOfParts, int _workTime)
        {
            vehicleRegisterNr = _registry;
            repairDate = _repairDate;
            mechanic = _mechanic;
            costsOfParts = _costsOfParts;
            workTime = _workTime;
        }
    }
}
