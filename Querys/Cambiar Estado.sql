ALTER TABLE Servicio Add Estado varchar(50)

SELECT * FROM Servicio

UPDATE Servicio SET
Estado = 'Habilitado'

CREATE PROCEDURE Cambiar_Estado_Servicio @IdServicio int
AS
if exists (SELECT
           *
           FROM 
           Servicio
           WHERE
           IdServicio = @IdServicio and Estado = 'Habilitado'
           )
UPDATE Servicio SET
Estado = 'Deshabilitado'
WHERE 
IdServicio = @IdServicio

ELSE

UPDATE Servicio SET
Estado = 'Habilitado'
WHERE 
IdServicio = @IdServicio

