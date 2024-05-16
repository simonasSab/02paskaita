namespace AntraPaskaita
{
    public class Uzduotis11
    {
        // 8. Užduotis: Skaičių filtravimas. Parašykite programą, kurioje vartotojas įveda skaičių seriją į masyvą,
        // o programa naudoja for ciklą ir if teiginį, kad atrinktų ir išvestų tik tuos skaičius,
        // kurie yra didesni už vidutinę visų įvestų skaičių reikšmę.
        public static void Main(String[] args)
        {
            bool correctType = false;
            int entriesAmount = 0;
            int sum = 0;
            int average = 0;

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

            // Go through array and calculate sum
            for (int i = 0; i < entriesAmount; i++)
            {
                sum += entries[i];
            }

            average = sum / entriesAmount;

            // Go through array and print entries larger than average
            for (int i = 0; i < entriesAmount; i++)
            {
                if (entries[i] > average)
                    Console.WriteLine($"{i}-oji reiksme {entries[i]} yra didesne uz vidurki {average}");
            }
        }
    }
}
