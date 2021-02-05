use AllianceFeedbackSystemDb
---------------REQUIREMENT 1----HANDSON 3-----------------------------------------------------------------------


CREATE TABLE Course_Info(Course_code VARCHAR(20) PRIMARY KEY, 
Course_name  VARCHAR(20)   NOT NULL, 
Course_description  VARCHAR(250), 
Course_start_date  DATE, 
Course_duration INT, 
No_of_participants INT, 
Course_type CHAR(3))
 
CREATE TABLE Student_Info(Student_id VARCHAR(10) PRIMARY KEY,
First_name VARCHAR(20),
Last_name VARCHAR(25),
Address VARCHAR(150))
-----------------------------------------------------------------------------------------------------------

CREATE TABLE student_courses(Student_id VARCHAR(10),
Course_code VARCHAR(20),
CONSTRAINT fk_student_id FOREIGN KEY (student_id)
REFERENCES student_info(student_id),
CONSTRAINT fk_course_code FOREIGN KEY(course_code)
REFERENCES course_info(course_code))
-------------------------------------------------------------------------------------------------------------


CREATE TABLE course_fees(Course_code VARCHAR (20), 
Base_fees INT,
Special_fees INT,
Discount INT,
CONSTRAINT fk_course_code2 FOREIGN KEY(course_code) 
REFERENCES course_info(course_code), 
CONSTRAINT chk_base_fees CHECK(base_fees > 0 AND base_fees>special_fees), 
CONSTRAINT chk_discount CHECK(discount >=5 AND discount <=15))



----------------------------------------------------HANDSON PRACTICE-----------------------------------------------------------



CREATE TABLE SUPPLIERS(SUPPLIER_ID INT NOT NULL,
SUPPLIER_NAME VARCHAR(50) NOT NULL,
ADDRESS VARCHAR(50),
CITY VARCHAR(50),
STATE VARCHAR(25),
ZIPCODE VARCHAR(10))

-----------------------------------------------------------------

CREATE TABLE CUSTOMERS(CUSTOMER_ID INT NOT NULL,
CUSTOMERR_NAME VARCHAR(50) NOT NULL,
ADDRESS VARCHAR(50),
CITY VARCHAR(50),
STATE VARCHAR(25),
ZIPCODE VARCHAR(10))

----------------------------------------------------------

CREATE TABLE DEPARTMENTS(DEPARTMENT_ID INT NOT NULL,
DEPARTMENT_NAME VARCHAR(50) NOT NULL
CONSTRAINT DEPARTMENTS_PK PRIMARY KEY(DEPARTMENT_ID))

CREATE TABLE EMPLOYEES(EMPLOYEE_NUMBER INT NOT NULL,
EMPLOYEE_NAME VARCHAR(50) NOT NULL,
DEPARTMENT_ID INT,
SALARY INT,
CONSTRAINT EMPLOYEE_NUMBER_PK PRIMARY KEY(EMPLOYEE_NUMBER),
CONSTRAINT FK_DEPARTMENT_ID FOREIGN KEY(DEPARTMENT_ID) REFERENCES DEPARTMENTS(DEPARTMENT_ID))

------------------------------------HANDSON 4-----------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------

SELECT COURSE_CODE, BASE_FEES+SPECIAL_FEES 
AS TOTAL_FEES 
FROM COURSE_FEES 

SELECT * FROM COURSE_FEES

SELECT COURSE_CODE,DISCOUNT*(BASE_FEES+SPECIAL_FEES)/100 
AS DISCOUNTFEES 
FROM COURSE_FEES 

SELECT course_name 
FROM course_info 
WHERE course_duration >10 and no_of_participants <20 

-----------Display the course code whose base fees are greater than 100 or special fees are less than 1000. ----------------
-------------[Hint: Use the course_fees table for this.]

SELECT COURSE_CODE FROM course_fees WHERE Base_fees >100 OR Special_fees<1000


--------------------------------------------------
SELECT COURSE_CODE FROM course_fees WHERE Base_fees > 200


SELECT STUDENT_ID,FIRST_NAME 
FROM STUDENT_INFO 
WHERE FIRST_NAME!=LAST_NAME


SELECT COURSE_CODE 
FROM COURSE_FEES 
WHERE BASE_FEES BETWEEN 100 AND 3000


SELECT STUDENT_ID,FIRST_NAME 
FROM STUDENT_INFO 
WHERE FIRST_NAME 
LIKE 'A%'

SELECT STUDENT_ID,FIRST_NAME 
FROM STUDENT_INFO 
WHERE FIRST_NAME 
LIKE '%O%'

SELECT course_name 
FROM COURSE_INFO 
WHERE COURSE_DESCRIPTION 
IS NULL


-------------------------------------PRACTICE---------------------


CREATE TABLE COURSE_FEES1(Course_code VARCHAR (20), 
Base_fees INT,
Special_fees INT,
Discount INT)


INSERT INTO course_fees1 VALUES('1',180,100,10),
('2',150,110,10),
('3',160,170,5),
('4',150,100,10),
('5',190,100,40)

SELECT * FROM COURSE_FEES1

CREATE TABLE COURSE_FEES_HISTORY(course_code VARCHAR(10), 
Base_fees INT,
Special_fees INT,
created_By VARCHAR(10),
Updated_By VARCHAR(10))

INSERT INTO COURSE_FEES_HISTORY VALUES('1',120,123,'RAM','RAMESH'),
('2',150,110,'BALA','RAM'),
('3',160,170,'BALA','VINU'),
('4',170,235,'RAM','RAM'),
('5',190,100,'VINOD','VINOD')

SELECT * FROM COURSE_FEES_HISTORY

SELECT Course_Code,Base_fees,Special_fees FROM COURSE_FEES1 union
SELECT Course_Code,Base_fees,Special_fees FROM COURSE_FEES_HISTORY


------------------------------------------------------------------------------------------------------------------------------
---------------------------------------EXERCISE 5-----------------------------------------------------------------------------



INSERT INTO COURSE_FEES1 VALUES('6',nuLL,100,10),
('7',NULL,110,10),
('8',300,170,5),
('9',175,100,10)

SELECT * FROM COURSE_FEES1

SELECT MIN(BASE_FEES),MAX(BASE_FEES) 
	   FROM COURSE_FEES1


SELECT AVG(Base_fees)  FROM COURSE_FEES1
