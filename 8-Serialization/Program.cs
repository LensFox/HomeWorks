using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace _8_Serialization
{/*
  Дополнительное задание
Создайте пользовательский тип (например, класс) и выполните сериализацию объекта этого
типа, учитывая тот факт, что состояние объекта необходимо будет передать по сети. 
    см. метод SerializeForNetwork
    Задание 2
Создайте класс, поддерживающий сериализацию. Выполните сериализацию объекта этого
класса в формате XML. Сначала используйте формат по умолчанию, а затем измените его
таким образом, чтобы значения полей сохранились в виде атрибутов элементов XML. 
    Задание 3
Создайте новое приложение, в котором выполните десериализацию объекта из предыдущего
примера. Отобразите состояние объекта на экране. 
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var fruitBasket = new FruitBasket();
            fruitBasket.KiwiNumber = 5;
            fruitBasket.AppleNumber = 10;
            fruitBasket.AppleKind = "Golden Delicious";

            //FileStream stream = File.Create(@"F:\Tests\Ser.xml");
            //XmlSerializer serializer = new(typeof(FruitBasket));
            //serializer.Serialize(stream, fruitBasket);
            //stream.Close();

            //SerializeForNetwork(fruitBasket);

            Deserialization(fruitBasket);
        }
        public static void SerializeForNetwork(FruitBasket fruitBasket)
        {
            string fileName = @"F:\Tests\FruitBasket.json";
            /*
            obsolete

            FileInfo file = new(@"F:\Tests\Ser.xml");
            FileStream stream = file.Open(@FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, fruitBasket);
            */

            string jsonString = JsonSerializer.Serialize(fruitBasket);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }
        public static void Deserialization(FruitBasket fruitBasket)
        {
            FileInfo file = new(@"F:\Tests\Ser.xml");
            FileStream stream = file.Open(@FileMode.OpenOrCreate, FileAccess.Read);
            XmlSerializer serializer = new(typeof(FruitBasket));
            serializer.Deserialize(stream);
            stream.Close();
        }
    }
}
