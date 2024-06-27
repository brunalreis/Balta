// See https://aka.ms/new-console-template for more information

// LEMBRAR SE ENTRAR NA PASTA MEUAPP ATRAVÉS DO COMANDO NO TERMINAL cd .\MeuApp\ ANTES DE DAR dotnet run
using System;

namespace MeuApp
{
  class Program
  {
    static void Main(string[] args)
    {
      int inteiro = 100;
      float real = 25.8f;

      // real = inteiro;
      inteiro = (int)real;
      // string valorReal = real.ToString();
      // inteiro = int.Parse(real.ToString());
      // inteiro = int.Parse("255");
      // inteiro = Convert.ToInt32(real);
      // Console.WriteLine(valorReal);

      Console.WriteLine(inteiro);


      int idade = 18;
      int maioridade = 21;
      int idadeMaxima = 65;

      if (idade >= maioridade && idade <= idadeMaxima)
      {
        Console.WriteLine("Adulto");
      }
      else if (idade < maioridade)
      {
        Console.WriteLine("Menor de idade");
      }
      else
      {
        Console.WriteLine("Idoso");
      }

      int valor = 1;
      switch (valor)
      {
        case 1: Console.WriteLine("Café"); break;
        case 2: Console.WriteLine("Água"); break;
        case 3: Console.WriteLine("Chá"); break;
        default: Console.WriteLine("Infelizmente seu item não consta no nosso sistema"); break;

      }

      MeuMetodo();

      string nome = RetornaNome("Bruna", "Loyola", 26);
      Console.WriteLine(nome); // esse comando é necessário pra imprimir a string quando a função RetornaNome for invocada
    }

    static void MeuMetodo()
    {
      Console.WriteLine("Taylor Swift tapete do pop");
    }
    static string RetornaNome(
      string nome,
      string sobrenome,
      int idade)
    {
      // Aqui além de um novo método estar sendo declarado, também está sendo informado entre parênteses quais os parâmetros que ele deve retornar
      return nome + " " + sobrenome + ", tem " + idade.ToString() + " anos";
    }
  }
}


