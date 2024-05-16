// See https://aka.ms/new-console-template for more information

namespace AntraPaskaita
{
    public class Uzduotis04
    {
        // 1. Užduotis: Skaičių sekos suma
        // Parašykite programą, kuri naudoja while ciklą, kad suskaičiuotų visų teigiamų skaičių,
        // mažesnių nei nurodytas skaičius 𝑛 suma.Programa turi paprašyti vartotojo įvesti skaičių 𝑛
        // ir tada išvesti suskaičiuotą sumą.
        public static void Main(String[] args)
        {
            bool isUlong = false;
            ulong n = 0;
            ulong suma = 0;

            do
            {
                Console.WriteLine("Įveskite teigiamą sveiką skaičių: ");
                isUlong = ulong.TryParse(Console.ReadLine(), out n);
            }
            while (!isUlong || n < 1);

            while (n > 0)
            {
                n--;
                suma += n;
            }

            Console.WriteLine($"Visų sveikų teigiamų skaičių, mažesnių už n, suma: {suma}");
        }
    }
}
