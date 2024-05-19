
static public class Chances
{
    static public int ChancesLeft { get; private set; } = 3;
    static Chances()
    {

    }
    static public void CheckIfNumberIsCorrect(int parseValidationResult)
    {
        if (parseValidationResult == GetRandomNumber.DiceRoll)
        {
            Console.WriteLine("You win!");
            ChancesLeft = 0;

        }
        else
        {

            ChancesLeft--;
            if (ChancesLeft == 0)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("Wrong Number");
            }

        }
    }

}

