namespace primefactorstests;
using primefactorslib;

public class PrimeFactorsUnitTests
{

    [Fact]
    public void TestFour()
    {
        //arrange
        int value = 4;
        string expected = "2 * 2";
        //act
        string fz = PrimeFactors.PrimeFactorization(value);
        //assert
        Assert.Equal(expected, fz);
    }

    [Fact]
    public void TestSeven()
    {
        //arrange
        int value = 7;
        string expected = "7";
        //act
        string fz = PrimeFactors.PrimeFactorization(value);
        //assert
        Assert.Equal(expected, fz);
    }

    [Fact]
    public void TestThirty()
    {
        //arrange
        int value = 30;
        string expected = "2 * 3 * 5";
        //act
        string fz = PrimeFactors.PrimeFactorization(value);
        //assert
        Assert.Equal(expected, fz);
    }

    [Fact]
    public void TestForty()
    {
        //arrange
        int value = 40;
        string expected = "2 * 2 * 2 * 5";
        //act
        string fz = PrimeFactors.PrimeFactorization(value);
        //assert
        Assert.Equal(expected, fz);
    }

    [Fact]
    public void TestFifty()
    {
        //arrange
        int value = 50;
        string expected = "2 * 5 * 5";
        //act
        string fz = PrimeFactors.PrimeFactorization(value);
        //assert
        Assert.Equal(expected, fz);
    }

    
}