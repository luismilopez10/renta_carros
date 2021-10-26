CREATE PROCEDURE [dbo].[spaConsultarEstacionCarga]
AS
	BEGIN
		SELECT 
			intIdEstacionCarga, 
			strNombre, 
			numLatitud,
			numLongitud,
			blnActivo,
			dtmActualiza
		FROM dbo.tblEstacionCarga
		WHERE blnActivo = 1
	END