SELECT TOP (1000) [Id]
      ,[Codigo]
      ,[Nombre]
      ,[Descripcion]
      ,[IdMarca]
      ,[IdCategoria]
      ,[ImagenUrl]
      ,[Precio]
  FROM [CATALOGO_DB].[dbo].[ARTICULOS]


Delete From ARTICULOS where Id = 7

select Codigo , Nombre, Descripcion ,ImagenUrl, Precio , M.Descripcion  Marca, C.Descripcion Categoria, A.IdCategoria,A.IdMarca , A.Id  from ARTICULOS A , MARCAS M , CATEGORIAS C  where M.Id = A.IdMarca AND C.Id = A.IdCategoria;

  Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1  