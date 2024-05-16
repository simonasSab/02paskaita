// See https://aka.ms/new-console-template for more information

namespace AntraPaskaita
{
    public class Uzduotis08
    {
        // 5. Užduotis: Sukurkite programą, kuri naudoja while ciklą, norint suskaičiuoti ir išvesti įvesto skaičiaus skaitmenų sumą.
        // Programa turi paprašyti vartotojo įvesti skaičių ir tada apskaičiuoti bei išvesti skaitmenų sumą.
        // Pvz., jei vartotojas įveda 123, programa turėtų išvesti 6 (1+2+3).
        public static void Main(String[] args)
        {
            bool isInt = false;
            string numberString;
            int suma = 0;
            int i = 0;

            do
            {
                Console.WriteLine("Iveskite sveikaji teigiama skaiciu: ");
                numberString = Console.ReadLine();
                isInt = int.TryParse(numberString, out int n);
            }
            while (!isInt);
            
            while (i < numberString.Length)
            {
                suma += (int)char.GetNumericValue(numberString, i);
                i++;
            }

            Console.WriteLine($"Skaiciaus {numberString} skaitmenu suma: {suma}");
        }
    }
}
