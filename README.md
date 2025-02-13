# Gerenciamento de Colaboradores

## Projeto de apoio para estudo de Interfaces

```Este projeto trata o cadastro e leitura de Colaboradores de uma empresa, para fins de estudos sobre implementação de interfaces. A aplicação não faz persistência dos dados, os mesmos são salvos e lidos em memória, em uma variável do tipo lista de Colaboradores.```

### Estrutura do projeto
- **`Program.cs`**: Arquivo principal que inicia a aplicação.
- **`Modelos/`**: Contém as classes que representam entidades do domínio.
  - `Colaborador.cs`: Representa o modelo de um colaborador.
- **`Interfaces/`**: Define os contratos (interfaces) para implementação de serviços e repositórios.
  - `ICadastroRepositorio.cs`: Interface para o repositório de cadastros.
  - `ICadastroServico.cs`: Interface para o serviço de cadastros.
- **`Servicos/`**: Contém as implementações dos serviços.
  - `CadastroServico.cs`: Implementação do serviço de cadastro.
  - `Gerencial.cs`: Serviço relacionado à gestão.
- **`Repositorios/`**: Contém as implementações dos Repositórios.
  - `CadastroRepositorio.cs`: Implementação do Repositorio de cadastro.

> Obs.: Toda implementação dos métodos, deve ser feita utilizando Interfaces

### Como a aplicação deve funcionar:

1. A classe Program.cs chama o gerencial, para executar os métodos do mesmo.
2. A classe Gerencial.cs chama o CadastroServico.cs, que contém a lógica da aplicação.
3. A Classe CadastroServico.cs por sua vez, chama os métodos do CadastroRepositorio.cs.
4. A classe CadastroRepositorio.cs faz a simulação de persistência, armazenando e lendo os dados dos colaboradoes em uma lista.

### Propriedades da classe Colaborador.cs:
```csharp
public class Colaborador
{
    public string Nome{get; set;}
    public string Cpf {get; set;}
    public int Matricula {get; set;}
    public int CodigoEmpresa {get; set;}
}
