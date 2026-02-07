USE LandParcelDB;

SELECT ParcelNumber, Address, county FROM Parcels
WHERE Price BETWEEN 90000 AND 200000;