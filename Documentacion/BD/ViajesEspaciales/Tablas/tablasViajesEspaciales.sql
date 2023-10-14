CREATE DATABASE ViajesEspaciales

USE ViajesEspaciales

CREATE TABLE Profesion
(
	Profesion_Id INT PRIMARY KEY IDENTITY(1,1)
	,Profesion_Nombre VARCHAR(60) NOT NULL
)

CREATE TABLE Astronauta
(
	Astronauta_Id INT PRIMARY KEY IDENTITY(1,1)
	,Astronauta_Nombre VARCHAR(150) NOT NULL
	,Astronauta_ProfesionId INT NOT NULL

	,FOREIGN KEY (Astronauta_ProfesionId)  REFERENCES Profesion (Profesion_Id)
)

CREATE TABLE Objetivo
(
	Objetivo_Id INT PRIMARY KEY IDENTITY(1,1)
	,Objetivo_Nombre VARCHAR(150) NOT NULL
)

CREATE TABLE Mision
(
	Mision_Id INT PRIMARY KEY IDENTITY(1,1)
	,Mision_Nombre VARCHAR(150) NOT NULL
	,Mision_Fecha DATETIME NOT NULL
	,Mision_AstronautaId INT NOT NULL
	,Mision_ObjetivoId INT NOT NULL

	,FOREIGN KEY (Mision_AstronautaId) REFERENCES Astronauta (Astronauta_Id)
	,FOREIGN KEY (Mision_ObjetivoId) REFERENCES Objetivo (Objetivo_Id)
)

SELECT * FROM Profesion