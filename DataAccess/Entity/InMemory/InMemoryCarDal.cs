using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Entity.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{ CarId=1, BrandId=1, ColorId= 2, Description="Audi"},
                new Car{ CarId=2, BrandId=4, ColorId= 3, Description="Ford"},
                new Car{ CarId=3, BrandId=3, ColorId= 5, Description="BMW"},
                new Car{ CarId=4, BrandId=2, ColorId= 1, Description="Kia"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Car _carToDelete=null;
            //foreach (var c in _cars)
            //{
            //    if (c.CarId == car.CarId)
            //    {
            //        _carToDelete = c;
            //    }
            //}
            //_cars.Remove(carToDelete);

            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(car);
         }

        public List<Car> GetAllCars()
        {     
            return _cars;
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;

        }
    }
}
