SELECT * FROM(                                                                                                                                      
SELECT        Makes.Make,COUNT(*)AS	 NumberOFVehicles
FROM            Makes INNER JOIN
                         VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID
						 
GROUP BY Make)r1
WHERE r1.NumberOFVehicles >20000
ORDER BY NumberOFVehicles DESC

-----------For More Proformence 

SELECT Makes.Make, COUNT(*) AS NumberOfVehicles
FROM VehicleDetails
INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
GROUP BY Makes.Make
HAVING COUNT(*) > 20000
ORDER BY NumberOfVehicles DESC;
