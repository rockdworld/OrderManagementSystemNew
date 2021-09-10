use orderdb;

CREATE TABLE tbl_order
(
   OrderID int,
   CustomerName varchar(1000),
   Amount numeric(6,1)
);

INSERT INTO tbl_order(OrderID, CustomerName, Amount) 
VALUES (1, 'Shyamlal & Sons.', 14450.5); 

INSERT INTO tbl_order(OrderID, CustomerName, Amount) 
VALUES (2, 'Hinduja & Family', 50000.0),(2, 'Raheja & Bros.', 24500.5);

INSERT INTO tbl_order(OrderID, CustomerName, Amount) 
VALUES (3, 'Hinduja & Family', 25000.0),(3, 'Mehta & Compony', 24500.5);