CREATE PROCEDURE [dbo].[spaIngresarPregunta]
	@intIdCategoria INT = 0,
	@strPregunta NVARCHAR(MAX) = '',
	@strRespuesta NVARCHAR(MAX) = ''
AS
	BEGIN
		INSERT INTO tblPregunta(intIdCategoria, strPregunta, strRespuesta)
		VALUES (@intIdCategoria, @strPregunta, @strRespuesta)
	END