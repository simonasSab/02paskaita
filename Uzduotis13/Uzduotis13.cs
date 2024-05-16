namespace Paskaita02
{
    public class Uzduotis13
    {
        // 1. Sukurkite masyvą su dešimties augalų pavadinimais.
        // 2. Atspausdinkite kiekvieną uždavinio augalą atskiroje eilutėje.
        // 3. Atspausdinkite uždavinio kiekvieną augalą pradedant nuo paskutinio, ir baigiant pirmuoju. (atvirkščias ciklas).
        // 4. Suskaičiuokite kiek uždavinio masyve yra žodžių trumpesnių nei 5 simboliai, ir kiek ilgesnių nei 7 simboliai. (du skaičiavimai)
        // 5. Suskaičiuokite kiek uždavinio masyve yra žodžių ilgesnių nei 5 simboliai bet trumpesnių nei 10 simboliai. (tarp 5 ir 10 simbolių ilgio)

        public static void Main(String[] args)
        {
            // 1. Create 10-elements long array for keeping plant names
            string[] plantNames =
            {
                "Cannabis sativa",
                "Picea jezoensis",
                "Theobroma cacao",
                "Coffea arabica",
                "Banisteriopsis caapi",
                "Psychotria viridis",
                "Erythroxylum coca",
                "Solanum lycopersicum",
                "Cucumis sativus",
                "Spinacia oleracea"
            };

            // 2. Print every plant name in its own line
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(plantNames[i]);
            }

            Console.WriteLine();

            // 3. Print every plant name in its own line starting from the last
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(plantNames[i]);
            }

            Console.WriteLine();

            // 4. Count and print how many words in array are shorter than 5 symbols and how many are longer than 7 symbols
            //    I am interpretting that a WORD is a collection of LETTERS only.

            int asciiCode;
            int wordLength;
            int shortWords = 0;
            int longWords = 0;

            for (int i = 0; i < 10; i++)
            {
                // Formatting strings to uppercase for easier access
                plantNames[i] = plantNames[i].ToUpper();
                wordLength = 0;

                // Iterate through string chars and identify words
                for (int j = 0; j < plantNames[i].Length; j++)
                {
                    asciiCode = plantNames[i][j];

                    if (asciiCode > 64 && asciiCode < 91)
                    {
                        wordLength++;
                        if (j == plantNames[i].Length - 1)
                        {
                            if (wordLength < 5)
                            {
                                shortWords++;
                            }
                            else if (wordLength > 7)
                            {
                                longWords++;
                            }
                        }
                    }
                    else if (wordLength > 0 && wordLength < 5)
                    {
                        wordLength = 0;
                        shortWords++;
                    }
                    else if (wordLength > 7)
                    {
                        wordLength = 0;
                        longWords++;
                    }
                }
            }

            Console.WriteLine($"{shortWords} zodziai(-is/-iu) trumpesni nei 5 raides, {longWords} zodziai(-is/-iu) ilgesni nei 7 raides.");

            // 5. Count and print how many words in array are 6 to 9 letters long

            int words6to9 = 0;

            for (int i = 0; i < 10; i++)
            {
                wordLength = 0;

                // Iterate through string chars and identify words
                for (int j = 0; j < plantNames[i].Length; j++)
                {
                    asciiCode = plantNames[i][j];

                    if (asciiCode > 64 && asciiCode < 91)
                    {
                        wordLength++;
                        if (j == plantNames[i].Length - 1)
                        {
                            if (wordLength > 5 && wordLength < 10)
                            {
                                words6to9++;
                            }
                        }
                    }
                    else if (wordLength > 5 && wordLength < 10)
                    {
                        wordLength = 0;
                        words6to9++;
                    }
                }
            }

            Console.WriteLine($"{words6to9} zodziai(-is/-iu) yra nuo 6 iki 9 simboliu ilgio.");
        }
    }
}
