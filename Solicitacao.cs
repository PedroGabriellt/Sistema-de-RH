class Solicitacao{

  private int id;
  private string AreaDeAtuacao;
  private string Turno;
  private Resposta[] resposta = new Resposta[5];
  private int cnt;
  private string Gestor;


  public Solicitacao(int id, string AreaDeAtuacao, string Turno, string Gestor){

  this.id = id;
  this.AreaDeAtuacao = AreaDeAtuacao;
  this.Turno = Turno;
  this.Gestor = Gestor;
  
  
  
  }

   public void SetId(int id){
        this.id = id;
  }

   public void SetAreaDeAtuacao(string AreaDeAtuacao){
        this.AreaDeAtuacao = AreaDeAtuacao;
  }

   public void SetTurno(string Turno){
        this.Turno = Turno;
  }

  public void SetGestor(string Gestor){
    this.Gestor = Gestor;
  }

 

  

  public int GetId(){
        return id;
  }

   public string GetAreaDeAtuacao(){
        return AreaDeAtuacao;
  }

   public string GetTurno(){
        return Turno;
  }


  public string GetGestor(){
    return Gestor;
  }

  

public Resposta[] RespostaListar(){
  return resposta;
}


public void RespostaIserir(Resposta r){
  resposta[cnt] = r;
  cnt++;
}


  public override string ToString(){
    return id + " - Area de atuação: " + AreaDeAtuacao + " - Turno: " + Turno + " - Gestor: " + Gestor;
  }
}