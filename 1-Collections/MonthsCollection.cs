using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1_Collections
{
    internal class MonthsCollection<Month> : ICollection<Month>
    {
        Month[] months = Array.Empty<Month>();
        public int Count
        {
            get
            {
                return months.Length;
            }
            set { }
        }
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        public void Add(Month month)
        {
            Month[] newMonths = new Month[months.Length + 1];
            months.CopyTo(newMonths, 0);
            newMonths[newMonths.Length - 1] = month;
            months = newMonths;
        }
        public void Clear()
        {
            months = Array.Empty<Month>();
        }
        public bool Contains(Month month)
        {
            foreach (Month item in months)
            {
                if (item.Equals(month))
                    return true;
            }
            return false;
        }
        public void CopyTo(Month[] arr, int index)
        {
            months.CopyTo(arr, index);
        }
        public bool Remove(Month month)
        {
            if (months.Contains(month))
            {
                var newMonths = new Month[months.Length - 1];

                int j = 0;
                for (int i = 0; i < months.Length; i++)
                {
                    if (months[i].Equals(month))
                    {
                        continue;
                    }

                    newMonths[j] = months[i];
                    j++;
                }
                months = newMonths;
                return true;
            }
            return false;
        }
        public IEnumerable<Month> ChooseByNumberOfDays(int numberOfDays)
        {
            try
            {
                if (numberOfDays > 31 && numberOfDays < 28)
                    throw new Exception("Impossible number");
                if (!months.Any())
                    throw new Exception("There are no months added");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            foreach (Month month in months)
            {
                if (month.DaysInMonth == numberOfDays)
                    yield return month;
            }

        }
        public Month ChooseByOrderNumber(int orderNumber)
        {
            try
            {
                if (orderNumber > 12 && orderNumber < 1)
                    throw new Exception("Impossible number");
                if (!months.Any())
                    throw new Exception("There are no months added");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            foreach (Month month in months)
            {
                if (month.NumberOfDays == orderNumber)
                    return month;
            }
            return default;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<Month>).GetEnumerator();
        }
        public IEnumerator<Month> GetEnumerator()
        {
            return ((IEnumerable<Month>)months).GetEnumerator();
        }
    }
}
