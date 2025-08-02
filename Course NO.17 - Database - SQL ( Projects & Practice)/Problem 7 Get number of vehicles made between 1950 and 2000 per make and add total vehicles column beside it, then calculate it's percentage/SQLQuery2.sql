
SELECT *,  prec=(R1.NumberOfVhhicels * 1.0 / R1.TotalVehcles) 
FROM (
SELECT Make , count(*) AS NumberOfVhhicels ,(SELECT count(*) FROM VehicleDetails vd1)AS TotalVehcles
FROM (Makes INNER JOIN VehicleDetails vd ON Makes.MakeId=vd.makeid )
WHERE (vd.Year BETWEEN 1950 AND 2000 )
GROUP BY Make )R1	

ORDER BY   NumberOfVhhicels DESC

