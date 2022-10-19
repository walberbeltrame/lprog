using System.Collections.Generic;

namespace Modelos {
  
  class Curso {

    public List<Disciplina> Disciplinas = 
      new List<Disciplina>();
    
    public string Nome {
      get; set;
    }
    
  }

}