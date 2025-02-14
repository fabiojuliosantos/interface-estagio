using projetoInterface.Interfaces;
using projetoInterface.Repositorios;
using projetoInterface.Servicos;

class Program
{
    static void Main(string[] args)
    {
        #region Variaveis
        //Instanciando o Repositorio e o Service para satisfazer o construtor do gerencial
        ICadastroRepositorio cadastroRepositorio = new CadastroRepositorio();
        ICadastroServico cadastroServico = new CadastroServico(cadastroRepositorio);
        #endregion Variaveis
        
        Gerencial gerencial = new Gerencial(cadastroServico);
        
        gerencial.Executar();
    }
}
