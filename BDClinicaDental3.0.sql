USE [master]
GO
/****** Object:  Database [BDClinicaDental]    Script Date: 18/03/2019 22:02:25 ******/
CREATE DATABASE [BDClinicaDental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDClinicaDental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BDClinicaDental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDClinicaDental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BDClinicaDental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BDClinicaDental] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDClinicaDental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDClinicaDental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDClinicaDental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDClinicaDental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDClinicaDental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDClinicaDental] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDClinicaDental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDClinicaDental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDClinicaDental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDClinicaDental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDClinicaDental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDClinicaDental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDClinicaDental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDClinicaDental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDClinicaDental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDClinicaDental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDClinicaDental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDClinicaDental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDClinicaDental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDClinicaDental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDClinicaDental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDClinicaDental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDClinicaDental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDClinicaDental] SET RECOVERY FULL 
GO
ALTER DATABASE [BDClinicaDental] SET  MULTI_USER 
GO
ALTER DATABASE [BDClinicaDental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDClinicaDental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDClinicaDental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDClinicaDental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDClinicaDental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDClinicaDental] SET QUERY_STORE = OFF
GO
USE [BDClinicaDental]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BDClinicaDental]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[IdCita] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [int] NOT NULL,
	[IdTipoCita] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[IdCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[IdDiagnostico] [int] IDENTITY(1,1) NOT NULL,
	[IdPaciente] [int] NOT NULL,
	[IdDiente] [int] NOT NULL,
	[Detalle] [varchar](200) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Diagnostico] PRIMARY KEY CLUSTERED 
(
	[IdDiagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diente]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diente](
	[IdDiente] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Diente] PRIMARY KEY CLUSTERED 
(
	[IdDiente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[IdPaciente] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
	[FechaNacimiento] [date] NOT NULL,
	[IdTipoOntograma] [int] NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[IdPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reporte]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reporte](
	[IdReporte] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoReporte] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[TotalCitas] [int] NULL,
	[CitasCanceladas] [int] NULL,
	[CitasExitosas] [int] NULL,
 CONSTRAINT [PK_Reporte] PRIMARY KEY CLUSTERED 
(
	[IdReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Cita]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Cita](
	[IdTipoCita] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_Tipo_Cita] PRIMARY KEY CLUSTERED 
(
	[IdTipoCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Ontograma]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Ontograma](
	[IdTipoOntograma] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[NumDientes] [int] NOT NULL,
 CONSTRAINT [PK_Tipo_Ontograma] PRIMARY KEY CLUSTERED 
(
	[IdTipoOntograma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Reporte]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Reporte](
	[IdTipoReporte] [int] NOT NULL,
	[Detalle] [varchar](100) NULL,
 CONSTRAINT [PK_Tipo_Reporte] PRIMARY KEY CLUSTERED 
(
	[IdTipoReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 18/03/2019 22:02:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido1] [varchar](50) NOT NULL,
	[Apellido2] [varchar](50) NULL,
	[Direccion] [varchar](200) NULL,
	[IdRol] [int] NOT NULL,
	[Clave] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Paciente] ([IdPaciente], [Nombre], [Apellido1], [Apellido2], [Telefono], [Correo], [FechaNacimiento], [IdTipoOntograma]) VALUES (22, N'Juan Carlos', N'Veliz', N'Arcia', N'85996073', N'veliz2808@gmail.com', CAST(N'1994-08-28' AS Date), 0)
INSERT [dbo].[Paciente] ([IdPaciente], [Nombre], [Apellido1], [Apellido2], [Telefono], [Correo], [FechaNacimiento], [IdTipoOntograma]) VALUES (333, N'Cheesecake', N'Veliz22', N'Arcia 2', N'85763456', N'velizchiky@gmail.com', CAST(N'1994-07-09' AS Date), 1)
INSERT [dbo].[Rol] ([IdRol], [Descripcion]) VALUES (0, N'Dentista')
INSERT [dbo].[Rol] ([IdRol], [Descripcion]) VALUES (1, N'Asistente')
INSERT [dbo].[Tipo_Ontograma] ([IdTipoOntograma], [Descripcion], [NumDientes]) VALUES (0, N'Niño', 20)
INSERT [dbo].[Tipo_Ontograma] ([IdTipoOntograma], [Descripcion], [NumDientes]) VALUES (1, N'Adulto', 32)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido1], [Apellido2], [Direccion], [IdRol], [Clave], [Correo]) VALUES (1, N'Alexis ', N'Veliz ', N'Arcia ', N'Alajuela, San Ramon ', 0, N'NlLiVuZcFkU=', N'aveliz@hotmail.com')
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido1], [Apellido2], [Direccion], [IdRol], [Clave], [Correo]) VALUES (2, N'Juan', N'Veliz', N'Arcia', N'Alajuela, San Ramon', 1, N'GFSckKsSk8U=', N'aveliz15@hotmail.com')
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Apellido1], [Apellido2], [Direccion], [IdRol], [Clave], [Correo]) VALUES (111, N'Tres leches', N'Veliz', N'Arcia', N'Alajuela, San Ramon', 1, N'NlLiVuZcFkU=', N'holaprobando@gmail.com')
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Paciente] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Paciente] ([IdPaciente])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Paciente]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Tipo_Cita] FOREIGN KEY([IdTipoCita])
REFERENCES [dbo].[Tipo_Cita] ([IdTipoCita])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Tipo_Cita]
GO
ALTER TABLE [dbo].[Diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_Diagnostico_Diente] FOREIGN KEY([IdDiente])
REFERENCES [dbo].[Diente] ([IdDiente])
GO
ALTER TABLE [dbo].[Diagnostico] CHECK CONSTRAINT [FK_Diagnostico_Diente]
GO
ALTER TABLE [dbo].[Diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_Diagnostico_Paciente] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Paciente] ([IdPaciente])
GO
ALTER TABLE [dbo].[Diagnostico] CHECK CONSTRAINT [FK_Diagnostico_Paciente]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Tipo_Ontograma] FOREIGN KEY([IdTipoOntograma])
REFERENCES [dbo].[Tipo_Ontograma] ([IdTipoOntograma])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Tipo_Ontograma]
GO
ALTER TABLE [dbo].[Reporte]  WITH CHECK ADD  CONSTRAINT [FK_Reporte_Tipo_Reporte] FOREIGN KEY([IdTipoReporte])
REFERENCES [dbo].[Tipo_Reporte] ([IdTipoReporte])
GO
ALTER TABLE [dbo].[Reporte] CHECK CONSTRAINT [FK_Reporte_Tipo_Reporte]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([IdRol])
REFERENCES [dbo].[Rol] ([IdRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
USE [master]
GO
ALTER DATABASE [BDClinicaDental] SET  READ_WRITE 
GO
