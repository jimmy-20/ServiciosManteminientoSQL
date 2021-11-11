CREATE PROCEDURE Insertar_Cliente @PNombre varchar(50), @SNombre varchar(50), @PApellido varchar(50), @SApellido varchar(50), @Telefono varchar(50)
AS
INSERT INTO Cliente VALUES (@PNombre,@SNombre,@PApellido,@SApellido,@Telefono)

CREATE PROCEDURE Insertar_Servicio @Descripcion varchar(50), @Precio decimal, @Mantenimiento varchar(50)
AS
INSERT INTO Servicio VALUES (@Descripcion, @Precio, @Mantenimiento)

CREATE PROCEDURE Insertar_Repuesto @Descripcion varchar(50), @Marca varchar(50), @Modelo varchar(50), @Cantidad int, @Precio decimal
AS
INSERT INTO Repuesto VALUES (@Descripcion, @Marca, @Modelo, @Cantidad, @Precio)

CREATE PROCEDURE Insertar_Vehiculo @IdCliente int, @Marca varchar(50), @Modelo varchar(50), @Año int 
AS
INSERT INTO Vehiculo VALUES (@IdCliente,@Marca,@Modelo,@Año)

