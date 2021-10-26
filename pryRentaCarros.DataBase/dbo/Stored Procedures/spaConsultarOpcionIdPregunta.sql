CREATE PROCEDURE [dbo].[spaConsultarOpcionIdPregunta]
	@intIdPregunta INT = 0
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
		AND tblOpcion.intIdPregunta = @intIdPregunta
	END