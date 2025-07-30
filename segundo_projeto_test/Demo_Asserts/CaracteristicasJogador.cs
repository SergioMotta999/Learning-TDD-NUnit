using Demo_Asserts;

public class CaracteristicasJogador
{
    public CaracteristicasJogador() : this("", 0, "", "", 0) { }
    /* 
     * Características de um jogador de futebol:
     * - Apelido
     * - Idade
     * - Nacionalidade
     * - Posição
     * - Score (de 0 a 100)
     */
    public string Apelido { get; set; }
    public int Idade { get; set; }
    public string Nacionalidade { get; set; }
    public string Posicao { get; set; } // Ex: Goleiro, Zagueiro, Meio-campo, Atacante
    public int Score { get; set; } // de 0 a 100

    public CaracteristicasJogador(string apelido, int idade, string nacionalidade, string posicao, int score)
    {
        Apelido = GerarApelido();
        Idade = idade;
        Nacionalidade = nacionalidade;
        Posicao = Gerarposicao();
        Score = score;
    }

    public void PartidaJogadaBem()
    {
        // Simula uma partida jogada, aumentando a experiência do jogador em aleatório  
        var random = new Random();
        int ScoreGanho = random.Next(1, 5); // Ganha entre 1 a 5 pontos de score

        Score += ScoreGanho;
    }

    public void PartidaJogadaMal(int scorePerdido)
    {
        Score = Math.Max(1, Score -= scorePerdido);
    }

    private string GerarApelido()
    {
        var apelidos = new[]
        {
            "Shine",
            "Dacrys",
            "Kassa",
            "DaIthala",
            "Hevenaut",
            "Jeff",
            "Sejux",
            "Dodo",
            "Vanessa",

        };
        return apelidos[new Random().Next(0, apelidos.Length)];
    }

    private string Gerarposicao()
    {
        var posicoes = new List<string>(){
            "Goleiro",
            "Zagueiro",
            "Meio-campo",
            "Atacante",
            "Lateral",
            "Volante",
            "Ponta",
            "Centroavante"
        };
        return posicoes[new System.Random().Next(0, posicoes.Count)];
    }
}

