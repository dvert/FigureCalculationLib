/*C������� ������� "���������"*/
CREATE TABLE Categories (
	Id uniqueidentifier NOT NULL
	CONSTRAINT Categories_PK PRIMARY KEY NONCLUSTERED,
	Name varchar(50) NULL
)

/*C������� ������� "��������"*/
CREATE TABLE Products (
	Id uniqueidentifier NOT NULL
	CONSTRAINT Products_PK PRIMARY KEY NONCLUSTERED,
	Name varchar(50) NULL
)
ALTER TABLE Products ADD  DEFAULT (newid()) FOR Id

/*C������� ������������� ������� "���������/��������" */
CREATE TABLE CategoriesProducts(
	Id uniqueidentifier NOT NULL
	CONSTRAINT Id_PK PRIMARY KEY NONCLUSTERED,
	ProductId uniqueidentifier NULL
	CONSTRAINT CategoriesProducts_ProductsId_FK REFERENCES Products,
	CategoryId uniqueidentifier NULL
	CONSTRAINT CategoriesProducts_CategoriesId_FK REFERENCES Categories
)
ALTER TABLE CategoriesProducts ADD  DEFAULT (newid()) FOR Id

/*���������� ������� "���������"*/
INSERT INTO Categories VALUES ('99d3f852-9a44-44bd-932e-76005c6a9c74','���������'),
                              ('6d7c5c37-e537-4c9c-999e-d472ce0a88dc','����������'),
							  ('65b9b1d4-abea-404e-adc5-70f2410c39c2','����'),
							  (NEWID(),'����������')

/*���������� ������� "��������"*/
INSERT INTO Products VALUES ('c37763cf-90b9-4cc9-bf6d-9f1c9e1421eb','Iphone'),
							('c9264df0-c97f-4895-be68-3db8f28d988a','Huawei'),
							('ae27d575-71ad-4bd7-9981-1432fd469a96','Honor'),
							(default,'Samsung'),
							(default,'LG')

/*���������� ������� "���������/��������"*/
INSERT INTO CategoriesProducts VALUES (default,'c37763cf-90b9-4cc9-bf6d-9f1c9e1421eb','99d3f852-9a44-44bd-932e-76005c6a9c74'),
								      (default,'c9264df0-c97f-4895-be68-3db8f28d988a','99d3f852-9a44-44bd-932e-76005c6a9c74'),
									  (default,'ae27d575-71ad-4bd7-9981-1432fd469a96','6d7c5c37-e537-4c9c-999e-d472ce0a88dc'),
									  (default,'ae27d575-71ad-4bd7-9981-1432fd469a96','6d7c5c37-e537-4c9c-999e-d472ce0a88dc'),
									  (default,'c9264df0-c97f-4895-be68-3db8f28d988a','65b9b1d4-abea-404e-adc5-70f2410c39c2'),
									  (default,'ae27d575-71ad-4bd7-9981-1432fd469a96','65b9b1d4-abea-404e-adc5-70f2410c39c2')