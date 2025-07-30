using NUnit.Framework;
using System.Collections.Generic;

namespace Demo_Asserts.Tests.CaracteristicasJogador
{
[TestFixture]
public class CaracteristicasJogadorTests
{
    // Método responsável por testar se a lista de uma determinada coleção está vazia
    [Test]
    public void NaoDevoTerListasDePosicaoVazia()
    {
      var jogador = new global::CaracteristicasJogador("Jogador1", 25, "Brasil", "Atacante", 80);

      Assert.That(jogador.Posicao, Is.Not.Empty);
    }

    // Método responsável  por testar se conter um determinado item da coleção
    [Test] 
    public void DeveConterItemNaColecao()
    {
        var jogador = new global::CaracteristicasJogador();

        // Defina a lista de posições válidas
        var posicoesValidas = new List<string> { "Atacante", "Meio-campo", "Defensor", "Goleiro", "Centroavante", "Lateral", "Ponta" };

        // Verifica se a posição do jogador está na lista de posições válidas
        Assert.That(posicoesValidas, Contains.Item(jogador.Posicao));
    }
}
}