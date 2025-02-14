using CarStudio.Models;
using CarStudio.Repositories.Interface;
using CarStudio.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CarStudio.Services.Services
{
    public class CarServices:ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IConfiguration _configHelper;
        public CarServices(ICarRepository carRepository, IConfiguration configHelper) {
            _carRepository=carRepository;
            _configHelper=configHelper;
        }
        public List<Car> GetAllCars() {
            List<Car> lstCars = new List<Car>();
            if (_configHelper["AppSettings:appToken"].ToString()== "a123-b567-c890")
                lstCars=_carRepository.GetAllCars();
            return lstCars;

        }

    }
}
