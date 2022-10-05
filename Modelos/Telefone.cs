namespace Modelos {

  class Telefone : Contato {

    public string Tipo {
      get; set;
    }

    public string Numero {
      get; set;
    }

    public string Informar() {
      return
        "Tipo: " + this.Tipo + "\n" +
        "Numero: " + this.Numero;
    }

  }
  
}