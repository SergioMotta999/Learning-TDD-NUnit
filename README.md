# Projetos de Estudo com NUnit

Este repositório contém um projeto simples desenvolvido em .NET para demonstrar os conceitos fundamentais de testes de unidade utilizando o framework NUnit. O objetivo é aplicar as boas práticas de teste em uma aplicação de calculadora simples.

## 🎯 Objetivo do Projeto

O principal objetivo deste projeto é servir como um material de estudo prático sobre:

*   Configuração de um projeto de testes.
*   Criação e estruturação de testes de unidade.
*   Uso de asserções para validar resultados.
*   Identificação de bugs através de testes automatizados.
*   Tratamento de exceções em testes.

## 📂 Estrutura do Projeto

A solução está dividida em dois projetos principais:

*   `Calculadora/`: Uma Class Library (.NET) que contém a lógica de negócio.
    *   `CalculadoraSimples.cs`: A classe que implementa as operações matemáticas básicas (Adicionar, Subtrair, Multiplicar, Dividir).
*   `Calculadora.Tests/`: Um projeto de teste NUnit para verificar o comportamento da `CalculadoraSimples`.
    *   `CalculadoraSimplesTests.cs`: A classe que contém os casos de teste para cada método da calculadora.

## 📚 Conceitos Abordados

### 1. Configuração do Ambiente de Teste

Para iniciar, foi criado um projeto de teste NUnit (`Calculadora.Tests`) e adicionada uma referência ao projeto principal (`Calculadora`), permitindo que as classes e métodos da aplicação sejam acessíveis para os testes.

As dependências do NUnit foram adicionadas via NuGet:
*   `NUnit`: O framework de teste.
*   `NUnit3TestAdapter`: O adaptador que permite que os testes NUnit sejam executados pelo Visual Studio Test Explorer e pela linha de comando.
*   `Microsoft.NET.Test.Sdk`: O SDK de teste da Microsoft.

### 2. Estrutura de um Teste (Padrão AAA)

Todos os testes foram escritos seguindo o padrão **Arrange, Act, Assert (AAA)**, que organiza o código de teste em três seções claras:

*   **Arrange (Organizar):** Preparação do cenário. Aqui, inicializamos os objetos e definimos os valores de entrada necessários para o teste.
*   **Act (Agir):** Execução do método que está sendo testado com os dados preparados na fase de Arrange.
*   **Assert (Verificar):** Verificação do resultado. Comparamos o resultado obtido com o resultado esperado. Se a verificação falhar, o teste falha.

**Exemplo (`deveadicionarDoisNumeros`):**

```csharp
[Test]
public void deveadicionarDoisNumeros()
{
    // Arrange
    var sut = new CalculadoraSimples(); // sut = System Under Test

    // Act
    var resultado = sut.Adicionar(5, 5);

    // Assert
    Assert.That(resultado, Is.EqualTo(10));
}
```

### 3. Asserções (Assertions)

O NUnit fornece uma rica API de asserções para validar os resultados. Neste projeto, utilizamos a sintaxe de restrição (`Constraint-based`):

*   `Assert.That(resultado, Is.EqualTo(valorEsperado))`: Verifica se o valor do resultado é igual ao valor esperado.

### 4. Encontrando Bugs com Testes

Os testes de unidade são uma ferramenta poderosa para garantir a qualidade do código e encontrar bugs. No método `Multiplicar`, o comentário no código sugere a intenção de introduzir um bug para demonstrar como um teste falha.

Um código com bug poderia ser:
```csharp
public double Multiplicar(double numero1, double numero2)
{
    // Bug intencional: o método está somando em vez de multiplicar.
    return numero1 + numero2;
}
```

O teste `devemultiplicarDoisNumeros` falharia ao ser executado contra esse código, pois esperaria `5 * 3 = 15`, mas receberia `5 + 3 = 8`, provando a eficácia dos testes para validar a lógica de negócio. O código no repositório já está com a implementação correta.

### 5. Testando Exceções

O método `Dividir` lança uma `DivideByZeroException` quando o divisor é zero. Embora o teste para este cenário ainda não tenha sido implementado, é um ponto importante de estudo. O NUnit permite testar exceções de forma elegante.

**Exemplo de como testar a exceção:**
```csharp
[Test]
public void DeveLancarExcecaoAoDividirPorZero()
{
    var sut = new CalculadoraSimples();

    // Assert
    Assert.Throws<DivideByZeroException>(() => sut.Dividir(10, 0));
}
```

## 🚀 Como Executar os Testes

1.  Clone o repositório.
2.  Abra a solução no Visual Studio.
3.  Vá para o menu **Testar > Gerenciador de Testes (Test > Test Explorer)**.
4.  Clique em **Executar Todos os Testes**.

Ou, via linha de comando, navegue até a pasta da solução e execute:
```bash
dotnet test
```

## 🔮 Próximos Passos e Melhorias

Este projeto é um ponto de partida. Para aprofundar os estudos, os seguintes tópicos podem ser explorados:

*   **Testes Parametrizados:** Utilizar o atributo `[TestCase]` do NUnit para testar múltiplos cenários com o mesmo método de teste, reduzindo a duplicação de código.
*   **Testar Exceções:** Implementar o teste para o cenário de divisão por zero, como mostrado no exemplo acima.
*   **Setup e Teardown:** Usar os atributos `[SetUp]` e `[TearDown]` para configurar e limpar o estado entre os testes.
*   **Análise de Cobertura de Código (Code Coverage):** Utilizar ferramentas para medir qual percentual do seu código está sendo coberto pelos testes.
*   **CI/CD:** Integrar a execução dos testes em um pipeline de Integração Contínua/Entrega Contínua (CI/CD) usando ferramentas como GitHub Actions ou Azure DevOps.

