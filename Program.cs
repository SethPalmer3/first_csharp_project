internal class Program
{
	private static int InputNumberHandler(string errorMessage) {
		int convertedInput;
		while (true){
			try{
				Console.Write("> ");
				convertedInput = Convert.ToInt32(Console.ReadLine());
				return convertedInput;
			} catch {
				Console.WriteLine(errorMessage);
			}
		}

	}
    private static void Main(string[] args)
    {
        Console.WriteLine("Lets play guess the number. You guess a number if you get it you win");
        Console.WriteLine("If you don't get it I'll tell you if your guess is too high or too low");
        var rand = new Random();
        var guessingNum = rand.Next(1, 101);
        int currentGuess;
        int guessTries = 0;

        do
        {
			currentGuess = InputNumberHandler("Bad number input");
            guessTries++;
            if (currentGuess < guessingNum)
            {
                Console.WriteLine("Your guess is too small\n");
            }
            else if (currentGuess > guessingNum)
            {
                Console.WriteLine("Your guess is too big\n");
            }
        } while (currentGuess != guessingNum);

        Console.WriteLine($"Correct! You got it in {guessTries} {
				currentGuess switch {
					> 1 => "tries",
					_ => "try",
				}
			}");
    }
}
