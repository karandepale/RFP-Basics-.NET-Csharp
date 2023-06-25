-- Create:- command is used for creating databse objects like database , table , view , functions etc...
create database School;

use School;
create table SchoolInformation(
                               Id int identity(1,1) primary key,
							   SchoolName varchar(200),
							   SchoolAddrs varchar(200),
							   Fees int,
							   Strength int 
							    );

--------------------------------------------------------------------------------------------

-- SELECT:- Select command is used for retriving the data from database table.
select * from SchoolInformation;	

--------------------------------------------------------------------------------------------
-- INSERT:- Insert command is used for inserting records in the database table.
insert into SchoolInformation values('SSVM' , 'Kasrawad' , 3000 , 1200 , 'yes'),
                                    ('vaibhav' , 'balsamund' , 2000 , 1000 , 'yes'),
									('Gurukul' , 'khargone' , 5000 , 2500 , 'No'),
									('JIT' , 'Borawan' , 30000 , 5000 , 'Yes'),
									('UEC' , 'Ujjain' , 9000 , 4500 , 'no');

---------------------------------------------------------------------------------------------

-- DROP:- Drop command is used for Deleting the database objects permanently ,like database , table , view , functions etc...
--	drop database School;	

-------------------------------------------------------------------------------------------

--UPDATE:- Update command is used for update the particular record in table baased upon some condition. using se and where keywords.

    update SchoolInformation
    set SchoolName='Vaibhav vidhya vihar' , SchoolAddrs='New RD Balsamund' 
	where Id=2; 

-------------------------------------------------------------------------------------------

-- DELETE:- Delete command is used for Delete the partiular row from table based upon some condition.

    delete SchoolInformation
    where Id=5;

------------------------------------------------------------------------------------------

-- TRUNCATE:- Truncate command is used for delete all the rows from database table.

truncate table SchoolInformation;

------------------------------------------------------------------------------------------

--ALTER:- Alter command is used for modification purpose like adding new column and removing existing column in the database table
alter table SchoolInformation Add BusFac varchar(200);

				
------------------------------------------------------------------------------------------

-- Aggregate functions:-
select * from SchoolInformation;
select Count(Id) as TotalRows from SchoolInformation;
select Sum(Fees) as TotalFeesOfAllSchool from SchoolInformation;
select Min(Strength) as MinStudents from SchoolInformation;
select Max(Fees) as MaxFees from SchoolInformation;
select Avg(Strength) as AverageOFStrength from SchoolInformation;

-------------------------------------------------------------------------------------------















