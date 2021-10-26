CREATE PROCEDURE [dbo].[spaConsultarPregunta]
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
	END