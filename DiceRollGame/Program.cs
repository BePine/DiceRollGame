Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.(numbers 1-6)" + Environment.NewLine);

while (Chances.ChancesLeft != 0)
{
    Console.WriteLine("enter a number:" + Environment.NewLine);
    TryParsingInputNumber number = new TryParsingInputNumber(Console.ReadLine());
    int parseValidationResult = number.ParsingNumberMethod();
    if (parseValidationResult != 0)
    {
        Chances.CheckIfNumberIsCorrect(parseValidationResult);
    }
    else
    {
    }
}

Console.ReadKey();
