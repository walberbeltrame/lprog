using System;
using Modelos;

class AulaObjeto {

  public static void Imprimir(Aluno aluno,
                              Disciplina disciplina) {
    if(aluno.Matricular(disciplina)) {
      Console.WriteLine(aluno.matricula);
    }
  }

  public static void Main (string[] args) {

    Aluno aluno1 = new Aluno {
      matricula = "012022",
      periodo = 1
    };
    
    Aluno aluno2 = new Aluno {
      matricula = "022022",
      periodo = 3
    };
    
    Disciplina disciplina = new Disciplina {
      nome = "Linguagem de Programação",
      semestre = 3
    };

    Imprimir(aluno1, disciplina);
    Imprimir(aluno2, disciplina);

  }
  
}