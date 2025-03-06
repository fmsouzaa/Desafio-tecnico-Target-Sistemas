# Desafio Técnico

Este repositório contém a resolução de um conjunto de desafios técnicos utilizando C#. O projeto está estruturado com classes de serviço para cada exercício e um programa principal que permite a execução interativa via menu.

## Tecnologias Utilizadas
- C#
- .NET
- Programação Orientada a Objetos
- Manipulação de JSON
- Estruturas de controle e repetição

## Estrutura do Projeto
- `Program.cs`: Ponto de entrada da aplicação, onde o usuário pode selecionar qual exercício deseja executar.
- `SomaService.cs`: Realiza a soma progressiva de números consecutivos até atingir um valor limite.
- `FibonacciService.cs`: Verifica se um número pertence à sequência de Fibonacci.
- `FaturamentoService.cs`: Processa um JSON contendo dados de faturamento e calcula estatísticas.
- `PercentualEstadosService.cs`: Calcula o percentual de faturamento de cada estado com base em valores fixos.
- `StringReversaService.cs`: Inverte uma string sem utilizar funções prontas.
- `dados.json`: Contém os dados de faturamento diário para análise.

## Como Executar
1. Clone este repositório:
   ```sh
   git clone https://github.com/seu-usuario/desafio-tecnico.git
   ```
2. Navegue até a pasta do projeto:
   ```sh
   cd desafio-tecnico
   ```
3. Compile e execute o programa:
   ```sh
   dotnet run
   ```
4. Escolha uma opção no menu interativo para executar os exercícios.

## Exercícios Resolvidos
### 1 - Cálculo da Soma
Executa um loop somando valores incrementais até um índice predefinido (13).

### 2 - Sequência de Fibonacci
O usuário informa um número e o programa verifica se ele pertence à sequência de Fibonacci.

### 3 - Análise de Faturamento
A partir de um JSON, o programa:
- Encontra o menor e maior faturamento diário;
- Calcula a média mensal ignorando dias sem faturamento;
- Conta quantos dias tiveram faturamento acima da média.

### 4 - Percentual de Representação dos Estados
Calcula a participação percentual de cada estado no faturamento total.

### 5 - Inversão de String
Solicita uma string ao usuário e retorna a versão invertida sem utilizar funções prontas como `Reverse()`.



