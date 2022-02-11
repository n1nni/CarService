using CarService.Models;
using CarService.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarService.Controllers
{
    public class CarController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("SelectCar")]
        public bool SelectCar(Car car)
        {
            if (car == null)
            {
                return false;
            }
            return CarProcessor.selectCar(car);
        }

        // POST api/values
        [HttpPost]
        [Route("SaveCar")]
        public bool SaveCar(Car car)
        {
            if (car == null)
            {
                return false;
            }
            return CarProcessor.ProcessCar(car);
        }

        // DELETE 
        [HttpDelete]
        [Route("DeleteCar")]
        public bool DeleteCar(Car car)
        {
            if (car != null)
            {
                return false;
            }
            return CarProcessor.deleteCars(car);
        }
    }
}
