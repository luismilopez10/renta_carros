CREATE TABLE [dbo].[tblOpcion] (
    [intIdOpcion]   INT            IDENTITY (1, 1) NOT NULL,
    [intIdPregunta] INT            NULL,
    [strOpcion]     NVARCHAR (MAX) NULL,
    [blnActivo]     BIT            DEFAULT ((1)) NULL,
    [dtmActualiza]  DATETIME       DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblOpciones] PRIMARY KEY CLUSTERED ([intIdOpcion] ASC),
    CONSTRAINT [FK_tblOpcion_tblPregunta] FOREIGN KEY ([intIdPregunta]) REFERENCES [dbo].[tblPregunta] ([intIdPregunta])
);


GO
CREATE NONCLUSTERED INDEX [IXFK_tblOpcion_tblPregunta]
    ON [dbo].[tblOpcion]([intIdPregunta] ASC);

