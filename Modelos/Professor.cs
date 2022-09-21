namespace Modelos {

  class Professor : Pessoa {

    public string Codigo {
      get; set;
    }

    public override bool Validar() {
      return this.Codigo != null &&
        this.Codigo.Length > 0;
    }

  }

}