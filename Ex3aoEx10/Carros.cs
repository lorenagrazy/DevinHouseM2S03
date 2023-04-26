using System;
class Carro
{
  public string marca;
  public string modelo;
  public string placa;
  public string cor;
  public Proprietario proprietario;

  public Carro(string marca, string modelo, string placa, string cor, Proprietario proprietario)
  {
    this.marca = marca;
    this.modelo = modelo;
    this.placa = placa;
    this.cor = cor;
    this.proprietario = proprietario;
  }
}