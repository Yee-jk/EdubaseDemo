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
	,Status
		CHAR(4)
		NOT NULL
	,StudentNo
		CHAR(10)
		CONSTRAINT fk_Student_No
		FOREIGN KEY(StudentNo)
		REFERENCES dbo.tb_Student(No)
		NOT NULL
	,Detail
		TEXT
		NOT NULL
	,Reply
		VARCHAR(10)
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
	,SendTime
		DATETIME
		NOT NULL
	,Status
		CHAR(4)
		NOT NULL
	);
IF OBJECT_ID('tb_Status')IS NOT NULL
	DROP TABLE tb_Status;
GO
CREATE TABLE tb_Status
	(StudentId
		CHAR(10)		
		NOT NULL
	,NoticeNo
		VARCHAR(3)
		NOT NULL
	,NoticeStatus
		Char(4)
		NOT NULL
	,NTReplyStatus
		VARCHAR(6)
		NOT NULL
	,NTReplyDetail
		VARCHAR(10)
		NULL
	)
IF OBJECT_ID('tb_PublicCourse')IS NOT NULL
	DROP TABLE tb_PublicCourse;
GO
CREATE TABLE tb_PublicCourse
	(No
		CHAR(4)
		CONSTRAINT pk_PublicCourse_No
		PRIMARY KEY(No)
		NOT NULL
	,Name
		VARCHAR(20)
		NOT NULL
	,Credit
		FLOAT
		NOT NULL
	,Hour
		FLOAT
		NOT NULL
	,ExamType
		VARCHAR(10)
		NOT NULL
	,StartTime
		CHAR(11)
		NOT NULL
	
	)
IF OBJECT_ID('tb_StudentScore')IS NOT NULL
	DROP TABLE tb_StudentScore;
GO
CREATE TABLE tb_StudentScore
	(CourseNo
		CHAR(4)
	,StudentNo
		CHAR(10)
	,Score
		FLOAT
	,PRIMARY KEY(CourseNo,StudentNo)
	)
IF OBJECT_ID('tb_SocialExam')IS NOT NULL
	DROP TABLE tb_SocialExam;
GO
CREATE TABLE tb_SocialExam
	(NO
		CHAR(9)
		CONSTRAINT pk_Social_Exam
		PRIMARY KEY(NO)
		NOT NULL
	,ExamName
		VARCHAR(40)
		NOT NULL
	,ExamDate
		DATE
		NOT NULL
	,Level
		VARCHAR(10)
		NOT NULL
	,Type
		VARCHAR(20)
		NOT NULL
	);
IF OBJECT_ID('tb_HasApply')IS NOT NULL
	DROP TABLE tb_HasApply;
GO
CREATE TABLE tb_HasApply
	(ExamNo
		CHAR(9)
	,StudentNo
		CHAR(10)
	,PRIMARY KEY(ExamNo,StudentNo)
	);
IF OBJECT_ID('tb_ClassRoom')IS NOT NULL
	DROP TABLE tb_ClassRoom;
GO
CREATE TABLE tb_ClassRoom
	(BuildingName
		VARCHAR(10)
		NOT NULL
	,ClassNumber
		VARCHAR(20)
		NOT NULL
	)
IF OBJECT_ID('tb_ClassBorrow')IS NOT NULL
	DROP TABLE tb_ClassBorrow;
GO
CREATE TABLE tb_ClassBorrow
	(Term
		CHAR(11)
	,BUilding
		CHAR(6)
		NOT NULL
	,Room
		CHAR(5)
		NOT NULL
	,Department
		VARCHAR(20)
		NOT NULL
	,WeekStart
		CHAR(6)
		NOT NULL
	,WeekEnd
		CHAR(6)		
	,DayStart
		CHAR(4)
		NOT NULL
	,DayEnd
		CHAR(4)		
	,SectionStart
		CHAR(6)
		NOT NULL
	,SectionEnd
		CHAR(6)			
	)


