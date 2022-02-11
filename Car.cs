using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarService.Models
{
    public class Car
    {
        public string Car_ID { get; }
        public string Car_Model { get; set; }
        public string Car_Date { get; set; }
        public string Car_description { get; set; }
        public string Car_image { get; set; }
        public string Car_Properties { get; set; }
        public string Car_Price { get; set; }
        public string Car_Valuta { get; set; }
    }
}