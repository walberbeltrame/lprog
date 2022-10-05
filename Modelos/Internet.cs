namespace Modelos {

  class Internet : Contato {

    public string Tipo {
      get; set;
    }

    public string Link {
      get; set;
    }

    public string Informar() {
      return
        "Tipo: " + this.Tipo + "\n" +
        "Link: " + this.Link;
    }

  }
  
}