namespace NinjectExample
{
    internal class Wheels : IWheels
    {
        public int Diameter { get; private set; }

        public Wheels(int diameter)
        {
            this.Diameter = diameter;
        }
    }
}
