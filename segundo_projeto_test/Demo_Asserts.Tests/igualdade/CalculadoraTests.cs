using NUnit.Framework;

namespace Demo_Asserts.Tests.igualdade
{
    [TestFixture]
    public class CalculadoraTests
    {
        [Test]
        public void DevoSomarNumerosInteros()
        {
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var resultado = calculadora.SomarNumerosInteros(5, 7);
            // Assert 
            Assert.That(resultado, Is.EqualTo(12));
        }

        [Test]
        public void DevoSomarNumerosDecimais()
        {
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var resultado = calculadora.SomarNumerosDecimais(1.1, 2.2);
            // Assert 
            Assert.That(resultado, Is.EqualTo(3.3));
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithin()
        {
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var resultado = calculadora.SomarNumerosDecimais(1.1, 2.2);
            // Assert 
            Assert.That(resultado, Is.EqualTo(3.3).Within(0.0001), "A soma dos números decimais não está correta.");
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithinPorcentagem()
        {
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var resultado = calculadora.SomarNumerosDecimais(50, 50); // 100%
            // Assert 
            Assert.That(resultado, Is.EqualTo(101).Within(1).Percent, "A tolerância de 1%  foi respeitada na soma dos números decimais.");
        }

        [Test]
        public void DevoSomarNumerosDecimais_NaoBomExemploDeWithin()
        {
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var resultado = calculadora.SomarNumerosDecimais(1.1, 2.2);
            // Assert 
            Assert.That(resultado, Is.EqualTo(30).Within(100), "Em qualquer lugar do mundo, 30 não é igual a 3.3, mesmo com uma tolerância de 100. ");
            // PASSOU MAS NÃO É UM BOM EXEMPLO DE USO DO WITHIN. tolerância de 100 é muito grande para o valor esperado de 3.3.
        }
    }
    
}
