using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    string opcao = "s";
    Fazenda fazenda = new Fazenda("Bridi",0.0);

    while(opcao == "s" || opcao == "S"){
      
      /*BLOCO DO MENU */
      try{
        Menu.exibeMenu();
        int escolheMenu = int.Parse(Console.ReadLine());

         switch(escolheMenu){
          case 1:
            fazenda.movimenta(1);
            break;
          case 2:
            fazenda.movimenta(2);
            break;
          case 3:
            fazenda.movimentaEstoque(1);
            break;
         case 4:
            fazenda.movimentaEstoque(2);
            break;
         case 5:
            fazenda.exibePatrimonio();
            break;
          default:
            Console.WriteLine("Opção inválida!");
            break;
        }
      } catch(FormatException){
        Console.WriteLine("Favor digitar um número inteiro!");
      }

      /*BLOCO DO MENU */

      /* VALIDADOR DE SAÍDA DO PROGRAMA */
      Console.WriteLine("Digite 's' para continuar ou qualquer outra tecla para sair");
      opcao = Console.ReadLine();
      /* VALIDADOR DE SAÍDA DO PROGRAMA */
    }    
  }
}