CREATE TABLE [dbo].[tblEstacionCarga] (
    [intIdEstacionCarga] INT              IDENTITY (1, 1) NOT NULL,
    [strNombre]          NVARCHAR (MAX)   NULL,
    [numLatitud]         NUMERIC (18, 14) NULL,
    [numLongitud]        NUMERIC (18, 14) NULL,
    [blnActivo]          BIT              DEFAULT ((1)) NULL,
    [dtmActualiza]       DATETIME         DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblEstacion] PRIMARY KEY CLUSTERED ([intIdEstacionCarga] ASC)
);

