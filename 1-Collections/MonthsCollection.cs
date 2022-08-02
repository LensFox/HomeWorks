using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Collections
{
    internal class MonthsCollection<Month> : ICollection<Month>
    {
        Month[] months = new Month[0];
        public int Count { get { return months.Length; } set { } }
        public bool IsReadOnly { get { return false; } }
        public void Add(Month month)
        {
            Month[] newMonths = new Month[months.Length + 1];
            months.CopyTo(newMonths, 0);
            newMonths[newMonths.Length - 1] = month;
            months = newMonths;
        }
        public void Clear()
        {
            months = new Month[0];
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
