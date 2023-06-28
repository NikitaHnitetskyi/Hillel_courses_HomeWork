using Ninject;
using NinjectExample;

var module = new CarModule();
var kernel = new StandardKernel(module);
var car = kernel.Get<ICar>();

car.ShowWheelInfo();
car.Move();
