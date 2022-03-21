using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

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

   public void abrir(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Vagas>));
    StreamReader v = new StreamReader("./Vagas.xml", Encoding.Default);
    vagas = (List<Vagas>) xml.Deserialize(v);
    v.Close();
    
  }

  public void salvar(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Vagas>));
    StreamWriter v = new StreamWriter("./Vagas.xml", false, Encoding.Default);
    xml.Serialize(v, Listar());
    v.Close();
    
  }



}