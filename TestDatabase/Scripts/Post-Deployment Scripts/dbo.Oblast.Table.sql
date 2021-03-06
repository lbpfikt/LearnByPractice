MERGE INTO [dbo].[Oblast] AS [target]
USING 
	(VALUES 
		(N'Софтверско инженерство'),
		(N'Мрежни сервиси'),
		(N'Embedded software development')
	) 
	AS [source] (ime)
ON [target].Ime = [source].ime
WHEN MATCHED THEN
	UPDATE SET [target].Ime = [source].ime
WHEN NOT MATCHED BY TARGET THEN
	INSERT ([Ime]) VALUES ([source].ime)
WHEN NOT MATCHED BY SOURCE THEN
	DELETE;