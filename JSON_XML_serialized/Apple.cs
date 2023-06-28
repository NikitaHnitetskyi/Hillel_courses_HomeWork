using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;

namespace ДЗ_12
{
    [Serializable]
    public class Apple : BaseFruit
    {
        //поля
        private int numberofpips;

        //свойства
        public int Numberofpips { get { return numberofpips; } set { numberofpips = value; } }
        public int MyProperty { get; set; }

        //конструктор без параметров
        public Apple() : base()
        {

        }

        //конструктор с параметрами
        public Apple(int Numberofpips, string Color, string Variety, int Size, string Peel, double Weight)
            : base(Color, Variety, Size, Peel, Weight)
        {
            this.numberofpips = Numberofpips;
        }
        //переопределенный метод
        public override void Seeds()
        {
            Console.WriteLine("Givin seeds apple!");
        }
        public override void PrintFruit()
        {
            Console.WriteLine($"Number of pips: {Numberofpips} \nColor: {Color} \nGrade: {Grade} \nSize: {Size} \nPeel: {Peel} \nWeight: {Weight}");

        }
    }
}
