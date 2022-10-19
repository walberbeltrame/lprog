namespace Modelos {

  class Disciplina {
    
    private int semestre;

    public Disciplina Prerequisito {
      get; set;
    }

    public string Nome {
      get; set;
    }

    public int Semestre {
      get => this.semestre;
      set {
        if(value < 1) {
          this.semestre = 1;
        } else if(value > 10) {
          this.semestre = 10;
        } else {
          this.semestre = value;
        }
      }
    }

    public Disciplina() : this(1) {
    }

    public Disciplina(int semestre) {
      this.Semestre = semestre;
    }

    public Disciplina(string nome) : this(1) {
      this.Nome = nome;
    }

    public Disciplina(string nome, int semestre) : this(semestre) {
      this.Nome = nome;
    }
    
  }

}