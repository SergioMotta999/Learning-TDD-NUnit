using NUnit.Framework;

namespace Demo_Asserts.Tests.boleanosNulos{

[TestFixture]
public class CaracteristicasJogadorTests
{
  [Test]
  public void DevoGerarApelidoRandomicoPorDefault(){

    // Arange
    var jogador = new global::CaracteristicasJogador("", 0, "", "", 0);

    // Act
 

    // Assert
    Assert.That(jogador.Apelido, Is.Not.Empty);
  }

}

}