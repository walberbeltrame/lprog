using Modelos;

class Aula7 {

  public static void Main (string[] args) {
    Familiar familiar = new Familiar();
    Impressora.Imprimir(familiar);
    Endereco endereco = new Endereco();
    Impressora.Imprimir(endereco);
  }

}