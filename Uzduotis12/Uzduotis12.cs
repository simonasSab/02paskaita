namespace Paskaita02
{
    public class Uzduotis12
    {
        // 9. Parašykite programą, kuri paprašo vartotojo įvesti tekstą.
        // Naudokite for ciklą, kad suskaičiuotumėte ir išvestumėte kiekvienos raidės
        // (A-Z, nepaisant didžiosios ar mažosios raidės) pasikartojimo skaičių tekste.
        // Norėdami tai padaryti, galite naudoti 26 elementų masyvą, kur kiekvienas indeksas atitinka raidę
        // (pvz., 0 atitinka A, 1 - B ir t.t.), o reikšmė masyve atitinka raidės pasikartojimo skaičių.

        public static void Main(String[] args)
        {
            string text;

            // Get string from user
            do
            {
                Console.WriteLine("Iveskite teksta");
                text = Console.ReadLine();
            }
            while (text == null);

            text = text.ToUpper();

            // Create 26-elements long empty array for keeping letter count
            int[] letterCount = new int[26];

            // Count letters in string
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    letterCount[(int)text[i] - 65]++;
                }
                catch
                {
                    continue;
                }
            }

            // Go through array and print entries
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine($"{(char)(i + 65)} pasikartoja {letterCount[i]} kartu(-s)");
            }
        }
    }
}
