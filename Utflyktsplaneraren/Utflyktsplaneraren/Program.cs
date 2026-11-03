using System;

namespace MyProgram
{
    class Program
    {
        static int Main()
        {

            Console.WriteLine("=== UTFLYKTSKALKYLATOR ===");

            int antal; int resa; int mat;


            //felhanterar koden
            try
            {

                Console.Write("Hur många personer ska följa med? ");
                antal = Convert.ToInt32(Console.ReadLine());

                Console.Write("Vad kostar resan per person? ");
                resa = Convert.ToInt32(Console.ReadLine());

                Console.Write("Vad kostar maten per person? ");
                mat = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Felaktig inmatning. Vänligen ange ett heltal.");
                return 1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("För stor/För liten inmatning. Vänligen ange ett heltal inom intervallet för en 32 bits int.");
                return 1;
            }

            if(antal <= 0)
            {
                Console.WriteLine("Antal personer måste vara större än 0");
                return 1;
            }
            else if(resa < 0 || mat < 0)
            {
                Console.WriteLine("kostnaderna måste vara större än eller lika med 0.");
                return 1;
            }


                // Räknar ut kostnaden för en person.
                int kostnadPerPerson = resa + mat;

            // Räknar ut kostnaden för hela gruppen.
            int totalKostnad = kostnadPerPerson * antal;

            Console.WriteLine();
            Console.WriteLine("Kostnad per person: " + kostnadPerPerson + " kr");
            Console.WriteLine("Total kostnad: " + totalKostnad + " kr");


            return 0;

        }
    }

}