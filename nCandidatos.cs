using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

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

  public void abrir(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Candidato>));
    StreamReader can = new StreamReader("./Candidatos.xml", Encoding.Default);
    candidatos = (List<Candidato>) xml.Deserialize(can);
    can.Close();
    
  }

  public void salvar(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Candidato>));
    StreamWriter can = new StreamWriter("./Candidatos.xml", false, Encoding.Default);
    xml.Serialize(can, Listar());
    can.Close();
    
  }

}