  
SELECT make ,
count(*) AS NumberOfVhhicels
FROM (VehicleDetails INNER JOIN Makes ON VehicleDetails.MakeID=makes.makeid)
WHERE (VehicleDetails.Year BETWEEN 1950 AND 2000)
GROUP BY makes.Make
ORDER BY NumberOfVhhicels DESC




