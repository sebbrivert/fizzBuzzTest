namespace Done.Core.utils;

public interface IFizzBuzzUtil
{
    string GetFizzBuzz(int input);
    bool IsFizz(int value);
    bool IsBuzz(int value);
}

public class FizzBuzzUtil : IFizzBuzzUtil
{
    public string GetFizzBuzz(int input)
    {
        if(IsFizz(input) && IsBuzz(input))
            return "FizzBuzz";
        if (IsFizz(input))
            return "Fizz";
        if (IsBuzz(input))
            return "Buzz";
        return $"{input}";
    }

    public bool IsFizz(int value)
    {
        if (value % 3 == 0)
            return true;
        return false;
    }

    public bool IsBuzz(int value)
    {
        if (value % 5 == 0)
            return true;
        return false;
    }
}
