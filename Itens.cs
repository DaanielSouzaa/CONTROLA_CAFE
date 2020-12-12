using System;

class Itens{
  private string descricao;
  private double saldo;
  private double preco;

  public Itens(string descricao, double saldo, double preco) {
    this.descricao = descricao;
    this.saldo = saldo;
    this.preco = preco;
  }

  public double getSaldo(){
    return this.saldo;
  }

  public double getPreco(){
    return this.preco;
  }

  public string getDescricao(){
    return this.descricao;
  }

  public void setSaldo(double saldo){
    this.saldo=saldo;
  }

  public void setPreco(double preco){
    this.preco = preco;
  }

  public void setDescricao(string descricao){
    this.descricao=descricao;
  }
}