class Vagas{

int idv;
private string Atuacao;
private int qvagas;
private string Turno;

public Vagas(int idv, string Atuacao, string Turno, int qvagas){
  this.idv = idv;
  this.Atuacao = Atuacao;
  this.qvagas = qvagas;
  this.Turno = Turno;
}

 public void SetIdv(int idv){
        this.idv = idv;
  }

public int GetIdv(){
        return idv;
  }

public void SetAtuacao(string Atuacao){
  this.Atuacao = Atuacao;
}

public string GetAtuacao(){
  return Atuacao;
}

public void SetQvagas(int qvagas){
        this.qvagas = qvagas;
  }

public int GetQvagas(){
        return qvagas;
  }
public void SetTurno(string Turno){
  this.Turno = Turno;
}

public string GetTurno(){
  return Turno;
}

 public override string ToString(){
    return idv + " - Area de atuação: " + Atuacao + " - Turno: " + Turno + " - Vagas: " + qvagas;
  }

}