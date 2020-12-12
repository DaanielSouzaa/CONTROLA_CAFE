using System;

class Mov{
  private int tipo;
  private string descricao;
  private double valor;

  public Mov(int tipo, string descricao,double valor) {
    this.tipo = tipo;
    this.descricao = descricao;
    this.valor = valor;
  }

  public int getTipo(){
    return this.tipo;
  }

  public string getDescricao(){
    return this.descricao;
  }

  public double getValor(){
    return this.valor;
  }
}