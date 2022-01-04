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

