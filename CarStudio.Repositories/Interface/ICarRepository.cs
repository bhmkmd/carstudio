using CarStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStudio.Repositories.Interface
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();
    }
}
