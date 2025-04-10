USE [master]
GO
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'controle_manut')
BEGIN
CREATE DATABASE [controle_manut] ON  PRIMARY 
( NAME = N'controle_manut', FILENAME = N'D:\Arquivos de programas\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\controle_manut.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'controle_manut_log', FILENAME = N'D:\Arquivos de programas\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\controle_manut_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
EXEC dbo.sp_dbcmptlevel @dbname=N'controle_manut', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [controle_manut].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [controle_manut] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [controle_manut] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [controle_manut] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [controle_manut] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [controle_manut] SET ARITHABORT OFF 
GO
ALTER DATABASE [controle_manut] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [controle_manut] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [controle_manut] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [controle_manut] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [controle_manut] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [controle_manut] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [controle_manut] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [controle_manut] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [controle_manut] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [controle_manut] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [controle_manut] SET  ENABLE_BROKER 
GO
ALTER DATABASE [controle_manut] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [controle_manut] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [controle_manut] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [controle_manut] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [controle_manut] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [controle_manut] SET  READ_WRITE 
GO
ALTER DATABASE [controle_manut] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [controle_manut] SET  MULTI_USER 
GO
ALTER DATABASE [controle_manut] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [controle_manut] SET DB_CHAINING OFF 
USE [controle_manut]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tab_equipamento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tab_equipamento](
	[equip_id] [int] IDENTITY(1,1) NOT NULL,
	[equip_nome] [nvarchar](50) NULL,
	[equip_local] [nvarchar](50) NULL,
 CONSTRAINT [PK_tab_equipamento] PRIMARY KEY CLUSTERED 
(
	[equip_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tab_problemas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tab_problemas](
	[prob_id] [int] IDENTITY(1,1) NOT NULL,
	[prob_tipo] [nvarchar](50) NULL,
	[prob_nome] [nvarchar](50) NULL,
 CONSTRAINT [PK_tab_problemas] PRIMARY KEY CLUSTERED 
(
	[prob_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tab_tecnicos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tab_tecnicos](
	[tec_id] [int] IDENTITY(1,1) NOT NULL,
	[tec_nome] [nvarchar](50) NULL,
 CONSTRAINT [PK_tab_tecnicos] PRIMARY KEY CLUSTERED 
(
	[tec_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tab_funcionarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tab_funcionarios](
	[func_id] [int] IDENTITY(1,1) NOT NULL,
	[func_nome] [nvarchar](50) NULL,
	[func_cargo] [nvarchar](50) NULL,
 CONSTRAINT [PK_tab_funcionarios] PRIMARY KEY CLUSTERED 
(
	[func_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tab_chamados]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tab_chamados](
	[cham_id] [int] IDENTITY(1,1) NOT NULL,
	[cham_equip_id] [int] NULL,
	[cham_func_id] [int] NULL,
	[cham_prob_id] [int] NULL,
	[cham_obs] [nvarchar](max) NULL,
	[cham_data] [nchar](10) NULL,
	[cham_osaberta] [nvarchar](1) NULL,
 CONSTRAINT [PK_tab_chamados] PRIMARY KEY CLUSTERED 
(
	[cham_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tab_os]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tab_os](
	[os_id] [int] IDENTITY(1,1) NOT NULL,
	[os_chamado_id] [int] NULL,
	[os_status] [nchar](10) NULL,
	[os_tecnico_id] [int] NULL,
	[os_solucao] [nvarchar](max) NULL,
	[os_dt_entrega] [nvarchar](10) NULL,
 CONSTRAINT [PK_tab_os] PRIMARY KEY CLUSTERED 
(
	[os_id] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tab_chamados_tab_equipamentos]') AND parent_object_id = OBJECT_ID(N'[dbo].[tab_chamados]'))
ALTER TABLE [dbo].[tab_chamados]  WITH CHECK ADD  CONSTRAINT [FK_tab_chamados_tab_equipamentos] FOREIGN KEY([cham_equip_id])
REFERENCES [dbo].[tab_equipamento] ([equip_id])
GO
ALTER TABLE [dbo].[tab_chamados] CHECK CONSTRAINT [FK_tab_chamados_tab_equipamentos]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tab_chamados_tab_funcionarios]') AND parent_object_id = OBJECT_ID(N'[dbo].[tab_chamados]'))
ALTER TABLE [dbo].[tab_chamados]  WITH CHECK ADD  CONSTRAINT [FK_tab_chamados_tab_funcionarios] FOREIGN KEY([cham_func_id])
REFERENCES [dbo].[tab_funcionarios] ([func_id])
GO
ALTER TABLE [dbo].[tab_chamados] CHECK CONSTRAINT [FK_tab_chamados_tab_funcionarios]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tab_chamados_tab_problemas]') AND parent_object_id = OBJECT_ID(N'[dbo].[tab_chamados]'))
ALTER TABLE [dbo].[tab_chamados]  WITH CHECK ADD  CONSTRAINT [FK_tab_chamados_tab_problemas] FOREIGN KEY([cham_prob_id])
REFERENCES [dbo].[tab_problemas] ([prob_id])
GO
ALTER TABLE [dbo].[tab_chamados] CHECK CONSTRAINT [FK_tab_chamados_tab_problemas]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tab_os_tab_chamados]') AND parent_object_id = OBJECT_ID(N'[dbo].[tab_os]'))
ALTER TABLE [dbo].[tab_os]  WITH CHECK ADD  CONSTRAINT [FK_tab_os_tab_chamados] FOREIGN KEY([os_chamado_id])
REFERENCES [dbo].[tab_chamados] ([cham_id])
GO
ALTER TABLE [dbo].[tab_os] CHECK CONSTRAINT [FK_tab_os_tab_chamados]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tab_os_tab_tecnicos]') AND parent_object_id = OBJECT_ID(N'[dbo].[tab_os]'))
ALTER TABLE [dbo].[tab_os]  WITH CHECK ADD  CONSTRAINT [FK_tab_os_tab_tecnicos] FOREIGN KEY([os_tecnico_id])
REFERENCES [dbo].[tab_tecnicos] ([tec_id])
GO
ALTER TABLE [dbo].[tab_os] CHECK CONSTRAINT [FK_tab_os_tab_tecnicos]
