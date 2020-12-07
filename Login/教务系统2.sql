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
	(   'A001',  '计算机导论',   '必修', 2019-2020-1 ,    3.0,   '上机考试'   )
	,(   'A002',  'C语言程序设计',   '必修',   2019-2020-1,  4.5,      '上机考试'          )
	,(   'A004',  '数据库原理',   '选修',   2020-2021-1,  4.5,    '笔试'          )
	,(   'A007',  '计算机网络',   '必修',   2019-2020-2,  4,     '笔试'          )
	,(   'A008',  '动态网站建设',   '选修',  2020-2021-1 , 4.5 ,   '课程设计'          )
	,(   'A009',  '面向对象程序设计',   '必修',  2019-2020-2 , 4.5 ,     '上机考试'          )
	,(   'D001',  '马克思主义基本原理概论',   '必修', 2020-2021-1  , 3 ,     '笔试'          );
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
	(   '1',  '计算机导论', 'A001', '黄国兴', '清华大学出版社', 35.0, NULL)
	,(   '2',  'C程序设计（第三版）', 'A002', '谭浩强', '清华大学出版社',   26.0, NULL)
	,(   '3',  '数据库系统概论（第5版）', 'A004', '王珊', '高等教育出版社',  33.8, NULL)
	,(   '4',  '计算机网络（第3版）', 'A007 ', '吴功宜', '清华大学出版社', 39.5, NULL)
	,(   '5',  'Web程序设计', 'A008', '沈士根', '清华大学出版社',   49.0, NULL)
	,(   '6',  'C#语言程序设计基础实验指导（第3版）', 'A009', '郑宇军', '清华大学出版社',  24, NULL)
	,(   '7',  '马克思主义基本原理概论 ', 'D001', '张雷声', '中国人民大学出版社',  30, NULL);
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
	StudentNo
)
VALUES
	(   '1',    '四六级考试通知',    '公告',     '教务处',   GETDATE(),'未读','3190707045' )
	,(   '2',    '计算机考试通知',    '公告',     '教务处',   GETDATE(),'未读','3190707045')
	,(   '3',    '2019-2020-2选课通知',    '公告',     '教务处',   GETDATE(),'未读','3190707045');
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
	('2019-2020-1','N2060238','C语言程序设计',61,4.5,'72','操作','必修','学科基础课');
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
