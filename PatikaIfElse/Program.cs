using System;

namespace PatikaIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 5 && 11 >= time)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
                Console.WriteLine("iyi günler");
            else
                Console.WriteLine("iyi geceler");

            string sonuc = time <= 10 ? "iyi günler" : "iyi geceler";

            sonuc = time >= 5 && time < 11 ? "GÜNAYDIN" : time <= 18 ? "iyi günler " : "İYİ GECELER";
            Console.WriteLine(sonuc);
        }
    }
}