USE EduSystem2;
DELETE FROM dbo.tb_Student;
INSERT dbo.tb_Student
(
    No,
    Code
)
VALUES
(   '3190707001','123456' )
,	(	'3190707002','123456'	)
,	(	'3190707003',	'123456'	)
,	(	'3190707004',	'123456')
,	(	'3190707005', '123456'	)
,	(	'3190707006',	'123456')
,	(	'3190707007',	'123456')
,	(	'3190707008',	'123456')
,	(	'3190707009',	'123456')
,	(	'3190707010',	'123456')
,	(	'3190707011',	'123456')
,	(	'3190707012',	'123456')
,	(	'3190707013',	'123456')
,	(	'3190707014',	'123456')
,	(	'3190707015',	'123456')
,	(	'3190707016',	'123456')
,	(	'3190707017',	'123456')
,	(	'3190707018',	'123456')
,	(	'3190707019',	'123456')
,	(	'3190707020',	'123456')
,	(	'3190707021',	'123456')
,	(	'3190707022',	'123456')
,	(	'3190707023',	'123456')
,	(	'3190707024',	'123456')
,	(	'3190707025',	'123456')
,	(	'3190707026',	'123456')
,	(	'3190707027',	'123456')
,	(	'3190707028',	'123456')
,	(	'3190707029',	'123456')
,	(	'3190707030',	'123456')
,	(	'3190707031',	'123456')
,	(	'3190707032',	'123456')
,	(	'3190707033',	'123456')
,	(	'3190707034',	'123456')
,	(	'3190707035',	'123456')
,	(	'3190707036',	'123456')
,	(	'3190707037',	'123456')
,	(	'3190707038',	'123456')
,	(	'3190707039',	'123456')
,	(	'3190707040',	'123456')
,	(	'3190707042',	'123456')
,	(	'3190707043',	'123456')
,	(	'3190707044',	'123456')
,	(	'3190707045',	'123456')
,	(	'3190707046',	'123456')
,	(	'3190707048',	'123456')
,	(	'3190707049',	'123456')
,	(	'3190707050',	'123456')
,	(	'3190707052',	'123456')
,	(	'3190707053',	'123456')
,	(	'3190707054',	'123456')
,	(	'3190707055',	'123456')
,	(	'3190707056',	'123456')
,	(	'3190707057',	'123456')
,	(	'3190707058',	'123456')
,	(	'3190707059',	'123456');
INSERT dbo.tb_Course
(
    No,
    Name,
    CourseNature,
    Credit,
	StartTime,
    ExamType
)
VALUES
	(   'A001',  '���������',   '����', 2019-2020-1 ,    3.0,   '�ϻ�����'   )
	,(   'A002',  'C���Գ������',   '����',   2019-2020-1,  4.5,      '�ϻ�����'          )
	,(   'A004',  '���ݿ�ԭ��',   'ѡ��',   2020-2021-1,  4.5,    '����'          )
	,(   'A007',  '���������',   '����',   2019-2020-2,  4,     '����'          )
	,(   'A008',  '��̬��վ����',   'ѡ��',  2020-2021-1 , 4.5 ,   '�γ����'          )
	,(   'A009',  '�������������',   '����',  2019-2020-2 , 4.5 ,     '�ϻ�����'          )
	,(   'D001',  '���˼�������ԭ�����',   '����', 2020-2021-1  , 3 ,     '����'          );
INSERT dbo.tb_Book
(
    No,
    Name,
    CourseNo,
    Writer,
    Publish,
    Price,
    IfSubscribe
)
VALUES
	(   '1',  '���������', 'A001', '�ƹ���', '�廪��ѧ������', 35.0, NULL)
	,(   '2',  'C������ƣ������棩', 'A002', '̷��ǿ', '�廪��ѧ������',   26.0, NULL)
	,(   '3',  '���ݿ�ϵͳ���ۣ���5�棩', 'A004', '��ɺ', '�ߵȽ���������',  33.8, NULL)
	,(   '4',  '��������磨��3�棩', 'A007 ', '�⹦��', '�廪��ѧ������', 39.5, NULL)
	,(   '5',  'Web�������', 'A008', '��ʿ��', '�廪��ѧ������',   49.0, NULL)
	,(   '6',  'C#���Գ�����ƻ���ʵ��ָ������3�棩', 'A009', '֣���', '�廪��ѧ������',  24, NULL)
	,(   '7',  '���˼�������ԭ����� ', 'D001', '������', '�й������ѧ������',  30, NULL);
DELETE FROM dbo.tb_LeaveMessage;
INSERT dbo.tb_LeaveMessage
(
    No,
    Title,
    Type,
    Sender,
    Sendtime,
	Status
)
VALUES
	(   '1',     '����ʡ������ȼ����Կ�����֪','����','������',   '2015-12-22','δ��');
