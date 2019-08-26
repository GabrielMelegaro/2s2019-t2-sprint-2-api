SELECT * FROM Estilos;

SELECT * FROM Artistas;

SELECT A.IdArtista, A.Nome, A.IdEstilo, E.Nome AS NomeEstilo FROM Artistas A INNER JOIN Estilos E ON A.IdEstilo = E.IdEstilo;

select * from Estilos for json auto




