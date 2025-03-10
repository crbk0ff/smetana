USE [smetana]
GO
/****** Object:  Table [dbo].[Застройщики]    Script Date: 22.04.2024 2:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Застройщики](
	[id] [int] NOT NULL,
	[id_проекта] [int] NULL,
	[ФИО] [varchar](100) NULL,
	[зарплата] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Отчет_по_проекту]    Script Date: 22.04.2024 2:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Отчет_по_проекту](
	[id_проекта] [int] NOT NULL,
	[id_пользователя] [int] NULL,
	[id_застройщика] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_проекта] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Пользователи]    Script Date: 22.04.2024 2:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пользователи](
	[Логин] [varchar](50) NULL,
	[Пароль] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Проект]    Script Date: 22.04.2024 2:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Проект](
	[id_проекта] [int] IDENTITY(1,1) NOT NULL,
	[Тип] [nvarchar](50) NULL,
	[Площадь] [int] NULL,
	[Материал] [nvarchar](50) NULL,
	[Этажи] [int] NULL,
	[Доп_элементы] [nvarchar](100) NULL,
	[общая_стоимость] [decimal](15, 2) NULL,
 CONSTRAINT [PK__Проект__942377B76DCBCA7C] PRIMARY KEY CLUSTERED 
(
	[id_проекта] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (1, 3, N'Иванов Александр Петрович', CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (2, 4, N'Смирнова Екатерина Сергеевна', CAST(32000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (3, 5, N'Козлов Дмитрий Андреевич', CAST(37000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (4, 6, N'Попова Ольга Владимировна', CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (5, 7, N'Никитин Артем Игоревич', CAST(38000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (6, 8, N'Степанова Мария Александровна', CAST(33000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (7, 9, N'Васильев Антон Викторович
', CAST(36000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (8, 10, N'Кузнецова Анна Павловна', CAST(31000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (9, 11, N'Петров Максим Алексеевич', CAST(34000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (10, 12, N'Ильина Татьяна Дмитриевна', CAST(32000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (11, 13, N'Алексеев Николай Иванович', CAST(37000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (12, 14, N'Соколова Юлия Андреевна', CAST(31000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (13, 15, N'Лебедев Артемий Васильевич', CAST(38000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (14, 16, N'Козлова София Михайловна
', CAST(33000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (15, 17, N'Жуков Владислав Сергеевич
', CAST(36000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (16, 18, N'Медведева Алина Алексеевна
', CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (17, 19, N'Семенов Павел Андреевич
', CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (18, 20, N'Полякова Елена Владимировна
', CAST(32000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (19, 21, N'Журавлев Даниил Петрович
', CAST(37000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (20, 22, N'Киселев Артур Станиславович', CAST(33000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (21, 23, N'Григорьева Вера Аркадьевна
', CAST(38000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (22, 24, N'Федоров Евгений Васильевич
', CAST(31000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (23, 25, N'Тарасова Алена Денисовна
', CAST(34000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (24, 26, N'Комаров Игорь Александрович', CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[Застройщики] ([id], [id_проекта], [ФИО], [зарплата]) VALUES (25, 27, N'Романова Анастасия Игоревна', CAST(36000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Пользователи] ([Логин], [Пароль]) VALUES (N'admin', N'admin')
INSERT [dbo].[Пользователи] ([Логин], [Пароль]) VALUES (N'ad', N'ad')
GO
SET IDENTITY_INSERT [dbo].[Проект] ON 

INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (3, N'Коттедж', 160, N'Дерево', 3, N'Камин, Подвал, Мангальная зона', CAST(66951360.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (4, N'Коттедж', 160, N'Металл', 2, N'Камин', CAST(37195200.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (5, N'Дуплекс', 160, N'Дерево', 1, N'', CAST(13382400.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (6, N'Резиденция', 160, N'Дерево', 1, N'', CAST(59040000.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (7, N'Вилла', 160, N'Дерево', 1, N'', CAST(15744000.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (12, N'Резиденция', 160, N'Дерево', 1, N'', CAST(59040000.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (13, N'Таунхаус', 160, N'Дерево', 1, N'', CAST(25584000.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (14, N'Лейнхаус', 160, N'Дерево', 1, N'', CAST(23616000.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (15, N'Дуплекс', 160, N'Дерево', 1, N'', CAST(13382400.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (16, N'Квадрохаус', 160, N'Дерево', 1, N'', CAST(12201600.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (17, N'Особняк', 160, N'Дерево', 1, N'', CAST(118080000.00 AS Decimal(15, 2)))
INSERT [dbo].[Проект] ([id_проекта], [Тип], [Площадь], [Материал], [Этажи], [Доп_элементы], [общая_стоимость]) VALUES (18, N'Усадьба', 160, N'Дерево', 1, N'', CAST(236160000.00 AS Decimal(15, 2)))
SET IDENTITY_INSERT [dbo].[Проект] OFF
GO
/****** Object:  StoredProcedure [dbo].[smetana]    Script Date: 22.04.2024 2:42:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[smetana]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Пользователи
END
GO
