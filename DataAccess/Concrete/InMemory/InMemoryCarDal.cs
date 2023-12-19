using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id=1,BrandId=1,ColorId=1,DailyPrice=200,ModelYear=2022,Description="Toyota"},
                new Car { Id=2,BrandId=2,ColorId=2,DailyPrice=300,ModelYear=2021,Description="Ford"},
                new Car { Id=3,BrandId=3,ColorId=1,DailyPrice=250,ModelYear=2020,Description="Opel"}};
            }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var deletedCar = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(deletedCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _cars.Where(c=>c.Id==colorId).ToList();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            var updatedCar = _cars.SingleOrDefault(c=>c.Id == car.Id);
            updatedCar.DailyPrice= car.DailyPrice;
            updatedCar.ModelYear= car.ModelYear;
            updatedCar.Description= car.Description;
            updatedCar.BrandId= car.BrandId;
            updatedCar.ColorId= car.ColorId;
        }
    }
}
