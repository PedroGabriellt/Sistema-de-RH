using System;
using System.Collections.Generic;

class Candidato{
  public int id {get; set;}
  public string Nome {get; set;}
  public int idade {get; set;}
  public string Telefone {get; set;}
  public string Email {get; set;}
  public string Formacao {get; set;}
  public string Experiencia {get; set;}

  

  public override string ToString(){
    return id + " - " + Nome + " - " + Email + " - " + Formacao + " - " + Experiencia;
  }
}