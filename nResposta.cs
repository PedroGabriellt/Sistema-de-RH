using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

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

  public void abrir(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Resposta>));
    StreamReader r = new StreamReader("./Respostas.xml", Encoding.Default);
    respostas = (List<Resposta>) xml.Deserialize(r);
    r.Close();
    
  }

  public void salvar(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Resposta>));
    StreamWriter r = new StreamWriter("./Respostas.xml", false, Encoding.Default);
    xml.Serialize(r, Listar());
    r.Close();
    
  }


}