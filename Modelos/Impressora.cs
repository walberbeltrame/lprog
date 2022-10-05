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

    public static void Imprimir(Pessoa pessoa) {
      Console.WriteLine(
        
      );
    }

    public static void Imprimir(Contato contato) {
      Console.WriteLine(
       contato.Informar()
      );
    }

    public static void Imprimir(Professor professor) {
      Console.WriteLine(
        "Codigo: " + professor.Codigo
      );
    }
    
    public static void Imprimir(Aluno aluno) {
      Console.WriteLine(
        
      );
    }

    private static void Imprimir(Disciplina disciplina) {
      Console.WriteLine(
        "Nome: " + disciplina.Nome + "\n" +
        "Semestre: " + disciplina.Semestre
      );
    }
    
  }

}