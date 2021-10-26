CREATE PROCEDURE [dbo].[spaIngresarEstacionCarga]
	@strNombre NVARCHAR(MAX) = '',
	@numLatitud NUMERIC(18,14) = 0.0,
	@numLongitud NUMERIC(18,14) = 0.0
AS
	BEGIN
		INSERT INTO tblEstacionCarga(strNombre, numLatitud, numLongitud)
		VALUES (@strNombre, @numLatitud, @numLongitud)
	END