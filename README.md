# Gerenciador de Bandas - Console em C# .NET

**Screen Sound** é uma aplicação de console desenvolvida em C# com .NET, cujo objetivo é gerenciar informações de bandas, permitindo que os usuários registrem novas bandas, listem bandas existentes, atribuam notas e visualizem a média das notas atribuídas.

## Funcionalidades

1. **Registrar Banda**
   - O usuário pode registrar uma nova banda no sistema, fornecendo o nome da banda.
   
2. **Listar Bandas**
   - Exibe uma lista com todas as bandas cadastradas.

3. **Avaliar Banda**
   - Permite que o usuário atribua uma nota (de 0 a 10) para uma banda cadastrada.

4. **Exibir Média de Notas**
   - Exibe a média das notas atribuídas a uma banda selecionada.

## Estrutura do Projeto

### 1. **Componentes principais**
   - **Dicionário de Bandas**: O sistema utiliza um **dicionário** (`Dictionary<string, List<int>>`), onde a chave é o nome da banda e o valor é uma lista de notas atribuídas à banda.
   - **Funções**:
     - `ExibirLogo()`: Exibe uma logo de boas-vindas e a mensagem de boas-vindas ao usuário.
     - `ExibirOpcoesMenu()`: Exibe o menu principal com as opções de interação.
     - `RegistrarBanda()`: Função para registrar uma nova banda.
     - `ListarBandas()`: Exibe todas as bandas cadastradas.
     - `AvaliarBanda()`: Permite atribuir uma nota a uma banda existente.
     - `Mediabandas()`: Exibe a média das notas atribuídas a uma banda específica.
    
# Como Rodar o Projeto
## Pré-requisitos
- .NET SDK (preferencialmente versão 6 ou superior)
### Instruções
- Clone ou baixe o repositório.
- Abra o projeto no Visual Studio ou Visual Studio Code.
- Compile e execute a aplicação com o comando:
<b>dotnet run</b>
## Exemplo de Interação

### O menu principal será exibido com as seguintes opções:
- Digite 1 para registrar uma banda.
- Digite 2 para listar todas as bandas.
- Digite 3 para avaliar uma banda.
- Digite 4 para exibir a média de uma banda.
- Digite -1 para sair do programa.

### Exemplo 1: Registrar uma banda
Digite o nome da banda: <b>Nirvana</b><br>
A banda Nirvana foi registrada com sucesso!!<br>
Pressione qualquer tecla para continuar...<br>

### Exemplo 2: Avaliar uma banda
Qual banda vai ser avaliada? <b>Nirvana</b><br>
Qual nota a banda Nirvana você deseja atribuir? <b>9</b><br>
A nota: 9, foi registrada com sucesso para a banda!<br>
Pressione qualquer tecla para continuar...<br>

### Exemplo 3: Listar todas as bandas
Bandas cadastradas:<br>
<b>1. Linkin Park</b><br>
<b>2. Charlie Brown Junior</b><br>
<b>3. The Beatles</b><br>
Pressione qualquer tecla para continuar...<br>

### Exemplo 4: Exibir a média das notas de uma banda
Qual banda você gostaria de ver a média? <b>Nirvana</b><br>
A média da banda Nirvana é 9.0.<br>
Pressione qualquer tecla para continuar...<br>


