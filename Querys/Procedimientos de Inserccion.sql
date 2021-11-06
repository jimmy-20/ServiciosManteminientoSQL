--Procedimientos almacenados para editar

CREATE PROCEDURE Editar_Cliente @IdCliente int, @PNombre varchar(50), @SNombre varchar(50), @PApellido varchar(50), @SApellido varchar(50), @Telefono varchar(50)
AS
UPDATE Cliente SET
PrimerNombre = @PNombre,
SegundoNombre = @SNombre,
PrimerApellido = @PApellido,
SegundoApellido = @SApellido,
Telefono = @Telefono
WHERE
IdCliente = @IdCliente