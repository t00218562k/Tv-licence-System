# Introduction/overview

The system manages the tv licenses of Ireland.

The system allows users to add, cancel or update a licence.

The system allows the admin to issue renewal notices from a list of expired or soon to be expired licenses, admin will be able to view the licence history of an address.

The system allows the admin to view revenue analysis for a selected year in a table format with details of each month.

The system will be connected to a database which allows the system to store the data generated.

Admin login is "admin123".


1.
# User Requirements

  1.
## TvLicenceSYS will manage Purchases

    1. TvLicenceSYS will add a licence.
    2. TvLicenceSYS will update the transfer of a licence.
    3. TvLicenceSYS will update the cancelling of a licence.

  1.
## TvLicenceSYS will process Renewals

    1. TvLicenceSYS will produce soon to be expired licenses.
    2. TvLicenceSYS will update a renewed licence.
    3. TvLicenceSYS will produce overdue licenses.
    4. TvLicenceSYS will produce property history of purchased licence.

  1.
## TvLicenceSYS will provide Admin functionality

    1. TvLicenceSYS will produce a yearly revenue analysis.
    2. TvLicenceSYS will produce a yearly authority analysis.
  

## Relational Schema

Relational schema for the data requirements

Customer(CusID, FirstName, LastName, email)

History(HistoryId, Street, Town, County, ExpiryDate, Fee, Cus\_Id)

History(LicenceId, Street, Town, County, ExpiryDate, Fee, stat, Cus\_Id)

History(StartDate, Fee)

  1.
## Database Schema

A definition of the database to be implemented.

This includes primary key, foreign key and other constraints to be implemented.

**Schema** : TvLicenceSYS

**Relation** _Customer_

CusId NUMBER(8) NOT NULL

FirstName VARCHAR(30) NOT NULL

LastName VARCHAR(30) NOT NULL

Email VARCHAR(100) NOT NULL

**Primary Key:** CusId

**Relation** _History_

HistoryId NUMBER(10) NOT NULL

Cus\_Id NUMBER(8) NOT NULL

Street VARCHAR(50) NOT NULL

Town VARCHAR(50) NOT NULL

County VARCHAR(50) NOT NULL

ExpiryDate VARCHAR(20)

Fee numeric(5,2) CHECK (Fee \> 0)

**Primary Key:** HistoryId

**[Foreign Key:** Cus\_Id **References** _Customer_]

**Relation** _Licence_

LicenceId NUMBER(10) NOT NULL

Cus\_Id NUMBER(8) NOT NULL

Street VARCHAR(50) NOT NULL

Town VARCHAR(50) NOT NULL

County VARCHAR(50) NOT NULL

ExpiryDate VARCHAR(20)

Fee numeric(5,2) CHECK (Fee \> 0)

Stat VARCHAR(9) CHECK (Stat IN ('Valid', 'Cancelled', 'Soon', 'Expired'))

**Primary Key:** LicenceId

**[Foreign Key:** Cus\_Id **References** _Customer_]

**Relation** _CurrentFee_

StartDate Date

Fee numeric(5,2)

**Primary Key:** StartDate

