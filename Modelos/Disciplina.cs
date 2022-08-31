namespace Modelos {

  class Disciplina {
    
    public string nome;
    public int semestre;

    public Disciplina() : this(1) {
    }

    public Disciplina(int semestre) {
      if(semestre < 1) {
        this.semestre = 1;
      } else if(semestre > 10) {
        this.semestre = 10;
      } else {
        this.semestre = semestre;
      }
    }

    public Disciplina(string nome) : this(1) {
      this.nome = nome;
    }

    public Disciplina(string nome, int semestre) : this(semestre) {
      this.nome = nome;
    }
    
  }

}