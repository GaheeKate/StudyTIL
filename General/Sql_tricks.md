# Sql_tricks


## CASE
Ordering rows based on a specific condition
It allows you to order query by condtions under where clause.


``` php
SELECT *
FROM your_table
ORDER BY 
    CASE 
        WHEN column_condition = 'your_condition' THEN 0  -- Specific rows to appear first
        ELSE 1  -- Rest of the rows
    END,
    other_column; -- Additional sorting criteria if needed

```
