using System;
using System.Collections.Generic;

public class Resposta {
  
  public int idr {get; set;}
  public int ids {get; set;}
  public int idc {get; set;}
  public string Gestor {get; set;}
  public string Nome {get; set;}

  

  public override string ToString(){
    return idr + " Gestor responsavel: " + Gestor + " Aprovado: " + Nome;
  }

}