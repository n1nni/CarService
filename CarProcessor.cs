using CarService.Models;
using CarService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.Processor
{
    public class CarProcessor
    {
        public static bool ProcessCar(Car car)
        {
            return CarRepository.AddCarToBD(car);
        }
        public static bool deleteCars(Car car)
        {
            return CarRepository.DeleteCarFromBD(car);
        }
        public static bool selectCar(Car car)
        {
            return CarRepository.SelectCarFromBD(car);
        }
    }
}