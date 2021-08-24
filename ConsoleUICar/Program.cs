using Business.Entity;
using DataAccess.Entity.EntityFramework;
using DataAccess.Entity.InMemory;
using System;

namespace ConsoleUICar
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAllCars())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
