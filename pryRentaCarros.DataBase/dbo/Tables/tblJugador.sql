CREATE TABLE [dbo].[tblJugador] (
    [intIdJugador] INT            IDENTITY (1, 1) NOT NULL,
    [intPuntaje]   INT            NULL,
    [strNombre]    NVARCHAR (MAX) NULL,
    [blnActivo]    BIT            DEFAULT ((1)) NULL,
    [dtmActualiza] DATETIME       DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_tblJugador] PRIMARY KEY CLUSTERED ([intIdJugador] ASC)
);

