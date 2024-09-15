# Desafio Target Sistemas

Este repositório contém a solução para os desafios propostos pela plataforma da vaga oferecida pela Target Sistemas.

## Estrutura do Projeto

- **Desafios**: Cada desafio está localizado em sua própria pasta, seguindo a ordem fornecida na plataforma da vaga.
- **Interface `IDesafio`**: Cada desafio implementa a interface `IDesafio`, que possui um método base `Execute`.
- **DesafioHandler**: Um handler central que gerencia a execução de uma lista de desafios implementando `IDesafio`.

## Como Rodar

1. **Inicializar o Programa**:
   - Execute o arquivo `Program.cs` para iniciar o processo.
   
2. **Interação**:
   - O `DesafioHandler` começará a executar cada desafio em ordem.
   - Após a execução de um desafio, pressione a tecla `ENTER` para prosseguir para o próximo desafio.

## Observações

- O desafio de **número 3** faz a leitura de um arquivo JSON presente na pasta do projeto. Caso queira fornecer sua própria base de dados, insira o arquivo na pasta do projeto e altere a variável constante no desafio 3 para o nome do arquivo em questão. 

  **Exemplo:**

  - Altere o nome do arquivo aqui:
    ![image](https://github.com/user-attachments/assets/ab22420d-4201-4fa1-978f-5323a2e2f0fa)

  - Substitua este arquivo:
    ![image](https://github.com/user-attachments/assets/f5babcd6-075e-42c2-a876-4196d6a31f53)
