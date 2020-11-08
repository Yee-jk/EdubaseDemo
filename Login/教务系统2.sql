DROP DATABASE IF EXISTS EduSystem2;
	CREATE DATABASE EduSystem2
		ON 
			(NAME='DataFile_1'
			, FILENAME='E:\EduSystem2\DataFile_1.mdf')
		LOG ON
			(NAME='LogFile_1'
			,FILENAME='E:\EduSystem2\LogFile_1.ldf');
USE EduSystem2;
IF OBJECT_ID('tb_Student')IS NOT NULL
	DROP TABLE tb_Student;
GO
CREATE TABLE tb_Student
	(No
		CHAR(10)
		NOT NULL
		CONSTRAINT pk_Studet_No
			PRIMARY KEY(No)
		CONSTRAINT ck_Student_No
			CHECK(No LIKE REPLICATE('[0-9]',10))
	,Code
		VARCHAR(20)
		NOT NULL
	);
IF OBJECT_ID('tb_Notice')IS NOT NULL
	DROP TABLE tb_Notice;
GO
CREATE TABLE tb_Notice
	(No
		VARCHAR(3)
		CONSTRAINT pk_Notice_No
		PRIMARY KEY(No)
		NOT NULL
	,Title
		VARCHAR(100)
		NOT NULL
	,Type
		VARCHAR(40)
		NOT NULL
	,Sender
		VARCHAR(20)
		NOT NULL
	,SendTime
		DATETIME
		NOT NULL
	);
IF OBJECT_ID('tb_LeaveMessage')IS NOT NULL
	DROP TABLE tb_LeaveMessage;
GO
CREATE TABLE tb_LeaveMessage
	(No
		VARCHAR(3)
		CONSTRAINT pk_LeaveMessage_No
		PRIMARY KEY(No)
		NOT NULL
	,Title
		VARCHAR(100)
		NOT NULL
	,Type
		VARCHAR(40)
		NOT NULL
	,Sender
		VARCHAR(20)
		NOT NULL
	,Sendtime
		DATETIME
		NOT NULL
	);
IF OBJECT_ID('tb_StudentCard')IS NOT NULL
	DROP TABLE tb_StudentCard;
GO
CREATE TABLE tb_StudentCard
	(No
		CHAR(10)
		CONSTRAINT pk_StudentCard_No
		PRIMARY KEY(No)
		CONSTRAINT ck_StudentCard_No
		CHECK(No LIKE REPLICATE('[0-9]',10))
		NOT NULL
	,Academy
		VARCHAR(20)
		NOT NULL
	,Major
		VARCHAR(40)
		NOT NULL
	,Gender
		BIT
        NOT NULL
	,BirthDate
		DATETIME
		NULL
	);
IF OBJECT_ID('tb_Course')IS NOT NULL
	DROP TABLE tb_Course;
GO
CREATE TABLE tb_Course
	(No
		CHAR(4)
		CONSTRAINT pk_Course_No
		PRIMARY KEY(No)
		CONSTRAINT ck_Course_No
		CHECK(No LIKE ('[A-Z][0-9][0-9][0-9]'))
		NOT NULL
	,Name
		VARCHAR(40)
		NOT NULL
	,CourseNature
		VARCHAR(20)
		NOT NULL
	,StartTime
		INT
		NOT NULL
	,Credit
		FLOAT
		NOT NULL
	,Hour
		AS(Credit*16)
	,ExamType
		VARCHAR(10)
	   NULL
	);
IF OBJECT_ID('tb_TrainProgram')IS NOT NULL
	DROP TABLE tb_TrainProgram;
GO
CREATE TABLE tb_TrainProgram
	(No
		VARCHAR(3)
		CONSTRAINT pk_TrainProgram_No
		PRIMARY KEY(No)
		NOT NULL
	,Title
		VARCHAR(40)
		NOT NULL
	);
IF OBJECT_ID('tb_StudySituation')IS NOT NULL
	DROP TABLE tb_StudySituation;
GO
CREATE TABLE tb_StudySituation
	(No
		VARCHAR(2)
		NOT NULL
	,CourseNature
		CHAR(10)
		CONSTRAINT pk_StudySituation_CourseNature
		PRIMARY KEY(CourseNature)
		NOT NULL
	,EarnedCredit
		FLOAT
		NULL
	);
IF OBJECT_ID('tb_Book')IS NOT NULL
	DROP TABLE tb_Book;
GO
CREATE TABLE tb_Book
	(No
		VARCHAR(2)
		CONSTRAINT pk_Book_No
			PRIMARY KEY(No)
	,Name
		VARCHAR(40)
		NOT NULL
	,CourseNo
		CHAR(4)
		CONSTRAINT fk_Book_CourseNo
		FOREIGN KEY(CourseNo)
		REFERENCES dbo.tb_Course(No)
		NOT NULL
	,Writer
		VARCHAR(20)
	,Publish
		VARCHAR(20)
	,Price
		FLOAT
	,IfSubscribe
		BIT
		SPARSE
		NULL
	);
IF OBJECT_ID('tb_DiplomaProjectTopic')IS NOT NULL
	DROP TABLE tb_DiplomaProjectTopic;
GO
CREATE TABLE tb_DiplomaProjectTopic
	(No
		VARCHAR(20)
		CONSTRAINT pk_DiplomaProjectTopic_No
		PRIMARY KEY(No)
		NOT NULL
	,Year
		CHAR(4)
		CONSTRAINT ck_DiplomaProjectTopic_No
		CHECK(Year LIKE REPLICATE('[0-9]',4))
	,Title
		VARCHAR(20)
		NOT NULL
	,Academy
		VARCHAR(20)
		NOT NULL
	,Teacher
		VARCHAR(20)
	,TeacherTitle
		VARCHAR(20)
	,LimitNumber
		VARCHAR(3)
	);