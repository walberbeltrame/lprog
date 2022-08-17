namespace Modelos {

  class Aluno {
    
    public string matricula;
    public int periodo;

    public bool Matricular(Disciplina disciplina) {
      return this.periodo == disciplina.semestre;
    }
    
  }
  
}