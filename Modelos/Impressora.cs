using System;

namespace Modelos {

  class Impressora {

    public static void Imprimir(Aluno aluno) {
      Console.WriteLine(
        "-------------------------\n" +
        "Matricula: " + aluno.matricula + "\n" +
        "Nome: " + aluno.nome + "\n" +
        "Periodo: " + aluno.periodo + "\n" +
        "-------------------------\n"
      );
    }

    public static void Imprimir(Disciplina disciplina) {
      Console.WriteLine(
        "-------------------------\n" +
        "Nome: " + disciplina.nome + "\n" +
        "Semestre: " + disciplina.semestre + "\n" +
        "-------------------------\n"
      );
    }
    
  }

}