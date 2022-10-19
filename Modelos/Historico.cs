using System.Collections.Generic;

namespace Modelos {

  class Historico {

    public float Faltas {
      get; set;
    }

    public Turma Turma {
      get; set;
    }

    public Matricula Matricula {
      get; set;
    }

    public List<Nota> Notas = 
      new List<Nota>();

    public Resultado Resultado {
      get; set;
    }

    public Historico() {
      this.Resultado = new Resultado(this);
    }
    
  }
  
}