// See https://aka.ms/new-console-template for more information

namespace Paskaita02
{
    public class Uzduotis05
    {
        // 2. Užduotis: Atvirkštinis skaičių išvedimas
        // Parašykite programą naudojant for ciklą, kuri paprašo vartotojo įvesti skaičių n
        // ir tada išveda visus skaičius nuo n iki 1 atvirkštine tvarka.
        // Kiekvienas skaičius turi būti atskirtas nauja eilute.
        public static void Main(String[] args)
        {
            ulong n = 0;
            bool isUlong = false;

            do
            {
                Console.WriteLine("Iveskite sveikaji teigiama skaiciu: ");
                isUlong = ulong.TryParse(Console.ReadLine(), out n);
            }
            while (!isUlong || n < 1);

            for (n = n; n > 0; n--)
            {
                Console.WriteLine(n + "\n");
            }
        }
    }
}
