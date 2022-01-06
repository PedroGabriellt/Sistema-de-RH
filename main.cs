using System;

class Program {
  public static void Main (string[] args) {
    Gestor g1 = new Gestor(1,"Designer","Pedro");

    Console.WriteLine(g1);
  }
}


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

class Solicitacao{

  private int id;
  private string AreaDeAtuacao;
  private string Turno;
  private string Resposta;
  private string Aprovado;

  public Solicitacao(int id, string AreaDeAtuacao, string Turno, string Resposta, string Aprovado){

  this.id = id;
  this.AreaDeAtuacao = AreaDeAtuacao;
  this.Turno = Turno;
  this.Resposta = Resposta;
  this.Aprovado = Aprovado;
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

  public void SetResposta(string Resposta){
        this.Resposta = Resposta;
  }

   public void SetAprovado(string Aprovado){
        this.Aprovado = Aprovado;
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

  public string GetResposta(){
        return Resposta;
  }

  public string GetAprovado(){
        return Aprovado;
  }


  public override string ToString(){
    return id + " - " + AreaDeAtuacao + " - " + Turno;
  }
}


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