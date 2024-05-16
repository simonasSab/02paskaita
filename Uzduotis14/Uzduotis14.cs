namespace Paskaita02
{
    public class Uzduotis14
    {
        // 1. Sugeneruokite 300 atsitiktinių skaičių nuo 0 iki 300, atspausdinkite juos atskirtus tarpais ir suskaičiuokite kiek tarp jų yra didesnių už 150.
        // Skaičiai didesni nei 275 turi būti atspausdinti skliausteliuose” [ ] “.-------
        // 2. Vienoje eilutėje atspausdinkite visus skaičius nuo 1 iki 3000, kurie dalijasi iš 77 be liekanos.
        // Skaičius atskirkite kableliais. Po paskutinio skaičiaus kablelio neturi būti.
        // 3. Nupieškite kvadratą iš “*”, kurio kraštines sudaro 25“*”

        public static void Main(String[] args)
        {
            // 1. Generate random numbers
            Generate300RandomNumbers();
            Console.WriteLine();

            // 2. Print all numbers [1;3000], divisible by 77, separated by commas, without a comma after the last.
            // This is a reusable method for positive integers (uint).
            ListMultiplesTidily(77, 1, 3000);
            Console.WriteLine();

            // 3. Square 25*25 made of stars "*".
            // Would be better to make from "* " in the developer's console.
            DrawStarCube(25);
            Console.WriteLine();
        }

        private static void Generate300RandomNumbers()
        {
            Random random = new Random();
            int integer;
            int largerThan150 = 0;

            for (int i = 0; i < 300; i++)
            {
                integer = random.Next(0, 301);

                if (integer > 150)
                    largerThan150++;

                if (integer > 275)
                    Console.Write($"[{integer}] ");
                else
                    Console.Write(integer + " ");
            }

            Console.WriteLine($"\n\nSkaiciu, didesniu nei 150, yra {largerThan150}");
        }

        private static void ListMultiplesTidily(uint baseNumber, uint floor, uint ceiling)
        {
            if (floor >= ceiling)
            {
                Console.WriteLine("Floor cannot be larger than the ceiling");
                return;
            }
            // How many numbers to print
            uint printCount = (ceiling - floor + 1) / baseNumber;
            if (printCount < 1)
            {
                Console.WriteLine("No multiples to display within the specified range");
                return;
            }

            // Finding first number
            uint firstNumber = 0;
            for (uint i = floor; i <= ceiling; i++)
            {
                if (i % baseNumber == 0)
                {
                    firstNumber = i;
                    break;
                }
            }

            // After what number not to print ", "
            uint lastNumber = firstNumber + (baseNumber * (printCount - 1));

            // This number will be updated and printed out
            uint currentNumber = firstNumber;

            // Print all multiples of the base number in the specified range
            for (uint i = 0; i < printCount; i++)
            {
                Console.Write(currentNumber);

                if (currentNumber != lastNumber)
                    Console.Write(", ");

                currentNumber += baseNumber;
            }

            Console.WriteLine();
        }

        private static void DrawStarCube(uint sideLength)
        {
            Console.WriteLine("Jei \"*\" uzimtu kvadrato forma tekste, cia butu kvadratas su 25 \"*\" krastine");
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
