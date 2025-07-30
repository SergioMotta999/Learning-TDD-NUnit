using System;
namespace Demo_Asserts;

/*Classe genérica que armazena datas especiais*/
public class DatasEspeciaisStore
{
    public static DateTime Data(DatasEspeciais datasEspeciais) =>
        datasEspeciais switch
        {
            DatasEspeciais.AnoNovo => new DateTime(2026, 1, 1, 0, 0, 0, 0),
            DatasEspeciais.AniversarioDeCrateus => new DateTime(2025, 7, 6, 0, 0, 0, 0),
            // O caso padrão `_` deve ser o último e trata qualquer valor não listado acima.
            _ => throw new ArgumentOutOfRangeException(nameof(datasEspeciais), $"Data especial não suportada: {datasEspeciais}")
        };
}