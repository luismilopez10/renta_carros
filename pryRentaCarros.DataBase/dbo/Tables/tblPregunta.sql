CREATE TABLE [dbo].[tblPregunta] (
    [intIdPregunta]  INT            IDENTITY (1, 1) NOT NULL,
    [intIdCategoria] INT            NULL,
    [strPregunta]    NVARCHAR (MAX) NULL,
    [strRespuesta]   NVARCHAR (MAX) NULL,
    [blnActivo]      BIT            DEFAULT ((1)) NULL,
    [dtmActualiza]   DATETIME       DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblPregunta] PRIMARY KEY CLUSTERED ([intIdPregunta] ASC),
    CONSTRAINT [FK_tblPregunta_tblCategoria] FOREIGN KEY ([intIdCategoria]) REFERENCES [dbo].[tblCategoria] ([intIdCategoria])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_tblPregunta_tblCategoria]
    ON [dbo].[tblPregunta]([intIdCategoria] ASC);

