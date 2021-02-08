# ReCapProject_RentCar
LinQ_Intro_exercise1
CREATE DATABASE CarRent;

CREATE TABLE Brands(
	BrandId int  NOT NULL IDENTITY(1,1) PRIMARY KEY,
	BrandName nvarchar(255) NOT NULL
)


CREATE TABLE Colors(
	ColorId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ColorName nvarchar(255) NOT NULL
)

CREATE TABLE Cars(
	Id int NOT NULL IDENTITY(1,1)  PRIMARY KEY,
	BrandId int NOT NULL FOREIGN KEY REFERENCES Brands(BrandId),
	ColorId int NOT NULL FOREIGN KEY REFERENCES Colors(ColorId),
	ModelYear nvarchar(255),
	DailyPrice decimal,
	Descriptions nvarchar(255)
)
INSERT INTO Brands(BrandName)
VALUES 
('Mercedes'),
('BMW'),
('Ford'),
('Renault'),
('Cadillac'),
('Jeep'),
('Hyundai');

INSERT INTO COLORS(ColorName)
VALUES
('white'),
('black'),
('red'),
('yellow'),
('blue'),
('green'),
('gray');

INSERT INTO Cars(BrandId, ColorId, ModelYear, DailyPrice, Descriptions)
VALUES          (1,1,'2016',100, 'fuel manuel'),
				(2,2,'2018',130, 'disel automatic'),
				(2,3,'2015',80, 'disel automatic'),
				(3,4,'2020',160, 'fuel automatic'),
				(4,5,'2019',150, 'fuel manuel'),
				(5,5,'2010',70, 'disel manuel'),
				(5,2,'2012',120, 'fuel automatic')





 

