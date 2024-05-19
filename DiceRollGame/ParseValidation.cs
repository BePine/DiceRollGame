
static public class ParseValidation
{
    public static int Validate(bool boolToValidate, int intToValidate)
    {

        if (boolToValidate)
        {
            if (intToValidate < 0)
            {
                Console.WriteLine("Given input cannot be negative");
                return 0;
            }
            else if (intToValidate == 0 || intToValidate > 6)
            {
                Console.WriteLine("Given input is out of the guessing range.");
                return 0;
            }
            else
                return intToValidate;
        }
        else
        {
            Console.WriteLine("Input is not a number");
            return 0;
        }
    }
}

