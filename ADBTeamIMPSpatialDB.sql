SELECT * FROM sys.spatial_reference_systems

--Câu 1
CREATE DATABASE ADBTeamIMPSpatialDB
go

USE ADBTeamIMPSpatialDB
go

CREATE TABLE LoDat
(
	ID int identity(1,1) primary key,
	MaDat varchar(50),
	TenDat nvarchar(100),
	MatDoNuoc nvarchar(100),
	MatDoDoanhThu nvarchar(100),
	Vitri geometry
)

INSERT INTO LoDat (MaDat, TenDat, MatDoNuoc, MatDoDoanhThu, Vitri)
VALUES
('M7',N'Trồng lúa',N'75000 m3/ha',N'250.6 triệu VNĐ/ha', geometry::STGeomFromText('MULTIPOLYGON(((-2 -2, -2 2, -1 3, 1 3, 1 -1, -2 -2 )),((3 0, 6 1, 5 3, 7 3, 7 -2, 5 -2, 3 0)))', 0)),
('M8',N'Trồng cây ăn quả',N'45000 m3/ha',N'350.4 triệu VNĐ/ha', geometry::STGeomFromText('POLYGON((1 0, 1 3, 3 4, 5 3, 5 1, 3 0, 1 0))',0)),
('M9',N'Trồng rau',N'35000 m3/ha',N'450.5 triệu VNĐ/ha', geometry::STGeomFromText('POLYGON((-2 -2, 1 -1, 1 0, 3 0, 3 -2, -2 -2))',0))
go

select * from LoDat


--Câu 2
--a.

--b.
--select *, Vitri.STArea() as DT
--from LoDat

DECLARE @DienTichM7 geometry
DECLARE @DienTichM8 geometry
DECLARE @DienTichM9 geometry
SET @DienTichM7 = ( SELECT Vitri FROM LoDat WHERE MaDat = 'M7')
SET @DienTichM8 = ( SELECT Vitri FROM LoDat WHERE MaDat = 'M8')
SET @DienTichM9 = ( SELECT Vitri FROM LoDat WHERE MaDat = 'M9')
IF @DienTichM7.STArea() > @DienTichM8.STArea() AND @DienTichM7.STArea() > @DienTichM9.STArea()
	PRINT 'M7 co dien tich lon nhat'
ELSE
BEGIN 
IF @DienTichM8.STArea() > @DienTichM7.STArea() AND @DienTichM8.STArea() > @DienTichM9.STArea()
	PRINT 'M8 co dien tich lon nhat'
ELSE
	IF @DienTichM9.STArea() > @DienTichM7.STArea() AND @DienTichM9.STArea() > @DienTichM8.STArea()
	PRINT 'M9 co dien tich lon nhat'
END;
GO

--c.
DECLARE @a geometry;
DECLARE @b geometry;
set @a = geometry::STGeomFromText('LINESTRING(2 4, 2 0)',0)
set @b = geometry::STGeomFromText('LINESTRING(4 -2, 4 4)',0)
select *, Vitri.STIntersection(@a.STConvexHull()).ToString()
from LoDat
