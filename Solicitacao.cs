class Solicitacao{

  private int id;
  private string AreaDeAtuacao;
  private string Turno;
  private Candidato[] aprovados = new Candidato[5];
  private int cnt;
  private Gestor Gestor;

  private FuncionarioDoRH FuncionarioDoRH; 

  public Solicitacao(int id, string AreaDeAtuacao, string Turno, Gestor Gestor, FuncionarioDoRH FuncionarioDoRH){

  this.id = id;
  this.AreaDeAtuacao = AreaDeAtuacao;
  this.Turno = Turno;
  this.Gestor = Gestor;
  
  this.FuncionarioDoRH = FuncionarioDoRH;
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

  public void SetGestor(Gestor Gestor){
    this.Gestor = Gestor;
  }

 

  public void SetFuncionarioDoRH(FuncionarioDoRH FuncionarioDoRH){
      this.FuncionarioDoRH = FuncionarioDoRH;
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


  public Gestor GetGestor(){
    return Gestor;
  }

  

  public FuncionarioDoRH GetFuncionarioDoRH(){
      return FuncionarioDoRH;
  }

public Candidato[] CandidatoListar(){
  return aprovados;
}

public void CandidatoInserir(Candidato a){
  aprovados[cnt] = a;
  cnt++;
}


  public override string ToString(){
    return id + " - Area de atuação: " + AreaDeAtuacao + " - Turno: " + Turno + " - Gestor: " + Gestor + "Responsavel do RH "+ FuncionarioDoRH + " - Quantidade de aprovados: " + cnt ;
  }
}