USE [master]
GO
/****** Object:  Database [db_School]    Script Date: 21/05/2018 6:34:06 ******/
CREATE DATABASE [db_School]
 
GO
ALTER DATABASE [db_School] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_School].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_School] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_School] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_School] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_School] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_School] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_School] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [db_School] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_School] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_School] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_School] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_School] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_School] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_School] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_School] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_School] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_School] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_School] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_School] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_School] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_School] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_School] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [db_School] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_School] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_School] SET  MULTI_USER 
GO
ALTER DATABASE [db_School] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_School] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_School] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_School] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_School] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_School] SET QUERY_STORE = OFF
GO
USE [db_School]
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
USE [db_School]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 21/05/2018 6:34:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[FirtsName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[BirthDay] [datetime] NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Course]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Course](
	[CourseID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Code] [nvarchar](25) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
	[EraseDate] [datetime] NULL,
	[LogicalErasure] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.T_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_InscriptionStudent]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_InscriptionStudent](
	[InscriptionStudentID] [uniqueidentifier] NOT NULL,
	[StudentID] [nvarchar](128) NULL,
	[Observation] [nvarchar](500) NULL,
	[Assistance] [bit] NOT NULL,
	[InstanceOfCourseID] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
	[EraseDate] [datetime] NULL,
	[LogicalErasure] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.T_InscriptionStudent] PRIMARY KEY CLUSTERED 
(
	[InscriptionStudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_InstanceOfCourse]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_InstanceOfCourse](
	[InstanceOfCourseID] [uniqueidentifier] NOT NULL,
	[Date] [date] NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[FinalTime] [time](7) NOT NULL,
	[TeacherID] [nvarchar](128) NULL,
	[CourseID] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
	[EraseDate] [datetime] NULL,
	[LogicalErasure] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.T_InstanceOfCourse] PRIMARY KEY CLUSTERED 
(
	[InstanceOfCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Menu]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](50) NOT NULL,
	[ParentMenuID] [int] NOT NULL,
	[OrderNumber] [int] NOT NULL,
	[MenuURL] [nvarchar](100) NULL,
	[MenuIcon] [nvarchar](25) NULL,
	[CreateDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
	[EraseDate] [datetime] NULL,
	[LogicalErasure] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.T_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Permission]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Permission](
	[PermissionID] [uniqueidentifier] NOT NULL,
	[RoleID] [nvarchar](128) NOT NULL,
	[MenuID] [int] NOT NULL,
	[Action] [nvarchar](max) NULL,
	[CreateDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
	[EraseDate] [datetime] NULL,
	[LogicalErasure] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.T_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_School]    Script Date: 21/05/2018 6:34:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_School](
	[SchoolID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Code] [nvarchar](25) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[ModificationDate] [datetime] NOT NULL,
	[EraseDate] [datetime] NULL,
	[LogicalErasure] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.T_School] PRIMARY KEY CLUSTERED 
(
	[SchoolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 21/05/2018 6:34:07 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 21/05/2018 6:34:07 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 21/05/2018 6:34:07 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleId]    Script Date: 21/05/2018 6:34:07 ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 21/05/2018 6:34:07 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 21/05/2018 6:34:07 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_one]    Script Date: 21/05/2018 6:34:07 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_one] ON [dbo].[T_InscriptionStudent]
(
	[StudentID] ASC,
	[InstanceOfCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CourseID]    Script Date: 21/05/2018 6:34:07 ******/
CREATE NONCLUSTERED INDEX [IX_CourseID] ON [dbo].[T_InstanceOfCourse]
(
	[CourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_OnlySchedulePerTeacher]    Script Date: 21/05/2018 6:34:07 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_OnlySchedulePerTeacher] ON [dbo].[T_InstanceOfCourse]
(
	[Date] ASC,
	[StartTime] ASC,
	[FinalTime] ASC,
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MenuID]    Script Date: 21/05/2018 6:34:07 ******/
CREATE NONCLUSTERED INDEX [IX_MenuID] ON [dbo].[T_Permission]
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleID]    Script Date: 21/05/2018 6:34:07 ******/
CREATE NONCLUSTERED INDEX [IX_RoleID] ON [dbo].[T_Permission]
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[T_InscriptionStudent]  WITH CHECK ADD  CONSTRAINT [FK_dbo.T_InscriptionStudent_dbo.AspNetUsers_StudentID] FOREIGN KEY([StudentID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[T_InscriptionStudent] CHECK CONSTRAINT [FK_dbo.T_InscriptionStudent_dbo.AspNetUsers_StudentID]
GO
ALTER TABLE [dbo].[T_InscriptionStudent]  WITH CHECK ADD  CONSTRAINT [FK_dbo.T_InscriptionStudent_dbo.T_InstanceOfCourse_InstanceOfCourseID] FOREIGN KEY([InstanceOfCourseID])
REFERENCES [dbo].[T_InstanceOfCourse] ([InstanceOfCourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[T_InscriptionStudent] CHECK CONSTRAINT [FK_dbo.T_InscriptionStudent_dbo.T_InstanceOfCourse_InstanceOfCourseID]
GO
ALTER TABLE [dbo].[T_InstanceOfCourse]  WITH CHECK ADD  CONSTRAINT [FK_dbo.T_InstanceOfCourse_dbo.AspNetUsers_TeacherID] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[T_InstanceOfCourse] CHECK CONSTRAINT [FK_dbo.T_InstanceOfCourse_dbo.AspNetUsers_TeacherID]
GO
ALTER TABLE [dbo].[T_InstanceOfCourse]  WITH CHECK ADD  CONSTRAINT [FK_dbo.T_InstanceOfCourse_dbo.T_Course_CourseID] FOREIGN KEY([CourseID])
REFERENCES [dbo].[T_Course] ([CourseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[T_InstanceOfCourse] CHECK CONSTRAINT [FK_dbo.T_InstanceOfCourse_dbo.T_Course_CourseID]
GO
ALTER TABLE [dbo].[T_Permission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.T_Permission_dbo.AspNetRoles_RoleID] FOREIGN KEY([RoleID])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[T_Permission] CHECK CONSTRAINT [FK_dbo.T_Permission_dbo.AspNetRoles_RoleID]
GO
ALTER TABLE [dbo].[T_Permission]  WITH CHECK ADD  CONSTRAINT [FK_dbo.T_Permission_dbo.T_Menu_MenuID] FOREIGN KEY([MenuID])
REFERENCES [dbo].[T_Menu] ([MenuID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[T_Permission] CHECK CONSTRAINT [FK_dbo.T_Permission_dbo.T_Menu_MenuID]
GO
USE [master]
GO
ALTER DATABASE [db_School] SET  READ_WRITE 
GO
