using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;

namespace ДЗ_12
{
    [Serializable]
    public abstract class BaseFruit
    {
        //поля
        private string color;
        private string variety;
        private int size;
        private string peel;
        private double weight;

        //свойства
        public string Color { get { return color; } set { color = value; } }
        public string Grade { get { return variety; } set { variety = value; } }
        public int Size { get { return size; } set { size = value; } }
        public string Peel { get { return peel; } set { peel = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

        //конструктор без параметров
        public BaseFruit()
        {

        }

        //конструктор с параметрами
        public BaseFruit(string Color, string Variety, int Size, string Peel, double Weight)
        {
            this.color = Color;
            this.variety = Variety;
            this.size = Size;
            this.peel = Peel;
            this.weight = Weight;
        }

        //метод(ы)
        public virtual void Seeds()
        {
            Console.WriteLine("I give seeds, but can be not:)");
        }
        public abstract void PrintFruit();
    }
}