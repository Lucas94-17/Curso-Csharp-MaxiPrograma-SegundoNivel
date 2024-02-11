SELECT TOP (1000) [Id]
      ,[Codigo]
      ,[Nombre]
      ,[Descripcion]
      ,[IdMarca]
      ,[IdCategoria]
      ,[ImagenUrl]
      ,[Precio]
  FROM [CATALOGO_DB].[dbo].[ARTICULOS]

  Select Numero, Nombre , P.Descripcion,UrlImagen , E.Descripcion as Tipo , 
  D.Descripcion as Debilidad , P.IdTipo, P.IdDebilidad,P.Id from 
  POKEMONS P, ELEMENTOS E , ELEMENTOS D 
  Where E.Id = P.IdTipo AND D.Id = P.IdDebilidad AND P.Activo = 1


  Select Id , Codigo from Articulos
  select * from ARTICULOS



Select Codigo , Nombre,A.Precio ,A.Descripcion, ImagenUrl , M.Descripcion as Marca , C.Descripcion as Categoria , A.IdCategoria, A.IdMarca , A.Id from ARTICULOS A,CATEGORIAS C , MARCAS M  WHERE M.Id = A.IdMarca AND C.Id = A.IdCategoria