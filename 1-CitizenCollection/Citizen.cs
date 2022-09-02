using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_CitizenCollection
{
    internal abstract class Citizen : IEquatable<Citizen>
    {
        internal protected string Name { get; set; }
        internal protected int YearOfBirth { get; set; }
        internal protected string PassportNumber { get; set; }

        public Citizen(string name, int yearOfBirth, string passportNumber)
        {
            Name = name;
            YearOfBirth = yearOfBirth;
            PassportNumber = passportNumber;
        }
        public bool Equals(Citizen citizen)
        {
            if (citizen == null)
                return false;

            if (Object.ReferenceEquals(this, citizen))
            {
                return true;
            }
            if (citizen is Citizen)
            {
                Citizen a = (Citizen)citizen;
                if (a.PassportNumber == this.PassportNumber)
                    return true;
            }
            return false;
        }
    }
}
