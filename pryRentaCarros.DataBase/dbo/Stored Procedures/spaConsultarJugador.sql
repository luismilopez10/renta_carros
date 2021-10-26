CREATE PROCEDURE [dbo].[spaConsultarJugador]
AS
	BEGIN
		SELECT 
			intIdJugador, 
			intPuntaje, 
			strNombre,
			blnActivo,
			dtmActualiza
		FROM dbo.tblJugador
		WHERE tblJugador.blnActivo = 1
		ORDER BY intPuntaje DESC
	END