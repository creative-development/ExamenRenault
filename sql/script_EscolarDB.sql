CREATE DATABASE EscolarDB;   

CREATE TABLE [EscolarDB].[Alumnos] (
    [ID]        INT           IDENTITY (1, 1) NOT NULL,
    [AluNom]    NVARCHAR (50) NOT NULL,
    [AluApePat] NVARCHAR (50) NOT NULL,
    [AluApeMat] NVARCHAR (50) NOT NULL,
    [AluMail]   NVARCHAR (50) NOT NULL,
    [AluTel]    NVARCHAR (50) NOT NULL,
    [status]    NVARCHAR (4)  NOT NULL,
    CONSTRAINT [PK_dbo.Alumnos] PRIMARY KEY CLUSTERED ([ID] ASC)
);
CREATE TABLE [EscolarDB].[Materias] (
    [ID]             INT           IDENTITY (1, 1) NOT NULL,
    [NomMAteria]     NVARCHAR (50) NOT NULL,
    [CreditoMateria] NVARCHAR (3)  NOT NULL,
    CONSTRAINT [PK_dbo.Materias] PRIMARY KEY CLUSTERED ([ID] ASC)
);