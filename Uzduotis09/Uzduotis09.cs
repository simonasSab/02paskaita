namespace AntraPaskaita
{
    public class Uzduotis09
    {
        // 6. Užduotis: Temperatūrų vidurkio skaičiavimas.
        // Parašykite programą, kuri leidžia vartotojui įvesti temperatūras kelias dienas.
        // Masyvas turi būti naudojamas temperatūroms saugoti.
        // Po to, kai visos temperatūros įvestos, programa turi naudoti for ciklą, kad apskaičiuotų ir išvestų temperatūrų vidurkį.
        public static void Main(String[] args)
        {
            bool correctType = false;
            int daysAmount = 0;
            float temperatureSum = 0;

            // Get number of days
            do
            {
                Console.WriteLine("Kelias dienas noresite vesti temperaturas skaiciavimams?");
                correctType = int.TryParse(Console.ReadLine(), out daysAmount);
            }
            while (!correctType || daysAmount < 0);

            // Create array of length daysAmount
            float[] temperatures = new float[daysAmount];

            // Populate array with user input temperature floats
            for (int i = 0; i < daysAmount; i++)
            {
                do
                {
                    Console.WriteLine($"Iveskite temperatura dienai nr. {i + 1}: ");
                    correctType = float.TryParse(Console.ReadLine(), out temperatures[i]);
                }
                while (!correctType);
            }

            // Iterate through array to calculate sum of all array values
            for (int i = 0; i < daysAmount; i++)
            {
                temperatureSum += temperatures[i];
            }

            Console.WriteLine($"Vidutine {daysAmount} dienu(os) temperatura: {temperatureSum / daysAmount:.0}");
        }
    }
}
