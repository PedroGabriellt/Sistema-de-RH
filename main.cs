using System;

class Program {
  public static void Main (string[] args) {
    Gestor g1 = new Gestor(1,"Designer","Pedro");

    Console.WriteLine(g1);
  }
}


class Gestor {

  private int id;
  private string area;
  private string nome;

  public Gestor(int id, string area, string nome){
    this.id = id;
    this.area = area;
    this.nome = nome;
  }

  public override string ToString(){
    return id + " - " + nome + " - " + area;
  }

}

class Solicitação{

  private int id;
  private string AreaDeAtuação;
  private string Turno;
  private string Resposta;
  private string Aprovados;

  public Solicitação(int id, string AreaDeAtuação, string Turno, string Resposta, string Aprovados){

  this.id = id;
  this.AreaDeAtuação = AreaDeAtuação;
  this.Turno = Turno;
  this.Resposta = Resposta;
  this.Aprovados = Aprovados;



  }
}


class FuncionarioDoRH {
 private int id;
 private string Nome;

 public FuncionarioDoRH(int id, string Nome){
   this.id = id;
   this.Nome = Nome;

 }
}

class Candidato{
  private int id;
  private string Nome;
  private int idade;
  private string Telefone;
  private string Email;
  private string Formacao;
  private string Experiencia;

  public Candidato(int id, string Nome, int idade, string Telefone, string Email, string Formacao, string Experiencia){
    this.id = id;
    this.Nome = Nome;
    this.idade = idade;
    this.Telefone = Telefone;
    this.Email = Email;
    this.Formacao = Formacao;
    this.Experiencia = Experiencia;
  }
}