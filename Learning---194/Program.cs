using System;

namespace Learning___194
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    Calc();
                    Console.WriteLine("Jesli chcesz zakończyć program wpisz Tak / tak. Jeśli chcesz dalej kontynować wciśjnij inny przycisk:");
                    string end = Console.ReadLine();
                    if (end == "Tak" || end == "tak" || end == "tAk" || end == "tAk")
                    {
                        break;
                    }
                    Console.Clear();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Calc()
        {
            Console.WriteLine("Zgadnij liczbę!");
            Console.WriteLine("Wybierz liczbę od 1 do 50: ");
            int user = int.Parse(Console.ReadLine());

            Random rand = new Random();
            int aI = rand.Next(1, 50);

            int count = 0;
            while (true)
            {


                if (user == aI)
                {
                    Console.WriteLine($"Liczna komputera to: {aI}");
                    Console.WriteLine("Zgadłeś liczbę! ");
                    break;
                }
                else if (user > aI)
                {
                    count++;
                    Console.WriteLine("Liczba jest za duża!");
                    Console.WriteLine("Wprowadź liczbę ponownie: ");
                    user = int.Parse(Console.ReadLine());
                    continue;
                }
                else
                {
                    count++;
                    Console.WriteLine("Liczba jest za mała!");
                    Console.WriteLine("Wprowadź liczbę ponownie: ");
                    user = int.Parse(Console.ReadLine());
                    continue;
                }

            }


            Console.WriteLine($"Twoje próby to: {count}");
        }
    }
}
