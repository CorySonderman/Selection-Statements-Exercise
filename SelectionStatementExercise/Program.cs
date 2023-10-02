namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let\'s see it you can guess my favorite number.");
            Console.WriteLine("Pick a number and I will tell you if you are high " +
                "or low.");
            Console.WriteLine();
            var guess = int.Parse (Console.ReadLine());
            var r = new Random();
            var favNumber = r.Next(1,1000);
            if (guess < favNumber) 
            {
                Console.WriteLine("Too low.");
            }
            else if (guess > favNumber) 
            {
                Console.WriteLine("Too high");
            }
            else { Console.WriteLine("Bingo.  You win!");
            }
        }
    }
}
