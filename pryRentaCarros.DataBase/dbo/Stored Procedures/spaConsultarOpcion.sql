CREATE PROCEDURE [dbo].[spaConsultarOpcion]
AS
	BEGIN
		SELECT 
			intIdOpcion, 
			intIdPregunta, 
			strOpcion,
			blnActivo,
			dtmActualiza
		FROM dbo.tblOpcion
		WHERE tblOpcion.blnActivo = 1
	END