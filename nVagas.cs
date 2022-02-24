using System;
using System.Collections.Generic;

class nVagas{
  private List<Vagas> vagas = new List<Vagas>();

  public List<Vagas> Listar(){
    return vagas;
  }

  public void Inserir(Vagas v){
    
    int max = 0;
    foreach(Vagas obj in vagas)
      if(obj.idv > max){
        max = obj.idv;
      }
    v.idv = max + 1;
    
    vagas.Add(v);
  }



}