SELECT TOP (1000) [Id]
      ,[Descripcion]
  FROM [POKEDEX_DB].[dbo].[ELEMENTOS]


  Select Numero, Nombre , P.Descripcion,UrlImagen , E.Descripcion as Tipo , D.Descripcion as Debilidad , P.IdTipo, P.IdDebilidad,P.Id
  from POKEMONS P, ELEMENTOS E , ELEMENTOS D
  Where E.Id = P.IdTipo 
  AND D.Id = P.IdDebilidad 
  AND P.Activo = 1
  AND Nombre like '%%'

  delete from ELEMENTOS where Id = 7
  insert into ELEMENTOS (Descripcion) values('Luchador')