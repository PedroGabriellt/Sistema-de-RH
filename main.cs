using System;

class Gertor {

  private int id;
  private string area;
  private string nome;

  public Gestor(int id, string area, string nome){
    this.id = id;
    this.area = area;
    this.nome = nome;
  }

}

class Solicitação{

  private int id;
  private string AreaDeAtuação;
  private int Qfuncionarios;
  private string Turno;
  private string Resposta;
  private string Aprovados;

  public Solicitação(int id, string AreaDeAtuação, int Qfuncionarios, string Turno, string Resposta, string Aprovados){

  this.id = id;
  this.AreaDeAtuação = AreaDeAtuação;
  this.Qfuncionarios = Qfuncionarios > 0 ? Qfuncionarios : 0;
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


class Curricolo {
  private int id;
  private string Formacao;
  private string Experiencia;

  public Curricolo( int id, string Formacao, string Experiencia){
    this.id = id;
    this.Formacao = Formacao;
    this.Experiencia = Experiencia;
  }

}

class Candidato{
  private int id;
  private string Nome;
  private int idade;
  private string Telefone;
  private string Email;

  public Candidato(int id, string Nome, int idade, string Telefone, string Email){
    this.id = id;
    this.Nome = Nome;
    this.idade = idade;
    this.Telefone = Telefone;
    this.Email = Email;
  }
}