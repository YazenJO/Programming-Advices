SELECT TotalMakesRunsONGas=count (*)FROM (
SELECT        Makes.Make, FuelTypes.FuelTypeName
FROM            Makes INNER JOIN
                         VehicleDetails ON Makes.MakeID = VehicleDetails.MakeID INNER JOIN
                         FuelTypes ON VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
				
				WHERE FuelTypeName	=N'gas'
		GROUP BY Make ,FuelTypeName )r1

				