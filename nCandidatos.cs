using System.Collections.Generic;

class nCandidatos{
  private List<Candidato> candidatos = new List<Candidato>();

  public List<Candidato> Listar(){
    return candidatos;
  }

  public void Inserir(Candidato c){

    int max = 0;
    foreach(Candidato obj in candidatos)
      if(obj.id > max){
        max = obj.id;
      }
    c.id = max + 1;
    
    candidatos.Add(c);
  }

}