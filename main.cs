using System;

class Program {
  public static void Main (string[] args) {
    int op = 0;
    Console.WriteLine("----------Sistema de RH----------");
    do{ 
      try{
    op = Menu();
    switch(op){
      case 1 : MenuGestor(); break;
      case 2 : MenuRH(); break;
      case 3: MenuCandidato(); break;

       }
     }
     catch(Exception erro){
       Console.WriteLine(erro.Message);
       op = 50;
     }
    } while (op!=0);
    Console.WriteLine("Fim");

  }
  public static int Menu(){
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
    return op;
  }

  public static int MenuGestor(){
     Console.WriteLine("|---------Área do Gestor---------|");
     Console.WriteLine();
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("|1 - Solicitar Funcionario       |");
     Console.WriteLine("|2 - Resposta                    |");
     Console.WriteLine("|0 - sair                        |");
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("Selecione uma opção: ");
     int op2 = int.Parse(Console.ReadLine());
     Console.WriteLine();
    return op2;
  }
  public static int MenuRH(){
     Console.WriteLine("|----------Área do RH------------|");
     Console.WriteLine();
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("|1 - Solicitações                |");
     Console.WriteLine("|2 - Listar Candidatos           |");
     Console.WriteLine("|3 - Responder                   |");
     Console.WriteLine("|0 - sair                        |");
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("Selecione uma opção: ");
     int op2 = int.Parse(Console.ReadLine());
     Console.WriteLine();
    return op2;

  }
  public static int MenuCandidato(){
     Console.WriteLine("|---------Área do Candidato------|");
     Console.WriteLine();
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("|1 - Listar Dados                |");
     Console.WriteLine("|2 - Atualizar Dados             |");
     Console.WriteLine("|0 - sair                        |");
     Console.WriteLine("|--------------------------------|");
     Console.WriteLine("Selecione uma opção: ");
     int op2 = int.Parse(Console.ReadLine());
     Console.WriteLine();
    return op2;

  }
}