DELETE FROM dbo.tb_Notice;
INSERT dbo.tb_Notice
(
    No,
    Title,
    Type,
    Sender,
    SendTime,
	Status,
	StudentNo,
	Detail,
	Reply
)
VALUES
	(   '1',    '����������֪ͨ',    '����',     '����',   GETDATE(),'δ��','3190707045'
	,'֪ͨ�����������Խ������쿪ʼ����μӿ��Ե�ͬѧ������׼����֤���˽�ע�������ȷ���Գ��أ�
	����ʱ�����Ϣ����ֹ���ִ����Ա㼰ʱ������','�ظ�')
	,(   '2',    '���������֪ͨ',    '����',     '����',   GETDATE(),'δ��','3190707045','����12�¸���ʡ������ȼ����Ե�֪ͨ:
	1.ʱ�䣺12��21-22�գ�������ļ�;2.������򿼣���������1310���ң���������1313����;
	3.ע�����������Ӧ��ǰ30���ӵ���1310���Ҽ��е���;����׼��֤��ѧ��֤�����֤��ȱһ����.�ֻ��ȵ���ͨѶ�豸��ػ��������ڿ�����ڣ�������Ʒ�뿼�����б��ܺá�','�ظ�')
	,(   '3',    '2019-2020-2ѡ��֪ͨ',    '����',     '����',   GETDATE(),'δ��','3190707045','����2019-2020ѧ��ڶ�ѧ������ѡ�޿��йذ��ŵ�֪ͨ:�������:��ɽУ��2016����2017����2018������ѧ��;
	ѡ�η�ʽ:����ѡ�Σ�ѡ����ַ: http://210. 34.74.201/f jzyyj sxsd/;���λͬѧ��ǰ��¼ϵͳ������ѡ�����ĵ������ѯѡ�ογ̡����鿴19-20-2�γ̰��������
	ѡ��ʱ�俪��ʱ�����ѧ��ѡ�����ġ�ѡ�Ρ�','�ظ�');
DELETE FROM dbo.tb_StudentCard;
INSERT tb_StudentCard
( 
	No,
	Name,
	Academy,
	Major,
	Gender,
	BirthDate
)
VALUES
('3190707045','��ѩ��','���������ѧԺ','2019����Ϣ��������Ϣϵͳ','Ů','2000-10-29')
,('3190707001','������','���������ѧԺ','2019����Ϣ��������Ϣϵͳ','Ů','2001-5-8')
,('3190707002','������','���������ѧԺ','2019����Ϣ��������Ϣϵͳ','Ů','2001-5-20')
,('3190707003','�ź���','���������ѧԺ','2019����Ϣ��������Ϣϵͳ','��','2001-4-27')
,('3190707004','������','���������ѧԺ','2019����Ϣ��������Ϣϵͳ','��','2000-7-8')
,('3190707005','����÷','���������ѧԺ','2019����Ϣ��������Ϣϵͳ','��','2000-11-5');

INSERT dbo.tb_StudySituation
(
    No,
    CourseNature,
    EarnedCredit
)
VALUES
	(   '1', 'ѧ�ƻ�����', 23.5 )
	,(   '2', '����ѡ�޿�', 7.0 )
	,(   '3', 'ͨʶ������', 20.0 )
	,(   '4', 'רҵ������', 5.0 )
	,(   '5', '����������', 4.0 );
DELETE FROM dbo.tb_TrainProgram;
INSERT dbo.tb_TrainProgram
(
    No,
    Title,
	Operation
)
VALUES
	(   '1', '��������2004','�鿴' ),
	(   '2', '��������2005','�鿴'),
	(   '3', '��������2006','�鿴' ),
	(   '4','��������2007','�鿴' ),
	(   '5', '��������2008','�鿴' ),
	(   '6', '��������2009','�鿴' ),
	(   '7', '��������2010','�鿴' ),
	(   '8', '��������2011','�鿴' ),
	(   '9', '��������2012','�鿴' ),
	(   '10', '��������2013','�鿴' ),
	(   '11', '��������2014','�鿴' ),
	(   '12', '��������2015','�鿴'),
	(   '13', '��������2016','�鿴' ),
	(   '14', '��������2017','�鿴' ),
	(   '15', '��������2018','�鿴' ),
	(   '16', '��������2019','�鿴' ),
	(   '17', '��������2020','�鿴' );
DELETE FROM tb_CourseGrade;
INSERT tb_CourseGrade
(	
	Term,
	CourseNo,
	CourseName,
	Grade,
	Credit,
	TotalHour,
	ExamWay,
	CourseAttribute,
	CourseNature
)
VALUES
	('2019-2020-1','N1190012','��������',87.00,2,'36','�վ���','����','ͨʶ������'),
	('2019-2020-1','N2020046','�ߵ���ѧ',82,5,'80','����','����','ѧ�ƻ�����'),
	('2019-2020-1','N2060089','Ӣ��1',80,4,'64','����','����','ͨʶ������'),
	('2019-2020-1','N2060162','�������ѧ����',85,3,'48','����','����','ѧ�ƻ�����'),
	('2019-2020-1','N2060238','C���Գ������',61,4.5,'72','����','����','ѧ�ƻ�����');
INSERT dbo.tb_PublicCourse
(
    No,
    Name,
    Credit,
    Hour,
    ExamType,
	StartTime
	
)
VALUES
	(   'P001',   '���Ļ���Ӱ���',   2.0, 32.0,  '����' ,'2020-2021-1' ),
	 (   'P002',   '����Ӣ���Ķ�д��',   2.0, 32.0,  '����','2020-2021-1'    ),
	 (   'P003',   '���ѾƵ��Ļ������',   2.0, 32.0,  '����' ,'2020-2021-1'   ),
	 (   'P004',   '���Լ��ɽ���',   2.0, 32.0,  '����' ,'2020-2021-1'   ),
	 (   'P005',   '��ҵѧ',   1.5, 24.0,  '����' ,'2020-2021-1'   ),
	 (   'P006',   '��������',   1.0, 16.0,  '����' ,'2020-2021-1'  );
DELETE FROM tb_StudentScore;
INSERT dbo.tb_StudentScore
(
    CourseNo,
    StudentNo,
    Score
)
VALUES
(   'P005',  '3190707045',    90.0     ),
(   'P002',  '3190707045',    NULL   );
INSERT dbo.tb_SocialExam
(
    NO,
    ExamName,
    ExamDate,
    Level,
    Type
)
VALUES
	(   'E20190401',  'ȫ����ѧӢ������������', '2019-11-23',   '�ļ�',   '����'  ),
	(   'E20190602',  'ȫ����ѧӢ������������', '2019-12-14',   '����',   '����'   ),
	(   'C20190102',  '����ʡ������ȼ�����',  '2019-12-21',   '����',   'C����'  ),
	(   'C20190202',  '����ʡ������ȼ�����',  '2019-12-22',   '����',   'Access' );
INSERT dbo.tb_HasApply
(
    ExamNo,
    StudentNo
)
VALUES
(   'E20190401', -- ExamNo - char(4)
    '3190707045'  -- StudentNo - char(10)
    )
INSERT dbo.tb_ClassRoom
(
    BuildingName,
    ClassNumber
)
VALUES
	(   '��ǿ¥',  '01103'   ),
	(   '��ǿ¥',  '01104'   ),
	(   '��ǿ¥',  '01105'   ),
	(   '��ǿ¥',  '01106'   ),
	(   '��ǿ¥',  '01109'   ),
	(   '��ǿ¥',  '01114'   ),
	(   '��ǿ¥',  '01115'   ),
	(   '��ǿ¥',  '01116'   ),
	(   '���¥',  '02101'   ),
	(   '���¥',  '02102'   ),
	(   '���¥',  '02103'   ),
	(   '���¥',  '02104'   ),
	(   '���¥',  '02110'   ),
	(   '���¥',  '02112'   ),
	(   '����¥',  '07102'   ),
	(   '����¥',  '07106'   ),
	(   '����¥',  '07108'   ),
	(   '����¥',  '07109'   ),
	(   '����¥',  '04104'   ),
	(   '����¥',  '04106'   ),
	(   '����¥',  '04107'   );
INSERT 	 dbo.tb_ClassBorrow
(
    Term,
    BUilding,
    Room,
    Department,
    WeekStart,
    WeekEnd,
    DayStart,
    DayEnd,
    SectionStart,
    SectionEnd
)
VALUES
	(  '2020-2021-1', '��ǿ¥',   '01101', '���������ѧԺ', '������',  '������',  '�ܶ�',  NULL,  '��һ��', '������' );
insert tb_Status
	(StudentId
	,NoticeNo
	,NoticeStatus
	,NTReplyStatus
	,NTReplyDetail
	)
values
	('3190707045','1','δ��','�ظ�',''),
	('3190707045','2','δ��','�ظ�',''),
	('3190707045','3','δ��','�ظ�','');
