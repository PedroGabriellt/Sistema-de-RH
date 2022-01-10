class nCandidatos{
  private Candidato[] candidatos = new Candidato[10];
  private int nc;

  public void Inserir(Candidato c){
    candidatos[nc] = c;
    nc++;
  }

  public Candidato[] Listar(){
    return candidatos;
  }

}