// See https://aka.ms/new-console-template for more information

namespace AntraPaskaita
{
    public class Uzduotis06
    {
        // 3. Užduotis: Skaičių, kurie dalijasi iš 3, paieška.
        // Sukurkite programą, kuri naudoja while ciklą norint rasti ir išvesti pirmus 10 skaičių nuo 1 iki 100,
        // kurie dalijasi iš 3 be liekanos. Programa turi išvesti šiuos skaičius vieną po kito, kiekvieną naujoje eilutėje.
        public static void Main(String[] args)
        {
            int n = 1;
            int k = 0;

            while (n < 101)
            {
                if (n % 3 == 0)
                {
                    k++;
                    Console.WriteLine(n);

                    if (k == 10)
                        return;
                }

                n++;
            }
        }
    }
}
