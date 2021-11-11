CREATE LOGIN Administrador with password 'Admin123'

USE Servicios_Mantenimiento

sp_adduser Administrador, Administrador
sp_addrolemember db_owner,Administrador


-------------------------------------------------
CREATE TABLE Usuario(
IdUsuario int primary key identity(1,1),
NombreUsuario varchar(50),
Contrasena varchar(50),
Rol varchar(50),
Estado varchar(50)
)

--NOTA: Cada vez que se hace un respaldo de la base de datos, crear un login y usuario si nos encontramos en otra PC