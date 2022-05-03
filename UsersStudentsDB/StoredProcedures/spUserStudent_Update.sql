CREATE PROCEDURE [dbo].[spUserStudent_Update]
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
	UPDATE dbo.UserStudent SET FirstName = @FirstName,
	LastName = @LastName, Patronymic = @Patronymic,
	DOB = @DOB, Email = @Email, Phone = @Phone, Telegram = @Telegram,
	University = @University, Country = @Country,
	Region = @Region, Town = @Town, Street = @Street, House = @House,
	Flat = @Flat, [Description] = @Description WHERE Id = @Id;
end
