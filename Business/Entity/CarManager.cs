using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Entity.InMemory;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entity
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }

        public CarManager()
        {

        }
        public List<Car> GetAllCars()
        {
            return _carDal.GetAllCars();
        }
    }
}
