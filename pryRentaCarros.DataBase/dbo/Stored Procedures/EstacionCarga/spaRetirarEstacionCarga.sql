CREATE PROCEDURE [dbo].[spaRetirarEstacionCarga]
	@intIdEstacionCarga INT = 0
AS
	BEGIN
		UPDATE tblEstacionCarga
		SET blnActivo = 0, dtmActualiza = GETDATE()
		WHERE intIdEstacionCarga = @intIdEstacionCarga
			AND blnActivo = 1
	END
RETURN 0
