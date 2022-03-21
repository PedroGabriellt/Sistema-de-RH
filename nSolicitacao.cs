using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

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

  public void abrir(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Solicitacao>));
    StreamReader f = new StreamReader("./Solicitações.xml", Encoding.Default);
    solitacoes = (List<Solicitacao>) xml.Deserialize(f);
    f.Close();
    
  }

  public void salvar(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Solicitacao>));
    StreamWriter f = new StreamWriter("./Solicitações.xml", false, Encoding.Default);
    xml.Serialize(f, Listar());
    f.Close();
    
  }
}