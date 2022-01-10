class nResposta{
  private Resposta[] respostas = new Resposta[10];
  private int nc;

  public void Inserir(Resposta r){
    respostas[nc] = r;
    nc++;



    
  }

  public Resposta[] Listar(){
    return respostas;
  }

}