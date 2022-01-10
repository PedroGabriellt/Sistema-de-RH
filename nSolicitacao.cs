class nSolicitacao{
  private Solicitacao[] solitacoes = new Solicitacao[10];
  private int nc;

  public void Inserir(Solicitacao s){
    solitacoes[nc] = s;
    nc++;
  }

  public Solicitacao[] Listar(){
    return solitacoes;
  }

}