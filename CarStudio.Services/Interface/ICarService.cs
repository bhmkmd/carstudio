using CarStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStudio.Services.Interface
{
    public interface ICarService
    {

        List<Car> GetAllCars();
    }
}
