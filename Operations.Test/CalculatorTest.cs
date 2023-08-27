namespace Operations.Test;

public class CalculatorTest
{
    [Fact]
    public void Sum_Test()
    {
        var calc = new Calculator();
        var result = calc.Sum(1, 2, 3, 4, 5);
        Assert.Equal(15,result);
    }
    
    [Fact]
    public void Multiple_Test()
    {
        var calc = new Calculator();
        var result = calc.Multiple(1, 2, 3, 4, 5);
        Assert.Equal(120,result);
    }
}
