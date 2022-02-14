using System;

class Program {
  private static nCandidatos  ncandidatos = new nCandidatos();
  private static nSolicitacao  nsolicitacao = new nSolicitacao();
  private static nResposta  nresposta = new nResposta();
  private static nVagas nvagas = new nVagas();
  public static void Main (string[] args) {
    int op = 0;
    int op2 = 0;
    int op3 = 0;
    int op4 = 0;
    
    Menu():

  }
  public static void Menu(){
    Console.WriteLine("----------Sistema de RH----------");
    Console.WriteLine();
    Console.WriteLine("|--------------------------------|");
    Console.WriteLine("|1 - Gestor                      |");
    Console.WriteLine("|2 - RH                          |");
    Console.WriteLine("|3 - Candidato                   |");
    Console.WriteLine("|0 - sair                        |");
    Console.WriteLine("|--------------------------------|");
    Console.WriteLine("Selecione uma opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    
    
      try{
    switch(op){
      
      case 1 : MenuGestor(); break;
      case 2 : MenuRH(); break;
      case 3: MenuCandidato(); break;
     

       }
     }
     catch(Exception erro){
       Console.WriteLine(erro.Message);Menu();
       op = 50;
     }
     if(op==0){
       Saida(); 
       
     } else{
      Menu();
      }

    
      
     
  }

  public static void MenuGestor(){
     Console.WriteLine("|---------Área do Gestor---------|");
     Console.WriteLine();
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("|1 - Solicitar Funcionario       |");
     Console.WriteLine("|2 - solicitações                |");
     Console.WriteLine("|3 - Respostas                   |");
     Console.WriteLine("|4 - Voltar                      |");
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("Selecione uma opção: ");
     int op2 = int.Parse(Console.ReadLine());
     Console.WriteLine();
    
      try{
    switch(op2){
      case 1 : AbrirS(); break;
      case 2 : Vsolicitacoes(); break;
      case 3 : Vresposta(); break;
      

       }
     }
     catch(Exception erro){
       Console.WriteLine(erro.Message);
       op2 = 50;
     }
     
     if(op2==4){
       Console.WriteLine("Voltar");
     } else{
      MenuGestor();
      }
  
  }
  public static void MenuRH(){
     Console.WriteLine("|----------Área do RH------------|");
     Console.WriteLine();
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("|1 - Solicitações                |");
     Console.WriteLine("|2 - Listar Candidatos           |");
     Console.WriteLine("|3 - Responder                   |");
     Console.WriteLine("|4 - Respostas                   |");
     Console.WriteLine("|5 - Abrir Vagas                 |");
     Console.WriteLine("|6 - Exibir Vagas                |");
     Console.WriteLine("|7 - Voltar                      |");
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("Selecione uma opção: ");
     int op3 = int.Parse(Console.ReadLine());
     Console.WriteLine();

  
      try{
    switch(op3){
    
      case 1 : Vsolicitacoes(); break;
      case 2 : Vcandidatos(); break;
      case 3: responder(); break;
      case 4: Vresposta();break;
      case 5:AbrirV();break;
      case 6: Vvagas(); break;
      

       }
     }
     catch(Exception erro){
       Console.WriteLine(erro.Message);
       op3 = 50;
     }
     if(op3==7){
       Console.WriteLine("Voltar");
     } else{
      MenuRH();
      }


     
     

  }
  public static void MenuCandidato(){
     Console.WriteLine("|---------Área do Candidato------|");
     Console.WriteLine();
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("|1 - Exibir Vagas                |");
     Console.WriteLine("|2 - Candidatar-se               |");
     Console.WriteLine("|3 - Ver Candidatos              |");
     Console.WriteLine("|4 - Voltar                      |");
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("Selecione uma opção: ");
     int op4 = int.Parse(Console.ReadLine());
     Console.WriteLine();
  
      try{

    switch(op4){
      case 1 : Vvagas(); break;
      case 2 : Candidatar(); break;
      case 3: Vcandidatos(); break;
    

       }
     }
     catch(Exception erro){
       Console.WriteLine(erro.Message);
       op4 = 50;
     }
     if(op4==4){
       Console.WriteLine("Voltar");
     } else{
      MenuCandidato();
      }

    

  }

public static void Candidatar(){
  Console.WriteLine("|--------- Candidatar-se ------|");
  Console.WriteLine("Informe um ID:");
  int id = int.Parse(Console.ReadLine());
  Console.WriteLine();

  Console.WriteLine("Informe seu nome:");
  string Nome = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe um sua idade:");
  int idade = int.Parse(Console.ReadLine());
  Console.WriteLine();

  Console.WriteLine("Informe seu telefone (xx) x xxxx-xxxx:");
  string Telefone = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe seu E-mail:");
  string Email = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe sua formação:");
  string Formacao = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe sua experiencia:");
  string Experiencia = Console.ReadLine();
  Console.WriteLine();

  Candidato ca = new Candidato(id, Nome, idade, Telefone, Email, Formacao, Experiencia);

  ncandidatos.Inserir(ca);

 Console.WriteLine("Candidatura Realizada");
 Menu();

  
}

public static void Vcandidatos(){
  Console.WriteLine("|--------- Candidatos ------|");
  Candidato[] cs = ncandidatos.Listar();
  if(cs.Length == 0){
    Console.WriteLine("Sem candidatos hoje");
    Menu();
  }
  foreach( Candidato c in cs) Console.WriteLine(c);
  Console.WriteLine();
  Menu();


}



public static void AbrirS(){
  Console.WriteLine("|--------- Abrir Solicitacao ------|");
  Console.WriteLine("Informe um ID:");
  int id = int.Parse(Console.ReadLine());
  Console.WriteLine();

  Console.WriteLine("Informe a área desejada:");
  string AreaDeAtuacao = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe o turno:");
  string Turno = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe o seu nome:");
  string Gestor = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe a quantidade de funcionarios que deseja:");
  int quvagas = int.Parse(Console.ReadLine());
  Console.WriteLine();

  Solicitacao sa = new Solicitacao(id, AreaDeAtuacao, Turno, Gestor,quvagas);

  nsolicitacao.Inserir(sa);

  Menu();

  
}

public static void Vsolicitacoes(){
  Console.WriteLine("|--------- Solicitações ------|");
  Solicitacao[] ss = nsolicitacao.Listar();
  if(ss.Length == 0){
    Console.WriteLine("Sem solicitações hoje");
    return;
    Menu();
    
  }
  foreach( Solicitacao s in ss) Console.WriteLine(s);
  Console.WriteLine(); 
  Menu();

}

public static void responder(){
  Console.WriteLine("|--------- Responder ------|");

 
  

  Console.WriteLine("Informe o ID da resposta:");
  int idr = int.Parse(Console.ReadLine());
  Console.WriteLine();

  Solicitacao[] ss = nsolicitacao.Listar();
  foreach( Solicitacao s in ss) Console.WriteLine(s);
  Console.WriteLine();

  Console.WriteLine("Informe o ID da solicitação:");
  int ids = int.Parse(Console.ReadLine());
  Console.WriteLine();

  Console.WriteLine("Informe o nome do gestor responsavel:");
  string Gestor = Console.ReadLine();
  Console.WriteLine();

  Candidato[] cs = ncandidatos.Listar();
  foreach( Candidato c in cs) Console.WriteLine(c);
  Console.WriteLine();

  Console.WriteLine("Informe o ID do candidato:");
  int idc = int.Parse(Console.ReadLine());
  Console.WriteLine();
 

  Console.WriteLine("Informe o nome do candidato aprovado:");
  string Nome = Console.ReadLine();
  Console.WriteLine();

  Resposta ra = new Resposta(idr, ids, idc, Gestor, Nome);

  nresposta.Inserir(ra);

  Menu();

  
}

public static void Vresposta(){
  Console.WriteLine("|--------- Respostas ------|");
  Resposta[] rs = nresposta.Listar();
  if(rs.Length == 0){
    Console.WriteLine("Sem respostas hoje");
    return;
    Menu();
    
  }
  foreach( Resposta r in rs) Console.WriteLine(r);
  Console.WriteLine(); 
  Menu();

}

public static void AbrirV(){
  Console.WriteLine("|--------- Abrir Vagas ------|");
  
  Console.WriteLine("Informe um ID:");
  int idv = int.Parse(Console.ReadLine());
  Console.WriteLine();

  Console.WriteLine("Informe a área desejada:");
  string Atuacao = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe o turno:");
  string Turno = Console.ReadLine();
  Console.WriteLine();

  Console.WriteLine("Informe a quantidade de Vagas:");
  int qvagas = int.Parse(Console.ReadLine());
  Console.WriteLine();


  Vagas va = new Vagas(idv, Atuacao, Turno, qvagas);

  nvagas.Inserir(va);

  Menu();

  
}

public static void Vvagas(){
  Console.WriteLine("|--------- Vagas ------|");
  Vagas[] vs = nvagas.Listar();
  if(vs.Length == 0){
    Console.WriteLine("Sem respostas hoje");
    return;
    Menu();
    
  }
  foreach( Vagas v in vs) Console.WriteLine(v);
  Console.WriteLine(); 
  Menu();

}

public static void Saida(){
  Console.WriteLine("Até mais!");
}

}
