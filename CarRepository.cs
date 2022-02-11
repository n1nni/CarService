using CarService.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarService.Repositories
{
    public class CarRepository
    {

        // adding new Car in Database
        public static bool AddCarToBD(Car car)
        {
            var connetionString = "Data Source=.;Initial Catalog=Car Integrated Security=True";

            var query = "INSERT INTO Cars" +
                "([Car_Model],[Car_Date],[Car_description],[Car_Properties],[Car_Price],[Car_Valuta]) values" +
                "('@model', '@date', '@description', '@properties', '@price', '@valuta')";

            query = query.Replace("@model", car.Car_Model)
                .Replace("@date", car.Car_Date)
                .Replace("@description", car.Car_description)
                .Replace("@properties", car.Car_Properties)
                .Replace("@price", car.Car_Price)
                .Replace("@valuta", car.Car_Valuta);

            SqlConnection connection = new SqlConnection(connetionString);

            try{
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // delete Car from Database
        public static bool DeleteCarFromBD(Car car)
        {
            var connetionString = "Data Source=.;Initial Catalog=Car Integrated Security=True";

            var query = "delete from Cars where Car_ID = @Car_ID";

            query = query.Replace("@Car_ID", car.Car_ID);


            SqlConnection connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // select Car from Database
        public static bool SelectCarFromBD(Car car)
        {
            var connetionString = "Data Source=.;Initial Catalog=Car Integrated Security=True";

            var query = "Select * from Cars where Car_ID = @Car_ID";

            query = query.Replace("@Car_ID", car.Car_ID);


            SqlConnection connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}