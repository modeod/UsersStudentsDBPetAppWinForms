CREATE PROCEDURE [dbo].[spUserStudent_GetBy]
	@columName NVARCHAR(50),
	@date NVARCHAR(200)
AS
	SELECT *
	FROM dbo.UserStudent
	WHERE 
		CASE @columName
			WHEN 'FirstName' THEN FirstName
			WHEN 'LastName' THEN LastName
			WHEN 'Patronymic' THEN Patronymic
			WHEN 'DOB' THEN DOB
			WHEN 'Email' THEN Email
			WHEN 'Phone' THEN Phone
			WHEN 'Telegram' THEN Telegram
			WHEN 'University' THEN University
			WHEN 'Country' THEN Country
			WHEN 'Region' THEN Region
			WHEN 'Town' THEN Town
			WHEN 'Street' THEN Street
			WHEN 'House' THEN House
			WHEN 'Flat' THEN Flat
			WHEN 'Description' THEN [Description]
			ELSE NULL
		END = @date
RETURN 0
