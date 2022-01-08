class Candidato{
  private int id;
  private string Nome;
  private int idade;
  private string Telefone;
  private string Email;
  private string Formacao;
  private string Experiencia;

  public Candidato(int id, string Nome, int idade, string Telefone, string Email, string Formacao, string Experiencia){
    this.id = id;
    this.Nome = Nome;
    this.idade = idade;
    this.Telefone = Telefone;
    this.Email = Email;
    this.Formacao = Formacao;
    this.Experiencia = Experiencia;
  }

  public void SetId(int id){
        this.id = id;
  }

  public void SetNome(string Nome){
        this.Nome = Nome;
  }

  public void SetIdade(int idade){
        this.idade = idade;
  }

  public void SetTelefone(string Telefone){
        this.Telefone = Telefone;
  }

  public void SetEmail(string Email){
        this.Email = Email;
  }

  public void SetFomacao(string Formacao){
        this.Formacao = Formacao;
  }

  public void SetExperiencia(string Experiencia){
        this.Experiencia = Experiencia;
  }


  public int GetId(){
        return id;
  }

  public string GetNome(){
        return Nome;
  }

  public int GetIdade(){
        return idade;
  }

  public string GetTelefone(){
        return Telefone;
  }

  public string GetEmail(){
        return Email;
  }

  public string GetFormacao(){
        return Formacao;
  }

  public string GetExperiencia(){
        return Experiencia;
  }

  public override string ToString(){
    return id + " - " + Nome + " - " + idade + " - " + Telefone + " - " + Email + " - " + Formacao + " - " + Experiencia;
  }
}