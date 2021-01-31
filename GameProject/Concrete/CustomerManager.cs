using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerManager : ICustomerService
    {
        IUserValidationService _userValidationService;

        public CustomerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public Customer Add(Customer customer)
        {
            Console.Write("Oyuncu Id: ");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncu Adı: ");
            customer.FirstName = Console.ReadLine();
            Console.Write("Oyuncu Soyadı: ");
            customer.LastName = Console.ReadLine();
            Console.Write("Oyuncu Doğum Yılı: ");
            customer.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncu TC: ");
            customer.NationalId = (Console.ReadLine());
            return customer;


           
        }


        public Customer Delete(List<Customer> customers)
        {
            Console.Write("Silmek istediğiniz oyuncunun id sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            return customers.Find(x => x.CustomerId == id);
        }

        public void ListCustomers(List<Customer> customers)
        {
            foreach (var customerss in customers)
            {
                Console.WriteLine("Id: " + customerss.NationalId + "\n" + "Ad Soyad: " + customerss.FirstName + " " + customerss.LastName + "\n" + "Doğum Yılı: " + customerss.BirthYear + "\n" + "TC: " + customerss.NationalId);
            }
        }

        public void Update(List<Customer> customers)
        {
            Console.Write("Güncellemek istediğiniz oyuncunun id'sini giriniz: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var customer =customers.Find(x => x.CustomerId == id);
            Console.Write("Oyuncu Id: ");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncu Adı: ");
            customer.FirstName = Console.ReadLine();
            Console.Write("Oyuncu Soyadı: ");
            customer.LastName = Console.ReadLine();
            Console.Write("Oyuncu Doğum Yılı: ");
            customer.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncu TC: ");
            customer.NationalId = (Console.ReadLine());

            if (_userValidationService.Validate(customer) == true)
            {
                Console.WriteLine("okey");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
        }
    }
}
