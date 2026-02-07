USE LandParcelDB;

INSERT INTO Parcels (ParcelNumber, Address, county, SizeInAcres, Price, HasWetlands, Status, notes, CreatedDate)
VALUES 
('P-2024-001', '123 Oak Ridge Road', 'Fulton', 2.5, 125000, 0, 'Available', 'Great location near schools', GETDATE()),
('P-2024-002', '456 Pine Valley Lane', 'Gwinnett', 5.0, 275000, 1, 'Available', 'Wetlands on east boundary', GETDATE()),
('P-2024-003', '789 Maple Street', 'Cobb', 1.2, 95000, 0, 'Pending', 'Corner lot, high traffic', GETDATE()),
('P-2024-004', '321 Birch Avenue', 'Cherokee', 10.0, 450000, 0, 'Available', 'Ideal for subdivision', GETDATE()),
('P-2024-005', '654 Cedar Drive', 'Forsyth', 3.3, 180000, 1, 'Sold', 'Protected wetlands area', GETDATE());

SELECT * FROM Parcels;