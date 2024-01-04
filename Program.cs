namespace SayiTaminOyunu.Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number;
            string tahmin;
            int tahminhakki;
            int sayac = 0;
            Console.WriteLine("Zorluk seçin.");
            string zorluk = Console.ReadLine();
            if (zorluk == "kolay")
            {
                number = rnd.Next(15);
                tahminhakki = 10;
            }
            else if (zorluk == "zor")
            {
                number = rnd.Next(25);
                tahminhakki = 3;
            }
            else
            {
                number = rnd.Next(20);
                tahminhakki = 5;
            }

            do
            {
                sayac++;
                tahminhakki--;
                Console.WriteLine("Tahmin edin.");
                tahmin = Console.ReadLine();
            } while (Convert.ToInt32(tahmin) != number && tahminhakki > 0);
            Console.WriteLine($"{sayac}. tahmininizde bildiniz.");
            Console.WriteLine($"Puanınız: {100 - sayac * 10}");

        }
    }
}