
public static class GetRandomNumber
{

    static Random rnd = new Random();
    public static int DiceRoll { get; } = rnd.Next(1, 7);


}

