using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using xUnit.Samples;

namespace xUnit.Tests;

public class CalculatorTests
{
    [Fact]
    public void AddTest()
    {
        var c = new Calculator();

        int expected = 5;
        int actual = c.Add(3, 2);

        Assert.Equal(expected, actual);
    }
}
