namespace projetoInterface.Modelos;
/*
 * Classe que possui as informações do Colaborador que serão utilizadas na aplicação.
 * Essa classe funciona como uma classe em um projeto de domínio (Domain) na arquitetura limpa. 
 */
public class Colaborador
{
    public string Nome{get; set;}
    public string Cpf {get; set;}
    public int Matricula {get; set;}
    public int CodigoEmpresa {get; set;}
}