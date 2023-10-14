INSERT INTO 
	Planeta(Planeta_Nombre, Planeta_DistanciaSol, Planeta_PeriodoOrbital, Planeta_VelocidadOrbital, Planeta_InclinacionOrbital)
VALUES
	('Mercurio',57910000, 87.97, 47.87,	7.00)
	,('Venus',	108200000, 224.70,	35.02, 3.39)
	,('Tierra',	149600000,	365.25,	29.78,	0.00)
	,('Marte',	227940000,	687.00,	24.08,	1.85)
	,('Júpiter', 778340821,	4333.6, 13.07,	1.30)

INSERT INTO 
	Satelite(Satelite_Nombre, Satelite_Excentricidad, Satelite_PeriodoOrbital, Satelite_InclinacionOrbital)
VALUES
	('Luna', 0.0549, 27.32, 5.15)
	,('Io', 0.0041, 1.77, 0.04 )
	,('Europa', 0.0094, 3.55, 0.47)
	,('Ganimedes', 0.0013, 7.16, 0.20)
	,('Calisto', 0.0074, 16.69, 0.28)

INSERT INTO
	Planetario(Planetario_Nombre)
VALUES
	('Planetario Wonder')


INSERT INTO
	PlanetarioSatelites(PlanetarioSatelites_PlanetarioId, PlanetarioSatelites_SateliteId)
VALUES
	(1,1)
	,(1,3)