﻿using System.Reflection.Metadata;

namespace App
{
    internal class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void Main(string[] args)
        {
            var users = new User[] {new User { Name = "Анатолий", IsPremium = true}, new User { Name = "Мария", IsPremium = false} };

            foreach (User user in users)
            {
                Console.WriteLine($"Здравствуйте, {user.Name}!");

                if (!user.IsPremium)
                    ShowAds();
            }
        }
    }
}