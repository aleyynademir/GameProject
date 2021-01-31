using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamesManager : IGameService 
    {
        public Games Add(Games games)
        {
            Console.Write("Oyun id'si giriniz: ");
            games.GameId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyun Adı giriniz: ");
            games.GameName = Console.ReadLine();
            Console.Write("Oyun çıkış yılını giriniz: ");
            games.GameReleaseYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyun türünü giriniz:");
            games.GameType = Console.ReadLine();
            Console.Write("Oyun Fiyatını giriniz:");
            games.Price = Convert.ToDouble(Console.ReadLine());
            return games;
        }


        public Games Delete(List<Games> games)
        {
            Console.Write("Silmek İStediğiniz oyun id'si giriniz:");
            int id = Convert.ToInt32(Console.ReadLine());
            return games.Find(x => x.GameId == id);
        }

        public void ListGames(List<Games> games)
        {
            foreach (var item in games)
            {
                Console.WriteLine("Id: " + item.GameId + "\n" + "Ad: " + item.GameName + "\n" + "Çıkış Yılı: " + item.GameReleaseYear + "\n" + "Fiyat: " + item.Price);
            }
        }

        public void Update(List<Games> games)
        {
            Console.Write("Güncellemek istediğiniz oyun id' sini giriniz ");
            int id = Convert.ToInt32(Console.ReadLine());
            var game = games.Find(x => x.GameId == id);
            Console.Write("Oyun Adı giriniz:");
            game.GameName = Console.ReadLine();
            Console.Write("Oyun çıkış yılını giriniz:");
            game.GameReleaseYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyun fiyatını giriniz: ");
            game.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Oyun türünü giriniz: ");
            game.GameType = Console.ReadLine();
            
        }
    }
}
