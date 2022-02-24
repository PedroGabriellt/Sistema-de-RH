using System;
using System.Collections.Generic;

class nSolicitacao{
  private List<Solicitacao> solitacoes = new List<Solicitacao>();

  public List<Solicitacao> Listar(){
    return solitacoes;
  }

 public void Inserir(Solicitacao s){
    int max = 0;
    foreach(Solicitacao obj in solitacoes)
      if(obj.id > max){
        max = obj.id;
      }
    s.id = max + 1;
    
    solitacoes.Add(s);

    
  }

  public void Excluir(Solicitacao s){
    if(s != null){
      solitacoes.Remove(s);
    }
  }

}