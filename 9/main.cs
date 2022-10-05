using Modelos;

class Aula9 {
  
  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno(1);
    aluno1.Cpf = "660.036.460-20";
    Aluno aluno2 = new Aluno(1);
    aluno2.Cpf = "588.401.710-37";
    PaginaAluno paginaAluno = new PaginaAluno();
    Impressora.Imprimir(paginaAluno.Formatar(aluno1));
    Impressora.Imprimir(paginaAluno.Formatar(aluno2),
                        Impressora.LinhaComum,
                        paginaAluno.Rodape);
  }

}