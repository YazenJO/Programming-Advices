CREATE VIEW VehicleMasterDetails1
--WITH ENCRYPTION, SCHEMABINDING, VIEW_METADATA
AS
	SELECT MakeName=(SELECT Makes.Make FROM Makes WHERE MakeID=vd.MakeID) ,
	ModelName=(SELECT ModelName FROM MakeModels WHERE MakeModels.ModelID=vd.ModelID ),
	SubModelName=(SELECT SubModels.SubModelName FROM SubModels WHERE SubModelID=vd.SubModelID),
	BodyIDName=(SELECT BodyName FROM Bodies WHERE BodyID=vd.BodyID),
	FuelTypeIDName=(SELECT FuelTypeName FROM FuelTypes WHERE FuelTypeID=vd.FuelTypeID) ,*

	
	FROM  VehicleDetails vd
	--WITH CHECK OPTION
GO
 SELECT * FROM VehicleMasterDetails1 vmd 
 SELECT * FROM VehicleMasterDetails vmd