IF OBJECT_ID('tb_Student')IS NOT NULL
	DROP TABLE tb_Student;
GO
CREATE TABLE tb_Student
	(No
		VARCHAR(10)
		CONSTRAINT pk_Student_No
		PRIMARY KEY(No)
		NOT NULL
	,Code
		VARCHAR(20)
		NOT NULL
	,ClassShort
		VARCHAR(20)		
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
	,Status
		CHAR(4)
		NOT NULL
	,StudentNo
		VARCHAR(10)
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
IF OBJECT_ID('tb_Book')IS NOT NULL
	DROP TABLE tb_Book;
GO
CREATE TABLE tb_Book
	(Term
		CHAR(11)
		NOT NULL
	,CourseNo
		CHAR(8)
		NOT NULL
	,CourseName
		VARCHAR(30)
	,ISBN
		CHAR(13)
		CONSTRAINT pk_Book_ISBN
		PRIMARY KEY(ISBN)
		NOT NULL
	,BookName
		VARCHAR(40)
		NOT NULL
	,Writer
		VARCHAR(10)
	,Publish
		VARCHAR(30)
	,Price
		DECIMAL
		NOT NULL
	,IfUse
		CHAR(2)
		NOT NULL
	,IfSubscribe
		CHAR(4)
		NOT NULL
	)
IF OBJECT_ID('tb_TeacherEvaluate')IS NOT NULL
	DROP TABLE tb_TeacherEvaluate;
GO
CREATE TABLE tb_TeacherEvaluate
	(TeacherNo
		CHAR(7)
		NOT NULL
	,CourseNo
		CHAR(8)
		NOT NULL
	,StudentNo
		CHAR(10)
		NOT NULL
	,Score
		DECIMAL
	,Evaluate
		VARCHAR(100)
	,State
		VARCHAR(6)
	,PRIMARY KEY(TeacherNo,CourseNo)
	)





	---数据插入
USE EduSystem2;
DELETE FROM dbo.tb_Student;
INSERT dbo.tb_Student
(
    No,
    Code,
	ClassShort
)
VALUES
(   '3190707001','123456','19信管' )
,	(	'3190707002','123456','19信管'	)
,	(	'3190707003',	'123456','19信管'	)
,	(	'3190707004',	'123456','19信管')
,	(	'3190707005', '123456','19信管'	)
,	(	'3190707006',	'123456','19信管')
,	(	'3190707007',	'123456','19信管')
,	(	'3190707008',	'123456','19信管')
,	(	'3190707009',	'123456','19信管')
,	(	'3190707010',	'123456','19信管')
,	(	'3190707011',	'123456','19信管')
,	(	'3190707012',	'123456','19信管')
,	(	'3190707013',	'123456','19信管')
,	(	'3190707014',	'123456','19信管')
,	(	'3190707015',	'123456','19信管')
,	(	'3190707016',	'123456','19信管')
,	(	'3190707017',	'123456','19信管')
,	(	'3190707018',	'123456','19信管')
,	(	'3190707019',	'123456','19信管')
,	(	'3190707020',	'123456','19信管')
,	(	'3190707045',	'123456','19信管')
,	('1989008','123456',NULL)
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
	(   'A001',  '计算机导论',   '必修', 2019-2020-1 ,    3.0,   '上机考试'   )
	,(   'A002',  'C语言程序设计',   '必修',   2019-2020-1,  4.5,      '上机考试'          )
	,(   'A004',  '数据库原理',   '选修',   2020-2021-1,  4.5,    '笔试'          )
	,(   'A007',  '计算机网络',   '必修',   2019-2020-2,  4,     '笔试'          )
	,(   'A008',  '动态网站建设',   '选修',  2020-2021-1 , 4.5 ,   '课程设计'          )
	,(   'A009',  '面向对象程序设计',   '必修',  2019-2020-2 , 4.5 ,     '上机考试'          )
	,(   'D001',  '马克思主义基本原理概论',   '必修', 2020-2021-1  , 3 ,     '笔试'          );
INSERT dbo.tb_Book
(
    Term,
    CourseNo,
    CourseName,
    ISBN,
    BookName,
    Writer,
    Publish,
	Price,
	IfUse,
	IfSubscribe
)
VALUES
	(   '2020-2021-2',  'N2020043', '概率论与数理统计', '9787030461681', '医药数理统计（第四版）','马志庆','科学出版社', 34.8,'否', '订购')
	,(   '2020-2021-1',  'N2020120', '正常人体解剖学', '9787513233187', '人体解剖学（十三五）','邵水金','中国中医药出版社', 59,'否', '订购')
	,(   '2020-2021-1',  'N2020140', '离散数学', '9787040419085', '离散数学','屈婉玲','高等教育出版社', 41.1,'否', '订购')
	,(   '2020-2021-1',  'N2060004', '公共艺术', '9787103030950', '音乐名作鉴赏','修金堂','人民音乐出版社', 38, '否','订购')
	,(   '2020-2021-2',  'N2060018', '经济学原理', '9787301256909', '经济学原理（第7版）：微观经济学','（美）曼昆','北京大学出版社', 72,'否', '订购')
	,(   '2020-2021-2',  'N2060173', '信息系统分析与设计', '9787040326277', '信息系统分析与设计','陈禹','高等教育出版社', 29.3,'否', '订购')
	,(   '2020-2021-1',  'N2120003', '形势与政策3', '9771674678147', '时事报告大学生版秋季、春季','杂志社','中宣部《时事报告》杂志社',24,'否', '订购')
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
	(   '1',     '福建省计算机等级考试考生须知','留言','林云燕',   '2015-12-22','未读');
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
	(   '1',    '四六级考试通知',    '公告',     '教务处',   GETDATE(),'未读','3190707045'
	,'通知：四六级考试将于明天开始，请参加考试的同学，认真准备三证，了解注意事项，明确考试场地，
	考试时间等信息，防止出现错误，以便及时更正。','回复')
	,(   '2',    '计算机考试通知',    '公告',     '教务处',   GETDATE(),'未读','3190707045','关于12月福建省计算机等级考试的通知:
	1.时间：12月21-22日，详情见文件;2.考场与候考：候考室设在1310教室，考场设在1313机房;
	3.注意事项：各考生应提前30分钟到达1310候考室集中点名;带齐准考证、学生证、身份证，缺一不可.手机等电子通讯设备需关机并放置于考场入口，贵重物品请考生自行保管好。','回复')
	,(   '3',    '2019-2020-2选课通知',    '公告',     '教务处',   GETDATE(),'未读','3190707045','关于2019-2020学年第二学期线下选修课有关安排的通知:面向对象:旗山校区2016级，2017级，2018级本科学生;
	选课方式:网络选课，选课网址: http://210. 34.74.201/f jzyyj sxsd/;请各位同学提前登录系统，进入选课中心点击“查询选课课程”，查看19-20-2课程安排情况。
	选课时间开放时点击“学生选课中心”选课。','回复');
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
('3190707045','蔡雪红','人文与管理学院','2019级信息管理与信息系统','女','2000-10-29')
,('3190707001','贾雨晗','人文与管理学院','2019级信息管理与信息系统','女','2001-5-8')
,('3190707002','温晓雯','人文与管理学院','2019级信息管理与信息系统','女','2001-5-20')
,('3190707003','张浩奇','人文与管理学院','2019级信息管理与信息系统','男','2001-4-27')
,('3190707004','李玉林','人文与管理学院','2019级信息管理与信息系统','男','2000-7-8')
,('3190707005','陈玉梅','人文与管理学院','2019级信息管理与信息系统','男','2000-11-5');

INSERT dbo.tb_StudySituation
(
    No,
    CourseNature,
    EarnedCredit
)
VALUES
	(   '1', '学科基础课', 23.5 )
	,(   '2', '公共选修课', 7.0 )
	,(   '3', '通识教育课', 20.0 )
	,(   '4', '专业教育课', 5.0 )
	,(   '5', '公共基础课', 4.0 );
DELETE FROM dbo.tb_TrainProgram;
INSERT dbo.tb_TrainProgram
(
    No,
    Title,
	Operation
)
VALUES
	(   '1', '培养方案2004','查看' ),
	(   '2', '培养方案2005','查看'),
	(   '3', '培养方案2006','查看' ),
	(   '4','培养方案2007','查看' ),
	(   '5', '培养方案2008','查看' ),
	(   '6', '培养方案2009','查看' ),
	(   '7', '培养方案2010','查看' ),
	(   '8', '培养方案2011','查看' ),
	(   '9', '培养方案2012','查看' ),
	(   '10', '培养方案2013','查看' ),
	(   '11', '培养方案2014','查看' ),
	(   '12', '培养方案2015','查看'),
	(   '13', '培养方案2016','查看' ),
	(   '14', '培养方案2017','查看' ),
	(   '15', '培养方案2018','查看' ),
	(   '16', '培养方案2019','查看' ),
	(   '17', '培养方案2020','查看' );
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
	('2019-2020-1','N1190012','军事理论',87.00,2,'36','闭卷考试','必修','通识教育课'),
	('2019-2020-1','N2020046','高等数学',82,5,'80','考试','必修','学科基础课'),
	('2019-2020-1','N2060089','英语1',80,4,'64','考试','必修','通识教育课'),
	('2019-2020-1','N2060162','计算机科学导论',85,3,'48','考试','必修','学科基础课'),
	('2019-2020-1','N2060238','C语言程序设计',61,4.5,'72','操作','必修','学科基础课'),
	 ('2019-2020-2','N2120001','形势与政策1',87,0.5,'6','论文','必修','通识教育课'),
	 ('2019-2020-2','N2120015','思想道德修养与法律基础',75,3,'48','考试','必修','通识教育课'),
	 ('2019-2020-2','N1220001','职业生涯与发展规划',87,1.0,'16','闭卷考','必修','通识教育课');
DELETE FROM tb_TeacherEvaluate;
INSERT tb_TeacherEvaluate
	(TeacherNo
	,CourseNo
	,StudentNo
	,Score
	,Evaluate
	,State
	)
Values
	('1989008','N2060162','3190707045',NULL,NULL,'未评教'),
	('2001018','N2060238','3190707045',NULL,NULL,'未评教'),
	('1987008','N1190012','3190707045',NULL,NULL,'未评教'),
	('2002024','N2020046','3190707045',NULL,NULL,'未评教'),
	('2212024','N2060089','3190707045',NULL,NULL,'未评教'),
	('1994202','N2120001','3190707045',NULL,NULL,'未评教'),
	('1894202','N2120015','3190707045',NULL,NULL,'未评教'),
	 ('1987202','N2120015','3190707045',NULL,NULL,'未评教');
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
	(   'P001',   '跨文化电影解读',   2.0, 32.0,  '论文' ,'2020-2021-1' ),
	 (   'P002',   '六级英语阅读写作',   2.0, 32.0,  '笔试','2020-2021-1'    ),
	 (   'P003',   '葡萄酒的文化与鉴赏',   2.0, 32.0,  '论文' ,'2020-2021-1'   ),
	 (   'P004',   '面试技巧讲解',   2.0, 32.0,  '论文' ,'2020-2021-1'   ),
	 (   'P005',   '创业学',   1.5, 24.0,  '论文' ,'2020-2021-1'   ),
	 (   'P006',   '经络养生',   1.0, 16.0,  '笔试' ,'2020-2021-1'  );
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
	(   'E20190401',  '全国大学英语四六级考试', '2019-11-23',   '四级',   '口试'  ),
	(   'E20190602',  '全国大学英语四六级考试', '2019-12-14',   '六级',   '笔试'   ),
	(   'C20190102',  '福建省计算机等级考试',  '2019-12-21',   '二级',   'C语言'  ),
	(   'C20190202',  '福建省计算机等级考试',  '2019-12-22',   '二级',   'Access' );
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
	(   '自强楼',  '01103'   ),
	(   '自强楼',  '01104'   ),
	(   '自强楼',  '01105'   ),
	(   '自强楼',  '01106'   ),
	(   '自强楼',  '01109'   ),
	(   '自强楼',  '01114'   ),
	(   '自强楼',  '01115'   ),
	(   '自强楼',  '01116'   ),
	(   '厚德楼',  '02101'   ),
	(   '厚德楼',  '02102'   ),
	(   '厚德楼',  '02103'   ),
	(   '厚德楼',  '02104'   ),
	(   '厚德楼',  '02110'   ),
	(   '厚德楼',  '02112'   ),
	(   '五行楼',  '07102'   ),
	(   '五行楼',  '07106'   ),
	(   '五行楼',  '07108'   ),
	(   '五行楼',  '07109'   ),
	(   '精诚楼',  '04104'   ),
	(   '精诚楼',  '04106'   ),
	(   '精诚楼',  '04107'   );
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
	(  '2020-2021-1', '自强楼',   '01101', '人文与管理学院', '第三周',  '第四周',  '周二',  NULL,  '第一节', '第三节' );
insert tb_Status
	(StudentId
	,NoticeNo
	,NoticeStatus
	,NTReplyStatus
	,NTReplyDetail
	)
values
	('3190707045','1','未读','回复',''),
	('3190707045','2','未读','回复',''),
	('3190707045','3','未读','回复','');














   --安全性
IF SUSER_ID('SqlLogin1') IS NOT NULL					
	DROP LOGIN SqlLogin1;				
GO					
CREATE LOGIN SqlLogin1					
	WITH 				
		PASSWORD='Jackson1128' 			
		,CHECK_POLICY=ON			
		,DEFAULT_DATABASE=master;		

DROP USER IF EXISTS DbUser1;					
GO					
CREATE USER DbUser1 					
	FOR LOGIN SqlLogin1;

EXEC sys.sp_addrolemember 'db_datareader','DbUser1';
EXEC sys.sp_addrolemember 'db_datawriter','DbUser1';
