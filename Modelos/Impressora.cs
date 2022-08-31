using System;

namespace Modelos {

  class Impressora {

    public static void Imprimir(Aluno aluno) {
      Console.WriteLine(
        "-------------------------\n" +
        "Matricula: " + aluno.Matricula + "\n" +
        "Nome: " + aluno.Nome + "\n" +
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