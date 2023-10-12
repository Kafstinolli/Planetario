CREATE DATABASE Planetario;

CREATE DATABASE ViajesEspaciales;

USE Planetario

CREATE TABLE Planetario
(
	Planetario_Id INT PRIMARY KEY IDENTITY(1,1)
	,Planetario_Nombre VARCHAR(60) NOT NULL
)

CREATE TABLE Satelite
(
	Satelite_Id INT PRIMARY KEY IDENTITY(1,1)
	,Satelite_Nombre VARCHAR(150) NOT NULL
	,Satelite_Excentricidad FLOAT
	,Satelite_PeriodoOrbital FLOAT
	,Satelite_InclinacionOrbital FLOAT
)

CREATE TABLE Planeta
(
	Planeta_Id INT PRIMARY KEY IDENTITY (1,1)
	,Planeta_Nombre VARCHAR(150) NOT NULL
	,Planeta_DistanciaSol FLOAT
	,Planeta_PeriodoOrbital FLOAT
	,Planeta_VelocidadOrbital FLOAT
	,Planeta_InclinacionOrbital FLOAT
)

CREATE TABLE PlanetarioPlanetas
(
	PlanetarioPlanetas_Id INT PRIMARY KEY IDENTITY(1,1)
	,PlanetarioPlanetas_PlanetarioId INT NOT NULL
	,PlanetarioPlanetas_PlanetaId INT NOT NULL

	,FOREIGN KEY (PlanetarioPlanetas_PlanetarioId) REFERENCES Planetario (Planetario_Id)
	,FOREIGN KEY (PlanetarioPlanetas_PlanetaId) REFERENCES Planeta (Planeta_Id)
)

CREATE TABLE PlanetarioSatelites
(
	PlanetarioSatelites_Id INT PRIMARY KEY IDENTITY(1,1)
	,PlanetarioSatelites_PlanetarioId INT NOT NULL
	,PlanetarioSatelites_SateliteId INT NOT NULL

	,FOREIGN KEY (PlanetarioSatelites_PlanetarioId) REFERENCES Planetario (Planetario_Id)
	,FOREIGN KEY (PlanetarioSatelites_SateliteId) REFERENCES Satelite (Satelite_Id)
)