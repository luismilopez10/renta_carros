CREATE PROCEDURE [dbo].[spaConsultarCategoria]
AS
	BEGIN
		SELECT 
			intIdCategoria, 
			intNivel, 
			intPremio,
			blnActivo,
			dtmActualiza
		FROM dbo.tblCategoria
		WHERE tblCategoria.blnActivo = 1
	END