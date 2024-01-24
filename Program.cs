using Mission_2;

internal class DiceSimulator
{
    

    private static void Main(string[] args)
    {
        // create a RollDice instance
        RollDice rd = new RollDice();

        int requested_num_roll = 0;

        // prompt the user to enter the desired number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator!" + "\n");
        Console.WriteLine("How many dice rolls would you like to simulate?" + "\n");
        requested_num_roll = int.Parse(Console.ReadLine());
        
        // plug the desired number of rolls into the RollDice class
        rd.PrintResult(requested_num_roll);

        
        
    }
}