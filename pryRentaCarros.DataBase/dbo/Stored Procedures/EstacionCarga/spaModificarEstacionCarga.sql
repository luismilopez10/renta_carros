CREATE PROCEDURE [dbo].[spaModificarEstacionCarga]
	@intIdEstacionCarga INT = 0,
	@strNombre NVARCHAR(MAX) = '',
	@numLatitud NUMERIC(18,14) = 0.0,
	@numLongitud NUMERIC(18,14) = 0.0
AS
	BEGIN
		UPDATE tblEstacionCarga
		SET strNombre = @strNombre, numLatitud = @numLatitud, numLongitud = @numLongitud, dtmActualiza = GETDATE()
		WHERE intIdEstacionCarga = @intIdEstacionCarga
	END
