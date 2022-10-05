using System;

namespace Modelos {

  class Impressora {

    public delegate string Linha();

    public static string LinhaComum() {
      return "-------------------------";
    }

    public static void Imprimir(Texto texto) {
      Imprimir(texto, LinhaComum, LinhaComum);
    }
    
    public static void Imprimir(Texto texto,
                                Linha cabecalho,
                                Linha rodape) {
      Console.WriteLine(cabecalho());
      Console.WriteLine(texto.Informar());
      Console.WriteLine(rodape());
    }
    
  }

}