CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[States](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CountryId] [int] NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[StateId] [int] NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[BornDate] [datetime] NOT NULL,
	[Salary] [decimal](10, 2) NOT NULL,
	[CityId] [int] NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE People ADD CONSTRAINT FK_People_Cities FOREIGN KEY(CityId) REFERENCES Cities;
ALTER TABLE Cities ADD CONSTRAINT FK_Cities_States FOREIGN KEY(StateId) REFERENCES States;
ALTER TABLE States ADD CONSTRAINT FK_States_Countries FOREIGN KEY(CountryId) REFERENCES Countries;

INSERT INTO Countries(Name) VALUES('Argentina');
INSERT INTO Countries(Name) VALUES('Brasil');
INSERT INTO Countries(Name) VALUES('Noruega');
INSERT INTO Countries(Name) VALUES('Chile');
INSERT INTO Countries(Name) VALUES('Venezuela');

INSERT INTO States(Name, CountryId) SELECT 'Tucumán', Id FROM Countries WHERE Name='Argentina';
INSERT INTO States(Name, CountryId) SELECT 'Santiago del Estero', Id FROM Countries WHERE Name='Argentina';
INSERT INTO States(Name, CountryId) SELECT 'Buenos Aires', Id FROM Countries WHERE Name='Argentina';
INSERT INTO States(Name, CountryId) SELECT 'Falcón', Id FROM Countries WHERE Name='Venezuela';
INSERT INTO States(Name, CountryId) SELECT 'Barquisimeto', Id FROM Countries WHERE Name='Venezuela';
INSERT INTO States(Name, CountryId) SELECT 'Capital Federal', Id FROM Countries WHERE Name='Venezuela';

INSERT INTO Cities(Name, StateId) SELECT 'San Miguel de Tucumán', Id FROM States WHERE Name='Tucumán';
INSERT INTO Cities(Name, StateId) SELECT 'Alderetes', Id FROM States WHERE Name='Tucumán';
INSERT INTO Cities(Name, StateId) SELECT 'Banda del Río Salí', Id FROM States WHERE Name='Tucumán';
INSERT INTO Cities(Name, StateId) SELECT 'Concepción', Id FROM States WHERE Name='Tucumán';
INSERT INTO Cities(Name, StateId) SELECT 'San Ana de Coro', Id FROM States WHERE Name='Falcón';
INSERT INTO Cities(Name, StateId) SELECT 'Punto Fijo', Id FROM States WHERE Name='Falcón';
INSERT INTO Cities(Name, StateId) SELECT 'Cumarebo', Id FROM States WHERE Name='Falcón';
INSERT INTO Cities(Name, StateId) SELECT 'Mene Mauroa', Id FROM States WHERE Name='Falcón';

INSERT INTO People(FullName, BornDate, Salary, CityId) SELECT 'Carlos Navarro', '1978-10-05', 25750, Id FROM Cities WHERE Name='San Miguel de Tucumán';
INSERT INTO People(FullName, BornDate, Salary, CityId) SELECT 'José Quinteros', '1971-08-10', 27500, Id FROM Cities WHERE Name='Alderetes';
INSERT INTO People(FullName, BornDate, Salary, CityId) SELECT 'Carolina González', '1973-07-03', 28300, Id FROM Cities WHERE Name='Banda del Río Salí';
INSERT INTO People(FullName, BornDate, Salary, CityId) SELECT 'Agustina Lizarraga', '1972-06-09', 26800, Id FROM Cities WHERE Name='Concepción';

CREATE TABLE VehicleClasses(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(50)
)
GO

CREATE TABLE VehicleBrands(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(50)
)
GO

CREATE TABLE VehicleModels(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(50),
	VehicleBrandId INT,
	VehicleClassId INT
)
GO

CREATE TABLE VehicleStatus(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(50)
)
GO

CREATE TABLE Vehicles(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	LicenseNumber NVARCHAR(10),
	PurchaseDate DATETIME,
	OdometerValue INT,
	VehicleModelId INT,
	VehicleStatusId INT
)
GO

ALTER TABLE VehicleModels ADD CONSTRAINT FK_VehicleModels_VehicleBrands FOREIGN KEY(VehicleBrandId) REFERENCES VehicleBrands;
ALTER TABLE VehicleModels ADD CONSTRAINT FK_VehicleModels_VehicleClasses FOREIGN KEY(VehicleClassId) REFERENCES VehicleClasses;
ALTER TABLE Vehicles ADD CONSTRAINT FK_Vehicles_VehicleModels FOREIGN KEY(VehicleModelId) REFERENCES VehicleModels;
ALTER TABLE Vehicles ADD CONSTRAINT FK_Vehicles_VehicleStatus FOREIGN KEY(VehicleStatusId) REFERENCES VehicleStatus;

INSERT INTO VehicleClasses(Name) VALUES('Alta');
INSERT INTO VehicleClasses(Name) VALUES('Mediana');
INSERT INTO VehicleClasses(Name) VALUES('Baja');

INSERT INTO VehicleBrands(Name) VALUES('Ford');
INSERT INTO VehicleBrands(Name) VALUES('Peugeot');
INSERT INTO VehicleBrands(Name) VALUES('Fiat');

INSERT INTO VehicleModels(Name, VehicleBrandId, VehicleClassId) SELECT 'Fiesta', vb.Id, vc.Id FROM VehicleBrands vb, VehicleClasses vc WHERE vb.Name='Ford' AND vc.Name='Mediana';
INSERT INTO VehicleModels(Name, VehicleBrandId, VehicleClassId) SELECT '408', vb.Id, vc.Id FROM VehicleBrands vb, VehicleClasses vc WHERE vb.Name='Peugeot' AND vc.Name='Alta';
INSERT INTO VehicleModels(Name, VehicleBrandId, VehicleClassId) SELECT 'Linea', vb.Id, vc.Id FROM VehicleBrands vb, VehicleClasses vc WHERE vb.Name='Fiat' AND vc.Name='Mediana';
INSERT INTO VehicleModels(Name, VehicleBrandId, VehicleClassId) SELECT 'Mondeo', vb.Id, vc.Id FROM VehicleBrands vb, VehicleClasses vc WHERE vb.Name='Ford' AND vc.Name='Alta';
INSERT INTO VehicleModels(Name, VehicleBrandId, VehicleClassId) SELECT '308', vb.Id, vc.Id FROM VehicleBrands vb, VehicleClasses vc WHERE vb.Name='Peugeot' AND vc.Name='Mediana';
INSERT INTO VehicleModels(Name, VehicleBrandId, VehicleClassId) SELECT 'Siena', vb.Id, vc.Id FROM VehicleBrands vb, VehicleClasses vc WHERE vb.Name='Fiat' AND vc.Name='Mediana';

INSERT INTO VehicleStatus(Name) VALUES('Excelente');
INSERT INTO VehicleStatus(Name) VALUES('Muy bueno');
INSERT INTO VehicleStatus(Name) VALUES('Bueno');
INSERT INTO VehicleStatus(Name) VALUES('Malo');

INSERT INTO Vehicles(LicenseNumber, PurchaseDate, OdometerValue, VehicleModelId, VehicleStatusId)
SELECT 'PPP-00'+CAST(Id AS NVARCHAR), DATEADD(MONTH, Id, '2013-01-01'), 50000-Id*1530, Id, (SELECT MIN(Id) FROM VehicleStatus)
FROM VehicleModels



