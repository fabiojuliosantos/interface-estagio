using projetoInterface.Interfaces;
using projetoInterface.Modelos;

namespace projetoInterface.Servicos;

public class Gerencial
{
    /*
     * O mesmo processo que foi feito no Servico tabém é feito no gerencial, para acessar a interface de servico.
     * Onde a ordem da execução fica da seguinte forma:
     * Gerencial -> ICadastroServico -> CadastroServico -> ICadastroRepositorio -> CadastroRepositorio
     * Dica: Para ver essa execução, rode o código com debug marcando o método do gerencial com um breakpoint.
     */
    private readonly ICadastroServico _cadastroServico;
    public Gerencial(ICadastroServico cadastroServico)
    {
        _cadastroServico = cadastroServico;
    }

    public void Executar()
    {
        int opcao = 4;
        Colaborador colaborador = new Colaborador();
        
        
        while (opcao != 0)
        {
            Console.WriteLine("1 - Cadastro \n 2 - Listar \n 3 - Salvar Arquivo \n 0 - Sair ");
            opcao = int.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("nome: ");
                    colaborador.Nome = Console.ReadLine();
                    
                    Console.WriteLine("matricula: ");
                    colaborador.Matricula = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("codigo da empresa: ");
                    colaborador.CodigoEmpresa = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("CPF: ");
                    colaborador.Cpf = Console.ReadLine();
                    
                    _cadastroServico.Cadastrar(colaborador);
                    break;
                
                    case 2:
                        _cadastroServico.Listar();
                        break;
                    
                #region Desafio
                    case 3:
                        int codigoEmpresa = int.Parse(Console.ReadLine());
                        _cadastroServico.SalvarArquivo(codigoEmpresa);
                        break;
                    #endregion Desafio
                
                default:
                        Console.WriteLine("Finalizando aplicação...");
                        break;
            }
        }
    }
}