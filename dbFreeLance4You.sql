USE MASTER
GO

CREATE DATABASE dbFreeLance4You
GO

USE dbFreeLance4You
GO

CREATE TABLE Gender
(GenderID int primary key not null,
Description varchar(10) null)
GO

CREATE TABLE Profile
(ProfileID int primary key not null,
ProfileName varchar(35) null,
ProfileSurname varchar(35) null,
ProfileCellNumber char(10) null,
ProfileUserName varchar(35) not null,
ProfilePassword varchar(15) not null,
ProdileEmail varchar(35) null,
PrdofileAddress varchar(50) null,
Experience int null,
LoginUserID int foreign key references LogIn not null,
PictureID bit foreign key references Picture not null,
GenderID int foreign key references Gender not null
)
GO

CREATE TABLE LogIn
(LoginUserID int primary key not null,
Name varchar(25) not null,
LoginPassword varchar(10) not null
)
GO

CREATE TABLE Picture
(PictureID bit primary key not null,
PictureSize int null,
PictureType char(10) null,
PictureFile image
)
GO

CREATE TABLE Employer
(EmployerID int primary key not null,
ProfileID int foreign key references Profile not null
)
GO

CREATE TABLE Required
(RequiredID int primary key not null,
Description varchar(50) null,
EmployerID int foreign key references Employer not null,
)
GO

CREATE TABLE Skill
(SkillID int primary key not null,
SkillDescription varchar(25) null,
RequiredID int foreign key references Required not null
)
GO

CREATE TABLE SkillSet
(SkillSetID int primary key not null,
SkillSetType varchar(100) null
)
GO

CREATE TABLE Employee
(EmployeeID int primary key not null,
EmployeePicture bit null,
EmployeeJobSkill varchar(100) null,
ProfileID int foreign key references Profile not null,
SkillSetID int foreign key references SkillSet not null,
)
GO

CREATE TABLE Transport
(TransportID int primary key not null,
TransportDescription varchar(25) null
)
GO

CREATE TABLE EmployeeTransport
(EmployeeTransportID int primary key not null,
TransportID int foreign key references Transport not null,
EmployeeID int foreign key references Employee not null
)
GO

CREATE TABLE Location
(LocationID int primary key not null,
CityID int foreign key references City not null
)
GO

CREATE TABLE EmployeeRange
(EmployeeRangeID int primary key not null,
EmployeeID int foreign key references Employee not null,
LocationID int foreign key references Location not null)
GO

CREATE TABLE ProfileLocation
(ProfileLocationID int primary key not null,
ProfileID int foreign key references Profile not null,
LocationID int foreign key references Location not null)
GO

CREATE TABLE Province
(ProvinceID int primary key not null,
Description varchar(100) null)
GO

CREATE TABLE City
(CityID int primary key not null,
Description varchar(100) null,
ProvinceID int foreign key references Province not null
)
GO