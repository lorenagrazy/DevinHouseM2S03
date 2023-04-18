using System;
using System.Collections.Generic;

class Proprietario
{
  public string nome;
  public string cpf;
  public string telefone;

  public Proprietario(string nome, string cpf, string telefone)
  {
    this.nome = nome;
    this.cpf = cpf;
    this.telefone = telefone;
  }
}

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

class Program
{
  static List<Carro> carros = new List<Carro>();

  static void Main(string[] args)
  {
    Console.WriteLine("Bem-vindo ao sistema de cadastro de carros!");

    while (true)
    {
      Console.WriteLine("\nSelecione uma opção:");
      Console.WriteLine("1 - Cadastrar Carro");
      Console.WriteLine("2 - Consultar Carros");
      Console.WriteLine("3 - Sair");

      string opcao = Console.ReadLine();

      switch (opcao)
      {
        case "1":
          CadastroDeCarro();
          break;
        case "2":
          ExibirCarros();
          break;
        case "3":
          Console.WriteLine("Saindo do sistema...");
          return;
        default:
          Console.WriteLine("Opção inválida!");
          break;
      }
    }
  }

  static void CadastroDeCarro()
  {
    Console.WriteLine("\nCadastro de carro:");

    Console.Write("Marca: ");
    string marca = Console.ReadLine();

    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();

    Console.Write("Placa: ");
    string placa = Console.ReadLine();

    Console.Write("Cor: ");
    string cor = Console.ReadLine();

    Console.WriteLine("\nDados do proprietário:");

    Console.Write("Nome: ");
    string nomeProprietario = Console.ReadLine();

    Console.Write("CPF: ");
    string cpfProprietario = Console.ReadLine();

    Console.Write("Telefone: ");
    string telefoneProprietario = Console.ReadLine();

    Proprietario proprietario = new Proprietario(nomeProprietario, cpfProprietario, telefoneProprietario);

    Carro carro = new Carro(marca, modelo, placa, cor, proprietario);

    carros.Add(carro);

    Console.WriteLine("\nCarro cadastrado com sucesso!");
  }

  static void ExibirCarros()
  {
    Console.WriteLine("\nLista de carros cadastrados:");

    foreach (Carro carro in carros)
    {
      Console.WriteLine("\nDados do carro:");

      Console.WriteLine("Marca: " + carro.marca);
      Console.WriteLine("Modelo: " + carro.modelo);
      Console.WriteLine("Placa: " + carro.placa);
      Console.WriteLine("Cor: " + carro.cor);

      Console.WriteLine("\nDados do proprietário:");

      Console.WriteLine("Nome: " + carro.proprietario.nome);
      Console.WriteLine("CPF: " + carro.proprietario.cpf);
      Console.WriteLine("Telefone: " + carro.proprietario.telefone);
    }
  }
}
