CREATE PROCEDURE [dbo].[spUserStudent_CountGroupByColum]
	@columName NVARCHAR(50)
AS
begin
	SELECT 
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
		END AS ColumName, COUNT(*) AS Number
		FROM dbo.UserStudent
		GROUP BY 
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
			END
end