USE [deneme34]
GO
/****** Object:  Table [dbo].[Calisan]    Script Date: 28.05.2024 04:09:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calisan](
	[CalisanID] [int] NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Departman] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CalisanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 28.05.2024 04:09:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NULL,
	[Sifre] [varchar](50) NULL,
	[Rol] [int] NULL,
 CONSTRAINT [PK__Kullanic__E011F09B0576E955] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 28.05.2024 04:09:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriID] [int] NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[Telefon] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparisler]    Script Date: 28.05.2024 04:09:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparisler](
	[SiparisID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriID] [int] NULL,
	[UrunID] [int] NULL,
	[TedarikciID] [int] NULL,
	[Miktar] [int] NULL,
	[Tarih] [date] NULL,
 CONSTRAINT [PK__Siparisl__C3F03BDD7E1B7E22] PRIMARY KEY CLUSTERED 
(
	[SiparisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tedarikci]    Script Date: 28.05.2024 04:09:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tedarikci](
	[TedarikciID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](100) NULL,
	[Telefon] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
 CONSTRAINT [PK__Tedarikc__E0B82CC1EA76DBDB] PRIMARY KEY CLUSTERED 
(
	[TedarikciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 28.05.2024 04:09:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](100) NULL,
	[Fiyat] [decimal](10, 2) NULL,
	[StokMiktari] [int] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yonetim]    Script Date: 28.05.2024 04:09:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yonetim](
	[YonetimID] [int] NOT NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Pozisyon] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[YonetimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Calisan] ([CalisanID], [Ad], [Soyad], [Departman]) VALUES (1, N'recep', N'bektaş', N'müdür')
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullaniciID], [KullaniciAdi], [Sifre], [Rol]) VALUES (1, N'Recep', N'123', 1)
INSERT [dbo].[Kullanici] ([KullaniciID], [KullaniciAdi], [Sifre], [Rol]) VALUES (2, N'tunç', N'123', 2)
INSERT [dbo].[Kullanici] ([KullaniciID], [KullaniciAdi], [Sifre], [Rol]) VALUES (3, N'arda', N'123', 1)
INSERT [dbo].[Kullanici] ([KullaniciID], [KullaniciAdi], [Sifre], [Rol]) VALUES (4, N'hessam', N'258', 0)
INSERT [dbo].[Kullanici] ([KullaniciID], [KullaniciAdi], [Sifre], [Rol]) VALUES (5, N'ahmet ', N'adıvar', 2)
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
INSERT [dbo].[Musteriler] ([MusteriID], [Ad], [Soyad], [Email], [Telefon]) VALUES (3, N'arda', N'akın', N'@gmail.com', N'5455385355')
INSERT [dbo].[Musteriler] ([MusteriID], [Ad], [Soyad], [Email], [Telefon]) VALUES (5, N'ahmet', N'adıvar', N'@gmail.com', N'2555555555')
GO
SET IDENTITY_INSERT [dbo].[Siparisler] ON 

INSERT [dbo].[Siparisler] ([SiparisID], [MusteriID], [UrunID], [TedarikciID], [Miktar], [Tarih]) VALUES (1, 3, 1, 1, 1, CAST(N'2015-07-15' AS Date))
INSERT [dbo].[Siparisler] ([SiparisID], [MusteriID], [UrunID], [TedarikciID], [Miktar], [Tarih]) VALUES (2, NULL, 1, NULL, 10, CAST(N'2024-05-27' AS Date))
INSERT [dbo].[Siparisler] ([SiparisID], [MusteriID], [UrunID], [TedarikciID], [Miktar], [Tarih]) VALUES (3, NULL, 1, NULL, 2000, CAST(N'2024-05-29' AS Date))
INSERT [dbo].[Siparisler] ([SiparisID], [MusteriID], [UrunID], [TedarikciID], [Miktar], [Tarih]) VALUES (4, 5, 1, 1, 1000, CAST(N'2024-05-30' AS Date))
INSERT [dbo].[Siparisler] ([SiparisID], [MusteriID], [UrunID], [TedarikciID], [Miktar], [Tarih]) VALUES (5, 5, 1, 1, 10, CAST(N'2024-05-30' AS Date))
SET IDENTITY_INSERT [dbo].[Siparisler] OFF
GO
SET IDENTITY_INSERT [dbo].[Tedarikci] ON 

INSERT [dbo].[Tedarikci] ([TedarikciID], [Ad], [Telefon], [Email]) VALUES (1, N'nalbur', N'5555555', N'@hotmail.com')
SET IDENTITY_INSERT [dbo].[Tedarikci] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([UrunID], [Ad], [Fiyat], [StokMiktari]) VALUES (1, N'bilgisayar', CAST(5000.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
INSERT [dbo].[Yonetim] ([YonetimID], [Ad], [Soyad], [Pozisyon]) VALUES (2, N'tunç', N'sezgin', N'ceo')
GO
ALTER TABLE [dbo].[Calisan]  WITH CHECK ADD  CONSTRAINT [FK_Calisan_Kullanici] FOREIGN KEY([CalisanID])
REFERENCES [dbo].[Kullanici] ([KullaniciID])
GO
ALTER TABLE [dbo].[Calisan] CHECK CONSTRAINT [FK_Calisan_Kullanici]
GO
ALTER TABLE [dbo].[Musteriler]  WITH CHECK ADD  CONSTRAINT [FK_Musteriler_Kullanici] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Kullanici] ([KullaniciID])
GO
ALTER TABLE [dbo].[Musteriler] CHECK CONSTRAINT [FK_Musteriler_Kullanici]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Musteriler] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteriler] ([MusteriID])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Musteriler]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Tedarikci] FOREIGN KEY([TedarikciID])
REFERENCES [dbo].[Tedarikci] ([TedarikciID])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Tedarikci]
GO
ALTER TABLE [dbo].[Siparisler]  WITH CHECK ADD  CONSTRAINT [FK_Siparisler_Urunler] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urunler] ([UrunID])
GO
ALTER TABLE [dbo].[Siparisler] CHECK CONSTRAINT [FK_Siparisler_Urunler]
GO
ALTER TABLE [dbo].[Yonetim]  WITH CHECK ADD  CONSTRAINT [FK_Yonetim_Kullanici] FOREIGN KEY([YonetimID])
REFERENCES [dbo].[Kullanici] ([KullaniciID])
GO
ALTER TABLE [dbo].[Yonetim] CHECK CONSTRAINT [FK_Yonetim_Kullanici]
GO
