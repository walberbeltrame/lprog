using System;
using Modelos;

class Aula11 {
  
  public static void Main (string[] args) {
    Disciplina calculo = 
      new Disciplina("Calculo");
    Disciplina fisica = 
      new Disciplina("Fisica");
    fisica.Prerequisito = calculo;
    Curso engenharia = new Curso();
    engenharia.Nome = "Engenharia";
    engenharia.Disciplinas.Add(calculo);
    engenharia.Disciplinas.Add(fisica);
    Aluno aluno1 = new Aluno();
    Matricula matricula1 = aluno1.Cursar(engenharia);
    matricula1.Ano = 2022;
    matricula1.Semestre = 2;
    matricula1.Codigo = "2022EN0001";
    Turma turma1 = new Turma();
    turma1.Ano = 2022;
    turma1.Semestre = 2022;
    Historico historico1 = new Historico();
    historico1.Matricula = matricula1;
    historico1.Turma = turma1;
    Console.WriteLine(historico1.Resultado.Media());
    Console.WriteLine(historico1.Resultado.Aprovado());
    historico1.Faltas = 0.8f;
    Nota nota1 = new Nota();
    nota1.Valor = 10.0f;
    historico1.Notas.Add(nota1);
    Nota nota2 = new Nota();
    nota2.Valor = 8.0f;
    historico1.Notas.Add(nota2);
    Console.WriteLine(historico1.Resultado.Media());
    Console.WriteLine(historico1.Resultado.Aprovado());
  }

}