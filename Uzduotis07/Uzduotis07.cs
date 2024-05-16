// See https://aka.ms/new-console-template for more information

namespace Paskaita02
{
    public class Uzduotis07
    {
        // 4. Užduotis: Parašykite programą kuri prašo įvesti intervalą NUO/IKI
        // ir jame atspausdina pirminius skaičius IR skaičius kurie dalinasi iš 11 be liekanos
        public static void Main(String[] args)
        {
            int from;
            int to;

            bool isInt = false;

            do
            {
                Console.WriteLine("Iveskite sveikaji teigiama skaiciu intervalo pradziai (NUO): ");
                isInt = int.TryParse(Console.ReadLine(), out from);
            }
            while (!isInt);

            isInt = false;

            do
            {
                Console.WriteLine("Iveskite sveikaji teigiama skaiciu intervalo pabaigai (IKI): ");
                isInt = int.TryParse(Console.ReadLine(), out to);
            }
            while (!isInt || to <= from);

            while (from <= to)
            {
                if (IsPrime(from) ) 
                {
                    Console.WriteLine($"{from} - pirminis");
                }
                if (from % 11 == 0)
                {
                    Console.WriteLine($"{from} - dalus is 11");
                }

                from++;
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 5; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
