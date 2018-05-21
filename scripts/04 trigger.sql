CREATE TRIGGER UnCoordinador
  ON T_InscriptionStudent
  instead of insert
as  
BEGIN
    IF (select count(*) from T_InscriptionStudent where StudentID in(select i.StudentID from inserted i))<5
    BEGIN
        INSERT INTO T_InscriptionStudent
		select * from inserted
    END
    ELSE
    BEGIN
        raiserror('No se puede ingresar mas de 4 registros por estudiante', 10, 1) 
        ROLLBACK TRANSACTION
    END
END
