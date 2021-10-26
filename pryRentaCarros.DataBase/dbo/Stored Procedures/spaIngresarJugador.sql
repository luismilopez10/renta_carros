CREATE PROCEDURE [dbo].[spaIngresarJugador]
	@intPuntaje INT = 0,
	@strNombre NVARCHAR(MAX) = ''
AS
	BEGIN
		INSERT INTO tblJugador(intPuntaje, strNombre)
		VALUES (@intPuntaje, @strNombre)
	END