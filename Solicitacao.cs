public class Solicitacao{

  public int id {get; set;}
  public string AreaDeAtuacao {get; set;}
  public string Turno {get; set;}
  public int cnt {get; set;}
  public string Gestor {get; set;}
  public int qvagas {get; set;}


  public override string ToString(){
    return id + " - Area de atuação: " + AreaDeAtuacao + " - Turno: " + Turno + " - Gestor: " + Gestor +" - Quantidade de Vagas" + qvagas;
  }
}