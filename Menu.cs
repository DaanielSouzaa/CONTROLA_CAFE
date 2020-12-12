using System;
using System.Collections.Generic;

class Menu {

  public static void exibeLinha(){
    Console.WriteLine("---------------------");
  }

  public static void exibeMenu () {
    Console.WriteLine("1 - Cadastro de receita:");
    Console.WriteLine("2 - Cadastro de despesa:");
    Console.WriteLine("3 - Entrada de estoque:");
    Console.WriteLine("4 - Saída de estoque:");
    Console.WriteLine("5 - Resultado geral:");
  }
}