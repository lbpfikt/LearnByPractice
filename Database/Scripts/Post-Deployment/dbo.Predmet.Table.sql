set identity_insert LearnByPractice.dbo.Predmet On
MERGE INTO [dbo].[Predmet] AS [target]
USING 
(VALUES
(1, N'ИКТ-241',N'Објектно ориентирано програмирање'),
(2, N'ИКТ-243', N'Визуелно програмирање'),
(3, N'ИКТ-245', N'Веб програмирање')
)
AS [source] (id, sifraPredmet, ime)
ON [target].[ID] = [source].[id]
WHEN Matched Then 
UPDATE SET Ime=[source].[ime],
Shifra_Na_Predmet=[source].[sifraPredmet]
When Not Matched By Target then
insert ( [ID], [Shifra_Na_Predmet],[Ime]) Values ([source].[id],[source].[sifraPredmet], [source].[ime])
When not matched by source then
DELETE
;
set identity_insert LearnByPractice.dbo.Predmet Off