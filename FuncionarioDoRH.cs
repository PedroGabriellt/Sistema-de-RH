class FuncionarioDoRH {
 private int id;
 private string Nome;

 public FuncionarioDoRH(int id, string Nome){
   this.id = id;
   this.Nome = Nome;

 }

  public void SetId(int id){
        this.id = id;
  }

  public void SetNome(string Nome){
        this.Nome = Nome;
  }

  public int GetId(){
    return id;
  }

   public string GetNome(){
        return Nome;
  }

 public override string ToString(){
    return id + " - " + Nome;
  }
}