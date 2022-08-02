using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1_CitizenCollection
{
    /*
    Создайте абстрактный класс Гражданин. Создайте классы Студент, Пенсионер, Рабочий
унаследованные от Гражданина. Создайте непараметризированную коллекцию со следующим
функционалом:
1. Добавление элемента в коллекцию.
1) Можно добавлять только Гражданина.
2) При добавлении, элемент добавляется в конец коллекции. Если Пенсионер, – то в
начало с учетом ранее стоящих Пенсионеров. Возвращается номер в очереди.
3) При добавлении одного и того же человека (проверка на равенство по номеру
паспорта, необходимо переопределить метод Equals и/или операторы равенства для
сравнения объектов по номеру паспорта) элемент не добавляется, выдается
сообщение.
2. Удаление
1) Удаление – с начала коллекции.
2) Возможно удаление с передачей экземпляра Гражданина.
3. Метод Contains возвращает true/false при налчичии/отсутствии элемента в коллекции и
номер в очереди.
4. Метод ReturnLast возвращsает последнего чеолвека в очереди и его номер в очереди.
5. Метод Clear очищает коллекцию.
6. С коллекцией можно работать опертаором foreach.
     */
    internal class CitizenCollection<T> : IEnumerable<T> where T : Citizen
    {
        T[] citizensList = new T[0];
        public int Count
        {
            get
            {
                return citizensList.Length;
            }
            set
            { }
        }
        public int Add(T citizen)
        {
            try
            {
                foreach (var item in citizensList)
                {
                    if (item.Equals(citizen))
                        throw new Exception("This citizen already exists in the list");
                }

                T[] newList = new T[citizensList.Length + 1];

                if (citizen is Retired)
                {
                    citizensList.CopyTo(newList, 1);
                    newList[0] = citizen;
                    return 1;
                }

                citizensList.CopyTo(newList, 0);
                newList[newList.Length - 1] = citizen;
                citizensList = newList;

                return citizensList.Length;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }

        public void Clear()
        {
            citizensList = new T[0];
        }
        public bool Contains(T citizen, out int number)
        {
            number = Array.IndexOf(citizensList, citizen);
            
            return number != -1;
        }

        public void CopyTo(T[] arr, int index)
        {
            citizensList.CopyTo(arr, index);
        }
        public bool Remove()
        {
            if (this != null)
            {
                var newList = new T[citizensList.Length - 1];

                for (int i = 0; i < newList.Length; i++)
                {
                    newList[i] = citizensList[i];
                }
                citizensList = newList;
                return true;
            }
            return false;
        }

        public bool Remove(T citizen)
        {
            if (citizensList.Contains(citizen))
            {
                var newList = new T[citizensList.Length - 1];

                int j = 0;
                for (int i = 0; i < citizensList.Length; i++)
                {
                    if (citizensList[i].Equals(citizen))
                    {
                        continue;
                    }

                    newList[j] = citizensList[i];
                    j++;
                }
                citizensList = newList;
                return true;
            }
            return false;
        }
        public Citizen ReturnLast(out int number)
        {
            number = citizensList.Length - 1;
            if (citizensList.Any())
                return null;
            return citizensList[^1];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<T>).GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)citizensList).GetEnumerator();
        }
    }
}

