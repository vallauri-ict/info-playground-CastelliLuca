CREATE TABLE [dbo].[StoricoCancellazioni] (
    [number]         INT           NOT NULL,
    [full_name]      VARCHAR (100) NULL,
    [country]        CHAR (2)      NOT NULL,
    [date_birth]     DATE          NULL,
    [team_id]        INT           NULL,
    [podiums_number] INT           NULL,
    [helmet_image]   IMAGE         NULL,
    [full_image]     IMAGE         NULL,
    [date_of_delete] DATE          NULL,
    [hour_of_delete] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([number] ASC)
);

