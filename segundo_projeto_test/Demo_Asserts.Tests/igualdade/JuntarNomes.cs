namespace Demo_Asserts.Tests;

public class JuntarNomes
{
    [Test]
    public void JuntarNomes_DeveRetornarNomeCompleto()
    {
        // Arrange
        var demo = new Demo_Asserts();
        // Act
        var nomeCompleto = demo.JuntarNomes("Sergio", "Motta");
        // Assert
        Assert.That(nomeCompleto, Is.EqualTo("Sergio Motta"));
    }
    [Test]
    public void DevoJuntarNomeCompleto_CaseSensitive()
    {
        // Arrange
        var demo = new Demo_Asserts();
        // Act
        var nomeCompleto = demo.JuntarNomes("SERGIO", "MOTTA");
        // Assert
        Assert.That(nomeCompleto, Is.EqualTo("sergio motta").IgnoreCase);
    }
    [Test]
    public void DevoJuntarNomeCompleto_NaoIgual()
    {
        // Arrange
        var demo = new Demo_Asserts();
        // Act
        var nomeCompleto = demo.JuntarNomes("Sergio", "Motta");
        // Assert
        Assert.That(nomeCompleto, Is.Not.EqualTo("Sergio Filho"));
  
    }
}