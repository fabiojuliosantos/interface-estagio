using projetoInterface.Interfaces;
using projetoInterface.Modelos;

namespace projetoInterface.Servicos;
/*
 * Semelhante A Classe CadastroRepositorio, a classe CadastroServico também implementa uma interface. Dessa vez, a
 * interface que está sendo implementada, é a interface de ICadastroServico.
 */
public class CadastroServico : ICadastroServico
{
    /*
     * Aqui chamamos a interface de repositorio que será utilizada para acessar os dados que estão sendo salvos.
     * Não chamamos a classe de Repositorio porque estamos trabalhando com o conceito de Abstração na aplicação,
     * utilizando as interfaces para tal. Após isso, criamos o construtor da interface de repositorio para acessá-la
     * no servico.
     */
    private readonly ICadastroRepositorio _repositorio; 
    public CadastroServico(ICadastroRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public void Cadastrar(Colaborador colaborador)
    {
        /*
         * A chamada é feita para o método descrito na interface, que por sua vez, redireciona a execução
         * para o método que implementa essa interface, e realiza a ação pretendida. Isso vale para todos os métodos
         * dessa classe.
         */
        _repositorio.Cadastrar(colaborador); 
    }

    public void Listar()
    {
        _repositorio.ListarTodos();
    }

    #region Desafio
    public void SalvarArquivo(int codEmpresa)
    {
        _repositorio.SalvarArquivo(codEmpresa);
    }
    #endregion Desafio
}