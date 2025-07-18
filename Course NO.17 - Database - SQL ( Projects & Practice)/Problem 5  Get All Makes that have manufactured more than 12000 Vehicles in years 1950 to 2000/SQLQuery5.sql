SELECT Make , count(*) AS NumberOfVhhicels 
FROM (Makes INNER JOIN VehicleDetails vd ON Makes.MakeId=vd.makeid )
WHERE (vd.Year BETWEEN 1950 AND 2000 )
GROUP BY Make 
HAVING COUNT(*) > 12000
ORDER BY   NumberOfVhhicels DESC
-----without having 



SELECT * FROM(
SELECT Make ,count (*) AS NumberOfVhhicels
FROM (Makes INNER JOIN VehicleDetails vd ON Makes.MakeID=vd.makeid)
WHERE 
( vd.Year BETWEEN 1955 AND 2000)
 GROUP BY make
 )r1
 WHERE r1.NumberOfVhhicels >12000
 ORDER BY r1.NumberOfVhhicels DESC