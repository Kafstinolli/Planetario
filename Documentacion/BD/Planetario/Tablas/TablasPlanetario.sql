CREATE DATABASE Planetario

USE Planetario

CREATE TABLE Planetario
(
	Planetario_Id INT IDENTITY(1,1)
	,Planetario_Nombre VARCHAR(60) NOT NULL

	,PRIMARY KEY (Planetario_Id)
)

CREATE TABLE Satelite
(
	Satelite_Id INT IDENTITY(1,1)
	,Satelite_Nombre VARCHAR(150) NOT NULL
	,Satelite_Excentricidad FLOAT
	,Satelite_PeriodoOrbital FLOAT
	,Satelite_InclinacionOrbital FLOAT

	,PRIMARY KEY (Satelite_Id)
)

CREATE TABLE Planeta
(
	Planeta_Id INT IDENTITY (1,1)
	,Planeta_Nombre VARCHAR(150) NOT NULL
	,Planeta_DistanciaSol FLOAT
	,Planeta_PeriodoOrbital FLOAT
	,Planeta_VelocidadOrbital FLOAT
	,Planeta_InclinacionOrbital FLOAT

	,PRIMARY KEY (Planeta_Id)
)

CREATE TABLE PlanetarioPlanetas
(
	PlanetarioPlanetas_Id INT IDENTITY(1,1)
	,PlanetarioPlanetas_PlanetarioId INT NOT NULL
	,PlanetarioPlanetas_PlanetaId INT NOT NULL

	,PRIMARY KEY (PlanetarioPlanetas_Id)
	,CONSTRAINT FK_PlanetarioPlanetas_PlanetarioId FOREIGN KEY (PlanetarioPlanetas_PlanetarioId) REFERENCES Planetario (Planetario_Id)
	,CONSTRAINT FK_PlanetarioPlanetas_PlanetaId FOREIGN KEY (PlanetarioPlanetas_PlanetaId) REFERENCES Planeta (Planeta_Id)
)

CREATE TABLE PlanetarioSatelites
(
	PlanetarioSatelites_Id INT IDENTITY(1,1)
	,PlanetarioSatelites_PlanetarioId INT NOT NULL
	,PlanetarioSatelites_SateliteId INT NOT NULL

	,PRIMARY KEY (PlanetarioSatelites_Id)
	,CONSTRAINT FK_PlanetarioSatelites_PlanetarioId FOREIGN KEY (PlanetarioSatelites_PlanetarioId) REFERENCES Planetario (Planetario_Id)
	,CONSTRAINT PlanetarioSatelites_SateliteId FOREIGN KEY (PlanetarioSatelites_SateliteId) REFERENCES Satelite (Satelite_Id)
)