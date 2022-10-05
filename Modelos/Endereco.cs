namespace Modelos {

  class Endereco : Contato {

    public string Local {
      get; set;
    }

    public int Postal {
      get; set;
    }

    public string Informar() {
      return
        "Local: " + this.Local + "\n" +
        "Postal: " + this.Postal;
    }

  }
  
}