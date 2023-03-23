using CarListApp.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car()
                {
                    Id= 1,
                    Make = "Ferrarri",
                    Model = "Monza",
                    VIN = "123"
                },
                new Car()
                {
                    Id= 1,
                    Make = "Lamborghini",
                    Model = "Aventador",
                    VIN = "123"
                },
                new Car()
                {
                    Id= 1,
                    Make = "Nissan",
                    Model = "Skyline",
                    VIN = "123"
                },
                new Car()
                {
                    Id= 1,
                    Make = "Aston Martin",
                    Model = "DBS",
                    VIN = "123"
                },
                new Car()
                {
                    Id= 1,
                    Make = "Maserati",
                    Model = "MC20",
                    VIN = "123"
                }
            };
        }
    }
}
