class Solicitacao{

  private int id;
  private string AreaDeAtuacao;
  private string Turno;
  private string Resposta;
  private string Aprovado;

  public Solicitacao(int id, string AreaDeAtuacao, string Turno, string Resposta, string Aprovado){

  this.id = id;
  this.AreaDeAtuacao = AreaDeAtuacao;
  this.Turno = Turno;
  this.Resposta = Resposta;
  this.Aprovado = Aprovado;
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

  public void SetResposta(string Resposta){
        this.Resposta = Resposta;
  }

   public void SetAprovado(string Aprovado){
        this.Aprovado = Aprovado;
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

  public string GetResposta(){
        return Resposta;
  }

  public string GetAprovado(){
        return Aprovado;
  }


  public override string ToString(){
    return id + " - " + AreaDeAtuacao + " - " + Turno;
  }
}