// -- Arquivo Exercicio6.cs

public static class Exercicio6
{
    public static void Executar()
    {
        string diaSemana = "";
        int temperatura = 0;
        int hora = 0;

        Console.WriteLine($"Que dia da semana é hoje? ");
        diaSemana = (Console.ReadLine()!);

        Console.WriteLine($"Qual a temperatura agora (em °C)? ");
        temperatura = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"Que horas são agora? ");
        hora = int.Parse(Console.ReadLine()!);
    

        Console.WriteLine();
        // Desse momento em diante, toda vez que vamos mostrar o valor de uma variável e tem um texto,
        // dentro do Console.WriteLine, vamos iniciar com $, conforme exemplo abaixo
        Console.WriteLine($"Hoje é {diaSemana}, está fazendo {temperatura} °C e agora são {hora} horas.");

    }
}
     