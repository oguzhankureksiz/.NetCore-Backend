using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var car in carManager.GetAllByColor(2))
{
    Console.WriteLine(car.Description);
}