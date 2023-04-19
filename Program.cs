using System;

namespace exercicio11
{

  class Program
  {

    static void Main(string[] args)
    {

      Console.Clear();

      Console.WriteLine("Digite o primeiro numero: ");
      int numero1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo numero: ");
      int numero2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Qual opção deseja:");
      Console.WriteLine("1 para soma");
      Console.WriteLine("2 para subtração");
      int opcao = int.Parse(Console.ReadLine());


      if (opcao == 1)
      {
        int soma = numero1 + numero2;
        int resultado = soma;
        Console.WriteLine("O resultado da opção escolhida é " + resultado);
      }
      else if (opcao == 2)
      {
        int subtracao = numero1 - numero2;
        int resultado = subtracao;
        Console.WriteLine("O resultado da opção escolhida é " + resultado);
      }

      else if (opcao != 2)
      {
        Console.WriteLine("Opção invalida");
      }
      while (opcao != 2)
      {

        Console.WriteLine("Tentar novamente");
        opcao = int.Parse(Console.ReadLine());
      }
    }
  }
}