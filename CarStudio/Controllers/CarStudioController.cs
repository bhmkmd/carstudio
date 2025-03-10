﻿using CarStudio.Models;
using CarStudio.Services.Interface;
using CarStudio.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarStudio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarStudioController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarStudioController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        [Route("cars")]
        public IActionResult GetAllCars() {
            var cars = _carService.GetAllCars();
            return Ok(cars);
        }

        [HttpGet]
        [Route("cars/{id}")]
        public IActionResult GetCar(int id)
        {
            var car = new Car() { Id = id, Company = "Toyota", ModelName = "Yaris", Price = 800000 };
            return Ok(car);
        }
    }
}
