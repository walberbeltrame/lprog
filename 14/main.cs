using System;
using System.Collections.Generic;
using System.IO;
using Modelos;

class Aula14 {
  
  public static void Main (string[] args) {
    try {
      Aluno aluno = new Aluno();
      Console.WriteLine(aluno.Periodo / 0);
    } catch(Exception) {
      Console.WriteLine(0);
    }
    try {
      Escrever();
    } catch(IOException) {
      Console.WriteLine("Erro na escrita do arquivo.");
    }
    try {
      List<Aluno> alunos = Ler();
      foreach(Aluno aluno in alunos) {
        PaginaAluno paginaAluno = new PaginaAluno();
        Impressora.Imprimir(paginaAluno.Formatar(aluno));
      }
    } catch(IOException) {
      Console.WriteLine("Erro na leitura do arquivo.");
    }
  }

  public static async void Escrever() {
    List<Aluno> alunos = new List<Aluno>();
    Aluno aluno1 = new Aluno(1);
    aluno1.Cpf = "585.478.460-26";
    aluno1.Nome = "Maria";
    Aluno aluno2 = new Aluno(2);
    aluno2.Cpf = "660.036.460-20";
    aluno2.Nome = "João";
    alunos.Add(aluno1);
    alunos.Add(aluno2);
    using StreamWriter arquivo = new("alunos.csv");
    foreach(Aluno aluno in alunos) {
      string linha = "\"" + aluno.Cpf + "\";";
      linha += "\"" + aluno.Nome + "\";";
      linha += "\"" + aluno.Periodo + "\"";
      await arquivo.WriteLineAsync(linha);
    }
  }

  public static List<Aluno> Ler() {
    List<Aluno> alunos = new List<Aluno>();
    string[] linhas = File.ReadAllLines("alunos.csv");
    foreach(string linha in linhas) {
      string[] dados = linha.Split(";");
      Aluno aluno = new Aluno();
      aluno.Cpf = dados[0].Replace("\"","");
      aluno.Nome = dados[1].Replace("\"","");
      aluno.Periodo = Int32.Parse(dados[2].Replace("\"",""));
      alunos.Add(aluno);
    }
    return alunos;
  }

}