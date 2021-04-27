using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            if(vehicle.Id == 0)
            {
                throw new Exception("ID can't be 0");
            }

            if(String.IsNullOrEmpty(vehicle.Type))
            {
                throw new Exception("Type can't be empty");
            }

            if(vehicle.YearOfProduction == 0)
            {
                throw new Exception("Year Of Production can't be 0");
            }

            return true;
        }
    }
}
