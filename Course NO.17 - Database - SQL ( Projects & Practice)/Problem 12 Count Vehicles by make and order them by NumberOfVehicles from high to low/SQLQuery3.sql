SELECT        Makes.Make,COUNT(*)AS	 NumberOFVehicles
FROM            Makes INNER JOIN
                         VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID
GROUP BY Make

ORDER BY NumberOFVehicles DESC