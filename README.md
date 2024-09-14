# Controle de Manutenção de Equipamentos

## Descrição
Este projeto, desenvolvido em C# e utilizando SQL Server como banco de dados, visa otimizar o processo de controle de manutenção de equipamentos de informática. A aplicação permite que usuários registrem chamados técnicos, os quais são transformados em Ordens de Serviço e atribuídas a técnicos para resolução.

## Funcionalidades
* **Cadastro de Usuários:** Permite cadastrar novos usuários e definir seus perfis (técnico, usuário final).
* **Abertura de Chamados:** Usuários finais podem registrar novos chamados, descrevendo o problema com o equipamento.
* **Geração de Ordens de Serviço:** Cada chamado gera uma OS única, associada a um técnico.
* **Geração de Relatórios:** O sistema gera relatórios personalizados, como histórico de chamados por equipamento, desempenho dos técnicos, etc.

 ## Possíveis Melhorias 
* **Notificações:** Envia notificações por email ou outras plataformas para usuários e técnicos sobre o status das OSs.

## Tecnologias Utilizadas
* **C#:** Linguagem de programação principal.
* **SQL Server:** Banco de dados para armazenar informações sobre usuários, equipamentos, chamados e OSs.
* **Framework:** .NET Framework
* **Outras:** ReportViewer
  
<!---
## Arquitetura
[Diagrama de classes ou arquitetura, se disponível]
--->
## Instruções de Instalação e Execução
1. **Pré-requisitos:**
   * .NET [7.5]
   * SQL Server [2019]
   * ReportViewer
2. **Clonar o repositório:**
   ```bash
[   git clone] (https://github.com/RBertini78/Controle_Manutencao)
