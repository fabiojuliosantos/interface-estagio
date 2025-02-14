using projetoInterface.Interfaces;
using projetoInterface.Modelos;

namespace projetoInterface.Repositorios;
/*
 * A Classe CadastroRepositorio implementa a interface ICadastroRepositorio, sendo assim, todos os métodos assinados
 * na interface ICadastroRepositorio, são implementados na classe CadastroRepositorio.
 */

public class CadastroRepositorio : ICadastroRepositorio
{
    private List<Colaborador> colaboradores = new List<Colaborador>(); //=> Definimos uma lista para simular um banco
    public void Cadastrar(Colaborador colaborador) //=> Método de adição de um colaborador na lista, simulando um insert no banco
    {
        Colaborador colaboradorCadastro = new Colaborador()
        {
            Matricula = colaborador.Matricula,
            Nome = colaborador.Nome,
            CodigoEmpresa = colaborador.CodigoEmpresa,
            Cpf = colaborador.Cpf
        };
        colaboradores.Add(colaboradorCadastro);
        Console.WriteLine($"Colaborador(a): {colaboradorCadastro.Nome} cadastrado(a) com sucesso!");
    }

    public void ListarTodos() //=> Método de listagem de todos os colaboradores
    {
        foreach (var colaborador in colaboradores)
        {
            Console.WriteLine($"Nome: {colaborador.Nome} " +
                              $"\n Matrícula: {colaborador.Matricula} " +
                              $"\n Código da Empresa: {colaborador.CodigoEmpresa} " +
                              $"\n CPF: {colaborador.Cpf}");
        }
    }
    
    #region Desafio
    public void SalvarArquivo(int codEmpresa)
    {
        //Primeira parte do desafio: Filtrar os colaboradores que possuem o codigoEmpresa que foi informado.
        colaboradores = colaboradores.Where(c => c.CodigoEmpresa == codEmpresa).ToList();
        
        /*
         *Segunda parte do desafio: Fazer a escrita dos dados dos colaboradores em um arquivo .txt
         * Defina o local onde será salvo o arquivo antes do nome do mesmo, ao salvar assim ele será armazenado
         * no diretório "projetoInterface\projetoInterface\bin\Debug\net8.0"
         */ 
        using(StreamWriter sw = new StreamWriter("colaboradores.txt"))
        {
            foreach (var colaborador in colaboradores)
            {
                sw.WriteLine($"Nome: {colaborador.Nome} " +
                             $"\n Matricula: {colaborador.Matricula} " +
                             $"\n CPF: {colaborador.Cpf} " +
                             $"\n Codigo Empresa: {colaborador.CodigoEmpresa}");
            }
        }
    }
    #endregion Desafio
}