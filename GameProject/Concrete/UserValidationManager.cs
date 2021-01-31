using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Customer customer)
        {
            if (customer.BirthYear == 1985 && customer.FirstName == "ENGİN"
                && customer.LastName == "DEMİROĞ" && customer.NationalId == "12345")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
