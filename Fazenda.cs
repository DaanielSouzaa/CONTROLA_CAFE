using System;
using System.Collections.Generic;

class Fazenda {

  private string nome; // NOME DADO A FAZENDA
  private double caixa = 0.0; //CAIXA DA FAZENDA
  private static Itens cafe = new Itens("Café",0.0,250);

  private static List<Mov> regMovimentacoes = new List<Mov>();

  public Fazenda(string nome,double caixa){
    this.nome = nome;
    this.caixa = caixa;
  }

  /* CONTROLE DE RECEITA */
  public void movimenta(int tipo){

    bool validValor = false;
    double valor = 0.0;
    string descricao = "";

    while (validValor == false){
      try{
        Console.WriteLine("DIgite o valor:");
        valor = double.Parse(Console.ReadLine());
        validValor = true;
      } catch(FormatException){
        Console.WriteLine("Erro de digitação!");
        validValor = false;
      }

      Console.WriteLine("Digite a descrição:");
      descricao = Console.ReadLine();
    }

    regMovimentacoes.Add(new Mov(tipo,descricao,valor));
  }
  /* CONTROLE DE RECEITA */


  /* CONTROLE DE ESTOQUE */

    public void movimentaEstoque(int tipo){

      double valor = 0.0;
      bool validValor = false;

      try{
        Console.WriteLine("DIgite o valor:");
        valor = double.Parse(Console.ReadLine());
        validValor = true;
      } catch(FormatException){
        Console.WriteLine("Erro de digitação!");
        validValor = false;
      }

      if(tipo == 1)
      {
        double novoValor = cafe.getSaldo() + valor;
        cafe.setSaldo(novoValor);
      } else if (tipo == 2){
        if ((cafe.getSaldo() - valor) > 0){
          double novoValor = cafe.getSaldo() - valor;
          cafe.setSaldo(novoValor);
        }
        Console.WriteLine("Saldo não pode ficar negativo!");        
      }

      Console.WriteLine("Item: {0}",cafe.getDescricao());
      Console.WriteLine("Saldo: {0} sacas",cafe.getSaldo());
      Console.WriteLine("Valor Atual: R$ {0}/saca",cafe.getPreco());

    }

  /* CONTROLE DE ESTOQUE */

  /* PATRIMÔNIO DA FAZENDA */

    public double percorreArray(){
      double retorno = 0.0;
      Console.WriteLine(regMovimentacoes[0]);

      foreach(Mov movimento in regMovimentacoes){
        if(movimento.getTipo() == 1){
          retorno = retorno + movimento.getValor();
        } else if(movimento.getTipo() == 2) {
          retorno = retorno - movimento.getValor();
        }
      }

      return retorno;
    }


    public void exibePatrimonio(){
      double receitas = percorreArray();
      double patrimonio = cafe.getSaldo() * cafe.getPreco();

      Menu.exibeLinha();
      Console.WriteLine("Fazenda {0}",this.nome);
      Menu.exibeLinha();
      Console.WriteLine("Receitas: R$ {0}",receitas);
      Menu.exibeLinha();
      Console.WriteLine("Patrimônio: R$ {0}",patrimonio);
      Menu.exibeLinha();
      Console.WriteLine("Resultado: R$ {0}",patrimonio + receitas);
    }
  /* PATRIMÔNIO DA FAZENDA */
}