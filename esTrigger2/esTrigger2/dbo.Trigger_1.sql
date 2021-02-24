CREATE TRIGGER TR_TestColumns ON [dbo].[Driver]
AFTER UPDATE 
AS
 BEGIN

 IF UPDATE(full_name)
   INSERT INTO [dbo].[StoricoAggiornamenti] (full_name,date_of_update,hour_of_update)
   VALUES (deleted.full_name,GETDATE(),GETDATE())

IF UPDATE(number)
   INSERT INTO [dbo].[StoricoAggiornamenti] (number,date_of_update,hour_of_update)
   VALUES (deleted.number,GETDATE(),GETDATE())
 
IF UPDATE(country)
   INSERT INTO [dbo].[StoricoAggiornamenti] (country,date_of_update,hour_of_update)
   VALUES (deleted.country,GETDATE(),GETDATE())

IF UPDATE(date_birth)
   INSERT INTO [dbo].[StoricoAggiornamenti] (date_birth,date_of_update,hour_of_update)
   VALUES (deleted.date_birth,GETDATE(),GETDATE())

IF UPDATE(team_id)
   INSERT INTO [dbo].[StoricoAggiornamenti] (team_id,date_of_update,hour_of_update)
   VALUES (deleted.team_id,GETDATE(),GETDATE())

IF UPDATE(podiums_number)
   INSERT INTO [dbo].[StoricoAggiornamenti] (podiums_number,date_of_update,hour_of_update)
   VALUES (deleted.podiums_number,GETDATE(),GETDATE())

IF UPDATE(helmet_image)
   INSERT INTO [dbo].[StoricoAggiornamenti] (helmet_image,date_of_update,hour_of_update)
   VALUES (deleted.helmet_image,GETDATE(),GETDATE())

IF UPDATE(full_image)
   INSERT INTO [dbo].[StoricoAggiornamenti] (full_image,date_of_update,hour_of_update)
   VALUES (deleted.full_image,GETDATE(),GETDATE())
END