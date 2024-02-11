--use master
--go
--create database DIGIMON_DB
--go

--/****** Object:  Table [dbo].[ELEMENTOS]    Script Date: 8/5/2021 9:48:22 PM ******/

--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO

--CREATE TABLE [dbo].[ATRIBUTOS](
--	[Id] [int] IDENTITY(1,1) NOT NULL,
--	[Descripcion] [varchar](50) NULL,
-- CONSTRAINT [PK_ATRIBUTOS] PRIMARY KEY CLUSTERED 
--(
--	[Id] ASC
--)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
--) ON [PRIMARY]
--GO

--USE DIGIMON_DB
--GO

--/****** Object:  Table [dbo].[POKEMONS]    Script Date: 8/5/2021 9:48:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DIGIMONS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[UrlImagen] [varchar](300) NULL,
	[IdTipo] [int] NULL,
	[IdDebilidad] [int] NULL,
	[IdEvolucion] [int] NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_DIGIMONS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[DIGIMONS]  WITH CHECK ADD  CONSTRAINT [FK_DIGIMONS_ATRIBUTOS] FOREIGN KEY([IdTipo])
REFERENCES [dbo].[ATRIBUTOS] ([Id])
GO

ALTER TABLE [dbo].[DIGIMONS] CHECK CONSTRAINT [FK_DIGIMONS_ATRIBUTOS]
GO

ALTER TABLE [dbo].[DIGIMONS]  WITH CHECK ADD  CONSTRAINT [FK_DIGIMONS_ATRIBUTOS1] FOREIGN KEY([IdDebilidad])
REFERENCES [dbo].[ATRIBUTOS] ([Id])
GO

ALTER TABLE [dbo].[DIGIMONS] CHECK CONSTRAINT [FK_DIGIMONS_ATRIBUTOS1]
GO

ALTER TABLE [dbo].[DIGIMONS]  WITH CHECK ADD  CONSTRAINT [FK_DIGIMONS_DIGIMONS] FOREIGN KEY([IdEvolucion])
REFERENCES [dbo].[DIGIMONS] ([Id])
GO

ALTER TABLE [dbo].[DIGIMONS] CHECK CONSTRAINT [FK_DIGIMONS_DIGIMONS]
GO

insert into ATRIBUTOS values ('Virus')
insert into ATRIBUTOS values ('Vacuna')
insert into ATRIBUTOS values ('Data')
insert into ATRIBUTOS values ('Variable')

Select * From ATRIBUTOS
Select * From DIGIMONS

insert into DIGIMONS values ('Gomamon', 'Gomamon is a Sea Animal Digimon'
, 'https://dmowiki.com/images/thumb/a/a1/Gomamon.png/250px-Gomamon.png', 2, 3, null, 1)

--insert into pokemons values (4, 'Charmander', 'Pokemon de fuego', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/004.png', 2, 3, null, 1)
--insert into pokemons values (11, 'Butterfree', 'mariposa', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/012.png', 1, 1, null, 1)
--insert into pokemons values (15, 'Pidgey', 'Voladorrrrr', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/016.png', 2, 1, null, 1)