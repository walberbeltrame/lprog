using System;
using Modelos;

class AulaObjeto {

  public static void Imprimir(Aluno aluno,
                              Disciplina disciplina) {
    if(aluno.Matricular(disciplina)) {
      Console.WriteLine(aluno.Matricula);
    }
  }

  public static void Main (string[] args) {

    Aluno aluno1 = new Aluno {
      Matricula = "012022",
      Periodo = 1
    };
    
    Aluno aluno2 = new Aluno {
      Matricula = "022022",
      Periodo = 3
    };
    
    Disciplina disciplina = new Disciplina {
      Nome = "Linguagem de Programação",
      Semestre = 3
    };

    Imprimir(aluno1, disciplina);
    Imprimir(aluno2, disciplina);

  }
  
}