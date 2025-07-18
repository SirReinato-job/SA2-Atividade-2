# 🏥 Sistema de Cadastro de Clientes - Clínica

Este projeto simula um sistema simples de cadastro de clientes para uma clínica, com distinção entre **Pessoa Física** e **Pessoa Jurídica**. O programa coleta dados básicos e realiza o cálculo de impostos sobre uma compra.

## 📦 Estrutura do Projeto

O código está organizado dentro do namespace `Clinica` e contém as seguintes classes:

- `Program`: Ponto de entrada da aplicação.
- `Clientes`: Classe base que contém propriedades comuns e método para cálculo de imposto.
- `Pessoa_Fisica`: Derivada de `Clientes`, inclui CPF e RG.
- `Pessoa_Juridica`: Derivada de `Clientes`, inclui CNPJ e IE.
- `Validador`: Classe estática com métodos auxiliares para leitura e formatação de dados.

## 💡 Funcionalidades

- Receber informações de cliente:
  - Nome
  - Endereço
  - Tipo de pessoa (`f` para física, `j` para jurídica)
- Validar documentos (CPF, RG, CNPJ, IE)
- Calcular imposto sobre valor de compra:
  - Pessoa Física: 10%
  - Pessoa Jurídica: 20%
- Exibir resumo formatado da transação

## 🛠️ Tecnologias Utilizadas

- Linguagem: **C#**
- Plataforma: **.NET Console Application**

## ▶️ Como Executar

1. Compile o projeto com o compilador C# (como `dotnet build`).
2. Execute o programa pelo terminal.
3. Siga as instruções interativas para cadastrar o cliente e calcular o imposto.

## 📌 Exemplo de Saída
- -------- Pessoa Física ---------
- Nome ..........: Renato
- Endereço ......: ass 32
- CPF ...........: 123.456.789-78
- RG ............: 12.345.678-9
- Valor de Compra: R$ 12.000,00
- Imposto .......: R$ 1.200,00
- Total a Pagar : R$ 13.200,00
- 
- -------- Pessoa Jurídica ---------
- Nome ..........: Renato
- Endereço ......: ass 32
- CNPJ ..........: 12.222.334/4556-65
- IE ............: 1234.567-89
- Valor de Compra: R$ 700,00
- Imposto .......: R$ 140,00
- Total a Pagar : R$ 840,00


## 📄 Licença

Este projeto é de uso educacional e livre para estudo e adaptação.

---

Desenvolvido por Renato.
