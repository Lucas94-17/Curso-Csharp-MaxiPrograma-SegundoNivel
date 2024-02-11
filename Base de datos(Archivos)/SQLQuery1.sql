--LEER TABLA
--Select * From TIPOSEDICION
--Select * From ESTILOS
--Select Descripcion From TIPOSEDICION

--LECTURA COMBINADA

--Select Titulo , CantidadCanciones , IdEstilo From  DISCOS, ESTILOS

--FILTRO DE BUSQUEDA WHERE

--Select * From DISCOS where idestilo = 2 AND CantidadCanciones = 12
--Select D.Titulo,  D.CantidadCanciones , E.Descripcion Estilo from DISCOS D , ESTILOS E where D.IdEstilo = E.Id
--Select * from DISCOS where IdEstilo = 1
--Select * from ESTILOS

--ESCRIBIR EN UNA BASE DE DATOS

--insert into DISCOS (Titulo , CantidadCanciones) values ('El titulo...',10)
--insert into DISCOS values ('Titulo de la cancion', getdate(),20,'qweqe',1,2)

--MODIFICAR UN REGISTRO

--Update ESTILOS set Descripcion = 'Country' where id = 1

--ELIMINAR UN REGISTRO

--Delete from DISCOS where id = 4