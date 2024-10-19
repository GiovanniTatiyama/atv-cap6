# atv-cap6

## Descrição
O **SCAPP** é um aplicativo desenvolvido em C# que visa gerenciar informações de trânsito, incluindo notificações, semáforos e tráfego. O aplicativo utiliza uma arquitetura baseada em controladores para oferecer funcionalidades robustas e escaláveis.

## Tecnologias Utilizadas
- **C#**: Linguagem de programação principal.
- **ASP.NET Core**: Framework web para construção da aplicação.
- **Entity Framework Core**: ORM para acesso a dados.
- **Docker**: Para containerização da aplicação.
- **Docker Compose**: Para facilitar a orquestração de múltiplos contêineres.
- **GitHub Actions**: Para automação de CI/CD.

## Pré-requisitos
- **Docker**: [Instalação do Docker](https://docs.docker.com/get-docker/)
- **Docker Compose**: [Instalação do Docker Compose](https://docs.docker.com/compose/install/)
- **.NET SDK**: [Download do .NET SDK](https://dotnet.microsoft.com/download)

## Configuração do Ambiente de Desenvolvimento
1. Clone o repositório:
   ```bash
   git clone https://github.com/GiovanniTatiyama/atv-cap6.git
   cd atv-cap6

2. Configure o ambiente local (opcional, se preferir usar Docker):
Crie um banco de dados no seu sistema ou utilize uma instância em memória.

### CI/CD com GitHub Actions
    O repositório contém um workflow de CI/CD configurado no arquivo .github/workflows/CI.yaml. Este workflow automatiza as etapas de build, teste e deploy do aplicativo.

