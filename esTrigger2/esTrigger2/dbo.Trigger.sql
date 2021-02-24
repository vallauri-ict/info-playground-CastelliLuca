CREATE TRIGGER triggerDelete
ON [dbo].[Driver]
FOR DELETE
AS
INSERT INTO StoricoCancellazioni
   SELECT *,GETDATE() FROM Deleted
