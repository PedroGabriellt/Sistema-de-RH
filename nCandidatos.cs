class nCandidatos{
  private Candidato[] candidatos = new Candidato[10];
  private int nc;

  public void Inserir(Candidato c){
    if (nc == candidatos.Length){
      Array.Resize(ref candidatos, 2*candidatos.Length);
    }
    candidatos[nc] = c;
    nc++;
  }

  public Candidato[] Listar(){
    Candidato[] c = new Candidato[nc];
    Array.Copy(candidatos, c, nc);
    return c;
  }

}