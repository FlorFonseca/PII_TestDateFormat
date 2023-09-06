namespace TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaEnBlanco()
    {
        string input= "";
        string expected="Vacío";
        string output= DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, output);
    }

    [Test]
    public void FormatoIncorrecto()
    {
        string input="20/04/20036";
        string expected="Error";
        string output=DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, output);
    }

    [Test]
    public void FormatoCorrecto()
    {
        string input = "20/04/2003";
        string expected = "2003-04-20";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, output);
    }
}