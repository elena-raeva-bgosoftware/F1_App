USE [F1_Web_App]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (1, N'Germany')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (2, N'France')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (3, N'Netherlands')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (4, N'Mexico')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (5, N'Monaco')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (6, N'Spain')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (7, N'United Kingdom')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (8, N'Australia')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (9, N'Singapore')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (10, N'Canada')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (11, N'Finland')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (12, N'China')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (13, N'Denmark')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (14, N'Belgium')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (15, N'Japan')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (16, N'New Zealand')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (17, N'Thailand')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (18, N'Argentina')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (19, N'USA')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (20, N'Switzerland')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (21, N'Bahrain')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (22, N'Saudi Arabia')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (23, N'Azerbaijan')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (24, N'Italy')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (25, N'Austria')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (26, N'Hungary')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (27, N'Japan')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (28, N'Qatar')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (29, N'Brazil')
GO
INSERT [dbo].[Countries] ([Id], [Name]) VALUES (30, N'UAE')
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Circuits] ON 
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (1, N'Bahrain International Circuit', 21, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto/q_auto/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Bahrain_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (2, N'Jeddah Corniche Circuit', 22, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Saudi_Arabia_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (3, N'Albert Park Circuit', 8, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_771/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Australia_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (4, N'Baku City Circuit', 23, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Baku_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (5, N'Miami International Autodrome', 19, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Miami_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (6, N'Imola Circuit', 24, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Emilia_Romagna_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (7, N'Circuit de Monaco', 5, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Monaco_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (8, N'Circuit Gilles Villeneuve', 10, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Canada_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (9, N'Red Bull Ring', 25, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Austria_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (10, N'Silverstone Circuit', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Great_Britain_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (11, N'Hungaroring', 26, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Hungary_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (12, N'Circuit de Barcelona-Catalunya', 6, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Spain_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (13, N'Circuit de Spa-Francorchamps', 14, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Belgium_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (14, N'Zandvoort Circuit', 3, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Netherlands_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (15, N'Monza Circuit', 24, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Italy_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (16, N'Marina Bay Street Circuit', 9, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Singapore_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (17, N'Suzuka International Racing Course', 27, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Japan_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (18, N'Losail International Circuit', 28, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Qatar_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (19, N'Circuit of the Americas', 19, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/USA_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (20, N'Autódromo Hermanos Rodríguez', 4, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Mexico_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (21, N'Interlagos Circuit', 29, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Brazil_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (22, N'Las Vegas Street Circuit', 19, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Las_Vegas_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (23, N'Shanghai International Circuit', 12, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/China_Circuit', 0)
GO
INSERT [dbo].[Circuits] ([Id], [Name], [CountryId], [ImageUrl], [IsLegacy]) VALUES (24, N'Yas Marina Circuit', 30, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/2018-redesign-assets/Circuit%20maps%2016x9/Abu_Dhabi_Circuit', 0)
GO
SET IDENTITY_INSERT [dbo].[Circuits] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (2, N'Red Bull Racing', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2053163352_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (3, N'Mercedes-AMG Petronas', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2055023690_16by9South')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (4, N'Ferrari', 24, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2027373349_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (5, N'McLaren', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2032675059_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (6, N'Alpine', 2, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2065862959_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (7, N'Aston Martin', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2053204844_16by9Centre')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (8, N'Haas F1 Team', 19, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2068767588_16by9North')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (9, N'Williams', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_auto,w_1320,t_16by9Centre,g_faces,ar_16:9/trackside-images/2024/F1_Grand_Prix_of_Italy___Practice/2169471457')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (10, N'RB Formula One Team', 24, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_auto,w_1320,t_16by9Centre,g_faces,ar_16:9/trackside-images/2024/F1_Grand_Prix_of_United_States/2179851387')
GO
INSERT [dbo].[Teams] ([Id], [Name], [CountryId], [ImageUrl]) VALUES (11, N'Kick Sauber', 20, N'https://media.formula1.com/image/upload/f_auto,c_limit,w_1440,q_auto/f_auto,c_fill,q_75,w_1320,g_faces,ar_16:9/content/dam/fom-website/manual/DriverAndTeamImages/2024/2047992871_16by9North')
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Events] ON 
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (1, 1, CAST(N'2024-03-02T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (2, 2, CAST(N'2024-03-09T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (3, 3, CAST(N'2024-03-24T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (4, 4, CAST(N'2024-04-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (5, 5, CAST(N'2024-04-21T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (6, 6, CAST(N'2024-05-05T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (7, 7, CAST(N'2024-05-19T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (8, 8, CAST(N'2024-05-26T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (9, 9, CAST(N'2024-06-09T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (10, 10, CAST(N'2024-06-23T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (11, 11, CAST(N'2024-06-30T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (12, 12, CAST(N'2024-07-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (13, 13, CAST(N'2024-07-21T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (14, 14, CAST(N'2024-07-28T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (15, 15, CAST(N'2024-08-25T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (16, 16, CAST(N'2024-09-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (17, 17, CAST(N'2024-09-15T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (18, 18, CAST(N'2024-09-22T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (19, 19, CAST(N'2024-10-20T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (20, 20, CAST(N'2024-10-27T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (21, 21, CAST(N'2024-11-03T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (22, 22, CAST(N'2024-11-17T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (23, 23, CAST(N'2024-12-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Events] ([Id], [CircuitId], [EventDate]) VALUES (24, 24, CAST(N'2024-12-15T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[Drivers] ON 
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (6, 1, N'Max Verstappen', 2, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/verstappen', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (8, 4, N'Lando Norris', 5, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/norris', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (9, 10, N'Pierre Gasly', 6, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/gasly', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (10, 11, N'Sergio Pérez', 2, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/perez', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (11, 14, N'Fernando Alonso', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/alonso', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (12, 16, N'Charles Leclerc', 4, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/leclerc', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (13, 18, N'Lance Stroll', 7, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/stroll', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (14, 20, N'Kevin Magnussen', 8, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/magnussen', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (15, 22, N'Yuki Tsunoda', 10, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/tsunoda', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (16, 23, N'Alexander Albon', 9, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/albon', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (17, 24, N'Guanyu Zhou', 11, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/zhou', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (18, 27, N'Nico Hülkenberg', 8, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hulkenberg', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (19, 30, N'Liam Lawson', 10, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/lawson', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (20, 31, N'Esteban Ocon', 6, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/ocon', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (21, 43, N'Franco Colapinto', 9, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_auto,w_1320/content/dam/fom-website/drivers/2024Drivers/colapinto', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (22, 44, N'Lewis Hamilton', 3, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/hamilton', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (24, 55, N'Carlos Sainz', 4, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/sainz', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (25, 63, N'George Russell', 3, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/russell', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (26, 77, N'Valtteri Bottas', 11, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/bottas', 0)
GO
INSERT [dbo].[Drivers] ([Id], [DriverNumber], [Name], [TeamId], [ImageUrl], [IsRetired]) VALUES (27, 81, N'Oscar Piastri', 5, N'https://media.formula1.com/image/upload/f_auto,c_limit,q_75,w_1320/content/dam/fom-website/drivers/2024Drivers/piastri', 0)
GO
SET IDENTITY_INSERT [dbo].[Drivers] OFF
GO
SET IDENTITY_INSERT [dbo].[Results] ON 
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (1, 25, 6, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (2, 18, 10, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (3, 15, 24, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (4, 12, 12, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (5, 10, 25, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (6, 8, 8, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (7, 6, 22, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (8, 4, 27, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (9, 2, 11, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (10, 1, 13, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (11, 0, 17, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (12, 0, 14, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (13, 0, 19, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (14, 0, 15, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (15, 0, 16, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (16, 0, 18, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (17, 0, 20, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (18, 0, 9, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (19, 0, 26, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (20, 0, 21, 1)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (21, 25, 6, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (22, 18, 10, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (23, 16, 12, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (24, 12, 27, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (25, 10, 11, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (26, 8, 25, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (27, 6, 24, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (28, 4, 8, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (29, 2, 22, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (30, 1, 18, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (31, 0, 16, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (32, 0, 14, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (33, 0, 20, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (34, 0, 19, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (35, 0, 15, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (36, 0, 21, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (37, 0, 26, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (38, 0, 17, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (39, 0, 13, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (40, 0, 9, 2)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (41, 25, 24, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (42, 19, 12, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (43, 15, 8, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (44, 12, 27, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (45, 10, 10, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (46, 8, 13, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (47, 6, 15, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (48, 4, 11, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (49, 2, 18, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (50, 1, 14, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (51, 0, 16, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (52, 0, 21, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (53, 0, 9, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (54, 0, 26, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (55, 0, 17, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (56, 0, 20, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (57, 0, 25, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (58, 0, 22, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (59, 0, 6, 3)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (60, 26, 6, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (61, 18, 10, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (62, 15, 24, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (63, 12, 12, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (64, 10, 8, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (65, 8, 11, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (66, 6, 25, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (67, 4, 27, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (68, 2, 22, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (69, 1, 15, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (70, 0, 18, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (71, 0, 13, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (72, 0, 14, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (73, 0, 26, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (74, 0, 20, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (75, 0, 9, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (76, 0, 17, 21, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (77, 0, 17, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (78, 0, 19, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (79, 0, 16, 4)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (80, 25, 6, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (81, 18, 8, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (82, 15, 10, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (83, 12, 12, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (84, 10, 24, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (85, 8, 25, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (86, 7, 11, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (87, 4, 27, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (88, 2, 22, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (89, 1, 18, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (90, 0, 20, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (91, 0, 16, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (92, 0, 9, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (93, 0, 17, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (94, 0, 13, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (95, 0, 14, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (96, 0, 21, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (97, 0, 19, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (98, 0, 15, 5)
GO
INSERT [dbo].[Results] ([Id], [Points], [DriverId], [EventId]) VALUES (99, 0, 26, 5)
GO
SET IDENTITY_INSERT [dbo].[Results] OFF
GO
