CREATE PROCEDURE [dbo].[spaIngresarOpcion]
	@intIdPregunta INT = 0,
	@strOpcion NVARCHAR(MAX) = ''
AS
	BEGIN
		INSERT INTO tblOpcion(intIdPregunta, strOpcion)
		VALUES (@intIdPregunta, @strOpcion)
	END