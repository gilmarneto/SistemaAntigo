# SistemaAntigo

Este projeto nasceu como um laboratório para estudar uma situação que ainda existe em muitas empresas: como automatizar um sistema antigo que não possui API?

Em vez de trabalhar apenas com uma automação isolada, montei um pequeno ambiente para simular esse cenário de ponta a ponta.

A ideia foi integrar n8n, Power Automate Desktop, um sistema Windows e SQL Server.

## O cenário

Imagine um processo em que as solicitações chegam através de uma planilha, mas precisam ser cadastradas em um sistema interno que não possui API ou outra forma simples de integração.

Alguém teria que abrir o sistema e cadastrar essas informações manualmente.

Foi justamente esse trabalho que tentei automatizar neste projeto.

## Como funciona

O processo começa no n8n, que consulta os registros existentes na planilha e organiza os dados que serão enviados para a automação.

Essas informações são enviadas em JSON para o Power Automate Desktop.

O PAD recebe os dados, abre o sistema e realiza o preenchimento dos campos automaticamente.

O próprio sistema fica responsável pela gravação no SQL Server através de Stored Procedures.

O fluxo ficou assim:

Google Sheets  
↓  
n8n  
↓  
JSON  
↓  
Power Automate Desktop  
↓  
Sistema Windows (VB.NET / WinForms)  
↓  
DAO / Stored Procedures  
↓  
SQL Server

## O sistema

Para conseguir testar a automação em um cenário mais próximo do mundo real, criei também um pequeno sistema desktop em VB.NET com Windows Forms.

Ele foi feito propositalmente de forma simples, simulando aquele tipo de sistema interno que encontramos em ambientes corporativos e que muitas vezes precisa continuar funcionando mesmo sem possuir uma API.

Atualmente o sistema permite:

- iniciar um novo cadastro;
- salvar uma solicitação;
- consultar uma solicitação pelo número;
- impedir registros duplicados;
- armazenar os dados no SQL Server;
- encerrar a aplicação.

A regra de duplicidade também foi tratada no banco de dados, evitando o cadastro da mesma combinação de solicitação e favorecido.

## Power Automate Desktop

O PAD é a ponte entre a automação e o sistema.

Ele recebe o JSON enviado pelo n8n, percorre os registros, preenche os campos da aplicação e executa o processo de gravação.

Os prints e a explicação dessa parte estão na pasta:

`PowerAutomateDesktop/`

## n8n

O n8n ficou responsável pela parte de integração e preparação dos dados.

O workflow consulta a planilha, organiza as informações e inicia o processo que será executado pelo Power Automate Desktop.

Uma versão sanitizada do workflow está disponível na pasta:

`n8n/`

Os identificadores e informações do ambiente utilizados durante o desenvolvimento foram removidos antes da publicação.

## Tecnologias utilizadas

- Power Automate Desktop
- n8n
- JSON
- Google Sheets
- VB.NET
- Windows Forms
- SQL Server
- Stored Procedures
- Microsoft.Data.SqlClient

## O que eu quis aprender com esse projeto

Mais do que construir o formulário, meu objetivo foi entender como ferramentas diferentes podem trabalhar juntas dentro de um mesmo processo.

Foi um exercício para praticar integração, automação de interface, troca de dados em JSON, acesso a banco de dados e separação das responsabilidades entre automação, aplicação e banco.

Também serviu para entender melhor uma situação importante em RPA: nem sempre o sistema que precisa ser automatizado possui uma API disponível.

Nesses casos, a automação de interface ainda pode ser uma alternativa para conectar processos novos a aplicações legadas.

## Próximas evoluções

O projeto foi encerrado como um MVP funcional, mas algumas melhorias podem ser adicionadas futuramente, como consulta por favorecido, edição e exclusão de registros, tratamento de novas exceções e melhorias na interface.

A ideia, porém, foi manter esta primeira versão pequena o suficiente para conseguir construir, testar e entender todo o processo de ponta a ponta.
