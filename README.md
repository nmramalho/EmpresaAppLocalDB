# EmpresaAppLocalDB
Exemplo (criado para as aulas de Cursos Profissionais de Informática) de uma aplicação que estabelece ligação a uma base de dados localDB

 # Tipo de projeto 
 Windows Forms App (.NET Framework) 

# Requisitos
 - Base de dados LocalDB. Pode ser criada no Visual Studio através da ferramenta SQL Server Object Explorer
```
CREATE DATABASE Empresa; 
 
CREATE TABLE [dbo].[Departamento] (
    [Id]   VARCHAR (10) NOT NULL,
    [Nome] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Funcionario] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [IdDepartamento] VARCHAR (10) NOT NULL,
    [Nome]           VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Funcionario_Departamento] FOREIGN KEY ([IdDepartamento]) REFERENCES [dbo].[Departamento] ([Id])
);
```

# Principais Funcionalidades
- Inserir de registos numa tabela (tabela Departamento)
- Atualização de registos numa tabela (tabela Departamento)
- Eliminar registos numa tabela (tabela Departamento)
- Importar registos de um ficheiro csv

  

 
