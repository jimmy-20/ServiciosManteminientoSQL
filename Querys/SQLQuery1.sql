--Procedimiento almacenado de cambio de Estado
ALTER PROCEDURE Cambiar_Estado @IdCliente int
AS

if exists(SELECT
    *
    FROM
    Cliente
    where IdCliente = @IdCliente and Estado = 'Habilitado'
    )
UPDATE Cliente SET
Estado = 'Deshabilitado'
WHERE IdCliente = @IdCliente
ELSE
UPDATE Cliente SET
Estado = 'Habilitado'
WHERE IdCliente = @IdCliente

SELECT * FROM Cliente