using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }


            
        }

        public static bool MainMenu()
        {
            Customer customer1 = new Customer() { CustomerId = 1, FirstName = "Aleyna", LastName = "Demir", BirthYear = 2000, NationalId = "225552" };
            Customer customer2 = new Customer() { CustomerId = 2, FirstName = "Sude", LastName = "Karagüney", BirthYear = 2000, NationalId = "22555452" };
            List<Customer> customer = new List<Customer>() {customer1,customer2 };
            ICustomerService customerManager = new CustomerManager(new UserValidationManager());
            Games games1 = new Games() { GameId = 1, GameName = "CS-GO", GameReleaseYear = 2005, GameType = "Action", Price = 250 };
            List<Games> games = new List<Games>() { games1};
            IGameService gameManager = new GamesManager();
            

            Console.WriteLine("Merhaba Hoşgeldiniz..\n"+
            "++++++++++++++++++++++++++++++++++++\n"+    
            "Lütfen yapmak istediğiniz işlemi seçiniz.\n" +
            "1. Oyuncu İşlemleri\n" +
            "2. Oyun İşlemleri\n" +
            "3. Çıkış");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz:\n" +
                        "1. Oyuncu Ekle\n" +
                        "2. Oyuncu Sil\n" +
                        "3. Oyuncu Güncelle\n" +
                        "4. Oyuncu Listele\n" +
                        "5. Çıkış\n");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            customer.Add(customerManager.Add(new Customer()));
                            break;
                        case "2":
                            customer.Remove(customerManager.Delete(customer));
                            break;
                        case "3":
                            customerManager.Update(customer);
                            break;
                        case "4":
                            customerManager.ListCustomers(customer);
                            break;
                        case "5":
                            Console.WriteLine("Çıkış yapıldı");
                            break;
                        default:
                            Console.WriteLine("Yanlış tuşlama yaptınız!!");
                            break;
                    }
                    return true;

                case "2":
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.\n" +
                    "1. Oyun Ekle\n" +
                    "2. Oyun Sil\n" +
                    "3. Oyun Güncelle\n" +
                    "4. Oyun Listele\n" +
                    "5. Çıkış");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            games.Add(gameManager.Add(new Games()));
                            break;
                        case "2":
                            games.Remove(gameManager.Delete(games));
                            break;
                        case "3":
                            gameManager.Update(games);
                            break;
                        case "4":
                            gameManager.ListGames(games);
                            break;
                        case "5":
                            Console.WriteLine("Çıkış Yaptınız.");
                            break;
                        default:
                            Console.WriteLine("Hatalı tuşlama yaptınız!!");
                            break;

                    }
                    return true;

                case "3":
                    return false;
                default:
                    Console.WriteLine("Yanlış tuşlama yaptınız!!");
                    return true;

            }
        }

    }
}
