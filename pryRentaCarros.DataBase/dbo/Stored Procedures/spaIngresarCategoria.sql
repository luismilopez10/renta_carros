CREATE PROCEDURE [dbo].[spaIngresarCategoria]
	@intNivel INT = 0,
	@intPremio INT = 0
AS
	BEGIN
		INSERT INTO tblCategoria(intNivel, intPremio)
		VALUES (@intNivel, @intPremio)
	END