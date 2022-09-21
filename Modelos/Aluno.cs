namespace Modelos {

  class Aluno : Pessoa {

    private int periodo;

    public int Periodo {
      get => this.periodo;
      set {
        if(value > 0) {
          this.periodo = value;
        } else {
          this.periodo = 1;
        }
      }
    }

    public string Matricula {
      get; set;
    }

    public Aluno() : this(1) {
    }

    public Aluno(int periodo) {
      this.Periodo = periodo;
    }

    public Aluno(string nome, string matricula)
      : this(1) {
      this.Nome = nome;
      this.Matricula = matricula;
    }

    public Aluno(string nome, string matricula, int periodo)
      : this(periodo) {
      this.Nome = nome;
      this.Matricula = matricula;
    }
    
    public bool Matricular(Disciplina disciplina) {
      return this.Periodo == disciplina.Semestre;
    }

    public override bool Validar() {
      return this.Matricula != null &&
        this.Matricula.Length > 0;
    }
    
  }
  
}