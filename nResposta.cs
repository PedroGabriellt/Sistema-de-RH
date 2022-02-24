using System;
using System.Collections.Generic;

class nResposta{
  private List<Resposta> respostas = new List<Resposta>();
  

  public List<Resposta> Listar(){
    return respostas;
  }

  public void Inserir(Resposta r){
    int max = 0;
    foreach(Resposta obj in respostas)
      if(obj.idr > max){
        max = obj.idr;
      }
    r.idr = max + 1;
    
    respostas.Add(r);

    
  }


}