namespace Modelos {

  class TextoAluno : TextoPessoa {

    public Aluno Aluno {
      get; set;
    }

    public TextoAluno(Aluno aluno) : base((Pessoa) aluno) {
      this.Aluno = aluno;
    }

    public override string Informar() {
      return
        base.Informar() + "\n" +
        "Matricula: " + this.Aluno.Matricula + "\n" +
        "Periodo: " + this.Aluno.Periodo;
    }
    
  }

  class PaginaAluno : Pagina<Aluno> {

    public TextoAluno TextoAluno {
      get; set;
    }

    public Texto Formatar(Aluno aluno) {
      return this.TextoAluno = new TextoAluno(aluno);
    }

    public string Rodape() {
      string rodape = "";
      if (string.IsNullOrEmpty(this.TextoAluno.Aluno.Matricula)) {
        rodape += "** Matricula invalida\n";
      }
      return rodape + Impressora.LinhaComum();
    }
    
  }
  
}