using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAllCars();
        void Add(Car car);
        void Update(Car car);

        void Delete(Car car);
        List<Car> GetCarsByBrandId( int brandId);
    }
}
