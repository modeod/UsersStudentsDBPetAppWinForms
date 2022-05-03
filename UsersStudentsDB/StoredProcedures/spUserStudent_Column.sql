CREATE PROCEDURE [dbo].[spUserStudent_Column]
	@columName NVARCHAR(50)
AS
	SELECT
		CASE @columName
			WHEN N'FirstName' THEN FirstName
			WHEN N'LastName' THEN LastName
			WHEN N'Patronymic' THEN Patronymic
			WHEN N'DOB' THEN CONVERT(NVARCHAR, DOB, 104)
			WHEN N'Email' THEN Email
			WHEN N'Phone' THEN Phone
			WHEN N'Telegram' THEN Telegram
			WHEN N'University' THEN University
			WHEN N'Country' THEN Country
			WHEN N'Region' THEN Region
			WHEN N'Town' THEN Town
			WHEN N'Street' THEN Street
			WHEN N'House' THEN House
			WHEN N'Flat' THEN Flat
			WHEN N'Description' THEN [Description]
			ELSE NULL
		END AS ColumnValue
	FROM dbo.UserStudent
RETURN 0
