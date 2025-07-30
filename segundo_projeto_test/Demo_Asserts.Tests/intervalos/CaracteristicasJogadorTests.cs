using NUnit.Framework;

namespace Demo_Asserts.Tests.intervalos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void AumentarPontosDepoisDePartidaJogadaBem()
        {
            // Arrange
            var jogador = new global::CaracteristicasJogador(apelido: "Jogador1", idade: 25, nacionalidade: "Brasil", posicao: "Atacante", score: 50);

            // Act
            jogador.PartidaJogadaBem();

            // Assert
            Assert.That(jogador.Score, Is.GreaterThan(50), "O score do jogador deve aumentar após uma partida jogada bem.");

        }
        [Test]
       public void AumentarPontosDepoisDePartidaJogadaBem_Intervalo()
        {
            // Arrange
            var jogador = new global::CaracteristicasJogador(apelido: "Jogador2", idade: 30, nacionalidade: "Argentina", posicao: "Meio-campo", score: 60);

            // Act
            jogador.PartidaJogadaBem();

            // Assert
            Assert.That(jogador.Score, Is.InRange(61, 65), "O score do jogador deve estar entre 61 e 65 após uma partida jogada bem.");
        }
    }
}