
# SISTEMA BÁSICO PARA CAMPEONATOS DE JIU-JITSU

Uma breve aplicação desenvolvida em .NET 7 que gerencia o cadastro de atletas em cameponatos de Jiu-Jitsu. Onde deve ser feito o cadastro de um usuário, e a partir disso, será feito a autenticação do mesmo para realizar os cadastros e outras operações.


## Instalação e configurações de ambiente

Para executar o projeto, é a [versão 7 do .NET](https://dotnet.microsoft.com/pt-br/download/dotnet/7.0) e o [SQL Server localmente](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads). Após obter a versão correta, faça o clone do repositório para sua máquina.

```bash
git clone https://github.com/thiagoaure/application-jiujitsu
```

### Importante
No arquivo aappsettings.Development.json, configure a string de conexão com o banco, como no exemplo:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=DESKTOP-NAME;Initial Catalog=JiuJitsu-DB;Integrated Security=True;TrustServerCertificate=True"
  }
}

```


## Run

Para executar o projeto sem nenhum problema de conexão, no diretorio principal, pode ser executado o seguinte comando: 

```
dotnet run --project KbrTec.JiuJitsuSystem.Application\KbrTec JiuJitsuSystem.Application.csproj
```

Após finalizar  o build, está sendo usado Swagger para documentação, onde também pode ser utilizado para fazer as requisições


## Melhorias e novas features em desenvolvimento
- Autorização de usuário em roles (ADMIN e USUARIO_COMUM)
- Segregação dos campeonatos em masculino e feminino
- Segregação do campeonatos por tipo de faixa, peso e outros atributos
- Geração da chave de lutas entre os atletas
- Geração dos resultados das partidas e do campoenatos como um todos
- Gerenciar tipos de campos com Imagens
- Utilização de ferramentas de otimização de desenvolvimento como Docker, Testes Unitários, Banco de dados Nosql...






