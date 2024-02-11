--1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).
--Select D.Titulo , D.FechaLanzamiento , E.Descripcion  from DISCOS D , ESTILOS E WHERE D.IdEstilo = E.Id
--Select * From DISCOS

--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco. 

--Insert into ESTILOS values('Jazz')
--Select * from ESTILOS

--Select * from TIPOSEDICION
--Insert into TIPOSEDICION values ('Digital')

--3. Insertar al menos dos discos nuevos cargando correctamente su información.
--Insert into DISCOS values ('Esquina del infinito',01/01/2000 , 12 , 'https://lastfm.freetls.fastly.net/i/u/ar0/7878928fe1b762957eb6f0dd87211302.jpg',3,2)
--Insert into DISCOS values ('Despedazado por mil partes',01/01/1996 , 11 , 'https://lastfm.freetls.fastly.net/i/u/avatar170s/f462592db75a4b5ffb78d3e56bf15052',3,2)
--Insert into DISCOS values ('Donde estan los ladrones',29/07/1998 , 11 , 'https://i.scdn.co/image/ab67616d0000b273bfcff1dd252b22bba16a2a5d',2,2)


--update DISCOS set FechaLanzamiento = '01-01-1996' where id = 8
--update DISCOS set FechaLanzamiento = '01-01-2000' where id = 7

--4. Actualizar al menos un disco modificando la cantidad de canciones y la fecha de lanzamiento. No te olvides del Where.
--Update DISCOS set CantidadCanciones = 10 , FechaLanzamiento = '09-10-1999' where id = 1

--5. Borrar un disco a elección.
--Delete from DISCOS where id = 1

--6. Traer todos los estilos que estén asociados a algún disco.
--Select E.Descripcion from DISCOS D , ESTILOS E Where E.Id = D.IdEstilo

--7. Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).
--Select D.Titulo , E.Descripcion , T.Descripcion from DISCOS D , ESTILOS E , TIPOSEDICION T Where E.Id = D.IdEstilo AND D.IdTipoEdicion = T.Id

--8. Traer todos los discos que contengan en su nombre la sílaba "ho".
--Select Titulo from DISCOS Where Titulo like'%ho%'