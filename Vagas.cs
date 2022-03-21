using System;
using System.Collections.Generic;

public class Vagas{

public int idv {get; set;}
public string Atuacao {get; set;}
public int qvagas {get; set;}
public string Turno {get; set;}


 public override string ToString(){
    return idv + " - Area de atuação: " + Atuacao + " - Turno: " + Turno + " - Vagas: " + qvagas;
  }

}