CREATE DATABASE BaseCotacoesEF
GO

USE BaseCotacoesEF
GO

CREATE TABLE dbo.Cotacoes(
	Sigla char(3) NOT NULL,
	NomeMoeda varchar(30) NOT NULL,
	UltimaCotacao datetime NOT NULL,
	Valor_Comercial NUMERIC (18,4) NOT NULL,
	Valor_Turismo NUMERIC (18,4) NULL,
	CONSTRAINT PK_Cotacoes PRIMARY KEY (Sigla)
)
GO


INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor_Comercial
           ,Valor_Turismo)
     VALUES
           ('USD'
           ,'Dólar norte-americano'
           ,'10/18/2019 16:59'
           ,4.1190
	   ,4.2800)

INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor_Comercial)
     VALUES
           ('EUR'
           ,'Euro'
           ,'10/18/2019 16:59'
           ,4.595)

INSERT INTO dbo.Cotacoes
           (Sigla
           ,NomeMoeda
           ,UltimaCotacao
           ,Valor_Comercial)
     VALUES
           ('LIB'
           ,'Libra esterlina'
           ,'10/18/2019 16:59'
           ,5.3301)
