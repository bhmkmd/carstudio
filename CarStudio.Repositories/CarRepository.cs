using CarStudio.Models;
using CarStudio.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStudio.Repositories
{
    public class CarRepository:ICarRepository
    {
        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car { Id = 1, Company = "Maruti", ModelName = "Swift", Price = 500000 });
            cars.Add(new Car { Id = 2, Company = "Maruti", ModelName = "Swift Dezire", Price = 600000 });
            cars.Add(new Car { Id = 3, Company = "Tata", ModelName = "Punch", Price = 700000 });
            return cars;
        }
    }
}
