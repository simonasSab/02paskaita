namespace Paskaita02
{
    public class Uzduotis10
    {
        // 7. Užduotis: Maksimalios ir minimalios reikšmės radimas.
        // Sukurkite programą, kuri paprašo vartotojo įvesti skaičių seriją į masyvą.
        // Naudokite for ciklą, kad rastumėte didžiausią ir mažiausią skaičius masyve.
        // Panaudokite if sąlyginius teiginius, kad nustatytumėte, kuris skaičius yra didžiausias,
        // o kuris - mažiausias, ir išveskite juos į ekraną.
        public static void Main(String[] args)
        {
            bool correctType = false;
            int entriesAmount = 0;
            int maxValue = 0;
            int minValue;

            // Get number of entries
            do
            {
                Console.WriteLine("Kiek skaiciu noretumete ivesti?");
                correctType = int.TryParse(Console.ReadLine(), out entriesAmount);
            }
            while (!correctType || entriesAmount < 0);

            // Create array of length entriesAmount
            int[] entries = new int[entriesAmount];

            // Populate array with user input integers
            for (int i = 0; i < entriesAmount; i++)
            {
                do
                {
                    Console.WriteLine($"Iveskite sveikaji skaiciu nr. {i + 1}: ");
                    correctType = int.TryParse(Console.ReadLine(), out entries[i]);
                }
                while (!correctType);
            }

            // Go through array and find largest integer
            for (int i = 0; i < entriesAmount; i++)
            {
                if (entries[i] >= maxValue)
                    maxValue = entries[i];
            }

            // Go through array and find smallest integer
            minValue = entries[0];
            for (int i = 0; i < entriesAmount; i++)
            {
                if (entries[i] <= minValue)
                    minValue = entries[i];
            }

            Console.WriteLine($"Maziausias ivestas skaicius yra {minValue}, didziausias ivestas skaicius yra {maxValue}");
        }
    }
}
