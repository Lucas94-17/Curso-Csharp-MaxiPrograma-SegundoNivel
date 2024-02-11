--Select * From ELEMENTOS

--Select * From POKEMONS

--Select Numero, Nombre , P.Descripcion,UrlImagen , E.Descripcion as Tipo , D.Descripcion from POKEMONS P, ELEMENTOS E , ELEMENTOS D Where E.Id = P.IdTipo AND D.Id = P.IdDebilidad

