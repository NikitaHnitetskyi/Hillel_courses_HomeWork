namespace NinjectExample
{
    internal class Car : ICar
    {
        private readonly IEngine engine;
        private readonly IWheels wheels;
        public Car(IEngine engine, IWheels wheels)
        {
            this.engine = engine;
            this.wheels = wheels;
        }

        public void ShowWheelInfo()
        {
            Console.WriteLine($"Wheel diameter is {wheels.Diameter}");
        }

        public void Move()
        {
            engine.Ignite();
            Console.WriteLine("I like to move it");
        }
    }
}
