CREATE TABLE Student (
	studID 	int(9) primary key,
    lName varchar(35),
    fName varchar(35),
    regCourses varchar(200),
    examGrade float,
    gpa float 
);

CREATE TABLE Courses (
	studID int(9),
	CRN varchar(6) primary key,
    cName varchar(30),
    credHours tinyint(3)
);

CREATE TABLE Grades (
	studID int(9),
    CRN varchar(6),
    examGradeAve float,
    credHours tinyint(3)
);

SELECT 
	s.studID,
    AVG(s.examGrade) = g.examGradeAve
FROM Student s
INNER JOIN Grades g on s.studID = g.studID
GROUP BY s.studID;

SELECT 
	s.studID,
    SUM(c.credHours * g.examGradeAve) / SUM(c.credHours) = s.gpa
FROM Student s
INNER JOIN Grades g on s.studID = g.studID
INNER JOIN Courses c on g.CRN = c.CRN
GROUP BY s.studID;


    
    