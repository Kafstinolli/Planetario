INSERT INTO
	Profesion (Profesion_Nombre)
VALUES
	('Piloto'),('Ingeniero'),('Fisico')


INSERT INTO
	Astronauta (Astronauta_Nombre,Astronauta_ProfesionId)
VALUES
	('Alan Shepard',1),('Gus Grissom',1),('John Glenn',1),('Joseph A. Walker',2),('Virgil I.  Grissom',1),('James McDivitt',2),('Gordon Cooper',1),('Frank Borman',1),('Neil Armstrong',2),('John Young',1),('James Lovell',1),('Wally Schirra',1),('Thomas P. Stafford',1),('Charles Conrad',1),('David Scott',2)


INSERT INTO
	Objetivo (Objetivo_Nombre)
VALUES
	('Suborbital para humanos'),('Orbita terrestre'),('Vuelo suborbital humano'),('Orbita lunar'),('Aterrizaje lunar')


INSERT INTO
	Mision (Mision_Nombre,Mision_Fecha,Mision_AstronautaId,Mision_ObjetivoId)
VALUES
	('Mercury-Redstone 3','5/5/1961 00:00:00',1,1),('Mercury-Redstone 4','6/21/1961 00:00:00',2,1),('Mercury-Atlas 6','2/20/1962 00:00:00',3,2),('X-15 Flight 33','8/22/1963 00:00:00',4,3),('Gemini 3','3/23/1965 00:00:00',5,2),('Gemini 4','6/3/1965 00:00:00',6,2),('Gemini 5','8/21/1965 00:00:00',7,2)
	,('Gemini 7','12/4/1965 00:00:00',8,2),('Gemini 8','3/16/1966 00:00:00',9,2),('Gemini 10','7/8/1966 00:00:00',10,2),('Gemini 12','11/11/1966 00:00:00',11,2),('Apollo 7','10/11/1968 00:00:00',12,2),('Apollo 8','12/21/1968 00:00:00',8,4),('Apollo 9','3/3/1969 00:00:00',6,2),('Apollo 10','5/18/1969 00:00:00',13,4),
	('Apollo 11','7/16/1969 00:00:00',9,5),('Apollo 12','11/14/1969 00:00:00',14,5),('Apollo 13','4/11/1970 00:00:00',11,4),('Apollo 14','1/31/1971 00:00:00',1,5),('Apollo 15','7/26/1971 00:00:00',15,5)