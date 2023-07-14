Create database Solo_Cueros
go 




create table Users (
UserName varchar (50) not null,
Password varchar (50) not null)
go

insert into Users values ( 'Admin','Admin1234')
insert into Users values ( 'Josue.Calero','1234')
insert into Users values ( 'Test','1234')


CREATE TABLE UsersLogin (
	UserName VARCHAR (50) not null,
	Password VARCHAR (50) not null
)
GO

CREATE TABLE CategoryP (
	ID INT PRIMARY KEY IDENTITY (1,1),
	NameP VARCHAR (50),
)
GO



--CREATE TABLE Products (
--	ID INT PRIMARY KEY IDENTITY (1,1),
--	Nombre VARCHAR (50),
--	Descripcion VARCHAR (150),
--	Stock INT,
--	Categoria INT,
--	Precio float ,
--	size int NULL,
--	Color VARCHAR (25)

--	CONSTRAINT FK_ProdCat FOREIGN KEY (Categoria) 
--	REFERENCES CategoryP(ID)
--)
--GO

CREATE TABLE Customer (
	ID INT PRIMARY KEY IDENTITY (1,1),
	NameC VARCHAR (50),
	Sex CHAR (1)

)
GO

CREATE TABLE Bill
(
	ID INT PRIMARY KEY IDENTITY,
	CustomerID VARCHAR (50) NOT NULL, 
	Fecha datetime NOT NULL,

)
go

CREATE TABLE Invoice_detail
(
	 ID INT PRIMARY KEY IDENTITY,
	 BillID INT NOT NULL,
	 ProducID VARCHAR (50) NOT NULL,
	 Amount INT NOT NULL,
	 Price NUMERIC (10,2) NOT NULL,

	 CONSTRAINT FK_Detail foreign key (BillID)
	 REFERENCES Bill(ID)
 )
 go

CREATE TABLE Sales_detail
(
	 ID INT PRIMARY KEY,
	 BillID INT NOT NULL,
	 ProducID VARCHAR (50)  NOT NULL,
	 Amount INT NOT NULL,
	 Price NUMERIC (10,2) NOT NULL,
 )
 go


 select * from CategoryP


INSERT INTO CategoryP VALUES ('Carteras y Bolsos'), ('Calzado')

INSERT INTO Products
VALUES 
('CARTERA DE CUERO 100% ','','25','1','1200','0','NEGRO'),
('CARTERA DE CUERO 75%','','55','1','850','0','NEGRO'),
('CARTERA DE CUERO 50%','','32','1','640','0','NEGRO'),
('ZAPATOS DOWNTOWN','','58','2','2500','45','NEGRO'),
('BOTÍN NEW LOOK','','56','2','1850','49','NEGRO'),
('ZAPATOS DE VESTIR EN CUERO','','2','2','1750','48','NEGRO'),
('ZAPATOS DE VESTIR ESTILO DERBY ','','32','2','1900','40','NEGRO'),
('ZAPATOS DE ESTILO CASUAL','','48','2','1650','42','NEGRO'),
('BOTÍN MULTITEXTURA','','53','2','2100','42','NEGRO'),
('SNEAKERS EN CUERO','','10','2','2200','44','NEGRO'),
('PORTA LENTES DE CUERO','','55','1','450','0','NEGRO'),
('BILLETERA DE CUERO','','55','1','800','0','NEGRO')




select* from products

----------------Procedimientos de almacenado -------------------------------------------------------------

Create proc sp_MostrarProductos
as 
select * from Products
go 

exec sp_MostrarProductos



Create proc sp_InsertProducts

@Nombre nvarchar (100),
@Descripcion nvarchar (100),
@Stock int ,
@Categoria nvarchar(100),
@Precio Float,
@Size nvarchar (20),
@Color nvarchar (50)

as 
insert into Products Values 
(@Nombre,@Descripcion,@Stock,@Categoria,@Precio,@Size,@Color)
go

exec sp_MostrarProductos
exec sp_InsertProducts  'Mochila','','12', 'alta',120, 'Grande','Negro'


------------------------------ Test ------------------------------
Create table Products (
ID int identity (1,1) Primary key,
Nombre nvarchar (100),
Descripcion nvarchar (100),
Stock int,
Categoria nvarchar(100),
Precio Float,
Size nvarchar (20),
Color nvarchar (50),
)


CONSTRAINT FK_ProdCat FOREIGN KEY (Categoria) 
	REFERENCES CategoryP(ID)
)
GO


insert into Products
Values 

('Zapatilla','con escamas','12', 'alta',120, 'XXL','Negro')


