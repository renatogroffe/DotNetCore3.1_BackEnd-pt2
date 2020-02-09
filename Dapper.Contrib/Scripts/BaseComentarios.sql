CREATE DATABASE BaseComentarios
GO

USE BaseComentarios
GO

CREATE TABLE dbo.Comentarios(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome varchar(50) NOT NULL,
	Mensagem varchar(1000) NOT NULL,
	CONSTRAINT PK_Comentarios PRIMARY KEY (Id)
)
GO