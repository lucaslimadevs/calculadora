# Calculadora CDB

Este repositório contém uma aplicação completa para calcular o rendimento de um Certificado de Depósito Bancário (CDB). Ele inclui tanto a API desenvolvida em C# quanto o frontend construído com Angular. A aplicação permite que os usuários insiram um valor inicial e um prazo para calcular os rendimentos de um investimento em CDB.

## Estrutura do Projeto

- **Calculadora.Api**: API em C# que realiza os cálculos do CDB e fornece os dados para o frontend.
- **Calculadora.Frontend**: Aplicação web em Angular que serve como interface do usuário.

## Funcionalidades

- **API (Calculadora.Api)**:
  - Cálculo do valor bruto e líquido de um CDB.
  - Retorno dos resultados em formato JSON.

- **Frontend (Calculadora.Frontend)**:
  - Interface amigável para inserção de dados.
  - Validações para garantir que o valor inicial e o prazo não sejam zero.
  - Notificações (toasts) para feedback instantâneo ao usuário.

## Tecnologias Utilizadas

- **Backend**: C# com ASP.NET Core
- **Frontend**: Angular
- **Estilização**: Bootstrap, ngx-toastr

## Pré-requisitos

Antes de começar, certifique-se de que você tem instalado em sua máquina:

- [Node.js](https://nodejs.org/) (Node.js v23 ou superior)
- [Angular CLI](https://angular.io/cli) (Angular cli 17 ou superior)
- [.NET SDK](https://dotnet.microsoft.com/download) (.net 8)

## Testes e cobertura da API

![image](https://github.com/user-attachments/assets/d87ffef7-127a-4b25-8f65-f0ee8c694e1f)

![image](https://github.com/user-attachments/assets/b9b5a9a9-1a94-4e18-9efe-e15dde04b567)
