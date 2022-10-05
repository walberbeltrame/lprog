using Modelos;

class Aula3 {

  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno {
      Matricula = "2022ENEL123",
      Nome = "Maria",
      Periodo = 0
    };
    //Impressora.Imprimir(aluno1);
    Aluno aluno2 = new Aluno();
    //Impressora.Imprimir(aluno2);
    Aluno aluno3 = new Aluno(2);
    //Impressora.Imprimir(aluno3);
    Aluno aluno4 = new Aluno("2022ENEL456", "José");
    //Impressora.Imprimir(aluno4);
    Aluno aluno5 = new Aluno("2022ENEL789", "João", 3);
    //Impressora.Imprimir(aluno5);
    Disciplina disciplina1 = new Disciplina("Algoritmos", 0);
    //Impressora.Imprimir(disciplina1);
    Disciplina disciplina2 = new Disciplina("Programação", 11);
    //Impressora.Imprimir(disciplina2);
  }
  
}