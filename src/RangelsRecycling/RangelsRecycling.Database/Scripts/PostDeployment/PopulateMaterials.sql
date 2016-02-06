INSERT INTO [dbo].[Materials]
           ([Name]
           ,[Description])

SELECT '#7',' Other'
UNION
SELECT '#6 PS','Polystyrene'
UNION
SELECT '#5 PP','Polypropylene'
UNION
SELECT '#4 LDPE Plastic','Low Density Polyethylene'
UNION
SELECT '#3 PVC Plastic','Polyvinyl Chloride'
UNION
SELECT '#2 HDPE Plastic','High Density Polyethylene'
UNION
SELECT '#1 PET Plastic','Polyethylene Terephthalate'
UNION
SELECT 'Bi-metal',Null
UNION
SELECT 'Glass', Null
UNION
SELECT 'Aluminum', Null
