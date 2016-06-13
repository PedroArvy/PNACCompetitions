
USE [PNACCompetitions]
GO
/****** Object:  Schema [PNAC]    Script Date: 06/14/2016 09:23:35 ******/
CREATE SCHEMA [PNAC] AUTHORIZATION [dbo]
GO
/****** Object:  Table [dbo].[Fish]    Script Date: 06/14/2016 09:23:36 ******/
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
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (97, N'Brown trout', 30, 140, 1)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (98, N'Rainbow trout', 30, 140, 1)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (99, N'Murray cod', 20, 200, 2)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (100, N'Bream', 28, 45, 1)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (101, N'Gummy Shark', 50, 200, 3)
INSERT [dbo].[Fish] ([FishId], [Name], [Minimum], [Maximum], [Difficulty]) VALUES (102, N'Redfin', 25, 60, 1)
SET IDENTITY_INSERT [dbo].[Fish] OFF
/****** Object:  Table [dbo].[Excel]    Script Date: 06/14/2016 09:23:36 ******/
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
/****** Object:  Table [dbo].[Environments]    Script Date: 06/14/2016 09:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Environments](
	[EnvironmentId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Order] [int] NOT NULL,
 CONSTRAINT [PK_Environments] PRIMARY KEY CLUSTERED 
(
	[EnvironmentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Environments] ON
INSERT [dbo].[Environments] ([EnvironmentId], [Name], [Order]) VALUES (1, N'Freshwater', 1)
INSERT [dbo].[Environments] ([EnvironmentId], [Name], [Order]) VALUES (2, N'Estuary', 3)
INSERT [dbo].[Environments] ([EnvironmentId], [Name], [Order]) VALUES (3, N'Saltwater', 2)
SET IDENTITY_INSERT [dbo].[Environments] OFF
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 06/14/2016 09:23:36 ******/
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
/****** Object:  Table [dbo].[Clubs]    Script Date: 06/14/2016 09:23:36 ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 06/14/2016 09:23:36 ******/
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
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c06b21c7-36b0-49a5-8763-c11e1a4f8efb', N'peter.antonello@gmail.com', 0, N'ACRN+YCb82Rc9JiscZmbbU0RAo8qOwF4ndPASGQin923wdel9dwVpPOjHd+/LDojcg==', N'9cb2065f-cfa9-49ad-bc8f-702d7fe0c30a', NULL, 0, 0, NULL, 1, 0, N'peter.antonello@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dcdf6c92-5dd8-499a-8b7d-7bb919e27632', N'petras.surna@yart.com.au', 0, N'ACq839IoTFJYsWx+yy3waQoYMaZvt9ztsn8wpq9J6qD6x8hX6NF5hRJlh62NElp6dA==', N'e76113f8-3528-4a61-8eb8-7a59268ed4ff', NULL, 0, 0, NULL, 1, 0, N'petras.surna@yart.com.au')
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 06/14/2016 09:23:36 ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 06/14/2016 09:23:36 ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 06/14/2016 09:23:36 ******/
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
/****** Object:  Table [dbo].[Competitors]    Script Date: 06/14/2016 09:23:36 ******/
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
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (625, 3, 1, 24, N'Gordon', N'McDonald', N'Flash', NULL, 0, 0, N'Pascoe Vale', NULL, N'0414 713 693', N'mactrac@hotmail.com')
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
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (727, 1, 1, 24, N'Anthony', N'Francis', NULL, NULL, 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[Competitors] ([CompetitorId], [CompetitorType], [Gender], [ClubId], [FirstName], [LastName], [NickName], [AspNetUserId], [Admin], [Hide], [Suburb], [Phone], [Mobile], [Email]) VALUES (728, 1, 1, 24, N'C', N'Scott', NULL, NULL, 0, 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Competitors] OFF
/****** Object:  Table [dbo].[Competitions]    Script Date: 06/14/2016 09:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Competitions](
	[CompetitionId] [int] IDENTITY(1,1) NOT NULL,
	[ClubId] [int] NOT NULL,
	[EnvironmentId] [int] NOT NULL,
	[End] [datetime] NULL,
	[Name] [varchar](100) NULL,
	[Start] [datetime] NOT NULL,
	[Venue] [varchar](100) NOT NULL,
	[WeighInTime] [datetime] NULL,
	[WeighInVenue] [varchar](1000) NULL,
	[DayType] [char](1) NOT NULL,
	[GoAnywhere] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Competitions] PRIMARY KEY CLUSTERED 
(
	[CompetitionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Competitions] ON
INSERT [dbo].[Competitions] ([CompetitionId], [ClubId], [EnvironmentId], [End], [Name], [Start], [Venue], [WeighInTime], [WeighInVenue], [DayType], [GoAnywhere]) VALUES (21, 24, 1, CAST(0x0000A5F3011826C0 AS DateTime), N'Anazac weekend', CAST(0x0000A5F10062E080 AS DateTime), N'Lake Fyans', CAST(0x0000A5D40107AC00 AS DateTime), N'At the shed', N'm', 0)
SET IDENTITY_INSERT [dbo].[Competitions] OFF
/****** Object:  Table [dbo].[Seasons]    Script Date: 06/14/2016 09:23:36 ******/
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
SET IDENTITY_INSERT [dbo].[Seasons] ON
INSERT [dbo].[Seasons] ([SeasonId], [ClubId], [End], [Start]) VALUES (142, 24, CAST(0x0000A67800000000 AS DateTime), CAST(0x0000A50A00000000 AS DateTime))
INSERT [dbo].[Seasons] ([SeasonId], [ClubId], [End], [Start]) VALUES (143, 24, CAST(0x0000A7E500000000 AS DateTime), CAST(0x0000A67800000000 AS DateTime))
INSERT [dbo].[Seasons] ([SeasonId], [ClubId], [End], [Start]) VALUES (144, 24, CAST(0x0000A95200000000 AS DateTime), CAST(0x0000A7E500000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[Seasons] OFF
/****** Object:  Table [dbo].[FishEnvironments]    Script Date: 06/14/2016 09:23:36 ******/
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
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (97, 1)
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (98, 1)
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (99, 1)
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (100, 2)
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (100, 3)
INSERT [dbo].[FishEnvironments] ([FishId], [EnvironmentId]) VALUES (102, 1)
/****** Object:  Table [dbo].[Entries]    Script Date: 06/14/2016 09:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entries](
	[EntryId] [int] IDENTITY(1,1) NOT NULL,
	[CompetitorId] [int] NOT NULL,
	[CompetitionId] [int] NOT NULL,
	[IsTripCaptain] [bit] NOT NULL,
	[IsReferee] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Entries] PRIMARY KEY CLUSTERED 
(
	[EntryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Entries] ON
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (103, 576, 21, 0, 0)
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (104, 664, 21, 0, 0)
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (105, 551, 21, 0, 0)
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (106, 625, 21, 0, 0)
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (107, 557, 21, 0, 0)
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (108, 617, 21, 0, 0)
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (109, 619, 21, 0, 0)
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (111, 727, 21, 0, 0)
INSERT [dbo].[Entries] ([EntryId], [CompetitorId], [CompetitionId], [IsTripCaptain], [IsReferee]) VALUES (112, 728, 21, 0, 0)
SET IDENTITY_INSERT [dbo].[Entries] OFF
/****** Object:  Table [dbo].[Catches]    Script Date: 06/14/2016 09:23:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catches](
	[CatchId] [int] IDENTITY(1,1) NOT NULL,
	[EntryId] [int] NOT NULL,
	[FishId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[CatchAndRelease] [bit] NOT NULL,
	[Number] [int] NOT NULL,
	[Weight] [float] NOT NULL,
	[Length] [int] NOT NULL,
	[Heaviest] [float] NOT NULL,
	[Longest] [int] NOT NULL,
	[Cleaned] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.Catches] PRIMARY KEY CLUSTERED 
(
	[CatchId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If Number is 1, the weight of this fish' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catches', @level2type=N'COLUMN',@level2name=N'Weight'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If Number is 1, the length of this fish' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catches', @level2type=N'COLUMN',@level2name=N'Length'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If Number is 1, the weight of the heaviest fish' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catches', @level2type=N'COLUMN',@level2name=N'Heaviest'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If Number is greater than 1, the longest fish' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Catches', @level2type=N'COLUMN',@level2name=N'Longest'
GO
SET IDENTITY_INSERT [dbo].[Catches] ON
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (3, 103, 97, CAST(0x0000A5F100000000 AS DateTime), 0, 1, 0.845, 44, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (4, 109, 97, CAST(0x0000A5F100000000 AS DateTime), 0, 1, 1.545, 56, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (5, 112, 97, CAST(0x0000A5F100000000 AS DateTime), 0, 1, 0.615, 42, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (6, 111, 97, CAST(0x0000A5F100000000 AS DateTime), 0, 1, 0.555, 41, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (7, 111, 98, CAST(0x0000A5F100000000 AS DateTime), 0, 1, 0, 46, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (8, 104, 102, CAST(0x0000A5F100000000 AS DateTime), 1, 1, 0, 36, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (9, 107, 102, CAST(0x0000A5F100000000 AS DateTime), 0, 1, 0.6, 36, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (10, 109, 102, CAST(0x0000A5F100000000 AS DateTime), 0, 1, 0.4, 33, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (11, 103, 97, CAST(0x0000A5F200000000 AS DateTime), 0, 1, 0.515, 39, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (12, 104, 97, CAST(0x0000A5F200000000 AS DateTime), 1, 1, 0, 54, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (13, 105, 97, CAST(0x0000A5F200000000 AS DateTime), 1, 1, 0, 42, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (14, 106, 97, CAST(0x0000A5F200000000 AS DateTime), 0, 1, 0.71, 41, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (15, 108, 97, CAST(0x0000A5F200000000 AS DateTime), 1, 1, 0, 48, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (16, 108, 97, CAST(0x0000A5F200000000 AS DateTime), 1, 1, 0, 43, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (17, 109, 97, CAST(0x0000A5F200000000 AS DateTime), 0, 1, 0.665, 42, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (18, 108, 98, CAST(0x0000A5F200000000 AS DateTime), 1, 1, 0, 36, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (19, 104, 97, CAST(0x0000A5F300000000 AS DateTime), 1, 1, 0, 42, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (20, 105, 102, CAST(0x0000A5F300000000 AS DateTime), 0, 1, 0.455, 33, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (21, 106, 98, CAST(0x0000A5F300000000 AS DateTime), 0, 1, 0.75, 46, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (22, 112, 98, CAST(0x0000A5F300000000 AS DateTime), 0, 1, 0, 39, 0, 0, 1)
INSERT [dbo].[Catches] ([CatchId], [EntryId], [FishId], [Date], [CatchAndRelease], [Number], [Weight], [Length], [Heaviest], [Longest], [Cleaned]) VALUES (23, 112, 102, CAST(0x0000A5F300000000 AS DateTime), 0, 1, 0, 31, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[Catches] OFF
/****** Object:  ForeignKey [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
/****** Object:  ForeignKey [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
/****** Object:  ForeignKey [FK_Competitors_AspNetUsers]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[Competitors]  WITH CHECK ADD  CONSTRAINT [FK_Competitors_AspNetUsers] FOREIGN KEY([AspNetUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Competitors] CHECK CONSTRAINT [FK_Competitors_AspNetUsers]
GO
/****** Object:  ForeignKey [FK_dbo.Competitors_dbo.Clubs_ClubId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[Competitors]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Competitors_dbo.Clubs_ClubId] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Clubs] ([ClubId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Competitors] CHECK CONSTRAINT [FK_dbo.Competitors_dbo.Clubs_ClubId]
GO
/****** Object:  ForeignKey [FK_Competitions_Environments]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[Competitions]  WITH CHECK ADD  CONSTRAINT [FK_Competitions_Environments] FOREIGN KEY([EnvironmentId])
REFERENCES [dbo].[Environments] ([EnvironmentId])
GO
ALTER TABLE [dbo].[Competitions] CHECK CONSTRAINT [FK_Competitions_Environments]
GO
/****** Object:  ForeignKey [FK_dbo.Seasons_dbo.Clubs_ClubId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[Seasons]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Seasons_dbo.Clubs_ClubId] FOREIGN KEY([ClubId])
REFERENCES [dbo].[Clubs] ([ClubId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Seasons] CHECK CONSTRAINT [FK_dbo.Seasons_dbo.Clubs_ClubId]
GO
/****** Object:  ForeignKey [FK_FishEnvironments_Environments]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[FishEnvironments]  WITH CHECK ADD  CONSTRAINT [FK_FishEnvironments_Environments] FOREIGN KEY([EnvironmentId])
REFERENCES [dbo].[Environments] ([EnvironmentId])
GO
ALTER TABLE [dbo].[FishEnvironments] CHECK CONSTRAINT [FK_FishEnvironments_Environments]
GO
/****** Object:  ForeignKey [FK_FishEnvironments_Fish]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[FishEnvironments]  WITH CHECK ADD  CONSTRAINT [FK_FishEnvironments_Fish] FOREIGN KEY([FishId])
REFERENCES [dbo].[Fish] ([FishId])
GO
ALTER TABLE [dbo].[FishEnvironments] CHECK CONSTRAINT [FK_FishEnvironments_Fish]
GO
/****** Object:  ForeignKey [FK_dbo.Entries_dbo.Competitions_CompetitionId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Entries_dbo.Competitions_CompetitionId] FOREIGN KEY([CompetitionId])
REFERENCES [dbo].[Competitions] ([CompetitionId])
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_dbo.Entries_dbo.Competitions_CompetitionId]
GO
/****** Object:  ForeignKey [FK_dbo.Entries_dbo.Competitors_CompetitorId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[Entries]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Entries_dbo.Competitors_CompetitorId] FOREIGN KEY([CompetitorId])
REFERENCES [dbo].[Competitors] ([CompetitorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Entries] CHECK CONSTRAINT [FK_dbo.Entries_dbo.Competitors_CompetitorId]
GO
/****** Object:  ForeignKey [FK_Catches_Fish]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[Catches]  WITH CHECK ADD  CONSTRAINT [FK_Catches_Fish] FOREIGN KEY([FishId])
REFERENCES [dbo].[Fish] ([FishId])
GO
ALTER TABLE [dbo].[Catches] CHECK CONSTRAINT [FK_Catches_Fish]
GO
/****** Object:  ForeignKey [FK_dbo.Catches_dbo.Entries_EntryId]    Script Date: 06/14/2016 09:23:36 ******/
ALTER TABLE [dbo].[Catches]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Catches_dbo.Entries_EntryId] FOREIGN KEY([EntryId])
REFERENCES [dbo].[Entries] ([EntryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Catches] CHECK CONSTRAINT [FK_dbo.Catches_dbo.Entries_EntryId]
GO
