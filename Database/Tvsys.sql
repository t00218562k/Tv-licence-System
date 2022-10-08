--Tv licence script
DROP TABLE History;
DROP TABLE Licence;
DROP TABLE Customer;
DROP Table CurrentFee;

CREATE TABLE CurrentFee
(StartDate Date,
Fee numeric(5,2),
CONSTRAINT pk_CurrentFee PRIMARY KEY (StartDate));

INSERT INTO CurrentFee
VALUES('01-JAN-19',155.00);
INSERT INTO CurrentFee
VALUES('01-JAN-20',160.00);
INSERT INTO CurrentFee
VALUES('01-JAN-21',165.00);
INSERT INTO CurrentFee
VALUES('01-JAN-22',170.00);
INSERT INTO CurrentFee
VALUES('01-JAN-23',170.00);


CREATE TABLE Customer 
(CusId NUMBER(8) NOT NULL,
FirstName VARCHAR(30) NOT NULL,
LastName VARCHAR(30) NOT NULL,
Email VARCHAR(100) NOT NULL,
CONSTRAINT pk_Customer PRIMARY KEY(CusId));
 
CREATE TABLE History
(HistoryId NUMBER(10) NOT NULL,
Cus_Id NUMBER(8) NOT NULL,
Street VARCHAR(50) NOT NULL,
Town VARCHAR(50) NOT NULL,
County VARCHAR(50) NOT NULL,
ExpiryDate VARCHAR(20),
Fee numeric(5,2) CHECK (Fee > 0),
CONSTRAINT fk_Customer FOREIGN KEY (Cus_Id) REFERENCES Customer(CusId),
CONSTRAINT pk_History PRIMARY KEY(HistoryId));
 
CREATE TABLE Licence
(LicenceId number(10) NOT NULL,
Cus_Id NUMBER(8) NOT NULL, 
Street VARCHAR(50) NOT NULL,
Town VARCHAR(50) NOT NULL,
County VARCHAR(50) NOT NULL,
ExpiryDate VARCHAR(20) NOT NULL,
Fee numeric(5,2) CHECK (Fee > 0),
Stat VARCHAR(9) CHECK (Stat IN ('Valid', 'Cancelled', 'Soon', 'Expired')),
CONSTRAINT pk_Licence PRIMARY KEY(LicenceId),
CONSTRAINT fk_Customer_Licence FOREIGN KEY (Cus_Id) REFERENCES Customer(CusId));

COMMIT;
