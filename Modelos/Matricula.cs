using System.Collections.Generic;

namespace Modelos {

  class Matricula {

    public List<Historico> Historicos = 
      new List<Historico>();

    public int Ano {
      get; set;
    }

    public int Semestre {
      get; set;
    }

    public string Codigo {
      get; set;
    }

    public Aluno Aluno {
      get; set;
    }

    public Curso Curso {
      get; set;
    }
    
  }
  
  
}