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

CREATE PROCEDURE Editar_Vehiculo @IdVehiculo int, @IdCliente int, @Marca varchar(50), @Modelo varchar(50),@Año int
AS
UPDATE Vehiculo SET
IdCliente = @IdCliente,
Marca = @Marca,
Modelo = @Modelo,
Año = @Año
WHERE
IdVehiculo = @IdVehiculo

CREATE PROCEDURE Editar_Servicio @IdServicio int,@Descripcion varchar(50),@Precio decimal, @TipoMantenimiento varchar(20)
AS
UPDATE Servicio SET
Descripcion = @Descripcion,
Precio = @Precio,
TipoMantenimiento = @TipoMantenimiento
WHERE 
IdServicio = @IdServicio

CREATE PROCEDURE Editar_Repuesto @IdRepuesto int, @Descripcion varchar(50), @Marca varchar(50), @Modelo varchar(50), @Precio decimal, @Cantidad int
AS
UPDATE Repuesto SET
Descripcion = @Descripcion,
Marca = @Marca,
Modelo = @Modelo,
Precio = @Precio,
Cantidad = @Cantidad
WHERE 
IdRepuesto = @IdRepuesto

