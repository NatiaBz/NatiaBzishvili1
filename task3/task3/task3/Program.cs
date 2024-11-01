

namespace RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11); // 1-dan 10-mde
            int attempts = 3;
            bool hasGuessedCorrectly = false;

            Console.WriteLine("gamarjoba! gamoicani cifri 1-dan 10-mde. gaqvs 3 cda.");

            while (attempts > 0 && !hasGuessedCorrectly)
            {
                Console.Write("SeiyvaneT cifri:");
                string userInput = Console.ReadLine();
                int userGuess;

                // vamocmebt, rom momxmarebels cifri Seyvanili aqvs
                if (int.TryParse(userInput, out userGuess))
                {
                    if (userGuess == randomNumber)
                    {
                        hasGuessedCorrectly = true;
                        Console.WriteLine("Shen moige! Cafikrebuli cifri iyo: " + randomNumber);
                    }
                    else
                    {
                        attempts--;
                        Console.WriteLine($"araswori cifria. darCenili cdebi: {attempts}");
                    }
                }
                else
                {
                    Console.WriteLine("Seikvanet swori cifri.");
                }
            }

            if (!hasGuessedCorrectly)
            {
                Console.WriteLine("Tqven caageT! chafikrebuli cifri iyo: " + randomNumber);
            }
        }
    }
}


