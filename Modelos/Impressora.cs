using System;

namespace Modelos {

  class Impressora {

    public static void Imprimir(Pessoa pessoa) {
      Console.WriteLine(
        "-------------------------\n" +
        "Nome: " + pessoa.Nome + "\n" +
        "CPF: " + pessoa.Cpf + "\n" +
        "-------------------------\n"
      );
    }

    public static void Imprimir(Professor professor) {
      Console.WriteLine(
        "-------------------------\n" +
        "Nome: " + professor.Nome + "\n" +
        "CPF: " + professor.Cpf + "\n" +
        "Codigo: " + professor.Codigo + "\n" +
        "-------------------------\n"
      );
    }
    
    public static void Imprimir(Aluno aluno) {
      Console.WriteLine(
        "-------------------------\n" +
        "Matricula: " + aluno.Matricula + "\n" +
        "Nome: " + aluno.Nome + "\n" +
        "CPF: " + aluno.Cpf + "\n" +
        "Periodo: " + aluno.Periodo + "\n" +
        "-------------------------\n"
      );
    }

    public static void Imprimir(Disciplina disciplina) {
      Console.WriteLine(
        "-------------------------\n" +
        "Nome: " + disciplina.Nome + "\n" +
        "Semestre: " + disciplina.Semestre + "\n" +
        "-------------------------\n"
      );
    }
    
  }

}