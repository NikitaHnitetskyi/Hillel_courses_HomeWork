using Ninject;
using Ninject.Modules;

namespace NinjectExample
{
    public class CarModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ICar>().To<Car>();
            this.Bind<IEngine>().To<Engine>().InThreadScope();
            this.Bind<IWheels>().ToMethod(ctx => new Wheels(50));
        }
    }
}
