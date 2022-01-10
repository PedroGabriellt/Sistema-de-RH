class Resposta {
  
  private int idr;
  private int ids;
  private int idc;
  private string nome;
  private string Gestor;
  private string Nome;

  public Resposta(int idr, int ids, int idc, string Gestor, string Nome){
    this.ids = idr;
    this.ids = ids;
    this.idc = idc;
    this.Gestor = Gestor;
    this.Nome = Nome;
  }

   public void SetIdr(int idr){
        this.idr = idr;
  }

  public void SetIds(int ids){
        this.ids = ids;
  }
  public void SetIdc(int idc){
        this.idc = idc;
  }
  public int GetIdr(){
    return idr;
  }
  public int GetIds(){
    return ids;
  }

   public int GetIdc(){
    return idc;
  }

  public void SetGestor(string Gestor){
    this.Gestor = Gestor;
  }
  public string GetGestor(){
    return Gestor;
  }

  public void SetNome(string Nome){
        this.Nome = Nome;
  }

  public string GetNome(){
        return Nome;
  }


  public override string ToString(){
    return idr + " Gestor responsavel " + Gestor + " Aprovado " + Nome;
  }

}