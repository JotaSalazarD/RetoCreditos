USE [master]
GO
/****** Object:  Database [RETO]    Script Date: 24/05/2021 14:45:01 ******/
CREATE DATABASE [RETO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RETO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RETO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RETO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RETO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RETO] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RETO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RETO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RETO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RETO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RETO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RETO] SET ARITHABORT OFF 
GO
ALTER DATABASE [RETO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RETO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RETO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RETO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RETO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RETO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RETO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RETO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RETO] SET RECURSIVE_TRIGGERS ON 
GO
ALTER DATABASE [RETO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RETO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RETO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RETO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RETO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RETO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RETO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RETO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RETO] SET RECOVERY FULL 
GO
ALTER DATABASE [RETO] SET  MULTI_USER 
GO
ALTER DATABASE [RETO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RETO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RETO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RETO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RETO] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RETO', N'ON'
GO
ALTER DATABASE [RETO] SET QUERY_STORE = OFF
GO
USE [RETO]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 24/05/2021 14:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoIdentificacion] [int] NOT NULL,
	[NroIdentificacion] [int] NOT NULL,
	[Nombres] [nvarchar](200) NOT NULL,
	[Apellidos] [nvarchar](200) NOT NULL,
	[Celular] [nvarchar](20) NULL,
	[Email] [nvarchar](200) NULL,
	[Direccion] [nvarchar](200) NULL,
	[IdDepartamento] [int] NOT NULL,
	[IdMunicipio] [int] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Creditos]    Script Date: 24/05/2021 14:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Creditos](
	[IdCredito] [int] IDENTITY(1,1) NOT NULL,
	[ValorCapital] [numeric](18, 2) NOT NULL,
	[Plazo] [int] NULL,
	[Frecuencia] [nvarchar](20) NOT NULL,
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_Creditos] PRIMARY KEY CLUSTERED 
(
	[IdCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuposClientes]    Script Date: 24/05/2021 14:45:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuposClientes](
	[IdCupo] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Cupo] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_CuposClientes] PRIMARY KEY CLUSTERED 
(
	[IdCupo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 24/05/2021 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[IdDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[CodDepartamento] [nvarchar](2) NOT NULL,
	[NombreDepartamento] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipios]    Script Date: 24/05/2021 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipios](
	[IdMunicipio] [int] IDENTITY(1,1) NOT NULL,
	[IdDepartamento] [int] NOT NULL,
	[CodMunicipio] [nvarchar](5) NOT NULL,
	[NombreMunicipio] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Municipios] PRIMARY KEY CLUSTERED 
(
	[IdMunicipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plazos]    Script Date: 24/05/2021 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plazos](
	[IdPlazo] [int] IDENTITY(1,1) NOT NULL,
	[Desde] [numeric](18, 0) NOT NULL,
	[Hasta] [numeric](18, 0) NOT NULL,
	[Plazo] [int] NOT NULL,
 CONSTRAINT [PK_Plazos] PRIMARY KEY CLUSTERED 
(
	[IdPlazo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposIdentificacion]    Script Date: 24/05/2021 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposIdentificacion](
	[IdTipoIdentificacion] [int] NOT NULL,
	[TipoIdentificacion] [nvarchar](10) NOT NULL,
	[NombreIdentificacion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TiposIdentificacion] PRIMARY KEY CLUSTERED 
(
	[IdTipoIdentificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Departamentos] FOREIGN KEY([IdDepartamento])
REFERENCES [dbo].[Departamentos] ([IdDepartamento])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Departamentos]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Municipios] FOREIGN KEY([IdMunicipio])
REFERENCES [dbo].[Municipios] ([IdMunicipio])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Municipios]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_TiposIdentificacion] FOREIGN KEY([IdTipoIdentificacion])
REFERENCES [dbo].[TiposIdentificacion] ([IdTipoIdentificacion])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_TiposIdentificacion]
GO
ALTER TABLE [dbo].[Creditos]  WITH CHECK ADD  CONSTRAINT [FK_Creditos_Creditos] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Creditos] CHECK CONSTRAINT [FK_Creditos_Creditos]
GO
ALTER TABLE [dbo].[Municipios]  WITH CHECK ADD  CONSTRAINT [FK_Municipios_Departamentos] FOREIGN KEY([IdDepartamento])
REFERENCES [dbo].[Departamentos] ([IdDepartamento])
GO
ALTER TABLE [dbo].[Municipios] CHECK CONSTRAINT [FK_Municipios_Departamentos]
GO
/****** Object:  StoredProcedure [dbo].[Sp_CargarCredito]    Script Date: 24/05/2021 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[Sp_CargarCredito] @ValorCapital Numeric(18,2), @Frecuencia varchar(20),
@IdCliente int
as

Declare @Cupo Numeric(18,2), @Plazo int



--Validar cupo
select @Cupo=MAX(Cupo) from CuposClientes where IdCliente =@IdCliente 
select @Plazo = Plazo from Plazos where @ValorCapital between Desde and Hasta


IF @Cupo >= @ValorCapital BEGIN
Insert into Creditos (ValorCapital,Plazo,Frecuencia,IdCliente)
select @ValorCapital,@Plazo,@Frecuencia,@IdCliente




END
GO
/****** Object:  Trigger [dbo].[AsignacionCuposClientes]    Script Date: 24/05/2021 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AsignacionCuposClientes] ON [dbo].[Clientes]
For Insert 
as

Insert into CuposClientes ( IdCliente, Cupo)
Select IdCliente, 2000000 from inserted
GO
ALTER TABLE [dbo].[Clientes] ENABLE TRIGGER [AsignacionCuposClientes]
GO
/****** Object:  Trigger [dbo].[AgotarCupoClientes]    Script Date: 24/05/2021 14:45:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[AgotarCupoClientes] ON [dbo].[Creditos]
For Insert 
as

Update a set a.Cupo= a.Cupo -ValorCapital  from CuposClientes a 
Inner Join inserted b on a.IdCliente=b.IdCliente
GO
ALTER TABLE [dbo].[Creditos] ENABLE TRIGGER [AgotarCupoClientes]
GO
USE [master]
GO
ALTER DATABASE [RETO] SET  READ_WRITE 
GO

