DECLARE @DB NVARCHAR(50) = 'DES-DB'

SELECT  'SELECT TOP 10 * FROM ' + TABLE_SCHEMA + '.' + TABLE_NAME + '(NOLOCK)'
FROM    INFORMATION_SCHEMA.TABLES
WHERE   TABLE_CATALOG = @DB