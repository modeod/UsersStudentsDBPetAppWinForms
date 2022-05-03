CREATE PROCEDURE [dbo].[spUserStudent_Delete]
	@Id int
AS
	DELETE FROM dbo.UserStudent WHERE Id = @Id;
RETURN 0
