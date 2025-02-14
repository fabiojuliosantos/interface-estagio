using projetoInterface.Modelos;

namespace projetoInterface.Interfaces;

/*
 * Na interface são criadas as assinaturas dos métodos, que definem como o método funcionará.
 * Na assinatura, definimos o tipo de retorno do método, nome e parâmetros. Essas informações
 * serão implementadas obrigatoriamente em todas as classes que implementarem a interface.
 */

public interface ICadastroRepositorio
{
    void Cadastrar(Colaborador colaborador);
    void ListarTodos();
    
    #region Desafio
    void SalvarArquivo(int codEmpresa);
    #endregion Desafio
}