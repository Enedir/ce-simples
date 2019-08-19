# Controle de Estudantes

O objetivo desta aplicação é cadastrar estudantes e professores, essa aplicação foi desenvolvida em *ASP MVC 5* e *SQL Server*.


# Como Executar Aplicação

Para executar com aplicação é necessário mudar as **ConnectionString** do **Web.config** do projeto **BrConselhosProva.WebApp**. Com as informações da sua instancia do *SQLServer*. 

## Migrações

É possível também criar uma base de dados já populado executando a funcionalidade de  **Migration** do **EntityFramework**. Para uso desse recurso é necessário mudar a **ConnectionString** do **App.config** do projeto **BrConselhosProva.Infra.ORM**. Com as informações da sua instancia do *SQLServer*.  E abrir o Console Gerenciador de Pacotes do Nuget no projeto **BrConselhosProva.Infra.ORM** para executar o comando update-database. Para  a migração ser efetuada.
