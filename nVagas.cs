class nVagas{
  private Vagas[] vagas = new Vagas[10];
  private int nc;

  public void Inserir(Vagas v){
    vagas[nc] = v;
    nc++;
  }

  public Vagas[] Listar(){
    return vagas;
  }

}