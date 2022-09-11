using NUnit.Framework;
using TestDateFormat;


namespace Library.Tests;


[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormatoCorrecto()
    {
        // Configuración.
        const string expectedDate = "2022-09-07";
        // Comportamiento.
        string result = DateFormatter.ChangeFormat("07/09/2022");
        // Prueba.
        Assert.AreEqual(expectedDate, result);

    }
    [Test]

    public void FormatoIncorrecto()
    {
        // Configuración.
        const string expectedDate2 = null;
        // Comportamiento.
        string result = DateFormatter.ChangeFormat("07/09/20222");
        // Prueba.
        Assert.AreEqual(expectedDate2, result);

    }
    [Test]

    public void FechaEnBlanco()
    {
        // Configuración.
        const string expectedDate = null;
        // Comportamiento.
        string result = DateFormatter.ChangeFormat("");
        // Prueba.
        Assert.AreEqual(expectedDate, result);

    }
}