namespace Operations;

public class Calculator
{
    public int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }
    
    public int Multiple(params int[] numbers)
    {
        return numbers.Aggregate(1, (current, number) => current * number);
    }
}