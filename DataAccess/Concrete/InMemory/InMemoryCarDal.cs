using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1, CategoryId=1,BrandId=1, ColorId=1 },
                new Car{CarId=2, CategoryId=2,BrandId=2, ColorId=2 },

                new Car{CarId=3, CategoryId=3,BrandId=3, ColorId=3 },

                new Car{CarId=4, CategoryId=4,BrandId=4, ColorId=4 }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);  
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars; 
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;

        }
    }
}
