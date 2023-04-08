CREATE DATABASE Student
CREATE TABLE StudentDetails(Id int Identity(1,1), Name varchar(max), Age int, Marks int)

CREATE OR ALTER PROC Insertstudent 'Chirag', 31,67
@Name varchar(max),
@Age int, @Marks int
AS
BEGIN
INSERT INTO StudentDetails values(@Name,@Age,@Marks)
END

CREATE OR ALTER PROC DeleteStudent
@Id int
AS
BEGIN
delete from  StudentDetails where Id = @Id
END

CREATE OR ALTER PROC UpdateStudent
@Id int,
@Name varchar(max),
@Age int, @Marks int
AS
BEGIN
Update StudentDetails set Name = @Name, Age =@Age, Marks =@Marks where Id =@Id
END

CREATE OR ALTER PROC Selectstudent

AS
BEGIN
select * from StudentDetails
END