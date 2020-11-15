USE [master]
GO
/****** Object:  Database [DbDesafio]    Script Date: 15/11/2020 19:03:43 ******/
CREATE DATABASE [DbDesafio]
GO
ALTER DATABASE [DbDesafio] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbDesafio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbDesafio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbDesafio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbDesafio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbDesafio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbDesafio] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbDesafio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbDesafio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbDesafio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbDesafio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbDesafio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbDesafio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbDesafio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbDesafio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbDesafio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbDesafio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbDesafio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbDesafio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbDesafio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbDesafio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbDesafio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbDesafio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbDesafio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbDesafio] SET RECOVERY FULL 
GO
ALTER DATABASE [DbDesafio] SET  MULTI_USER 
GO
ALTER DATABASE [DbDesafio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbDesafio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbDesafio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbDesafio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbDesafio] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbDesafio', N'ON'
GO
ALTER DATABASE [DbDesafio] SET QUERY_STORE = OFF
GO
USE [DbDesafio]
GO
/****** Object:  Table [dbo].[tbSubscribe]    Script Date: 15/11/2020 19:03:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSubscribe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[dt_create] [datetime] NOT NULL,
 CONSTRAINT [PK_tbSubscribe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DbDesafio] SET  READ_WRITE 
GO
