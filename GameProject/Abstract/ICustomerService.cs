using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
     interface ICustomerService
    {
        Customer Add(Customer customer);


        void Update(List<Customer> customers);


        Customer Delete(List<Customer> customers);

        void ListCustomers(List<Customer> customers);
            
        
    }
}
