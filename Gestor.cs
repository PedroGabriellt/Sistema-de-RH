class Gestor {

  private int id;
  private string area;
  private string nome;

  public Gestor(int id, string area, string nome){
    this.id = id;
    this.area = area;
    this.nome = nome;
  }

  public void SetId(int id){
        this.id = id;
  }

  public void SetArea(string area){
        this.area = area;
  }

  public void SetNome(string nome){
        this.nome = nome;
  }

  public int GetId(){
    return id;
  }

  public string GetArea(){
        return area;
  }

   public string GetNome(){
        return nome;
  }

  public override string ToString(){
    return id + " - " + nome + " - " + area;
  }

}