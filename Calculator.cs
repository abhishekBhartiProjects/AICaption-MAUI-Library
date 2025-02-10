namespace Com.AICaptionLibrary;

public class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public string GetMessage()
    {
        return "Hello from MAUI Library!";
    }
}