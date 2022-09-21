namespace Modelos {

  class Familiar : Pessoa, Contato {

    public string Parentesco {
      get; set;
    }

    public override bool Validar() {
      return this.Parentesco != null &&
        this.Parentesco.Length > 0;
    }

    public string Informar() {
      return "Parentesco: " + this.Parentesco;
    }

  }
  
}