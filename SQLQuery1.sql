-- Consultas SQL

-- LEER 
--Select * from TIPOSEDICION
--Select * from DISCOS
--Select Titulo, CantidadCanciones from Discos
--Select * from ESTILOS

--Select D.Titulo, D.CantidadCanciones, E.Descripcion from DISCOS D, ESTILOS E
--where D.IdEstilo = E.Id 

--Select * from DISCOS where idEstilo = 5 AND CantidadCanciones = 11

-- ESCRIBIR
--Insert into DISCOS (Titulo, CantidadCanciones) values ('El Titulo...', 15)
--
--Insert into DISCOS values 
--('El Titulo...', GETDATE(), 10, '', 1, 2)

-- MODIFICAR
--Update ESTILOS set Descripcion = 'Country' where Id = 1 

-- ELIMINAR
--Delete from DISCOS where Id = 6