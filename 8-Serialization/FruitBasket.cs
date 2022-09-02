using System;
using System.Xml.Serialization;

namespace _8_Serialization
{
    [Serializable]
    public class FruitBasket
    {

        [XmlAttribute] public int AppleNumber { get; set; }
        [XmlAttribute] public int PearNumber { get; set; }
        [XmlAttribute] public int KiwiNumber { get; set; }
        [XmlAttribute] public string AppleKind { get; set; }
    }
}
