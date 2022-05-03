CREATE PROCEDURE [dbo].[spUserStudent_Insert]
	@Id int,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@Patronymic NVARCHAR(50),
	@DOB DATE,
	@Email NVARCHAR(50),
	@Phone NCHAR(20),
	@Telegram NVARCHAR(50),
	@University NCHAR(10),
	@Country NVARCHAR(50),
	@Region NVARCHAR(50),
	@Town NVARCHAR(50),
	@Street NVARCHAR(50),
	@House NVARCHAR(50),
	@Flat NVARCHAR(50),
	@Description NVARCHAR(200)
AS
begin
	INSERT INTO dbo.UserStudent (FirstName, LastName, Patronymic,
	DOB,Email,Phone,Telegram,University,Country,
	Region,Town,Street, House, Flat, [Description])
	VALUES (@FirstName, @LastName, @Patronymic,
	@DOB,@Email,@Phone,@Telegram,@University,@Country,
	@Region,@Town,@Street, @House,@Flat,@Description);
end
