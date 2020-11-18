USE EduSystem2;
DELETE FROM dbo.tb_Student;
INSERT dbo.tb_Student
(
    No,
    Code
)
VALUES
(   '3190707001','123456' )
,	(	'3190707002'	,'	123456'	)
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
    Sendtime
)
VALUES
	(   '1',     '福建省计算机等级考试考生须知',      '留言',     '林云燕',   '2015-12-22' );
INSERT dbo.tb_Notice
(
    No,
    Title,
    Type,
    Sender,
    SendTime
)
VALUES
	(   '1',    '四六级考试通知',    '公告',     '教务处',   GETDATE() )
	,(   '2',    '计算机考试通知',    '公告',     '教务处',   GETDATE() )
	,(   '3',    '2019-2020-2选课通知',    '公告',     '教务处',   GETDATE() )
	,(   '4',    '2020年英语竞赛报名通知',    '公告',     '教务处',   GETDATE() )
	,(   '5',    '2019-2020-1评教通知',    '公告',     '教务处',   GETDATE() );
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
('3190707045','蔡雪红','人文与管理学院','2019级信息管理与信息系统','女','2000-10-29');

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
INSERT dbo.tb_TrainProgram
(
    No,
    Title
)
VALUES
	(   '1', '培养方案2004' ),
	(   '2', '培养方案2005'),
	(   '3', '培养方案2006' ),
	(   '4','培养方案2007' ),
	(   '5', '培养方案2008' ),
	(   '6', '培养方案2009' ),
	(   '7', '培养方案2010' ),
	(   '8', '培养方案2011' ),
	(   '9', '培养方案2012' ),
	(   '10', '培养方案2013' ),
	(   '11', '培养方案2014' ),
	(   '12', '培养方案2015'),
	(   '13', '培养方案2016' ),
	(   '14', '培养方案2017' ),
	(   '15', '培养方案2018' ),
	(   '16', '培养方案2019' ),
	(   '17', '培养方案2020' );