using System;
using Demo_Asserts;
using NUnit.Framework;

namespace Demo_Asserts.DatasespeciaisStoreTests;

[TestFixture]
public class DatasEspeciaisStoreTests
{
    [Test]
    public void DeveRetornarDataCorretaParaAnoNovo()
    {
        // Arrange
        var dataEsperada = new DateTime(2026, 1, 1, 0, 0, 0, 0);

        // Act
        // Chamando o método estático diretamente na classe
        var dataRetornada = DatasEspeciaisStore.Data(DatasEspeciais.AnoNovo);

        // Assert
        // Verificando se a data retornada é exatamente a que esperamos
        Assert.That(dataRetornada, Is.EqualTo(dataEsperada));
    }

    [Test]
    public void DeveRetornarCorretamenteAnoNovo_Whitin()
    {
        // Arrange
        var dataEsperada = new DateTime(2026, 1, 1, 0, 0, 0, 1);

        // Act
        var dataRetornada = DatasEspeciaisStore.Data(DatasEspeciais.AnoNovo);

        // Assert
        // Verificando se a data retornada é igual à esperada com uma tolerância de 1 segundo
        Assert.That(dataRetornada, Is.EqualTo(dataEsperada).Within(TimeSpan.FromSeconds(1)));
    }
}
