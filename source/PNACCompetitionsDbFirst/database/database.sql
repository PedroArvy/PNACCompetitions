USE [PNACCompetitions]
GO
/****** Object:  Table [dbo].[Clubs]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clubs](
	[ClubId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.Clubs] PRIMARY KEY CLUSTERED 
(
	[ClubId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clubs] ON
INSERT [dbo].[Clubs] ([ClubId], [Name]) VALUES (24, N'Preston Northcote Angling Club Test')
SET IDENTITY_INSERT [dbo].[Clubs] OFF
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers] 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c06b21c7-36b0-49a5-8763-c11e1a4f8efb', N'peter.antonello@gmail.com', 0, N'ACRN+YCb82Rc9JiscZmbbU0RAo8qOwF4ndPASGQin923wdel9dwVpPOjHd+/LDojcg==', N'9cb2065f-cfa9-49ad-bc8f-702d7fe0c30a', NULL, 0, 0, NULL, 1, 0, N'peter.antonello@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dcdf6c92-5dd8-499a-8b7d-7bb919e27632', N'petras.surna@yart.com.au', 0, N'ACq839IoTFJYsWx+yy3waQoYMaZvt9ztsn8wpq9J6qD6x8hX6NF5hRJlh62NElp6dA==', N'e76113f8-3528-4a61-8eb8-7a59268ed4ff', NULL, 0, 0, NULL, 1, 0, N'petras.surna@yart.com.au')
/****** Object:  Table [dbo].[Fish]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fish](
	[FishId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Minimum] [int] NOT NULL,
	[Maximum] [int] NOT NULL,
	[Difficulty] [float] NOT NULL,
 CONSTRAINT [PK_dbo.Fish] PRIMARY KEY CLUSTERED 
(
	[FishId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Fish] ON
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (97, N'Brown trout', 0, 0, 0)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (98, N'Rainbow trout', 0, 0, 0)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (99, N'Murray cod', 20, 200, 2)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (100, N'Bream', 28, 45, 1)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (101, N'Gummy Shark', 50, 200, 3)
SET IDENTITY_INSERT [dbo].[Fish] OFF
/****** Object:  Table [dbo].[Excel]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Excel](
	[Id] [int] NULL,
	[NAME] [nvarchar](255) NULL,
	[F2] [nvarchar](255) NULL,
	[PHONE] [nvarchar](255) NULL,
	[MOBILE] [nvarchar](255) NULL,
	[AREA] [nvarchar](255) NULL,
	[EMAIL] [nvarchar](255) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Fernanda', N'Antonello', N'9458 1254', N'0415 342 088', NULL, N'peter.antonello@gmail.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Harry & Barbara', N'Braidwood', N'9457 5083', N'0488 052 215', N'West Heidelberg', N'hbraid@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Preston Northcote Angling Club', NULL, N'www.prestonac.com.au', NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Peter', N'Antonello', N'9458 1254', N'0415 342 088', NULL, N'peter.antonello@gmail.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Ian', N'Axford', NULL, N'0417 522 804', N'Heidelberg West', N'ianaxford@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John', N'Backx', N'9404 1650', NULL, N'South Morang', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Kevin', N'Bamford', N'9354 6789', N'0408 699 135', N'Coburg North', N'kevinbamford@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Andrew', N'Barclay', NULL, N'0402 044 131', N'Keysborough', N'abpropmaint@gmail.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Bob', N'Beeson   ', N'9465 3095', NULL, N'Thomastown', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Harry & Barbara', N'Braidwood', N'9457 5083', N'0488 052 215', N'West Heidelberg', N'hbraid@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Andrew', N'Brandi', N'5743 1715', N'0418 594 797', N'Yarrawonga', N'alkc@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Phil', N'Brandi', N'9436 7256', N'0410 626 796', N'Mill Park', N'philj_b@live.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Alf & Margaret', N'Breci', N'9323 9355', N'0403 309 852', N'Fawkner', N'alfsabi@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Len', N'Brown', N'9216 1506', NULL, N'Mernda', N'len1936@merndaretirementvillage.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Jamie', N'Burrell', N'9438 1870', N'0418 559 347', N'Diamond Creek', N'wa23876@bigpond.net.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Kerrie', N'Burrell', N'9438 1870', N'0419 577 637', N'Diamond Creek', N'wa23876@bigpond.net.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Stephen', N'Burton ', NULL, NULL, NULL, N'torquayfish@yahoo.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'David', N'Cahir', NULL, N'0497 689 825', NULL, N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Frank & Bronwyn', N'Calleja', N'9458 4350', N'0403 502 925', N'Macleod', N'frank171@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Les', N'Chadwick', N'9459 2768', N'0438 511 082', N'Rosanna', N'leschadwick38@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Frank & Norma', N'Christopher', N'9439 2974', NULL, N'Eltham', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John & Lyn', N'Clarke', N'9898 1830', N'0412 939 343', N'Box Hill South', N'cowleyl@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Mick', N'Coats', N'9460 3948', NULL, N'Reservoir', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Ron & Di ', N'Cocking', NULL, N'0407 686 097', NULL, N'r.dcocking@hotmail.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Tony & Dot', N'Coon', N'9408 6060', N'0408 504 200', N'Epping', N'chitogal@tpg.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Amanda', N'Costa', N'9460 9063', N'0406 943 195', N'Keon Park', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John & Jenny', N'Costa', N'9460 9063', N'0417 870 404', N'Keon Park', N'fosj@netspace.net.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Julian', N'Costa', N'9460 9063', N'0415 140 601', N'Keon Park', N'julien_costa@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Tony', N'Cupo', NULL, N'04119 152 250', N'Reservoir', N'tonycupo@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Bill & Karlene', N'Cutting', N'9435 0498', NULL, N'Watsonia', N'karlenec@iprimus.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Ron & Mimma', N'Debono', N'9383 3287', N'0427 925 958', N'Pascoe Vale South', N'thatshandy@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Andrew', N'Deveson', NULL, NULL, N'Eldorado', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John & Bernice', N'Deveson', N'9331 6650', N'0419 298 680', N'East Keilor', N'John.Deveson@team.telstra.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Michael', N'Deveson', NULL, NULL, N'Eldorado', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Neil', N'Deveson', N'5725 1572', N'0408 340 765', N'Eldorado', N'devesonna@iinet.net.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Leo & Laura', N'DiCori', N'9457 5307', N'0412 439 047', N'Heidelberg West', N'attidicori@yahoo.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Joe', N'Donnini', N'9478 7978 ', N'0411 828 482', N'Reservoir', N'jmdmobilemechanics@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Tony', N'Dorner', N'9434 5662', N'0400 951 570', N'Macleod', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Bob & Rachael', N'Dower', N'(02) 6072 4268', NULL, N'Dartmouth', N'dartmouthcottages@yahoo.com.au ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Dennis', N'Dowling', N'9457 7965', N'0419 536 913', N'Heidelberg Hghts', N'custommowing@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John', N'Draper', NULL, N'0412 280 063', N'Broadford', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Niki', N'Duckstein', NULL, N'0451 307 129', N'Preston', N'n_duckstein@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Jim  ', N'Duff', N'5782 2385', NULL, N'Kilmore', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Ken & Deanna', N'Ely', N'9645 6924', N'0437 256 031', N'Port Melbourne', N'kenely@internode.on.net')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Rod', N'Ely', N'5278 1800', N'0408 474 976', N'Bell Park', N'oldacorn@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'David', N'Fairy', NULL, N'0408 990 995', N'Heidelberg  ', N'davidf@biznexus.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Manuel', N'Ferrero  ', N'9465 3549 ', N'0404 287 933', N'Thomastown', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Robert', N'Fisher', NULL, N'0412 774 699', N'Kilmore', N'Robelsfh@bigpond.net.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Dave', N'Fleming', N'9716 1506', N'0407 330 698', N'Whittlesea', N'davencoll@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Vic', N'Furlan', NULL, NULL, N'Thornbury', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John', N'Gilmour', N'5025 2118', N'0407 041 854', N'Mildura', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Peter & Josephine', N'Goldsworthy', N'9467 5481', NULL, N'Bundoora', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Alex & Jenny', N'Goodfellow', N'5981 8750', N'0407 050 290', N'Dromana', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Stephen & Di', N'Goodfellow', N'9305 7010', N'0416 021 822', N'Craigieburn', N'goodie15@live.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Perc', N'Gravenall', N'9465 9582', N'Fax  9465 9582', N'Thomastown', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Charlie & Margaret', N'Grech', N'9465 5301', NULL, N'Thomastown', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Joe & Anna', N'Grech', N'9402 0577', N'0412 332 199', N'Reservoir', N'joe_grech@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Steve', N'Gusman', NULL, N'0419 380 423', N'Taylors Lakes', N'steven.gusman@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Mark', N'Gutterson', N'9401 3551', N'0419 364 096', N'Epping', N'mgutters@parks.vic.gov.au ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'David', N'Halligan', N'9308 3750', N'0408 357 228', N'Craigieburn', N'samhalligan@live.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Ross & Marie', N'Halligan', N'9435 2044', N'0425 725 167', N'Greensborough', N'r.halligan@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Andrew', N'Harris', NULL, N'0417 734 498', N'Brunswick West', N'andrew@woowoowoo.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Bernard', N'Harris', NULL, N'0410 526 036', N'Thomastown', N'bernieharris@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Wayne', N'Harris', NULL, N'0414 455 407', N'Thomastown', N'harrissheetmetal@bigpond.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Duncan', N'Henshaw', NULL, N'0478 599 669', N'Reservoir', N'wondercat@supernerd.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Richard', N'Higlett', NULL, N'0407 802 631', N'Bulleen', N'higlett52@iprimus.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Daniel', N'Hughes', NULL, N'0430 281 299', N'Mernda', N'danz74@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Mark & Sharon', N'Hughes', N'9717 8141', N'0407 362 957', N'Mernda', N'hughesm@roads.vic.gov.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Timothy', N'Hughes', NULL, N'0421 662 734', N'Mernda', N'timmi.j.hughes@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Daniel', N'Jennings', N'9876 4131', N'0422 870 113', N'Ringwood North', N'dancjennings@live.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Robert', N'Johnstone', N'5674 2031', NULL, N'Inverloch', N'wingspurs@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Graeme', N'Jonson', NULL, N'0407 260 342', N'Essendon', N'graemejonson@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'George', N'Kapouleas', NULL, N'0428 107 205', N'Coburg', N'gkohsconsultancy@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Jason', N'King', N'9478 0607', N'0400 139 500', N'Regent', N'jrking@deakin.edu.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Peter', N'King', N'9478 0607', N'0437 011 292', N'Regent', N'peter.k1ng@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Rod', N'King', N'9478 0607', N'0418 134 013', N'Regent', N'rod.king2@cub.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Mark', N'Land', NULL, NULL, N'Craigieburn', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Frank & Mary', N'Maiolo', N'9858 2501', N'0409 427 346', N'Lwr Templestowe', N'fmaiolo@auto-it.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Glenn', N'Maplesden', N'5783 4400', N'0438 926 498', NULL, N'gmaplesden@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Roy & Kerry', N'Maplesden', N'5787 1177', N'0419 750 439', N'Wandong', N'royandkerry@bigpond.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Rod', N'Mason', NULL, N'0412 112 024', N'Glenroy', N'rmason@cashtronics.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Gordon', N'McDonald', NULL, N'0414 713 693', N'Pascoe Vale', N'mactrac@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Heath', N'McKinna', NULL, N'0450 891 241', N'Craigieburn', N'heath_mckinna@yahoo.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Joe  ', N'Mifsud', NULL, N'0457 992 276', NULL, N'joe.mifsud@nh.org.au ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Peter', N'Miles', N'9717 4239', N'0433 733 384', N'Doreen', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Robert & Sandy', N'Miles', N'9467 1934', N'0407 561 895', N'Bundoora', N'robgmiles45@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Greg', N'Mills', NULL, N'0409 003 624', N'Mill Park', N'gregmariemills@live.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Ken', N'Minnitt', N'5782 2857', NULL, N'Kilmore', N'kennethminnitt@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Vladimir', N'Molotsky', N'9395 6095', N'0418 513659', N'Point Cook', N'vmolotsky@yahoo.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Sandi', N'Muzzi', N'9435 6446', N'0407 620 053', N'Plenty', N'smuzzi67@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Tony', N'Nicolosi', N'9471 4448', N'0414 689 759', N'Reservoir', N'c2ctn@yahoo.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Arthur', N'Nixon', N'5987 2082', N'0408 108 240', N'Safety Beach', N'ajnixon@dodo.com.au ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Chris', N'O''Connell', NULL, N'0422 266 733', N'Bulleen', N'CO''CONNELL@gio.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Michael', N'O''Connell', NULL, N'0413 716 233', N'Mill Park', N'mocka-57@hotmail.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Donald', N'O''Donnel', N'07 5483 6943', N'0416 207 784', N'Gympie, Qld', N'deelohdee@aapt.net.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Samuel', N'Ogden', NULL, N'0497 686 643', N'Mernda', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John', N'Owen', N'8358 2551', N'0417 541 365', N'Hillside', N'jowen@swiftdsl.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Brian', N'Paice', N'9465 4887', NULL, N'Lalor', N'brianpaice@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Peter & Patty', N'Patterson', N'9402 5058', N'0408 303 520', N'Thomastown', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Tim & Julie', N'Paul', NULL, N'0428 260 960', N'Doreen', N'timp@banksiapalliative.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John', N'Penrose', N'9465 2220', NULL, N'Thomastown', N'Johnlpenrose@gmail.com')
GO
print 'Processed 100 total records'
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Les & Dawn', N'Penrose', N'9465 2220', N'0409 806 301', N'Thomastown', N'leslie.penrose@yahoo.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Joe & Lyn', N'Perri', N'9386 2660', N'0407 513 989', N'Coburg', N'lynperri@live.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Stan', N'Petkovic', N'9308 9771', N'0413 920 316', N'Roxburgh Park', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Joe & Jane', N'Psaila', N'9717 1191', N'0409 719 610', N'Mernda', N'eddiepsaila@hotmail.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Ryhs', N'Rech', NULL, N'0400 562 279', N'Mill Park', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Jim & Heather', N'Reimers', N'9465 2050', NULL, N'Lalor', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Bob', N'Richards', N'9459 9973', N'0421 022 595', N'Heidelberg Heights', N'thefisherman47@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Alan & Eileen', N'Russell', N'9401 1359', NULL, N'Lalor', N'Nil')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Jill', N'Sanders', N'9458 1627', NULL, N'Heidelberg Heights', N'jil_san@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Jeffrey', N'Santamaria', N'N/A', N'N/A', N'Coburg North', N'Jeffrey.s@optusnet.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Gary', N'Short', N'9496 8379', N'0417 548 447', N'Mill Park', N'garys8888@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Steve', N'Smith', NULL, N'0415 877 900', N'Richmond', N'stesmi@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Adam', N'Snelling', NULL, N'0404 864 432', N'Thomastown', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Kellie', N'Spencer', NULL, N'0437 646 413', N'Craigieburn', N'Ni')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Petras', N'Surna', NULL, N'0412 063 453', NULL, N'petras.surna@yart.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Jason', N'Tanti', NULL, N'0424 817 713', N'Yarrambat', N'jasonn_leigh@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'David', N'Tantis', NULL, NULL, NULL, N'davidtantis@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Nick', N'Tantis', NULL, N'0409 403 775', N'Portarlington', N'davidtantis@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John', N'Taylor', N'9460 5729', N'0450 119 865', N'Reservoir', N'johntaylor45@bigpond.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Stuart', N'Taylor', NULL, N'0408 336 628', N'Reservoir', N'sta87020@bigpond.net.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Daniel', N'Trafford', N'9408 5136', NULL, N'Lalor', N'Djt_at_his_best@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Phil & Val', N'Treble', N'9401 1269', NULL, N'Epping', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Tony & Laura', N'Valier D''Abate', N'9850 2530', NULL, N'Lwr Templestowe', N'abate46@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Helen', N'Warne', N'9459 3280', NULL, N'Rosanna', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Bruce', N'Warwick', NULL, N'0419 008 227', N'Thornbury', N'denikagencies@hotmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'David', N'Way', N'9434 1445 ', N'0411 856 861', N'Watsonia', N'dewayelectrical@gmail.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Gavin', N'White', NULL, N'0422 396 522', N'Heidelberg', N'gav.whyte23@gmail.com')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Luke', N'Whitmore', NULL, N'0422 052 563', N'Diamond Creek', N'whitmore3004@hotmail.com ')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'Ross', N'Wolfe', NULL, NULL, N'Brunswick', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'John & Natalie', N'Wus', NULL, N'0417 336 858', N'Devon North', NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, N'This list if for Preston Northcote Angling Club use only and no information is to be ', NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, N'given to any outside parties without the individual members consent.', NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, N'  FOR ALL UPDATES OR CHANGES  Please Contact Tony on 0408 504 200 or EMAIL -', NULL, NULL, NULL, NULL, N'chitogal@tpg.com.au')
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, N'Changes made since last update are marked in Red', NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, N'Delisted', N'Lee Brickell, Danny Dibb, Simon Gee, Tony Hewson, Jerry Iwanowski, Nick Kemp,', NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, N'Adrian Laino, Suzanne Meese, Bradley & Domenic Outschoorn, Mario Patane,', NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, N'John Rath, Shane Whitmore', NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Excel] ([Id], [NAME], [F2], [PHONE], [MOBILE], [AREA], [EMAIL]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[Environments]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Environments](
	[EnvironmentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Environments] PRIMARY KEY CLUSTERED 
(
	[EnvironmentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Environments] ON
INSERT [dbo].[Environments] ([EnvironmentId], [Name]) VALUES (1, N'Freshwater')
INSERT [dbo].[Environments] ([EnvironmentId], [Name]) VALUES (2, N'Estuary')
INSERT [dbo].[Environments] ([EnvironmentId], [Name]) VALUES (3, N'Saltwater')
SET IDENTITY_INSERT [dbo].[Environments] OFF
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 05/17/2016 09:16:52 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles] 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201605082344577_InitialCreate', N'PNACCompetitionsDbFirst.Models.ApplicationDbContext', 0x1F8B0800000000000400DD5CDB6EE436127D5F60FF41D05376E1B47CD919CC1ADD099CB69D35767CC1B427C8DB802DB1DBC4489422518E8D45BE2C0FF9A4FCC216254A2DF1A24BB7FAE22040E0168B87C5E221592C16E7CFDFFF187FFF12F8D6338E1312D2897D323AB62D4CDDD0237439B153B6F8F683FDFD777FFFDBF8CA0B5EAC9F0AB9332E07356932B19F188BCE1D27719F7080925140DC384CC2051BB961E0202F744E8F8FFFED9C9C3818206CC0B2ACF1A7943212E0EC07FC9C86D4C5114B917F1B7AD84FC477289965A8D61D0A701221174FEC87BB8BE9340C22CC08035D92CBF935891336CA6BDAD6854F106835C3FEC2B610A521435CEEFC7382672C0EE97216C107E43FBE4618E416C84FB0E8CBF94ABC6BB78E4F79B79C55C502CA4D1316063D014FCE849D1CB9FA5AD6B64B3B8225AFC0E2EC95F73AB3E6C4BEF170F6E953E88301E406CFA77ECC8527F66DD9C44512DD61362A2A8E72C8EB18E07E0DE3AFA32AE291D5B9DE51C9ABD3D131FFEFC89AA63E4B633CA1386531F28FAC8774EE13F7BFF8F531FC8AE9E4EC64BE38FBF0EE3DF2CEDEFF0B9FBDABF614FA0A72B50FF0E9210E231C836E7851F6DFB69C7A3D47AE5856ABD4C9AD025C8229625BB7E8E523A64BF60493E7F4836D5D9317EC155F04B93E5302330A2AB138859F77A9EFA3B98FCB72A7B14DFEFF86564FDFBD1FA4D53BF44C96D9D04BEDC3C489615E7DC27E569A3C91289F5EB5F1FE22C4AEE330E0BFEBFCCA4BBFCCC23476796742A3C8238A9798D5B51B3B2BF276A234871A9ED605EAE1539B6BAAD25B2BCA3BB4CE4C289AD8F56C28F4DD6EBB9D19771145307819B5B8459A08D7BC718D2424E0855E7E45A993AE94A2D0D5BFF20A791520E20FB0447668053C950589035CF6F287100889686F9D1F5092C00AE1FD07254F0DAAC39F03A83EC36E1A0371670C05D1D65B7B780A29BE4B83399F0FBB6B6BB0A179FC35BC462E0BE32BCA6B6D8CF73174BF8629BBA2DE2562F833730B40FEF39104DD010651E7C27571925C0399B1370DC1112F006F283B3BED0DC717AB7DBB28531F9140EFA348CBEA974274E5A7E825145FC520A6F3579A54FD182E09EDA66A216A56359768555588F555958375D354489A15CD045AF5CCA506F300B3111ADE05CC600FDF07DC6CF336AD051533CE6085C43F628A6358C6BC07C4188EE96A04BAAC1BFB7016B2E1E38D6E7D6FCA5AFA09F9E9D04DAD351BB24560F8D990C11EFE6CC8D484CFCFC4E35E49878351210CF09DE4F567AEF6392769B6EBE950EBE6AE1BDFCD1A609A2E174912BA249B059A90980868D4F5071FCE6A8F6EE4BD912324D031203AE15B1E7C81BED932A9EEE925F631C3D6859B870CA7287191A79A113AE4F550ACD851358AAD222575E5FEA9B4094CC731AF84F8212881994A2853A705A12E8990DF6A25A966C72D8CF7BD6C432EB9C411A6BCC1564B74695C1F18E10A94ED4883D266A1B153615C33110D5EAB69CCDB5CD8D5B82BF18A9D70B2C57736F052F86F5B2166B3C57640CE66937451C018E4DB0741C559A52B01E483CBA111543A3119082A5CAA9D10B46EB13D10B46E923747D0FC88DA75FCA5F3EAA1D1B37E50DEFDB6DE68AE3D70B3668F03A366EE7B421D063570ACD2F372CE0BF10BD31CCE404F713E4B84AB2B538483CF30AB876C56FEAED60F759A4164123501AE88D6022AAE0715206542F550AE88E5356A27BC881EB045DCAD1156ACFD126C85032A76F59AB42268BE4C95C9D9E9F451F6AC648342F24E87850A8E8610F2E255EF7807A398E2B2AA61BAF8C27DBCE14AC7C4603418A8C5733518A9E8CCE0562AA8D96E259D43D6C725DBC84A92FB64B052D199C1AD2438DA6E248D53D0C32DD8C844F52D7CA0C956443ACADDA62C1B3B792695F830760C2957E35B1445842E2B2958E28B35CBF3AFA6DFCEFA2723053986E3269A9CA452DBB22516C66889A552681A34CDEEC02F114373C4E33C532F50C4B47BAB61F92F9AAC6E9FEA2016FB4021CDFF16E1B3E64BFDDABEAB3A2602EF1A7A1B70EF260BA96BB8A0AF6EF1F438E4A35813C59F867E1A50B3B365AE9DDFE555EBE75F5484B123E9AF38538AE51497B73E0C9D06499D205B18B0D2AF597FD0CC1026D3175E69D5F8264FD58C5204AEAA28A660D6DE06D1E4E0AC3D70B21FD97FDC5A11B633DF44F24A15407CEA8951C97F50C02A65DD51EB292A55CC7A497744290FA50A2915F5D0B29A6D5253B25AB0169EC1A27A89EE2DA8F9255574B5B43BB226D3A40AAD295E035BA3B35CD61D55938C5205D61477C75E65A6C80BEA01EF68C6D3CD205B5A7E18DE6C4F33606C67751C664BACDCF957812A9F7B62895B7D054C7C3F4866194F8483302B8F876CC62C03867945AADD9CD717A4C6EB7E3366ED3ABCB6E837A50398F1FAF177AB2C510E87B248D97A7948940E836371306B7FA4A39CD47211DB2ACC081BFE6BC27030E202A3D92FFED427982FEF85C02DA264811396A780D87090FC20BDED399C77364E9278BEE6606B7A6C531FB31D6473D16714BB4F2856732B36788BB20255C2D637D4C32F13FB7F59ADF32C02C2FFCA3E1F5937C9674A7E49A1E0314EB1F59B9A2B3A4C6E7EF341EC405F5274B7EACDCF5FF2AA47D67D0C33E6DC3A966CB9CE08D7DF57F4D226AFBA81366BBFBA78BB13AAF674418B2A4D88F55F2ACC091BE49542A1E537017AF9475FD5B42F113642D4BC36180A6F10139A5E13AC83657C49E0C14F96BD24E8D759FDCB82755433BE2A20B43F98FCA6A0FB3254D4DCE356A3391FED6249CAECDC9A93BD5182E6BEF72625757BA389AEA667F780DB20057B0D66BCB1ECE5C176474D72F260D8FBA4F6D633920F250979951EB2DFDCE35DA61B375C1DFDA5B28C0F202F4E93E7B3FF5CE25D73CD14D33DF084CC7E19C307463691FDB5FFBCE05D93CD14E63D70B2F5CAFE3D30AEED6BFFDC33D33A6FA17BCFE555D3920C7733BA58705BAE6E1E388713FE3C0412E41E65FEC4529F1CD694D8DAD2E04AC4DCA8392B4D6E5899384ABB8A4473B3FDFA2A36FCC6CE0A99E6660DB99C4D6D8BF5BFB16D21D3DCB62143721F59C6DA1C455DE677CB3AD69428F596B28A6B3D6949626FF3591B2FDADF5212F12046A9CD1EC31DF1DBC9191EC424434E9D1E39C2EA752FEC9D957FB911F6EF842C5710FCDF71A4D8ADED9AA5CC0D5D84C5E62D69548848119A5BCC90075BEA45CCC802B90C8A798C397B239EC5EDF84DC71C7B37F43E6551CAA0CB3898FBB5801777029ADACF12A1EB3A8FEFA32CD961882E809A84C7E6EFE90F29F1BD52EF6B4D4CC800C1BD0B11D1E563C9786477F95A22DD85B42390305FE9143DE220F2012CB9A733F48CD7D10DE8F7112F91FBBA8A009A40DA07A26EF6F12541CB180589C058D5879FC0612F78F9EEFFA07FCEA3C0540000, N'6.1.3-40302')
/****** Object:  Table [dbo].[Seasons]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seasons](
	[SeasonId] [int] IDENTITY(1,1) NOT NULL,
	[ClubId] [int] NOT NULL,
	[End] [datetime] NOT NULL,
	[Start] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.Seasons] PRIMARY KEY CLUSTERED 
(
	[SeasonId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_ClubId] ON [dbo].[Seasons] 
(
	[ClubId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Seasons] ON
INSERT [dbo].[Seasons] ([SeasonId], [ClubId], [End], [Start]) VALUES (142, 24, CAST(0x0000A67800000000 AS DateTime), CAST(0x0000A50A00000000 AS DateTime))
INSERT [dbo].[Seasons] ([SeasonId], [ClubId], [End], [Start]) VALUES (143, 24, CAST(0x0000A7E500000000 AS DateTime), CAST(0x0000A67800000000 AS DateTime))
INSERT [dbo].[Seasons] ([SeasonId], [ClubId], [End], [Start]) VALUES (144, 24, CAST(0x0000A95200000000 AS DateTime), CAST(0x0000A7E500000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Seasons] OFF
/****** Object:  Table [dbo].[FishEnvironments]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FishEnvironments](
	[FishId] [int] NOT NULL,
	[EnvironmentId] [int] NOT NULL,
 CONSTRAINT [PK_FishEnvironments] PRIMARY KEY CLUSTERED 
(
	[FishId] ASC,
	[EnvironmentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (99, 1)
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (100, 2)
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (100, 3)
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 05/17/2016 09:16:52 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles] 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles] 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 05/17/2016 09:16:52 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins] 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 05/17/2016 09:16:52 ******/
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
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims] 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Competitors]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Competitors](
	[CompetitorId] [int] IDENTITY(1,1) NOT NULL,
	[CompetitorType] [int] NOT NULL,
	[Gender] [int] NOT NULL,
	[ClubId] [int] NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[NickName] [varchar](100) NULL,
	[AspNetUserId] [nvarchar](128) NULL,
	[Admin] [bit] NOT NULL,
	[Hide] [bit] NOT NULL,
	[Suburb] [varchar](100) NULL,
	[Phone] [varchar](30) NULL,
	[Mobile] [varchar](30) NULL,
	[Email] [varchar](100) NULL,
 CONSTRAINT [PK_dbo.Competitors] PRIMARY KEY CLUSTERED 
(
	[CompetitorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ClubId] ON [dbo].[Competitors] 
(
	[ClubId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Competitors] ON
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (544, 3, 1, 24, N'Fernanda', N'Antonello', N'', NULL, 0, 0, N'', N'9458 1254', N'0415 342 088', N'peter.antonello@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (547, 3, 1, 24, N'Peter', N'Antonello', NULL, N'c06b21c7-36b0-49a5-8763-c11e1a4f8efb', 0, 0, N'sss', N'111', N'222', N'peter.antonello@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (548, 3, 1, 24, N'Ian', N'Axford', N'', NULL, 0, 0, N'Heidelberg West', N'', N'0417 522 804', N'ianaxford@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (549, 3, 1, 24, N'John', N'Backx', N'', NULL, 0, 0, N'South Morang', N'9404 1650', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (550, 3, 1, 24, N'Kevin', N'Bamford', N'', NULL, 0, 0, N'Coburg North', N'9354 6789', N'0408 699 135', N'kevinbamford@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (551, 3, 1, 24, N'Andrew', N'Barclay', N'', NULL, 0, 0, N'Keysborough', N'', N'0402 044 131', N'abpropmaint@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (552, 3, 1, 24, N'Bob', N'Beeson   ', N'', NULL, 0, 0, N'Thomastown', N'9465 3095', N'', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (553, 3, 1, 24, N'Harry', N'Braidwood', N'', NULL, 0, 0, N'West Heidelberg', N'9457 5083', N'0488 052 215', N'hbraid@optusnet.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (554, 3, 1, 24, N'Andrew', N'Brandi', N'', NULL, 0, 0, N'Yarrawonga', N'5743 1715', N'0418 594 797', N'alkc@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (555, 3, 1, 24, N'Phil', N'Brandi', N'', NULL, 0, 0, N'Mill Park', N'9436 7256', N'0410 626 796', N'philj_b@live.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (556, 3, 1, 24, N'Alf', N'Breci', N'', NULL, 0, 0, N'Fawkner', N'9323 9355', N'0403 309 852', N'alfsabi@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (557, 3, 1, 24, N'Len', N'Brown', N'', NULL, 0, 0, N'Mernda', N'9216 1506', N'', N'len1936@merndaretirementvillage.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (558, 3, 1, 24, N'Jamie', N'Burrell', N'', NULL, 0, 0, N'Diamond Creek', N'9438 1870', N'0418 559 347', N'wa23876@bigpond.net.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (559, 3, 1, 24, N'Kerrie', N'Burrell', N'', NULL, 0, 0, N'Diamond Creek', N'9438 1870', N'0419 577 637', N'wa23876@bigpond.net.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (560, 3, 1, 24, N'Stephen', N'Burton ', N'', NULL, 0, 0, N'', N'', N'', N'torquayfish@yahoo.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (561, 3, 1, 24, N'David', N'Cahir', N'', NULL, 0, 0, N'', N'', N'0497 689 825', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (562, 3, 1, 24, N'Frank', N'Calleja', N'', NULL, 0, 0, N'Macleod', N'9458 4350', N'0403 502 925', N'frank171@optusnet.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (563, 3, 1, 24, N'Les', N'Chadwick', N'', NULL, 0, 0, N'Rosanna', N'9459 2768', N'0438 511 082', N'leschadwick38@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (564, 3, 1, 24, N'Frank', N'Christopher', N'', NULL, 0, 0, N'Eltham', N'9439 2974', N'', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (565, 3, 1, 24, N'John', N'Clarke', N'', NULL, 0, 0, N'Box Hill South', N'9898 1830', N'0412 939 343', N'cowleyl@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (566, 3, 1, 24, N'Mick', N'Coats', N'', NULL, 0, 0, N'Reservoir', N'9460 3948', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (567, 3, 1, 24, N'Ron', N'Cocking', N'', NULL, 0, 0, N'', N'', N'0407 686 097', N'r.dcocking@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (568, 3, 1, 24, N'Tony', N'Coon', N'', NULL, 0, 0, N'Epping', N'9408 6060', N'0408 504 200', N'chitogal@tpg.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (569, 3, 1, 24, N'Amanda', N'Costa', N'', NULL, 0, 0, N'Keon Park', N'9460 9063', N'0406 943 195', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (570, 3, 1, 24, N'John', N'Costa', N'', NULL, 1, 0, N'Keon Park', N'9460 9063', N'0417 870 404', N'fosj@netspace.net.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (571, 3, 1, 24, N'Julian', N'Costa', N'', NULL, 0, 0, N'Keon Park', N'9460 9063', N'0415 140 601', N'julien_costa@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (572, 3, 1, 24, N'Tony', N'Cupo', N'', NULL, 0, 0, N'Reservoir', N'', N'04119 152 250', N'tonycupo@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (573, 3, 1, 24, N'Bill', N'Cutting', N'', NULL, 0, 0, N'Watsonia', N'9435 0498', N'', N'karlenec@iprimus.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (574, 3, 1, 24, N'Ron', N'Debono', N'', NULL, 0, 0, N'Pascoe Vale South', N'9383 3287', N'0427 925 958', N'thatshandy@optusnet.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (575, 3, 1, 24, N'Andrew', N'Deveson', N'', NULL, 0, 0, N'Eldorado', N'', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (576, 3, 1, 24, N'John', N'Deveson', N'', NULL, 0, 0, N'East Keilor', N'9331 6650', N'0419 298 680', N'John.Deveson@team.telstra.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (577, 3, 1, 24, N'Michael', N'Deveson', N'', NULL, 0, 0, N'Eldorado', N'', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (578, 3, 1, 24, N'Neil', N'Deveson', N'', NULL, 0, 0, N'Eldorado', N'5725 1572', N'0408 340 765', N'devesonna@iinet.net.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (579, 3, 1, 24, N'Leo', N'DiCori', N'', NULL, 0, 0, N'Heidelberg West', N'9457 5307', N'0412 439 047', N'attidicori@yahoo.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (580, 3, 1, 24, N'Joe', N'Donnini', N'', NULL, 0, 0, N'Reservoir', N'9478 7978', N'0411 828 482', N'jmdmobilemechanics@optusnet.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (581, 3, 1, 24, N'Tony', N'Dorner', N'', NULL, 0, 0, N'Macleod', N'9434 5662', N'0400 951 570', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (582, 3, 1, 24, N'Bob', N'Dower', N'', NULL, 0, 0, N'Dartmouth', N'(02) 6072 4268', N'', N'dartmouthcottages@yahoo.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (583, 3, 1, 24, N'Dennis', N'Dowling', N'', NULL, 0, 0, N'Heidelberg Heights', N'9457 7965', N'0419 536 913', N'custommowing@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (584, 3, 1, 24, N'John', N'Draper', N'', NULL, 0, 0, N'Broadford', N'', N'0412 280 063', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (585, 3, 1, 24, N'Niki', N'Duckstein', N'', NULL, 0, 0, N'Preston', N'', N'0451 307 129', N'n_duckstein@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (586, 3, 1, 24, N'Jim', N'Duff', N'', NULL, 0, 0, N'Kilmore', N'5782 2385', N'', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (587, 3, 1, 24, N'Ken', N'Ely', N'', NULL, 1, 0, N'Port Melbourne', N'9645 6924', N'0437 256 031', N'kenely@internode.on.net')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (588, 3, 1, 24, N'Rod', N'Ely', N'', NULL, 0, 0, N'Bell Park', N'5278 1800', N'0408 474 976', N'oldacorn@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (589, 3, 1, 24, N'David', N'Fairy', N'', NULL, 0, 0, N'Heidelberg', N'', N'0408 990 995', N'davidf@biznexus.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (590, 3, 1, 24, N'Manuel', N'Ferrero  ', N'', NULL, 0, 0, N'Thomastown', N'9465 3549', N'0404 287 933', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (591, 3, 1, 24, N'Robert', N'Fisher', N'', NULL, 0, 0, N'Kilmore', N'', N'0412 774 699', N'Robelsfh@bigpond.net.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (592, 3, 1, 24, N'Dave', N'Fleming', N'', NULL, 0, 0, N'Whittlesea', N'9716 1506', N'0407 330 698', N'davencoll@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (593, 3, 1, 24, N'Vic', N'Furlan', N'', NULL, 0, 0, N'Thornbury', N'', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (594, 3, 1, 24, N'John', N'Gilmour', N'', NULL, 0, 0, N'Mildura', N'5025 2118', N'0407 041 854', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (595, 3, 1, 24, N'Peter', N'Goldsworthy', N'', NULL, 0, 0, N'Bundoora', N'9467 5481', N'', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (596, 3, 1, 24, N'Alex', N'Goodfellow', N'', NULL, 0, 0, N'Dromana', N'5981 8750', N'0407 050 290', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (597, 3, 1, 24, N'Stephen', N'Goodfellow', N'', NULL, 0, 0, N'Craigieburn', N'9305 7010', N'0416 021 822', N'goodie15@live.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (598, 3, 1, 24, N'Perc', N'Gravenall', N'', NULL, 0, 0, N'Thomastown', N'9465 9582', N'Fax  9465 9582', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (599, 3, 1, 24, N'Charlie', N'Grech', N'', NULL, 0, 0, N'Thomastown', N'9465 5301', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (600, 3, 1, 24, N'Joe', N'Grech', N'', NULL, 0, 0, N'Reservoir', N'9402 0577', N'0412 332 199', N'joe_grech@optusnet.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (601, 3, 1, 24, N'Steve', N'Gusman', N'', NULL, 0, 0, N'Taylors Lakes', N'', N'0419 380 423', N'steven.gusman@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (602, 3, 1, 24, N'Mark', N'Gutterson', N'', NULL, 0, 0, N'Epping', N'9401 3551', N'0419 364 096', N'mgutters@parks.vic.gov.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (603, 3, 1, 24, N'David', N'Halligan', N'', NULL, 0, 0, N'Craigieburn', N'9308 3750', N'0408 357 228', N'samhalligan@live.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (604, 3, 1, 24, N'Ross', N'Halligan', N'', NULL, 1, 0, N'Greensborough', N'9435 2044', N'0425 725 167', N'r.halligan@optusnet.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (605, 3, 1, 24, N'Andrew', N'Harris', N'', NULL, 0, 0, N'Brunswick West', N'', N'0417 734 498', N'andrew@woowoowoo.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (606, 3, 1, 24, N'Bernard', N'Harris', N'', NULL, 0, 0, N'Thomastown', N'', N'0410 526 036', N'bernieharris@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (607, 3, 1, 24, N'Wayne', N'Harris', N'', NULL, 0, 0, N'Thomastown', N'', N'0414 455 407', N'harrissheetmetal@bigpond.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (608, 3, 1, 24, N'Duncan', N'Henshaw', N'', NULL, 0, 0, N'Reservoir', N'', N'0478 599 669', N'wondercat@supernerd.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (609, 3, 1, 24, N'Richard', N'Higlett', N'', NULL, 0, 0, N'Bulleen', N'', N'0407 802 631', N'higlett52@iprimus.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (610, 3, 1, 24, N'Daniel', N'Hughes', N'', NULL, 0, 0, N'Mernda', N'', N'0430 281 299', N'danz74@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (611, 3, 1, 24, N'Mark', N'Hughes', N'', NULL, 0, 0, N'Mernda', N'9717 8141', N'0407 362 957', N'hughesm@roads.vic.gov.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (612, 3, 1, 24, N'Timothy', N'Hughes', N'', NULL, 0, 0, N'Mernda', N'', N'0421 662 734', N'timmi.j.hughes@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (613, 3, 1, 24, N'Daniel', N'Jennings', N'', NULL, 0, 0, N'Ringwood North', N'9876 4131', N'0422 870 113', N'dancjennings@live.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (614, 3, 1, 24, N'Robert', N'Johnstone', N'', NULL, 0, 0, N'Inverloch', N'5674 2031', N'', N'wingspurs@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (615, 3, 1, 24, N'Graeme', N'Jonson', N'', NULL, 0, 0, N'Essendon', N'', N'0407 260 342', N'graemejonson@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (616, 3, 1, 24, N'George', N'Kapouleas', N'', NULL, 0, 0, N'Coburg', N'', N'0428 107 205', N'gkohsconsultancy@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (617, 3, 1, 24, N'Jason', N'King', N'', NULL, 0, 0, N'Regent', N'9478 0607', N'0400 139 500', N'jrking@deakin.edu.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (618, 3, 1, 24, N'Peter', N'King', N'', NULL, 0, 0, N'Regent', N'9478 0607', N'0437 011 292', N'peter.k1ng@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (619, 3, 1, 24, N'Rod', N'King', N'', NULL, 0, 0, N'Regent', N'9478 0607', N'0418 134 013', N'rod.king2@cub.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (620, 3, 1, 24, N'Mark', N'Land', N'', NULL, 0, 0, N'Craigieburn', N'', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (621, 3, 1, 24, N'Frank', N'Maiolo', N'', NULL, 0, 0, N'Lwr Templestowe', N'9858 2501', N'0409 427 346', N'fmaiolo@auto-it.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (622, 3, 1, 24, N'Glenn', N'Maplesden', N'', NULL, 0, 0, N'', N'5783 4400', N'0438 926 498', N'gmaplesden@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (623, 3, 1, 24, N'Roy', N'Maplesden', N'', NULL, 0, 0, N'Wandong', N'5787 1177', N'0419 750 439', N'royandkerry@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (624, 3, 1, 24, N'Rod', N'Mason', N'', NULL, 0, 0, N'Glenroy', N'', N'0412 112 024', N'rmason@cashtronics.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (625, 3, 1, 24, N'Gordon', N'McDonald', N'', NULL, 0, 0, N'Pascoe Vale', N'', N'0414 713 693', N'mactrac@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (626, 3, 1, 24, N'Heath', N'McKinna', N'', NULL, 0, 0, N'Craigieburn', N'', N'0450 891 241', N'heath_mckinna@yahoo.com ')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (627, 3, 1, 24, N'Joe', N'Mifsud', N'', NULL, 0, 0, N'', N'', N'0457 992 276', N'joe.mifsud@nh.org.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (628, 3, 1, 24, N'Peter', N'Miles', N'', NULL, 0, 0, N'Doreen', N'9717 4239', N'0433 733 384', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (629, 3, 1, 24, N'Robert', N'Miles', N'', NULL, 0, 0, N'Bundoora', N'9467 1934', N'0407 561 895', N'robgmiles45@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (630, 3, 1, 24, N'Greg', N'Mills', N'', NULL, 0, 0, N'Mill Park', N'', N'0409 003 624', N'gregmariemills@live.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (631, 3, 1, 24, N'Ken', N'Minnitt', N'', NULL, 0, 0, N'Kilmore', N'5782 2857', N'', N'kennethminnitt@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (632, 3, 1, 24, N'Vladimir', N'Molotsky', N'', NULL, 0, 0, N'Point Cook', N'9395 6095', N'0418 513659', N'vmolotsky@yahoo.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (633, 3, 1, 24, N'Sandi', N'Muzzi', N'', NULL, 0, 0, N'Plenty', N'9435 6446', N'0407 620 053', N'smuzzi67@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (634, 3, 1, 24, N'Tony', N'Nicolosi', N'', NULL, 0, 0, N'Reservoir', N'9471 4448', N'0414 689 759', N'c2ctn@yahoo.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (635, 3, 1, 24, N'Arthur', N'Nixon', N'', NULL, 0, 0, N'Safety Beach', N'5987 2082', N'0408 108 240', N'ajnixon@dodo.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (636, 3, 1, 24, N'Chris', N'O''Connell', N'', NULL, 0, 0, N'Bulleen', N'', N'0422 266 733', N'CO''CONNELL@gio.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (637, 3, 1, 24, N'Michael', N'O''Connell', N'', NULL, 0, 0, N'Mill Park', N'', N'0413 716 233', N'mocka-57@hotmail.com ')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (638, 3, 1, 24, N'Donald', N'O''Donnel', N'', NULL, 0, 0, N'Gympie, Qld', N'07 5483 6943', N'0416 207 784', N'deelohdee@aapt.net.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (639, 3, 1, 24, N'Samuel', N'Ogden', N'', NULL, 0, 0, N'Mernda', N'', N'0497 686 643', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (640, 3, 1, 24, N'John', N'Owen', N'', NULL, 0, 0, N'Hillside', N'8358 2551', N'0417 541 365', N'jowen@swiftdsl.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (641, 3, 1, 24, N'Brian', N'Paice', N'', NULL, 0, 0, N'Lalor', N'9465 4887', N'', N'brianpaice@optusnet.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (642, 3, 1, 24, N'Peter', N'Patterson', N'', NULL, 0, 0, N'Thomastown', N'9402 5058', N'0408 303 520', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (643, 3, 1, 24, N'Tim', N'Paul', N'', NULL, 0, 0, N'Doreen', N'', N'0428 260 960', N'timp@banksiapalliative.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (644, 3, 1, 24, N'John', N'Penrose', N'', NULL, 0, 0, N'Thomastown', N'9465 2220', N'', N'Johnlpenrose@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (645, 3, 1, 24, N'Les', N'Penrose', N'', NULL, 0, 0, N'Thomastown', N'9465 2220', N'0409 806 301', N'leslie.penrose@yahoo.com')
GO
print 'Processed 100 total records'
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (646, 3, 1, 24, N'Joe', N'Perri', N'', NULL, 0, 0, N'Coburg', N'9386 2660', N'0407 513 989', N'lynperri@live.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (647, 3, 1, 24, N'Stan', N'Petkovic', N'', NULL, 0, 0, N'Roxburgh Park', N'9308 9771', N'0413 920 316', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (648, 3, 1, 24, N'Joe', N'Psaila', N'', NULL, 0, 0, N'Mernda', N'9717 1191', N'0409 719 610', N'eddiepsaila@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (649, 3, 1, 24, N'Ryhs', N'Rech', N'', NULL, 0, 0, N'Mill Park', N'', N'0400 562 279', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (650, 3, 1, 24, N'Jim', N'Reimers', N'', NULL, 0, 0, N'Lalor', N'9465 2050', N'', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (651, 3, 1, 24, N'Bob', N'Richards', N'', NULL, 0, 0, N'Heidelberg Heights', N'9459 9973', N'0421 022 595', N'thefisherman47@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (652, 3, 1, 24, N'Alan', N'Russell', N'', NULL, 0, 0, N'Lalor', N'9401 1359', N'', N'Nil')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (653, 3, 1, 24, N'Jill', N'Sanders', N'', NULL, 0, 0, N'Heidelberg Heights', N'9458 1627', N'', N'jil_san@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (654, 3, 1, 24, N'Jeffrey', N'Santamaria', N'', NULL, 0, 0, N'Coburg North', N'N/A', N'N/A', N'Jeffrey.s@optusnet.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (655, 3, 1, 24, N'Gary', N'Short', N'', NULL, 0, 0, N'Mill Park', N'9496 8379', N'0417 548 447', N'garys8888@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (656, 3, 1, 24, N'Steve', N'Smith', N'', NULL, 0, 0, N'Richmond', N'', N'0415 877 900', N'stesmi@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (657, 3, 1, 24, N'Adam', N'Snelling', N'', NULL, 0, 0, N'Thomastown', N'', N'0404 864 432', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (658, 3, 1, 24, N'Kellie', N'Spencer', N'', NULL, 0, 0, N'Craigieburn', N'', N'0437 646 413', N'Ni')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (659, 3, 1, 24, N'Petras', N'Surna', N'', N'dcdf6c92-5dd8-499a-8b7d-7bb919e27632', 1, 0, N'', N'', N'0412 063 453', N'petras.surna@yart.com.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (660, 3, 1, 24, N'Jason', N'Tanti', N'', NULL, 0, 0, N'Yarrambat', N'', N'0424 817 713', N'jasonn_leigh@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (661, 3, 1, 24, N'David', N'Tantis', N'', NULL, 0, 0, N'', N'', N'', N'davidtantis@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (662, 3, 1, 24, N'Nick', N'Tantis', N'', NULL, 0, 0, N'Portarlington', N'', N'0409 403 775', N'davidtantis@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (663, 3, 1, 24, N'John', N'Taylor', N'', NULL, 0, 0, N'Reservoir', N'9460 5729', N'0450 119 865', N'johntaylor45@bigpond.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (664, 3, 1, 24, N'Stuart', N'Taylor', N'', NULL, 0, 0, N'Reservoir', N'', N'0408 336 628', N'sta87020@bigpond.net.au')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (665, 3, 1, 24, N'Daniel', N'Trafford', N'', NULL, 0, 0, N'Lalor', N'9408 5136', N'', N'Djt_at_his_best@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (666, 3, 1, 24, N'Phil', N'Treble', N'', NULL, 0, 0, N'Epping', N'9401 1269', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (667, 3, 1, 24, N'Tony', N'Valier D''Abate', N'', NULL, 0, 0, N'Lwr Templestowe', N'9850 2530', N'', N'abate46@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (668, 3, 1, 24, N'Helen', N'Warne', N'', NULL, 0, 0, N'Rosanna', N'9459 3280', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (669, 3, 1, 24, N'Bruce', N'Warwick', N'', NULL, 0, 0, N'Thornbury', N'', N'0419 008 227', N'denikagencies@hotmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (670, 3, 1, 24, N'David', N'Way', N'', NULL, 0, 0, N'Watsonia', N'9434 1445', N'0411 856 861', N'dewayelectrical@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (671, 3, 1, 24, N'Gavin', N'White', N'', NULL, 0, 0, N'Heidelberg', N'', N'0422 396 522', N'gav.whyte23@gmail.com')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (672, 3, 1, 24, N'Luke', N'Whitmore', N'', NULL, 0, 0, N'Diamond Creek', N'', N'0422 052 563', N'whitmore3004@hotmail.com ')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (673, 3, 1, 24, N'Ross', N'Wolfe', N'', NULL, 0, 0, N'Brunswick', N'', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (674, 3, 1, 24, N'John', N'Wus', N'', NULL, 0, 0, N'Devon North', N'', N'0417 336 858', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (692, 3, 2, 24, N'Barbara', N'Braidwood', N'', NULL, 0, 0, N'West Heidelberg', N'9457 5083', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (693, 3, 2, 24, N'Margaret', N'Breci', N'', NULL, 0, 0, N'Fawkner', N'9323 9355', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (694, 3, 2, 24, N'Bronwyn', N'Calleja', N'', NULL, 0, 0, N'Macleod', N'9458 4350', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (695, 3, 2, 24, N'Norma', N'Christopher', N'', NULL, 0, 0, N'Eltham', N'9439 2974', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (696, 3, 2, 24, N'Lyn', N'Clarke', N'', NULL, 0, 0, N'Box Hill South', N'9898 1830', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (697, 3, 2, 24, N'Di', N'Cocking', N'', NULL, 0, 0, N'', N'', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (698, 3, 2, 24, N'Dot', N'Coon', N'', NULL, 0, 0, N'Epping', N'9408 6060', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (699, 3, 2, 24, N'Jenny', N'Costa', N'', NULL, 0, 0, N'Keon Park', N'9460 9063', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (700, 3, 2, 24, N'Karlene', N'Cutting', N'', NULL, 0, 0, N'Watsonia', N'9435 0498', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (701, 3, 2, 24, N'Mimma', N'Debono', N'', NULL, 0, 0, N'Pascoe Vale South', N'9383 3287', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (702, 3, 2, 24, N'Bernice', N'Deveson', N'', NULL, 0, 0, N'East Keilor', N'9331 6650', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (703, 3, 2, 24, N'Laura', N'DiCori', N'', NULL, 0, 0, N'Heidelberg West', N'9457 5307', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (704, 3, 2, 24, N'Rachael', N'Dower', N'', NULL, 0, 0, N'Dartmouth', N'(02) 6072 4268', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (705, 3, 2, 24, N'Deanna', N'Ely', N'', NULL, 0, 0, N'Port Melbourne', N'9645 6924', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (706, 3, 2, 24, N'Josephine', N'Goldsworthy', N'', NULL, 0, 0, N'Bundoora', N'9467 5481', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (707, 3, 2, 24, N'Jenny', N'Goodfellow', N'', NULL, 0, 0, N'Dromana', N'5981 8750', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (708, 3, 2, 24, N'Di', N'Goodfellow', N'', NULL, 0, 0, N'Craigieburn', N'9305 7010', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (709, 3, 2, 24, N'Margaret', N'Grech', N'', NULL, 0, 0, N'Thomastown', N'9465 5301', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (710, 3, 2, 24, N'Anna', N'Grech', N'', NULL, 0, 0, N'Reservoir', N'9402 0577', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (711, 3, 2, 24, N'Marie', N'Halligan', N'', NULL, 0, 0, N'Greensborough', N'9435 2044', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (712, 3, 2, 24, N'Sharon', N'Hughes', N'', NULL, 0, 0, N'Mernda', N'9717 8141', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (713, 3, 2, 24, N'Mary', N'Maiolo', N'', NULL, 0, 0, N'Lwr Templestowe', N'9858 2501', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (714, 3, 2, 24, N'Kerry', N'Maplesden', N'', NULL, 0, 0, N'Wandong', N'5787 1177', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (715, 3, 2, 24, N'Sandy', N'Miles', N'', NULL, 0, 0, N'Bundoora', N'9467 1934', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (716, 3, 2, 24, N'Patty', N'Patterson', N'', NULL, 0, 0, N'Thomastown', N'9402 5058', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (717, 3, 2, 24, N'Julie', N'Paul', N'', NULL, 0, 0, N'Doreen', N'', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (718, 3, 2, 24, N'Dawn', N'Penrose', N'', NULL, 0, 0, N'Thomastown', N'9465 2220', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (719, 3, 2, 24, N'Lyn', N'Perri', N'', NULL, 0, 0, N'Coburg', N'9386 2660', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (720, 3, 2, 24, N'Jane', N'Psaila', N'', NULL, 0, 0, N'Mernda', N'9717 1191', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (721, 3, 2, 24, N'Heather', N'Reimers', N'', NULL, 0, 0, N'Lalor', N'9465 2050', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (722, 3, 2, 24, N'Eileen', N'Russell', N'', NULL, 0, 0, N'Lalor', N'9401 1359', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (723, 3, 2, 24, N'Val', N'Treble', N'', NULL, 0, 0, N'Epping', N'9401 1269', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (724, 3, 2, 24, N'Laura', N'Valier D''Abate', N'', NULL, 0, 0, N'Lower Templestowe', N'9850 2530', N'', N'')
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (725, 3, 2, 24, N'Natalie', N'Wus', N'', NULL, 0, 0, N'Devon North', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[Competitors] OFF
/****** Object:  Table [dbo].[Competitions]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Competitions](
	[CompetitionId] [int] IDENTITY(1,1) NOT NULL,
	[ClubId] [int] NOT NULL,
	[Environment] [int] NOT NULL,
	[End] [datetime] NULL,
	[Name] [varchar](100) NULL,
	[Start] [datetime] NOT NULL,
	[TripCaptainId] [int] NULL,
	[Referee1Id] [int] NULL,
	[Referee2Id] [int] NULL,
	[Venue] [varchar](100) NOT NULL,
	[WeighInTime] [datetime] NULL,
	[WeighInVenue] [varchar](1000) NULL,
	[DayType] [char](1) NOT NULL,
 CONSTRAINT [PK_dbo.Competitions] PRIMARY KEY CLUSTERED 
(
	[CompetitionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IX_ClubId] ON [dbo].[Competitions] 
(
	[ClubId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Competitions] ON
INSERT [dbo].[Competitions] ([CompetitionId], [ClubId], [Environment], [End], [Name], [Start], [TripCaptainId], [Referee1Id], [Referee2Id], [Venue], [WeighInTime], [WeighInVenue], [DayType]) VALUES (21, 24, 1, CAST(0x0000A5D3011826C0 AS DateTime), N'Anazac weekend', CAST(0x0000A5D20062E080 AS DateTime), 547, NULL, NULL, N'Lake Fyans', CAST(0x0000A5D40107AC00 AS DateTime), N'At the shed', N'm')
SET IDENTITY_INSERT [dbo].[Competitions] OFF
/****** Object:  Table [dbo].[Entries]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entries](
	[EntryId] [int] IDENTITY(1,1) NOT NULL,
	[CompetitorId] [int] NOT NULL,
	[CompetitionId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Entries] PRIMARY KEY CLUSTERED 
(
	[EntryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_CompetitionId] ON [dbo].[Entries] 
(
	[CompetitionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_CompetitorId] ON [dbo].[Entries] 
(
	[CompetitorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Catches]    Script Date: 05/17/2016 09:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catches](
	[CatchId] [int] IDENTITY(1,1) NOT NULL,
	[Cleaned] [bit] NOT NULL,
	[EntryId] [int] NOT NULL,
	[FishId] [int] NOT NULL,
	[Length] [int] NOT NULL,
	[Recordered] [datetime] NOT NULL,
	[Weight] [float] NOT NULL,
 CONSTRAINT [PK_dbo.Catches] PRIMARY KEY CLUSTERED 
(
	[CatchId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_EntryId] ON [dbo].[Catches] 
(
	[EntryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_FishRuleId] ON [dbo].[Catches] 
(
	[FishId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_dbo.Seasons_dbo.Clubs_ClubId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Seasons]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Seasons_dbo.Clubs_ClubId] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Clubs] ([ClubId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Seasons] CHECK CONSTRAINT [FK_dbo.Seasons_dbo.Clubs_ClubId]
GO
/****** Object:  ForeignKey [FK_FishEnvironments_Environments]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[FishEnvironments]  WITH CHECK ADD  CONSTRAINT [FK_FishEnvironments_Environments] FOREIGN KEY([EnvironmentId])
REFERENCES [dbo].[Environments] ([EnvironmentId])
GO
ALTER TABLE [dbo].[FishEnvironments] CHECK CONSTRAINT [FK_FishEnvironments_Environments]
GO
/****** Object:  ForeignKey [FK_FishEnvironments_Fish]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[FishEnvironments]  WITH CHECK ADD  CONSTRAINT [FK_FishEnvironments_Fish] FOREIGN KEY([FishId])
REFERENCES [dbo].[Fish] ([FishId])
GO
ALTER TABLE [dbo].[FishEnvironments] CHECK CONSTRAINT [FK_FishEnvironments_Fish]
GO
/****** Object:  ForeignKey [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
/****** Object:  ForeignKey [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_Competitors_AspNetUsers]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Competitors]  WITH CHECK ADD  CONSTRAINT [FK_Competitors_AspNetUsers] FOREIGN KEY([AspNetUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Competitors] CHECK CONSTRAINT [FK_Competitors_AspNetUsers]
GO
/****** Object:  ForeignKey [FK_dbo.Competitors_dbo.Clubs_ClubId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Competitors]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Competitors_dbo.Clubs_ClubId] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Clubs] ([ClubId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Competitors] CHECK CONSTRAINT [FK_dbo.Competitors_dbo.Clubs_ClubId]
GO
/****** Object:  ForeignKey [FK_Competitions_Competitors]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Competitions]  WITH CHECK ADD  CONSTRAINT [FK_Competitions_Competitors] FOREIGN KEY([TripCaptainId])
REFERENCES [dbo].[Competitors] ([CompetitorId])
GO
ALTER TABLE [dbo].[Competitions] CHECK CONSTRAINT [FK_Competitions_Competitors]
GO
/****** Object:  ForeignKey [FK_Competitions_Competitors1]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Competitions]  WITH CHECK ADD  CONSTRAINT [FK_Competitions_Competitors1] FOREIGN KEY([Referee1Id])
REFERENCES [dbo].[Competitors] ([CompetitorId])
GO
ALTER TABLE [dbo].[Competitions] CHECK CONSTRAINT [FK_Competitions_Competitors1]
GO
/****** Object:  ForeignKey [FK_Competitions_Competitors2]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Competitions]  WITH CHECK ADD  CONSTRAINT [FK_Competitions_Competitors2] FOREIGN KEY([Referee2Id])
REFERENCES [dbo].[Competitors] ([CompetitorId])
GO
ALTER TABLE [dbo].[Competitions] CHECK CONSTRAINT [FK_Competitions_Competitors2]
GO
/****** Object:  ForeignKey [FK_dbo.Entries_dbo.Competitions_CompetitionId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Entries_dbo.Competitions_CompetitionId] FOREIGN KEY([CompetitionId])
REFERENCES [dbo].[Competitions] ([CompetitionId])
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_dbo.Entries_dbo.Competitions_CompetitionId]
GO
/****** Object:  ForeignKey [FK_dbo.Entries_dbo.Competitors_CompetitorId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Entries_dbo.Competitors_CompetitorId] FOREIGN KEY([CompetitorId])
REFERENCES [dbo].[Competitors] ([CompetitorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_dbo.Entries_dbo.Competitors_CompetitorId]
GO
/****** Object:  ForeignKey [FK_Catches_Fish]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Catches]  WITH CHECK ADD  CONSTRAINT [FK_Catches_Fish] FOREIGN KEY([FishId])
REFERENCES [dbo].[Fish] ([FishId])
GO
ALTER TABLE [dbo].[Catches] CHECK CONSTRAINT [FK_Catches_Fish]
GO
/****** Object:  ForeignKey [FK_dbo.Catches_dbo.Entries_EntryId]    Script Date: 05/17/2016 09:16:52 ******/
ALTER TABLE [dbo].[Catches]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Catches_dbo.Entries_EntryId] FOREIGN KEY([EntryId])
REFERENCES [dbo].[Entries] ([EntryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Catches] CHECK CONSTRAINT [FK_dbo.Catches_dbo.Entries_EntryId]
GO
