CREATE PROCEDURE [dbo].[spaConsultarPreguntaIdCategoria]
	@intIdCategoria INT = 0
AS
	BEGIN
		SELECT 
			intIdPregunta, 
			intIdCategoria, 
			strPregunta,
			strRespuesta,
			blnActivo,
			dtmActualiza
		FROM dbo.tblPregunta
		WHERE tblPregunta.blnActivo = 1
		AND tblPregunta.intIdCategoria = @intIdCategoria
	END