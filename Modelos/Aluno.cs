namespace Modelos {

  class Aluno {

    public string nome;
    public string matricula;
    public int periodo;

    public Aluno() : this(1) {
    }

    public Aluno(int periodo) {
      if(periodo > 0) {
        this.periodo = periodo;
      } else {
        this.periodo = 1;
      }
    }

    public Aluno(string nome, string matricula)
      : this(1) {
      this.nome = nome;
      this.matricula = matricula;
    }

    public Aluno(string nome, string matricula, int periodo)
      : this(periodo) {
      this.nome = nome;
      this.matricula = matricula;
    }
    
    public bool Matricular(Disciplina disciplina) {
      return this.periodo == disciplina.semestre;
    }
    
  }
  
}