CREATE TABLE [dbo].[tblCategoria] (
    [intIdCategoria] INT      IDENTITY (1, 1) NOT NULL,
    [intNivel]       INT      NULL,
    [intPremio]      INT      NULL,
    [blnActivo]      BIT      DEFAULT ((1)) NULL,
    [dtmActualiza]   DATETIME DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblCategoria] PRIMARY KEY CLUSTERED ([intIdCategoria] ASC)
);

