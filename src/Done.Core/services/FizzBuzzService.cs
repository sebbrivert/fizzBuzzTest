using Done.Core.utils;

namespace Done.Core.services;

public interface IFizzBuzzService
{
    void DisplayInConsoleFizzBuzz();
    void DisplayInFileFizzBuzz();
}

public class FizzBuzzService(IFizzBuzzUtil _util)
    : IFizzBuzzService
{
    public void DisplayInConsoleFizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(_util.GetFizzBuzz(i));
        }
    }

    public void DisplayInFileFizzBuzz()
    {
        string myFile = "myFile.txt";
        using (StreamWriter writer = new StreamWriter(myFile))
        {
            for (int i = 1; i <= 100; i++)
            {
                writer.WriteLine(_util.GetFizzBuzz(i));
            }
        }
    }
}
