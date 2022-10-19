namespace Modelos {

  class Resultado {

    public bool Aprovado() {
      return this.Media() >= 6.0 &&
        this.Historico.Faltas >= 0.7;
    }

    public float Media() {
      if (this.Historico.Notas.Count == 0) {
        return 0;
      }
      float soma = 0;
      foreach(Nota nota in this.Historico.Notas) {
        soma += nota.Valor;
      }
      return soma/this.Historico.Notas.Count;
    }

    public Historico Historico {
      get; set;
    }

    public Resultado(Historico historico) {
      this.Historico = historico;
    }
    
  }
  
}