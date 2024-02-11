SELECT TOP (1000) [Id]
      ,[Numero]
      ,[Nombre]
      ,[Descripcion]
      ,[UrlImagen]
      ,[IdTipo]
      ,[IdDebilidad]
      ,[IdEvolucion]
      ,[Activo]
  FROM [POKEDEX_DB].[dbo].[POKEMONS]

  Insert into POKEMONS (Numero , Nombre , Descripcion ,Activo) values (1,'','',1)

  update POKEMONS set  UrlImagen = 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/025.png' where id = 8

  select * from POKEMONS