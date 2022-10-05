namespace Modelos {

  class TextoPessoa : Texto {

    public Pessoa Pessoa {
      get; set;
    }

    public TextoPessoa(Pessoa Pessoa) {
      this.Pessoa = Pessoa;
    }

    public override string Informar() {
      return
        "Nome: " + this.Pessoa.Nome + "\n" +
        "CPF: " + this.Pessoa.Cpf;
    }
    
  }

  class PaginaPessoa : Pagina<Pessoa> {

    public Texto Formatar(Pessoa Pessoa) {
      return new TextoPessoa(Pessoa);
    }
    
  }
  
}