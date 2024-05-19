public class TryParsingInputNumber
{
    public string Number { get; private set; }
    public TryParsingInputNumber(string number)
    {
        Number = number;
    }
    public int ParsingNumberMethod()
    {
        bool parsingBooleanResult = int.TryParse(Number, out int parsingIntResult);
        int parseValidationResult = ParseValidation.Validate(parsingBooleanResult, parsingIntResult);

        return parseValidationResult;
    }
}

